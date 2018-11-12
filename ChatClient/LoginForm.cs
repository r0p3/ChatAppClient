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
    public partial class LoginForm : Form
    {
        Size standardSize;
        Point btnActionStartPos;
        List<Control> registerControls;
        List<Control> loginControls;
        Model model;
        public LoginForm()
        {
            InitializeComponent();
            standardSize = this.Size;
            btnActionStartPos = btnAction.Location;
            loginControls = new List<Control>() { cbAutoLogin, cbRememberMe, lblForgotPassword };
            registerControls = new List<Control>() { tbConfirmPassword, tbEmail, tbSureName, tbLastName, lblConfirmPasswordHint, lblEmailHint, lblSureNameHint, lblLastNameHint };
            loginMode();
            model = new Model(this);
            //Check for username file
            //Check for sessionkey
            //do stuff with that

        }

        public void Update(string command)
        {
            switch (command)
            {
                case Commands.LoginOK:
                    model.startChatApp(tbUsername.Text);
                    break;
                default:
                    break;
            }
        }

        private void registerMode()
        {
            lblRegisterHere.Text = "Login";
            foreach (var item in loginControls)
                item.Visible = false;
            foreach (var item in registerControls)
                item.Visible = true;
            btnAction.Text = "Register";
            lblTitle.Text = btnAction.Text;
            this.Size = new Size(this.Width, 465);
            btnAction.Location = new Point(btnAction.Location.X, this.Height - 68);
        }

        private void loginMode()
        {
            lblRegisterHere.Text = "Register account";
            
            foreach (var item in registerControls)
                item.Visible = false;
            foreach (var item in loginControls)
                item.Visible = true;
            btnAction.Text = "Login";
            lblTitle.Text = btnAction.Text;
            this.Size = standardSize;
            btnAction.Location = btnActionStartPos;
        }



        private void TBSubmit_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && btnAction.Text == "Login")
            {
                e.SuppressKeyPress = true;
                submitLogin();  
            }
        }

        private void lblRegisterHere_Click(object sender, EventArgs e)
        {
            lblRegisterHere.Enabled = false;
            if (lblTitle.Text == "Login")
                registerMode();
            else if (lblTitle.Text == "Register")
                loginMode();
            lblRegisterHere.Enabled = true;
            
        }

        private void submitLogin()
        {
            if (tbUsername.TextLength > 0 && tbPassword.TextLength > 0)
            {
                string packet = "";
                List<string> credentials = new List<string>() { tbUsername.Text, tbPassword.Text };
                if(cbAutoLogin.Checked)
                {
                    packet = Commands.createPacket(Commands.AutoLogin, credentials);
                }
                else
                {
                    if(cbRememberMe.Checked)
                    {
                        //SaveUsernameSomeWhere
                    }
                    packet = Commands.createPacket(Commands.Login, credentials);
                }
                model.login(packet);
                //Send packet
            }
            else
                MessageBox.Show("No textfield can be empty");
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if(btnAction.Text == "Login")
                submitLogin();
            else if(btnAction.Text == "Register")
            {
                if(registerCheck())
                {
                    //Register
                }
                
            }
        }

        private bool registerCheck()
        {
            return true;
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
