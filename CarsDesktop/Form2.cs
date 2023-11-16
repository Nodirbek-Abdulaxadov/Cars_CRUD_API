using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CarsDesktop
{
    public partial class Edit : Form
    {
        private readonly Guid id;

        public Edit(Guid Id,
                    string Brand,
                    string Name,
                    string imgUrl,
                    decimal Price)
        {
            InitializeComponent();
            id = Id;
            textBox1.Text = Brand;
            textBox2.Text = Name;
            textBox3.Text = Price.ToString();
            textBox4.Text = imgUrl;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            Car car = new()
            {
                Id = this.id,
                Brand = textBox1.Text,
                Name = textBox2.Text,
                Price = decimal.Parse(textBox3.Text),
                ImageUrl = textBox4.Text
            };

            var json = JsonConvert.SerializeObject(car);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            using var client = new HttpClient();
            var response = await client.PutAsync("https://localhost:44337/api/cars/tahrirlash", data);
            var result = await response.Content.ReadAsStringAsync();
            MessageBox.Show("Yangilandi!");
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            using var client = new HttpClient();
            var response = await client.DeleteAsync($"https://localhost:44337/api/cars/ochir/{id}");
            var result = await response.Content.ReadAsStringAsync();
            MessageBox.Show("O'chirildi!");
        }
    }
}
