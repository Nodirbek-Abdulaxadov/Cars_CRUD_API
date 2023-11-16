namespace CarsDesktop;

public partial class UserControl1 : UserControl
{
    public Guid Id;
    public Car Car { get; set; }
    public UserControl1(Guid Id,
                        string Brand,
                        string Name,
                        string imgUrl,
                        decimal Price)
    {
        InitializeComponent();
        brand.Text += Brand;
        name.Text += Name;
        price.Text += Price.ToString();
        picture.ImageLocation = imgUrl;
        this.Id = Id;
        Car = new()
        {
            Id = Id,
            Brand = Brand,
            Name = Name,
            Price = Price,
            ImageUrl = imgUrl
        };
    }

    private void UserControl1_Click(object sender, EventArgs e)
    {
    }

    private void UserControl1_DoubleClick(object sender, EventArgs e)
    {
        Edit edit = new Edit(Car.Id,
                            Car.Brand,
                            Car.Name,
                            Car.ImageUrl,
                            Car.Price);
        edit.ShowDialog();
    }
}