namespace TRC_Redesign.RentPicker
{
    partial class RentTimePicker
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.caption_box = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.message_box = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.caption_box);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 24);
            this.panel1.TabIndex = 0;
            // 
            // caption_box
            // 
            this.caption_box.Font = new System.Drawing.Font("SF UI Display", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.caption_box.ForeColor = System.Drawing.Color.Silver;
            this.caption_box.Location = new System.Drawing.Point(0, 3);
            this.caption_box.Name = "caption_box";
            this.caption_box.Size = new System.Drawing.Size(360, 19);
            this.caption_box.TabIndex = 23;
            this.caption_box.Text = "caption_box";
            this.caption_box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(106, 108);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(152, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // message_box
            // 
            this.message_box.Font = new System.Drawing.Font("SF UI Display", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.message_box.ForeColor = System.Drawing.Color.White;
            this.message_box.Location = new System.Drawing.Point(53, 38);
            this.message_box.Name = "message_box";
            this.message_box.Size = new System.Drawing.Size(249, 54);
            this.message_box.TabIndex = 2;
            this.message_box.Text = "message_box";
            this.message_box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("SF UI Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(140, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 100;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // RentTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(360, 190);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.message_box);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RentTimePicker";
            this.Text = "RentTimePicker";
            this.VisibleChanged += new System.EventHandler(this.visibleChanged);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label caption_box;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.Label message_box;
        public System.Windows.Forms.Button button1;
    }
}