namespace TRC_Redesign
{
    partial class UCStatistic
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
            this.btn_client = new System.Windows.Forms.Panel();
            this.lbl_client = new System.Windows.Forms.Label();
            this.btn_money = new System.Windows.Forms.Panel();
            this.lbl_money = new System.Windows.Forms.Label();
            this.btn_vehicle = new System.Windows.Forms.Panel();
            this.lbl_vehicle = new System.Windows.Forms.Label();
            this.ucStatClient = new TRC_Redesign.StatisticComponent.UCStatClient();
            this.btn_client.SuspendLayout();
            this.btn_money.SuspendLayout();
            this.btn_vehicle.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_client
            // 
            this.btn_client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_client.Controls.Add(this.lbl_client);
            this.btn_client.Location = new System.Drawing.Point(19, 17);
            this.btn_client.Name = "btn_client";
            this.btn_client.Size = new System.Drawing.Size(217, 39);
            this.btn_client.TabIndex = 0;
            // 
            // lbl_client
            // 
            this.lbl_client.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_client.Font = new System.Drawing.Font("SF UI Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_client.ForeColor = System.Drawing.Color.White;
            this.lbl_client.Location = new System.Drawing.Point(0, 0);
            this.lbl_client.Name = "lbl_client";
            this.lbl_client.Size = new System.Drawing.Size(217, 39);
            this.lbl_client.TabIndex = 0;
            this.lbl_client.Text = "Рейтинг клієнтів";
            this.lbl_client.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_client.Click += new System.EventHandler(this.lbl_client_Click);
            this.lbl_client.MouseLeave += new System.EventHandler(this.client_MouseLeave);
            this.lbl_client.MouseHover += new System.EventHandler(this.client_MouseHover);
            // 
            // btn_money
            // 
            this.btn_money.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_money.Controls.Add(this.lbl_money);
            this.btn_money.Location = new System.Drawing.Point(555, 17);
            this.btn_money.Name = "btn_money";
            this.btn_money.Size = new System.Drawing.Size(217, 39);
            this.btn_money.TabIndex = 1;
            // 
            // lbl_money
            // 
            this.lbl_money.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_money.Font = new System.Drawing.Font("SF UI Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_money.ForeColor = System.Drawing.Color.White;
            this.lbl_money.Location = new System.Drawing.Point(0, 0);
            this.lbl_money.Name = "lbl_money";
            this.lbl_money.Size = new System.Drawing.Size(217, 39);
            this.lbl_money.TabIndex = 2;
            this.lbl_money.Text = "Фінанси";
            this.lbl_money.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_money.Click += new System.EventHandler(this.lbl_money_Click);
            this.lbl_money.MouseLeave += new System.EventHandler(this.money_MouseLeave);
            this.lbl_money.MouseHover += new System.EventHandler(this.money_MouseHover);
            // 
            // btn_vehicle
            // 
            this.btn_vehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_vehicle.Controls.Add(this.lbl_vehicle);
            this.btn_vehicle.Location = new System.Drawing.Point(288, 17);
            this.btn_vehicle.Name = "btn_vehicle";
            this.btn_vehicle.Size = new System.Drawing.Size(217, 39);
            this.btn_vehicle.TabIndex = 2;
            // 
            // lbl_vehicle
            // 
            this.lbl_vehicle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_vehicle.Font = new System.Drawing.Font("SF UI Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_vehicle.ForeColor = System.Drawing.Color.White;
            this.lbl_vehicle.Location = new System.Drawing.Point(0, 0);
            this.lbl_vehicle.Name = "lbl_vehicle";
            this.lbl_vehicle.Size = new System.Drawing.Size(217, 39);
            this.lbl_vehicle.TabIndex = 1;
            this.lbl_vehicle.Text = "Рейтинг автомобілів";
            this.lbl_vehicle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_vehicle.Click += new System.EventHandler(this.lbl_vehicle_Click);
            this.lbl_vehicle.MouseLeave += new System.EventHandler(this.vehicle_MouseLeave);
            this.lbl_vehicle.MouseHover += new System.EventHandler(this.vehicle_MouseHover);
            // 
            // ucStatClient
            // 
            this.ucStatClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ucStatClient.Location = new System.Drawing.Point(7, 121);
            this.ucStatClient.Name = "ucStatClient";
            this.ucStatClient.Size = new System.Drawing.Size(785, 486);
            this.ucStatClient.TabIndex = 3;
            // 
            // UCStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.ucStatClient);
            this.Controls.Add(this.btn_vehicle);
            this.Controls.Add(this.btn_money);
            this.Controls.Add(this.btn_client);
            this.Name = "UCStatistic";
            this.Size = new System.Drawing.Size(795, 610);
            this.btn_client.ResumeLayout(false);
            this.btn_money.ResumeLayout(false);
            this.btn_vehicle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel btn_client;
        private System.Windows.Forms.Panel btn_money;
        private System.Windows.Forms.Panel btn_vehicle;
        private System.Windows.Forms.Label lbl_client;
        private System.Windows.Forms.Label lbl_money;
        private System.Windows.Forms.Label lbl_vehicle;
        public StatisticComponent.UCStatClient ucStatClient;
    }
}
