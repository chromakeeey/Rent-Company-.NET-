namespace TRC_Redesign.CustomMessageBox
{
    partial class msgBoxOK
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
            this.button1 = new System.Windows.Forms.Button();
            this.message_box = new System.Windows.Forms.RichTextBox();
            this.icon_box = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_box)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.caption_box);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 25);
            this.panel1.TabIndex = 1;
            // 
            // caption_box
            // 
            this.caption_box.Font = new System.Drawing.Font("SF UI Display", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.caption_box.ForeColor = System.Drawing.Color.Silver;
            this.caption_box.Location = new System.Drawing.Point(0, 3);
            this.caption_box.Name = "caption_box";
            this.caption_box.Size = new System.Drawing.Size(567, 19);
            this.caption_box.TabIndex = 22;
            this.caption_box.Text = "caption_box";
            this.caption_box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("SF UI Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(250, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 99;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // message_box
            // 
            this.message_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.message_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.message_box.Font = new System.Drawing.Font("SF UI Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.message_box.ForeColor = System.Drawing.Color.White;
            this.message_box.Location = new System.Drawing.Point(131, 43);
            this.message_box.Name = "message_box";
            this.message_box.ReadOnly = true;
            this.message_box.Size = new System.Drawing.Size(403, 100);
            this.message_box.TabIndex = 100;
            this.message_box.Text = "message_box";
            // 
            // icon_box
            // 
            this.icon_box.Image = global::TRC_Redesign.Properties.Resources.Information;
            this.icon_box.Location = new System.Drawing.Point(25, 43);
            this.icon_box.Name = "icon_box";
            this.icon_box.Size = new System.Drawing.Size(100, 100);
            this.icon_box.TabIndex = 0;
            this.icon_box.TabStop = false;
            // 
            // msgBoxOK
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(567, 194);
            this.Controls.Add(this.message_box);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.icon_box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "msgBoxOK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "msgBoxOK";
            this.Load += new System.EventHandler(this.msgBoxOK_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icon_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox icon_box;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label caption_box;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.RichTextBox message_box;
    }
}