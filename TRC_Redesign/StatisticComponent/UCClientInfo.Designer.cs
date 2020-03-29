namespace TRC_Redesign.StatisticComponent
{
    partial class UCClientInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCClientInfo));
            this.lbl_top = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_money = new System.Windows.Forms.Label();
            this.btn_additional = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_top
            // 
            this.lbl_top.Font = new System.Drawing.Font("SF UI Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_top.ForeColor = System.Drawing.Color.White;
            this.lbl_top.Location = new System.Drawing.Point(22, 0);
            this.lbl_top.Name = "lbl_top";
            this.lbl_top.Size = new System.Drawing.Size(72, 59);
            this.lbl_top.TabIndex = 0;
            this.lbl_top.Text = "1";
            this.lbl_top.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_name
            // 
            this.lbl_name.Font = new System.Drawing.Font("SF UI Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_name.Location = new System.Drawing.Point(114, 13);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(238, 33);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Паламарчук Олександр\r\nВолодимирович\r\n";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_money
            // 
            this.lbl_money.Font = new System.Drawing.Font("SF UI Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_money.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_money.Location = new System.Drawing.Point(372, 1);
            this.lbl_money.Name = "lbl_money";
            this.lbl_money.Size = new System.Drawing.Size(179, 59);
            this.lbl_money.TabIndex = 2;
            this.lbl_money.Text = "125.500  грн.";
            this.lbl_money.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_additional
            // 
            this.btn_additional.FlatAppearance.BorderSize = 0;
            this.btn_additional.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_additional.Image = ((System.Drawing.Image)(resources.GetObject("btn_additional.Image")));
            this.btn_additional.Location = new System.Drawing.Point(638, 1);
            this.btn_additional.Name = "btn_additional";
            this.btn_additional.Size = new System.Drawing.Size(36, 59);
            this.btn_additional.TabIndex = 3;
            this.btn_additional.UseVisualStyleBackColor = true;
            this.btn_additional.Click += new System.EventHandler(this.btn_additional_Click);
            // 
            // UCClientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.btn_additional);
            this.Controls.Add(this.lbl_money);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_top);
            this.Name = "UCClientInfo";
            this.Size = new System.Drawing.Size(694, 59);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_top;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_money;
        private System.Windows.Forms.Button btn_additional;
    }
}
