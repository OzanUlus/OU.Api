using System.Text;
using System.Text.Json;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string baseUrl = "https://localhost:7128/api/Product";
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            using HttpClient client = new HttpClient();
            var data = await client.GetAsync(baseUrl);
            var result = await data.Content.ReadAsStringAsync();
            var products = JsonSerializer.Deserialize<List<Product>>(result, new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            });

            products.ForEach(x =>
            {

                listBox1.Items.Add($"{x.Id}|id : {x.Id} name : {x.Name} price : {x.Price}");
            });

            MessageBox.Show(result);
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var product = new Product()
            {
                Name = txtName.Text,
                Price = decimal.Parse(txtPrice.Text)

            };
            var jsonData = JsonSerializer.Serialize(product);
            var stringContent = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");
            using HttpClient client = new HttpClient();
            var response = await client.PostAsync(baseUrl, stringContent);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("iþlem baþarýlý");

            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();

            var id = textBox1.Text;
            var result = await client.DeleteAsync(baseUrl + "/" + id);
            if (result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Silme baþarýlý");

            }
            else
            {
                MessageBox.Show(await result.Content.ReadAsStringAsync());
            }

        }

        private async void listBox1_DoubleClick(object sender, EventArgs e)
        {

            
        }
        private int itemId = 0;
        private async void button4_Click(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            var product = new Product()
            {
                Id = itemId,
                Price = decimal.Parse(txtUpdatePrice.Text),
                Name = txtUpdateName.Text

            };
            var jsonData = JsonSerializer.Serialize(product);
            var stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");

            var result = await httpClient.PutAsync(baseUrl, stringContent);

            if (result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Ýþlem Baþarýlý");
            }

        }

        private async void listBox1_Click(object sender, EventArgs e)
        {
            ListBox listBox = sender as ListBox;
            var selectedItem = listBox1.SelectedItem.ToString().Split("|")[0];

            HttpClient client = new HttpClient();
            var result = await client.GetAsync(baseUrl + $"/{selectedItem}");
            var jsonData = await result.Content.ReadAsStringAsync();
            var product = JsonSerializer.Deserialize<List<Product>>(jsonData , new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            });


            txtUpdatePrice.Text = product[0].Price.ToString();
            txtUpdateName.Text = product[0].Name;
            itemId = product[0].Id;


        }
    }
}
