namespace TRC_Redesign.InputBoxes
{
    partial class InputComboBox
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
            this.message_box = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.cb_value = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // message_box
            // 
            this.message_box.Font = new System.Drawing.Font("SF UI Display", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.message_box.ForeColor = System.Drawing.Color.White;
            this.message_box.Location = new System.Drawing.Point(13, 11);
            this.message_box.Name = "message_box";
            this.message_box.Size = new System.Drawing.Size(249, 54);
            this.message_box.TabIndex = 105;
            this.message_box.Text = "message_box";
            this.message_box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_OK
            // 
            this.btn_OK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.FlatAppearance.BorderSize = 0;
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.Font = new System.Drawing.Font("SF UI Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_OK.ForeColor = System.Drawing.Color.White;
            this.btn_OK.Location = new System.Drawing.Point(97, 118);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 104;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            // 
            // cb_value
            // 
            this.cb_value.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_value.Font = new System.Drawing.Font("SF UI Display", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_value.ForeColor = System.Drawing.Color.Black;
            this.cb_value.Location = new System.Drawing.Point(76, 68);
            this.cb_value.Name = "cb_value";
            this.cb_value.Size = new System.Drawing.Size(121, 21);
            this.cb_value.TabIndex = 106;
            // 
            // InputComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(275, 152);
            this.Controls.Add(this.cb_value);
            this.Controls.Add(this.message_box);
            this.Controls.Add(this.btn_OK);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InputComboBox";
            this.Text = "InputComboBox";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label message_box;
        public System.Windows.Forms.Button btn_OK;
        public System.Windows.Forms.ComboBox cb_value;
    }
}