namespace TRC_Redesign.StatisticComponent
{
    partial class UCStatClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCStatClient));
            this.btn_statistic = new System.Windows.Forms.Button();
            this.location_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_statistic
            // 
            this.btn_statistic.FlatAppearance.BorderSize = 0;
            this.btn_statistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_statistic.Font = new System.Drawing.Font("SF UI Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_statistic.ForeColor = System.Drawing.Color.White;
            this.btn_statistic.Image = ((System.Drawing.Image)(resources.GetObject("btn_statistic.Image")));
            this.btn_statistic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_statistic.Location = new System.Drawing.Point(541, 447);
            this.btn_statistic.Name = "btn_statistic";
            this.btn_statistic.Size = new System.Drawing.Size(183, 33);
            this.btn_statistic.TabIndex = 8;
            this.btn_statistic.Text = "           Експортувати в Excel ";
            this.btn_statistic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_statistic.UseVisualStyleBackColor = true;
            this.btn_statistic.Click += new System.EventHandler(this.btn_statistic_Click);
            // 
            // location_panel
            // 
            this.location_panel.AutoScroll = true;
            this.location_panel.Location = new System.Drawing.Point(0, 26);
            this.location_panel.Name = "location_panel";
            this.location_panel.Size = new System.Drawing.Size(785, 403);
            this.location_panel.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("SF UI Display", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(513, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Відображено топ 20 користувачів";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UCStatClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.location_panel);
            this.Controls.Add(this.btn_statistic);
            this.Name = "UCStatClient";
            this.Size = new System.Drawing.Size(785, 486);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btn_statistic;
        public System.Windows.Forms.Panel location_panel;
        public System.Windows.Forms.Label label1;
    }
}
