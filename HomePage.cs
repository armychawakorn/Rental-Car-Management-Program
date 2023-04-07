using Rental_Car_Management_Program.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rental_Car_Management_Program
{
    public partial class HomePage : Form
    {
        private List<RentalList> rentlist = new List<RentalList>();
        public HomePage()
        {
            InitializeComponent();
        }

        private void rentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPage page = new AddPage();
            page.ShowDialog();
            if (page.DialogResult == DialogResult.OK)
            {
                rentlist.Add(page.getRentallist());
            }
            ReloadDataGrid();
        }
        private void ReloadDataGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (RentalList rent in rentlist)
            {
                Person customer = rent.getCustomer();
                Car customercar = rent.getCustomerCar();
                dataGridView1.Rows.Add(
                    customer.getPersonalInformation(EPersonal.Name),
                    customer.getPersonalInformation(EPersonal.ID),
                    customer.getPersonalInformation(EPersonal.Phone),
                    customer.getPersonalInformation(EPersonal.Address),
                    customercar.getCarName(),
                    customercar.getCatID(),
                    customercar.getPrice(),
                    rent.getPrice(),
                    rent.getTimeStart(),
                    rent.getTimeEnd()
                );
            }
        }

        private void openFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.FileName = "RentalSave";
            openfile.Filter = "CSV|*.csv";
            openfile.Title = "Open csv file";
            openfile.ShowDialog();
            if (openfile.FileName != "")
            {
                rentlist.Clear();
                dataGridView1.Rows.Clear();
                using (StreamReader file = new StreamReader(openfile.FileName))
                {
                    string line;
                    int count = 0;
                    while ((line = file.ReadLine()) != null)
                    {
                        if (count == 0)
                        {
                            count++;
                            continue;
                        }
                        string[] data = line.Split(',');
                        rentlist.Add(
                            new RentalList(
                                new Person(
                                    data[1],
                                    data[0],
                                    data[2],
                                    data[3]
                                ),
                                new Car(
                                    data[4],
                                    data[5],
                                    decimal.Parse(
                                        data[6]
                                    )
                                ),
                                decimal.Parse(data[7]),
                                new DateTime().AddTicks(long.Parse(data[8])),
                                new DateTime().AddTicks(long.Parse(data[9]))
                            )
                        );
                    }
                }
                ReloadDataGrid();
            }
        }

        private void saveFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = "RentalSave";
            saveFile.Filter = "CSV|*.csv";
            saveFile.Title = "Save to csv";
            saveFile.ShowDialog();

            if (saveFile.FileName != "")
            {
                using (StreamWriter file = new StreamWriter(saveFile.FileName))
                {
                    file.WriteLine("ชื่อลูกค้า, รหัสบัตรประชาชน, หมายเลขโทรสัพท์, ที่อยู่, รถที่เช่า, ทะเบียน, ราคารถ/วัน, ราคา, วันที่เช่า, วันที่ต้องคืน");
                    foreach (RentalList Sharkwow in rentlist)
                    {
                        Person customer = Sharkwow.getCustomer();
                        Car customercar = Sharkwow.getCustomerCar();
                        file.WriteLine(
                            $"{customer.getPersonalInformation(EPersonal.Name)}," +
                            $"{customer.getPersonalInformation(EPersonal.ID)}," +
                            $"{customer.getPersonalInformation(EPersonal.Phone)}," +
                            $"{customer.getPersonalInformation(EPersonal.Address)}," +
                            $"{customercar.getCarName()}," +
                            $"{customercar.getCatID()}," +
                            $"{customercar.getPrice()}," +
                            $"{Sharkwow.getPrice()}," +
                            $"{Sharkwow.getTimeStart().Ticks}," +
                            $"{Sharkwow.getTimeEnd().Ticks}"
                        );
                    }
                }
            }
        }
    }
}
