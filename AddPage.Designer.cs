namespace Car_for_rent
{
    partial class AddPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            customer_name = new TextBox();
            customer_id = new TextBox();
            label3 = new Label();
            customer_phone = new TextBox();
            label4 = new Label();
            label5 = new Label();
            customer_address = new RichTextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            car_price = new TextBox();
            car_id = new TextBox();
            car_list = new ComboBox();
            button_add = new Button();
            button2 = new Button();
            label6 = new Label();
            label10 = new Label();
            DatePicker_Start = new DateTimePicker();
            DatePicker_End = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(247, 9);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 0;
            label1.Text = "หมีเช่ารถ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(73, 49);
            label2.Name = "label2";
            label2.Size = new Size(62, 21);
            label2.TabIndex = 1;
            label2.Text = "ชื่อลูกค้า";
            // 
            // customer_name
            // 
            customer_name.Location = new Point(79, 73);
            customer_name.Name = "customer_name";
            customer_name.Size = new Size(164, 23);
            customer_name.TabIndex = 2;
            // 
            // customer_id
            // 
            customer_id.Location = new Point(79, 133);
            customer_id.Name = "customer_id";
            customer_id.Size = new Size(164, 23);
            customer_id.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(73, 109);
            label3.Name = "label3";
            label3.Size = new Size(118, 21);
            label3.TabIndex = 3;
            label3.Text = "รหัสบัตรประชาชน";
            // 
            // customer_phone
            // 
            customer_phone.Location = new Point(79, 192);
            customer_phone.Name = "customer_phone";
            customer_phone.Size = new Size(164, 23);
            customer_phone.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(73, 168);
            label4.Name = "label4";
            label4.Size = new Size(90, 21);
            label4.TabIndex = 5;
            label4.Text = "เบอร์โทรศัพท์";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(73, 227);
            label5.Name = "label5";
            label5.Size = new Size(35, 21);
            label5.TabIndex = 7;
            label5.Text = "ที่อยู่";
            // 
            // customer_address
            // 
            customer_address.Location = new Point(79, 251);
            customer_address.Name = "customer_address";
            customer_address.Size = new Size(164, 134);
            customer_address.TabIndex = 8;
            customer_address.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(321, 166);
            label7.Name = "label7";
            label7.Size = new Size(63, 21);
            label7.TabIndex = 13;
            label7.Text = "ราคา/วัน";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(321, 107);
            label8.Name = "label8";
            label8.Size = new Size(55, 21);
            label8.TabIndex = 11;
            label8.Text = "ทะเบียน";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(321, 47);
            label9.Name = "label9";
            label9.Size = new Size(53, 21);
            label9.TabIndex = 9;
            label9.Text = "รถยนต์";
            // 
            // car_price
            // 
            car_price.Location = new Point(327, 190);
            car_price.Name = "car_price";
            car_price.ReadOnly = true;
            car_price.Size = new Size(164, 23);
            car_price.TabIndex = 14;
            // 
            // car_id
            // 
            car_id.Location = new Point(327, 131);
            car_id.Name = "car_id";
            car_id.ReadOnly = true;
            car_id.Size = new Size(164, 23);
            car_id.TabIndex = 12;
            // 
            // car_list
            // 
            car_list.FormattingEnabled = true;
            car_list.Location = new Point(327, 71);
            car_list.Name = "car_list";
            car_list.Size = new Size(164, 23);
            car_list.TabIndex = 17;
            car_list.Text = "เลือกรถยนต์";
            // 
            // button_add
            // 
            button_add.Location = new Point(327, 362);
            button_add.Name = "button_add";
            button_add.Size = new Size(75, 23);
            button_add.TabIndex = 18;
            button_add.Text = "เพิ่ม";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // button2
            // 
            button2.Location = new Point(416, 362);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 19;
            button2.Text = "เคลีย";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(321, 227);
            label6.Name = "label6";
            label6.Size = new Size(57, 21);
            label6.TabIndex = 20;
            label6.Text = "วันที่เช่า";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(321, 288);
            label10.Name = "label10";
            label10.Size = new Size(61, 21);
            label10.TabIndex = 22;
            label10.Text = "วันส่งคืน";
            // 
            // DatePicker_Start
            // 
            DatePicker_Start.Location = new Point(327, 251);
            DatePicker_Start.Name = "DatePicker_Start";
            DatePicker_Start.Size = new Size(190, 23);
            DatePicker_Start.TabIndex = 23;
            // 
            // DatePicker_End
            // 
            DatePicker_End.Location = new Point(327, 312);
            DatePicker_End.Name = "DatePicker_End";
            DatePicker_End.Size = new Size(190, 23);
            DatePicker_End.TabIndex = 24;
            // 
            // AddPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 428);
            Controls.Add(DatePicker_End);
            Controls.Add(DatePicker_Start);
            Controls.Add(label10);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button_add);
            Controls.Add(car_list);
            Controls.Add(car_price);
            Controls.Add(label7);
            Controls.Add(car_id);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(customer_address);
            Controls.Add(label5);
            Controls.Add(customer_phone);
            Controls.Add(label4);
            Controls.Add(customer_id);
            Controls.Add(label3);
            Controls.Add(customer_name);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddPage";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox customer_name;
        private TextBox customer_id;
        private Label label3;
        private TextBox customer_phone;
        private Label label4;
        private Label label5;
        private RichTextBox customer_address;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox car_price;
        private TextBox car_id;
        private ComboBox car_list;
        private Button button_add;
        private Button button2;
        private Label label6;
        private Label label10;
        private DateTimePicker DatePicker_Start;
        private DateTimePicker DatePicker_End;
    }
}