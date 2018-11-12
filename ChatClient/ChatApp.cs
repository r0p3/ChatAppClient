using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatClient
{
    public partial class ChatApp : Form
    {
        public ChatApp(string username)
        {
            InitializeComponent();
            lblMe.Text = username;
        }

        //Exit button
        private void lblX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Minimize button
        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Set background color when hover over form controls
        private void ControlButtons_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.LightGray;
        }

        //reset background color when not hover over form controls
        private void ControlButtons_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = pHeader.BackColor;
        }

        //Move form when mouse down in panel
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void pHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
