namespace TRC_Redesign
{
    partial class admin_vehicleadd
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_vehicleadd));
            this.label41 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.pb_vehicle = new System.Windows.Forms.PictureBox();
            this.jThinButton1 = new JThinButton.JThinButton();
            this.error_label = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_model = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.cb_transmission = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_license = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_fuelnow = new System.Windows.Forms.TextBox();
            this.tb_fuelmax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_mileage = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mtb_plate = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tb_maxspeed = new System.Windows.Forms.TextBox();
            this.btn_imagepick = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_price = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_vehicle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label41
            // 
            this.label41.Font = new System.Drawing.Font("SF UI Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label41.ForeColor = System.Drawing.Color.Silver;
            this.label41.Location = new System.Drawing.Point(9, 44);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(102, 19);
            this.label41.TabIndex = 85;
            this.label41.Text = "Назва";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_name
            // 
            this.tb_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tb_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_name.Font = new System.Drawing.Font("SF UI Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_name.ForeColor = System.Drawing.Color.White;
            this.tb_name.Location = new System.Drawing.Point(12, 69);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(101, 22);
            this.tb_name.TabIndex = 84;
            this.tb_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pb_vehicle
            // 
            this.pb_vehicle.Image = global::TRC_Redesign.Properties.Resources.error_vehicle;
            this.pb_vehicle.Location = new System.Drawing.Point(513, 95);
            this.pb_vehicle.Name = "pb_vehicle";
            this.pb_vehicle.Size = new System.Drawing.Size(168, 77);
            this.pb_vehicle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_vehicle.TabIndex = 93;
            this.pb_vehicle.TabStop = false;
            // 
            // jThinButton1
            // 
            this.jThinButton1.BackColor = System.Drawing.Color.Transparent;
            this.jThinButton1.BackgroundColor = System.Drawing.Color.Green;
            this.jThinButton1.BorderColor = System.Drawing.Color.Green;
            this.jThinButton1.BorderRadius = 11;
            this.jThinButton1.ButtonText = "Додати";
            this.jThinButton1.Font = new System.Drawing.Font("SF UI Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.jThinButton1.Font_Size = new System.Drawing.Font("SF UI Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.jThinButton1.ForeColors = System.Drawing.Color.White;
            this.jThinButton1.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.jThinButton1.HoverBorder = System.Drawing.Color.Green;
            this.jThinButton1.HoverFontColor = System.Drawing.Color.White;
            this.jThinButton1.LineThickness = 2;
            this.jThinButton1.Location = new System.Drawing.Point(609, 229);
            this.jThinButton1.Margin = new System.Windows.Forms.Padding(4);
            this.jThinButton1.Name = "jThinButton1";
            this.jThinButton1.Size = new System.Drawing.Size(107, 26);
            this.jThinButton1.TabIndex = 95;
            this.jThinButton1.Click += new System.EventHandler(this.jThinButton1_Click);
            // 
            // error_label
            // 
            this.error_label.Font = new System.Drawing.Font("SF UI Display", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.error_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.error_label.Location = new System.Drawing.Point(352, 234);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(250, 18);
            this.error_label.TabIndex = 96;
            this.error_label.Text = "error_label";
            this.error_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.error_label.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.PNG;*.JPEG)|*.BMP;*.JPG;*.PNG;*.JPEG|All files (*.*)|*." +
    "*";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("SF UI Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(10, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 19);
            this.label1.TabIndex = 98;
            this.label1.Text = "Модель";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_model
            // 
            this.tb_model.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tb_model.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_model.Font = new System.Drawing.Font("SF UI Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_model.ForeColor = System.Drawing.Color.White;
            this.tb_model.Location = new System.Drawing.Point(12, 120);
            this.tb_model.Name = "tb_model";
            this.tb_model.Size = new System.Drawing.Size(101, 22);
            this.tb_model.TabIndex = 97;
            this.tb_model.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("SF UI Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(133, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 19);
            this.label2.TabIndex = 101;
            this.label2.Text = "Тип автомобіля";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb_type
            // 
            this.cb_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cb_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_type.Font = new System.Drawing.Font("SF UI Display", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_type.ForeColor = System.Drawing.Color.White;
            this.cb_type.Location = new System.Drawing.Point(136, 177);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(108, 21);
            this.cb_type.TabIndex = 102;
            // 
            // cb_transmission
            // 
            this.cb_transmission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cb_transmission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_transmission.Font = new System.Drawing.Font("SF UI Display", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_transmission.ForeColor = System.Drawing.Color.White;
            this.cb_transmission.Location = new System.Drawing.Point(136, 234);
            this.cb_transmission.Name = "cb_transmission";
            this.cb_transmission.Size = new System.Drawing.Size(108, 21);
            this.cb_transmission.TabIndex = 104;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("SF UI Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(133, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 19);
            this.label3.TabIndex = 103;
            this.label3.Text = "Трансмісія";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb_license
            // 
            this.cb_license.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cb_license.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_license.Font = new System.Drawing.Font("SF UI Display", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_license.ForeColor = System.Drawing.Color.White;
            this.cb_license.Location = new System.Drawing.Point(265, 66);
            this.cb_license.Name = "cb_license";
            this.cb_license.Size = new System.Drawing.Size(108, 21);
            this.cb_license.TabIndex = 106;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("SF UI Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(262, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 19);
            this.label4.TabIndex = 105;
            this.label4.Text = "Категорія прав";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_fuelnow
            // 
            this.tb_fuelnow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tb_fuelnow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_fuelnow.Font = new System.Drawing.Font("SF UI Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_fuelnow.ForeColor = System.Drawing.Color.White;
            this.tb_fuelnow.Location = new System.Drawing.Point(136, 120);
            this.tb_fuelnow.Name = "tb_fuelnow";
            this.tb_fuelnow.Size = new System.Drawing.Size(108, 22);
            this.tb_fuelnow.TabIndex = 87;
            this.tb_fuelnow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_fuelmax
            // 
            this.tb_fuelmax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tb_fuelmax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_fuelmax.Font = new System.Drawing.Font("SF UI Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_fuelmax.ForeColor = System.Drawing.Color.White;
            this.tb_fuelmax.Location = new System.Drawing.Point(136, 66);
            this.tb_fuelmax.Name = "tb_fuelmax";
            this.tb_fuelmax.Size = new System.Drawing.Size(108, 22);
            this.tb_fuelmax.TabIndex = 89;
            this.tb_fuelmax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("SF UI Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(133, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 19);
            this.label6.TabIndex = 108;
            this.label6.Text = "Бензина в баці";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("SF UI Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(133, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 19);
            this.label7.TabIndex = 109;
            this.label7.Text = "Об\'єм бака";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("SF UI Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(10, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 19);
            this.label8.TabIndex = 101;
            this.label8.Text = "Пробіг";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_mileage
            // 
            this.tb_mileage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tb_mileage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_mileage.Font = new System.Drawing.Font("SF UI Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_mileage.ForeColor = System.Drawing.Color.White;
            this.tb_mileage.Location = new System.Drawing.Point(13, 178);
            this.tb_mileage.Name = "tb_mileage";
            this.tb_mileage.Size = new System.Drawing.Size(100, 22);
            this.tb_mileage.TabIndex = 100;
            this.tb_mileage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_mileage.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("SF UI Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(10, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 19);
            this.label9.TabIndex = 104;
            this.label9.Text = "Макс. швидкість";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(265, 170);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 110;
            this.pictureBox1.TabStop = false;
            // 
            // mtb_plate
            // 
            this.mtb_plate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtb_plate.Font = new System.Drawing.Font("SF UI Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtb_plate.ForeColor = System.Drawing.Color.Black;
            this.mtb_plate.Location = new System.Drawing.Point(279, 172);
            this.mtb_plate.Mask = "AA 9999 AA";
            this.mtb_plate.Name = "mtb_plate";
            this.mtb_plate.Size = new System.Drawing.Size(139, 23);
            this.mtb_plate.TabIndex = 112;
            this.mtb_plate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(265, 110);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 114;
            this.pictureBox3.TabStop = false;
            // 
            // tb_maxspeed
            // 
            this.tb_maxspeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tb_maxspeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_maxspeed.Font = new System.Drawing.Font("SF UI Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_maxspeed.ForeColor = System.Drawing.Color.White;
            this.tb_maxspeed.Location = new System.Drawing.Point(13, 234);
            this.tb_maxspeed.Name = "tb_maxspeed";
            this.tb_maxspeed.Size = new System.Drawing.Size(100, 22);
            this.tb_maxspeed.TabIndex = 103;
            this.tb_maxspeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_imagepick
            // 
            this.btn_imagepick.FlatAppearance.BorderSize = 0;
            this.btn_imagepick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imagepick.Image = ((System.Drawing.Image)(resources.GetObject("btn_imagepick.Image")));
            this.btn_imagepick.Location = new System.Drawing.Point(658, 63);
            this.btn_imagepick.Name = "btn_imagepick";
            this.btn_imagepick.Size = new System.Drawing.Size(20, 22);
            this.btn_imagepick.TabIndex = 116;
            this.btn_imagepick.UseVisualStyleBackColor = true;
            this.btn_imagepick.Click += new System.EventHandler(this.btn_imagepick_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("SF UI Display", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(510, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 19);
            this.label10.TabIndex = 117;
            this.label10.Text = "Вибрати зображення";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("SF UI Display", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(9, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(325, 19);
            this.label11.TabIndex = 118;
            this.label11.Text = "Заповніть всі поля для додання нового автомобіля";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_price
            // 
            this.tb_price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tb_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_price.Font = new System.Drawing.Font("SF UI Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_price.ForeColor = System.Drawing.Color.White;
            this.tb_price.Location = new System.Drawing.Point(317, 115);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(56, 22);
            this.tb_price.TabIndex = 119;
            this.tb_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // admin_vehicleadd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_imagepick);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.mtb_plate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_maxspeed);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_mileage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_fuelmax);
            this.Controls.Add(this.tb_fuelnow);
            this.Controls.Add(this.cb_license);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_transmission);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_type);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_model);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.jThinButton1);
            this.Controls.Add(this.pb_vehicle);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.tb_name);
            this.Name = "admin_vehicleadd";
            this.Size = new System.Drawing.Size(732, 270);
            this.Load += new System.EventHandler(this.admin_vehicleadd_Load);
            this.VisibleChanged += new System.EventHandler(this.visibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pb_vehicle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label label41;
        public System.Windows.Forms.TextBox tb_name;
        public System.Windows.Forms.PictureBox pb_vehicle;
        public JThinButton.JThinButton jThinButton1;
        public System.Windows.Forms.Label error_label;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tb_model;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.ComboBox cb_transmission;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_license;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tb_fuelnow;
        public System.Windows.Forms.TextBox tb_fuelmax;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox tb_mileage;
        public System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox mtb_plate;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.TextBox tb_maxspeed;
        private System.Windows.Forms.Button btn_imagepick;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox tb_price;
    }
}
