using Newtonsoft.Json;
using System.Text;

namespace CarsDesktop;

public partial class Add : Form
{
    public Add()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Close();
    }

    private async void button2_Click(object sender, EventArgs e)
    {
        Car car = new()
        {
            Id = Guid.NewGuid(),
            Brand = textBox1.Text,
            Name = textBox2.Text,
            Price = decimal.Parse(textBox3.Text),
            ImageUrl = textBox4.Text
        };

        var json = JsonConvert.SerializeObject(car);
        var data = new StringContent(json, Encoding.UTF8, "application/json");
        using var client = new HttpClient();
        var response = await client.PostAsync("https://localhost:44337/api/cars/yaratish", data);
        var result = await response.Content.ReadAsStringAsync();
        MessageBox.Show("Qo'shildi!");
    }
}
