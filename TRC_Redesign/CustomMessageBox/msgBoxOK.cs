using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRC_Redesign.CustomMessageBox
{
    public partial class msgBoxOK : Form
    {
        public void setLocalTheme(Form1 obj)
        {

            Color fullBlack = Color.FromArgb(0, 0, 0);
            Color fullWhite = Color.FromArgb(255, 255, 255);

            Color lightGray = Color.FromArgb(222, 222, 222);
            Color lightBlack = Color.FromArgb(18, 18, 18);
            Color darkGray = Color.FromArgb(40, 40, 40);

            switch (obj.ui.themeCurrent)
            {
                case 0:
                    {
                        obj.ui.SetPictureColor(icon_box, fullBlack);
                        BackColor = fullWhite;
                        button1.BackColor = fullWhite;
                        panel1.BackColor = lightGray;
                        message_box.ForeColor = fullBlack;
                        message_box.BackColor = fullWhite;

                        caption_box.ForeColor = darkGray;
                        button1.ForeColor = darkGray;

                        break;
                    }
                    
                case 1:
                    {
                        obj.ui.SetPictureColor(icon_box, fullWhite);
                        BackColor = lightBlack;
                        button1.BackColor = lightBlack;
                        panel1.BackColor = darkGray;
                        message_box.ForeColor = fullWhite;
                        message_box.BackColor = lightBlack;

                        caption_box.ForeColor = lightGray;
                        button1.ForeColor = lightGray;

                        break;
                    }
                case 2:
                    {
                        obj.ui.SetPictureColor(icon_box, obj.ui.customIcon);
                        BackColor = obj.ui.customForm;
                        button1.BackColor = obj.ui.customForm;
                        panel1.BackColor = obj.ui.customMainPanel;
                        message_box.ForeColor = obj.ui.customMainText;
                        message_box.BackColor = obj.ui.customForm;
                        caption_box.ForeColor = obj.ui.customSecondText;
                        button1.ForeColor = obj.ui.customSecondText;

                        break;
                    }
            }
        }

        public msgBoxOK()
        {
            InitializeComponent();

            message_box.SelectionAlignment = HorizontalAlignment.Center;
        }

        public Image MessageIcon
        {
            get { return icon_box.Image; }
            set { icon_box.Image = value;  }
        }

        public string Caption
        {
            get { return caption_box.Text; }
            set { caption_box.Text = value;  }
        }

        public string Message
        {
            get { return message_box.Text; }
            set { message_box.Text = value; }
        }

        public Point Position
        {
            get { return this.DesktopLocation; }
            set { this.SetDesktopLocation(value.X, value.Y); }
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        private bool m_aeroEnabled;

        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]

        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();
                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW; return cp;
            }
        }
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0; DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 0,
                            rightWidth = 0,
                            topHeight = 0
                        }; DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                    }
                    break;
                default: break;
            }
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT) m.Result = (IntPtr)HTCAPTION;
        }

        private void msgBoxOK_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        
        private void PanelMove_MouseDown(object sender, MouseEventArgs e)
        {
            
            
        }
        private void PanelMove_MouseMove(object sender, MouseEventArgs e)
        {
            
        }
        private void PanelMove_MouseUp(object sender, MouseEventArgs e) {  }
    }
}
