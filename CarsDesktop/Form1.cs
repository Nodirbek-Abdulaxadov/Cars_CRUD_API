using Newtonsoft.Json;

namespace CarsDesktop;

public partial class Form1 : Form
{
    HttpClient client = new();

    public Form1()
    {
        InitializeComponent();
    }

    private async void button1_Click(object sender, EventArgs e)
    {
        var json = await client.GetStringAsync("https://localhost:44337/api/cars/hammasi");
        var cars = JsonConvert.DeserializeObject<List<Car>>(json);

        body.Controls.Clear();
        foreach (var car in cars)
        {
            UserControl1 userControl = new(car.Id,
                                           car.Brand,
                                           car.Name,
                                           car.ImageUrl,
                                           car.Price);
            body.Controls.Add(userControl);
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        Add add = new();
        add.ShowDialog();
    }
}
