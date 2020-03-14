namespace TRC_Redesign.InputBoxes
{
    partial class InputTextBox
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
            this.btn_OK = new System.Windows.Forms.Button();
            this.message_box = new System.Windows.Forms.Label();
            this.tb_value = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.FlatAppearance.BorderSize = 0;
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.Font = new System.Drawing.Font("SF UI Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_OK.ForeColor = System.Drawing.Color.White;
            this.btn_OK.Location = new System.Drawing.Point(98, 116);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 101;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            // 
            // message_box
            // 
            this.message_box.Font = new System.Drawing.Font("SF UI Display", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.message_box.ForeColor = System.Drawing.Color.White;
            this.message_box.Location = new System.Drawing.Point(14, 9);
            this.message_box.Name = "message_box";
            this.message_box.Size = new System.Drawing.Size(249, 54);
            this.message_box.TabIndex = 102;
            this.message_box.Text = "message_box";
            this.message_box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_value
            // 
            this.tb_value.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tb_value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_value.Font = new System.Drawing.Font("SF UI Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_value.ForeColor = System.Drawing.Color.White;
            this.tb_value.Location = new System.Drawing.Point(83, 75);
            this.tb_value.Name = "tb_value";
            this.tb_value.Size = new System.Drawing.Size(108, 22);
            this.tb_value.TabIndex = 103;
            this.tb_value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InputTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(275, 152);
            this.Controls.Add(this.tb_value);
            this.Controls.Add(this.message_box);
            this.Controls.Add(this.btn_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InputTextBox";
            this.Text = "InputTextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_OK;
        public System.Windows.Forms.Label message_box;
        public System.Windows.Forms.TextBox tb_value;
    }
}