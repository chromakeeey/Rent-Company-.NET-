namespace TRC_Redesign
{
    partial class vehicle_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vehicle_page));
            this.label77 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.panel31 = new System.Windows.Forms.Panel();
            this.panel30 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.label74 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.vehiclePanel1 = new TRC_Redesign.VehiclePanel();
            this.panel30.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            this.panel16.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label77
            // 
            this.label77.Font = new System.Drawing.Font("SF UI Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label77.ForeColor = System.Drawing.Color.White;
            this.label77.Location = new System.Drawing.Point(25, 14);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(254, 30);
            this.label77.TabIndex = 1;
            this.label77.Text = "Список автомобілів";
            this.label77.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label76
            // 
            this.label76.Font = new System.Drawing.Font("SF UI Display", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label76.ForeColor = System.Drawing.Color.Silver;
            this.label76.Location = new System.Drawing.Point(27, 42);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(346, 30);
            this.label76.TabIndex = 2;
            this.label76.Text = "На цій сторінці Ви зможете переглянути всі автомобілі, які знаходяться в автосало" +
    "ні та відсортувати за параметрами\r\n";
            this.label76.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel31
            // 
            this.panel31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.panel31.Location = new System.Drawing.Point(16, 16);
            this.panel31.Name = "panel31";
            this.panel31.Size = new System.Drawing.Size(8, 56);
            this.panel31.TabIndex = 7;
            // 
            // panel30
            // 
            this.panel30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel30.Controls.Add(this.textBox2);
            this.panel30.Controls.Add(this.textBox1);
            this.panel30.Controls.Add(this.pictureBox15);
            this.panel30.Controls.Add(this.label74);
            this.panel30.Controls.Add(this.label75);
            this.panel30.Controls.Add(this.checkedListBox1);
            this.panel30.Location = new System.Drawing.Point(357, 16);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(392, 56);
            this.panel30.TabIndex = 22;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("SF UI Display", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(237, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 14);
            this.textBox2.TabIndex = 24;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("SF UI Display", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(237, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 14);
            this.textBox1.TabIndex = 23;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox15
            // 
            this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
            this.pictureBox15.Location = new System.Drawing.Point(343, 9);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(38, 38);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox15.TabIndex = 8;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Click += new System.EventHandler(this.pictureBox15_Click);
            // 
            // label74
            // 
            this.label74.Font = new System.Drawing.Font("SF UI Display", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label74.ForeColor = System.Drawing.Color.Silver;
            this.label74.Location = new System.Drawing.Point(124, 32);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(112, 19);
            this.label74.TabIndex = 22;
            this.label74.Text = "Максимальна ціна:";
            this.label74.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label75
            // 
            this.label75.Font = new System.Drawing.Font("SF UI Display", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label75.ForeColor = System.Drawing.Color.Silver;
            this.label75.Location = new System.Drawing.Point(125, 8);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(112, 19);
            this.label75.TabIndex = 21;
            this.label75.Text = "Мінімальна ціна:";
            this.label75.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Font = new System.Drawing.Font("SF UI Display", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListBox1.ForeColor = System.Drawing.Color.White;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "всі",
            "орендовані",
            "не орендовані"});
            this.checkedListBox1.Location = new System.Drawing.Point(8, 4);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(114, 48);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel16.Controls.Add(this.panel1);
            this.panel16.Controls.Add(this.panel30);
            this.panel16.Controls.Add(this.panel31);
            this.panel16.Controls.Add(this.label76);
            this.panel16.Controls.Add(this.label77);
            this.panel16.Location = new System.Drawing.Point(0, 0);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(766, 600);
            this.panel16.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.vehiclePanel1);
            this.panel1.Location = new System.Drawing.Point(0, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 475);
            this.panel1.TabIndex = 23;
            // 
            // vehiclePanel1
            // 
            this.vehiclePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.vehiclePanel1.Location = new System.Drawing.Point(16, 14);
            this.vehiclePanel1.Name = "vehiclePanel1";
            this.vehiclePanel1.Size = new System.Drawing.Size(722, 153);
            this.vehiclePanel1.TabIndex = 1;
            this.vehiclePanel1.Visible = false;
            // 
            // vehicle_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel16);
            this.Name = "vehicle_page";
            this.Size = new System.Drawing.Size(766, 600);
            this.panel30.ResumeLayout(false);
            this.panel30.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            this.panel16.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label label77;
        public System.Windows.Forms.Label label76;
        public System.Windows.Forms.Panel panel31;
        public System.Windows.Forms.Panel panel30;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.PictureBox pictureBox15;
        public System.Windows.Forms.Label label74;
        public System.Windows.Forms.Label label75;
        public System.Windows.Forms.CheckedListBox checkedListBox1;
        public System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel1;
        public VehiclePanel vehiclePanel1;
    }
}
