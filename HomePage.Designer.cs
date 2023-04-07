namespace Rental_Car_Management_Program
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            filesToolStripMenuItem = new ToolStripMenuItem();
            openFilesToolStripMenuItem = new ToolStripMenuItem();
            saveFilesToolStripMenuItem = new ToolStripMenuItem();
            rentalToolStripMenuItem = new ToolStripMenuItem();
            rentToolStripMenuItem = new ToolStripMenuItem();
            datagrid_customer_name = new DataGridViewTextBoxColumn();
            datagrid_customer_id = new DataGridViewTextBoxColumn();
            datagrid_customer_phone = new DataGridViewTextBoxColumn();
            datagrid_customer_address = new DataGridViewTextBoxColumn();
            datagrid_customer_car = new DataGridViewTextBoxColumn();
            datagrid_customer_car_id = new DataGridViewTextBoxColumn();
            datagrid_customer_car_price = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            datagrid_customer_date_start = new DataGridViewTextBoxColumn();
            datagrid_customer_date_end = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { datagrid_customer_name, datagrid_customer_id, datagrid_customer_phone, datagrid_customer_address, datagrid_customer_car, datagrid_customer_car_id, datagrid_customer_car_price, dataGridViewTextBoxColumn1, datagrid_customer_date_start, datagrid_customer_date_end });
            dataGridView1.Location = new Point(12, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(848, 318);
            dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { filesToolStripMenuItem, rentalToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(872, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            filesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openFilesToolStripMenuItem, saveFilesToolStripMenuItem });
            filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            filesToolStripMenuItem.Size = new Size(42, 20);
            filesToolStripMenuItem.Text = "Files";
            // 
            // openFilesToolStripMenuItem
            // 
            openFilesToolStripMenuItem.Name = "openFilesToolStripMenuItem";
            openFilesToolStripMenuItem.Size = new Size(127, 22);
            openFilesToolStripMenuItem.Text = "Open files";
            openFilesToolStripMenuItem.Click += openFilesToolStripMenuItem_Click;
            // 
            // saveFilesToolStripMenuItem
            // 
            saveFilesToolStripMenuItem.Name = "saveFilesToolStripMenuItem";
            saveFilesToolStripMenuItem.Size = new Size(127, 22);
            saveFilesToolStripMenuItem.Text = "Save Files";
            saveFilesToolStripMenuItem.Click += saveFilesToolStripMenuItem_Click;
            // 
            // rentalToolStripMenuItem
            // 
            rentalToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rentToolStripMenuItem });
            rentalToolStripMenuItem.Name = "rentalToolStripMenuItem";
            rentalToolStripMenuItem.Size = new Size(52, 20);
            rentalToolStripMenuItem.Text = "Rental";
            // 
            // rentToolStripMenuItem
            // 
            rentToolStripMenuItem.Name = "rentToolStripMenuItem";
            rentToolStripMenuItem.Size = new Size(119, 22);
            rentToolStripMenuItem.Text = "Rent Car";
            rentToolStripMenuItem.Click += rentToolStripMenuItem_Click;
            // 
            // datagrid_customer_name
            // 
            datagrid_customer_name.HeaderText = "ชื่อลูกค้า";
            datagrid_customer_name.Name = "datagrid_customer_name";
            datagrid_customer_name.ReadOnly = true;
            // 
            // datagrid_customer_id
            // 
            datagrid_customer_id.HeaderText = "รหัสบัตรประชาชน";
            datagrid_customer_id.Name = "datagrid_customer_id";
            datagrid_customer_id.ReadOnly = true;
            // 
            // datagrid_customer_phone
            // 
            datagrid_customer_phone.HeaderText = "เบอร์โทรศัพท์";
            datagrid_customer_phone.Name = "datagrid_customer_phone";
            datagrid_customer_phone.ReadOnly = true;
            // 
            // datagrid_customer_address
            // 
            datagrid_customer_address.HeaderText = "ที่อยู่ลูกค้า";
            datagrid_customer_address.Name = "datagrid_customer_address";
            datagrid_customer_address.ReadOnly = true;
            // 
            // datagrid_customer_car
            // 
            datagrid_customer_car.HeaderText = "รถที่เช่า";
            datagrid_customer_car.Name = "datagrid_customer_car";
            datagrid_customer_car.ReadOnly = true;
            // 
            // datagrid_customer_car_id
            // 
            datagrid_customer_car_id.HeaderText = "ทะเบียนรถ";
            datagrid_customer_car_id.Name = "datagrid_customer_car_id";
            datagrid_customer_car_id.ReadOnly = true;
            // 
            // datagrid_customer_car_price
            // 
            datagrid_customer_car_price.HeaderText = "ราคารถ/วัน";
            datagrid_customer_car_price.Name = "datagrid_customer_car_price";
            datagrid_customer_car_price.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ราคาเช่า";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // datagrid_customer_date_start
            // 
            datagrid_customer_date_start.HeaderText = "วันที่เช่า";
            datagrid_customer_date_start.Name = "datagrid_customer_date_start";
            datagrid_customer_date_start.ReadOnly = true;
            // 
            // datagrid_customer_date_end
            // 
            datagrid_customer_date_end.HeaderText = "วันที่คืน";
            datagrid_customer_date_end.Name = "datagrid_customer_date_end";
            datagrid_customer_date_end.ReadOnly = true;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 357);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "HomePage";
            Text = "HomePage";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem filesToolStripMenuItem;
        private ToolStripMenuItem openFilesToolStripMenuItem;
        private ToolStripMenuItem saveFilesToolStripMenuItem;
        private ToolStripMenuItem rentalToolStripMenuItem;
        private ToolStripMenuItem rentToolStripMenuItem;
        private DataGridViewTextBoxColumn datagrid_customer_name;
        private DataGridViewTextBoxColumn datagrid_customer_id;
        private DataGridViewTextBoxColumn datagrid_customer_phone;
        private DataGridViewTextBoxColumn datagrid_customer_address;
        private DataGridViewTextBoxColumn datagrid_customer_car;
        private DataGridViewTextBoxColumn datagrid_customer_car_id;
        private DataGridViewTextBoxColumn datagrid_customer_car_price;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn datagrid_customer_date_start;
        private DataGridViewTextBoxColumn datagrid_customer_date_end;
    }
}