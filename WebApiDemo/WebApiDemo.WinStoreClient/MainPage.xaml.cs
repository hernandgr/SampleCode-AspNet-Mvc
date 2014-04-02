using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using WebApiDemo.WinStoreClient.Models;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace WebApiDemo.WinStoreClient
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(txtId.Text);

            string response = await GetProduct(id);

            Product product = JsonConvert.DeserializeObject<Product>(response);
            txtName.Text = product.Name;
            txtPrice.Text = product.Price.ToString();
        }

        private static async Task<string> GetProduct(int id)
        {
            // TO-DO: Check your API url.
            string url = "http://localhost:50482/api/products/" + id.ToString();
            string response;
            
            using (var client = new HttpClient())
            {
                response = await client.GetStringAsync(url);
            }
            
            return response;
        }
    }
}