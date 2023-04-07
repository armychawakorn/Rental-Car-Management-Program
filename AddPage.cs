using Car_for_rent.Class;

namespace Car_for_rent
{
    public partial class AddPage : Form
    {
        private RentalList rentallist;
        private int SelectedCarIndex;
        public AddPage()
        {
            InitializeComponent();
            foreach (Car car in Cars.AllCar)
            {
                car_list.Items.Add(car.getCarName());
            }
            car_list.SelectedValueChanged += SelectedValueChanged;
        }
        private void SelectedValueChanged(object? sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            SelectedCarIndex = cb.SelectedIndex;
            car_id.Text = Cars.AllCar[cb.SelectedIndex].getCatID();
            car_price.Text = Cars.AllCar[cb.SelectedIndex].getPrice().ToString("0#,##.00");
        }
        private void button_add_Click(object sender, EventArgs e)
        {
            Car getallcar = Cars.AllCar[SelectedCarIndex];
            Person person = new Person(
                customer_id.Text,customer_name.Text,
                customer_phone.Text,
                customer_address.Text
            );
            Car car = new Car(
                getallcar.getCarName(), 
                getallcar.getCatID(), 
                getallcar.getPrice()
            );
            rentallist = new RentalList(
                person, 
                car, 
                (DatePicker_End.Value.Subtract(DatePicker_Start.Value).Days + 2) * getallcar.getPrice(), 
                DatePicker_Start.Value, 
                DatePicker_End.Value
            );
            this.DialogResult = DialogResult.OK;
        }
        public RentalList getRentallist()
        {
            return rentallist;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            customer_name.Text = "";
            customer_id.Text = ""; 
            customer_phone.Text = ""; 
            customer_address.Text = "";
        }
    }
}