namespace ChatClient
{
    partial class ChatApp
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Online", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Offline", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Friend requests", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("ö");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("lol");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("noty");
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.pHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lvFriends = new System.Windows.Forms.ListView();
            this.rbChat = new System.Windows.Forms.RichTextBox();
            this.lblMe = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblFriend = new System.Windows.Forms.Label();
            this.lblUsernameHint = new System.Windows.Forms.Label();
            this.tbFriendSearch = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimize.ForeColor = System.Drawing.Color.White;
            this.lblMinimize.Location = new System.Drawing.Point(818, 3);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(22, 25);
            this.lblMinimize.TabIndex = 9;
            this.lblMinimize.Text = "-";
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            this.lblMinimize.Enter += new System.EventHandler(this.ControlButtons_MouseEnter);
            this.lblMinimize.Leave += new System.EventHandler(this.ControlButtons_MouseLeave);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.ForeColor = System.Drawing.Color.Red;
            this.lblX.Location = new System.Drawing.Point(846, 3);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(26, 25);
            this.lblX.TabIndex = 8;
            this.lblX.Text = "X";
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            this.lblX.Enter += new System.EventHandler(this.ControlButtons_MouseEnter);
            this.lblX.Leave += new System.EventHandler(this.ControlButtons_MouseLeave);
            // 
            // pHeader
            // 
            this.pHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pHeader.Controls.Add(this.lblTitle);
            this.pHeader.Controls.Add(this.lblMinimize);
            this.pHeader.Controls.Add(this.lblX);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(0, 0);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(882, 33);
            this.pHeader.TabIndex = 8;
            this.pHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pHeader_MouseDown);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Silver;
            this.lblTitle.Location = new System.Drawing.Point(9, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(154, 33);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "ChatApp";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvFriends
            // 
            this.lvFriends.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lvFriends.FullRowSelect = true;
            listViewGroup1.Header = "Online";
            listViewGroup1.Name = "groupOnline";
            listViewGroup2.Header = "Offline";
            listViewGroup2.Name = "groupOffline";
            listViewGroup3.Header = "Friend requests";
            listViewGroup3.Name = "groupFriendRequests";
            this.lvFriends.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3});
            listViewItem1.Group = listViewGroup1;
            listViewItem2.Group = listViewGroup2;
            listViewItem3.Group = listViewGroup3;
            this.lvFriends.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lvFriends.Location = new System.Drawing.Point(12, 73);
            this.lvFriends.Name = "lvFriends";
            this.lvFriends.Size = new System.Drawing.Size(206, 451);
            this.lvFriends.TabIndex = 9;
            this.lvFriends.UseCompatibleStateImageBehavior = false;
            // 
            // rbChat
            // 
            this.rbChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.rbChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rbChat.Location = new System.Drawing.Point(228, 73);
            this.rbChat.Name = "rbChat";
            this.rbChat.ReadOnly = true;
            this.rbChat.Size = new System.Drawing.Size(642, 451);
            this.rbChat.TabIndex = 10;
            this.rbChat.Text = "";
            // 
            // lblMe
            // 
            this.lblMe.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMe.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMe.Location = new System.Drawing.Point(626, 36);
            this.lblMe.Name = "lblMe";
            this.lblMe.Size = new System.Drawing.Size(244, 34);
            this.lblMe.TabIndex = 12;
            this.lblMe.Text = "label1";
            this.lblMe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(147, 560);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 34);
            this.button2.TabIndex = 14;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblFriend
            // 
            this.lblFriend.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFriend.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFriend.Location = new System.Drawing.Point(228, 36);
            this.lblFriend.Name = "lblFriend";
            this.lblFriend.Size = new System.Drawing.Size(240, 34);
            this.lblFriend.TabIndex = 16;
            this.lblFriend.Text = "label1";
            this.lblFriend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUsernameHint
            // 
            this.lblUsernameHint.AutoSize = true;
            this.lblUsernameHint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblUsernameHint.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblUsernameHint.Location = new System.Drawing.Point(171, 530);
            this.lblUsernameHint.Name = "lblUsernameHint";
            this.lblUsernameHint.Size = new System.Drawing.Size(47, 13);
            this.lblUsernameHint.TabIndex = 17;
            this.lblUsernameHint.Text = "Search";
            // 
            // tbFriendSearch
            // 
            this.tbFriendSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.tbFriendSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFriendSearch.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFriendSearch.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbFriendSearch.Location = new System.Drawing.Point(12, 530);
            this.tbFriendSearch.Name = "tbFriendSearch";
            this.tbFriendSearch.Size = new System.Drawing.Size(206, 24);
            this.tbFriendSearch.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.Location = new System.Drawing.Point(228, 530);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(642, 64);
            this.textBox1.TabIndex = 19;
            // 
            // ChatApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(882, 606);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblUsernameHint);
            this.Controls.Add(this.lblFriend);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMe);
            this.Controls.Add(this.rbChat);
            this.Controls.Add(this.lvFriends);
            this.Controls.Add(this.pHeader);
            this.Controls.Add(this.tbFriendSearch);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChatApp";
            this.Text = "ChatApp";
            this.pHeader.ResumeLayout(false);
            this.pHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListView lvFriends;
        private System.Windows.Forms.RichTextBox rbChat;
        private System.Windows.Forms.Label lblMe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblFriend;
        private System.Windows.Forms.Label lblUsernameHint;
        private System.Windows.Forms.TextBox tbFriendSearch;
        private System.Windows.Forms.TextBox textBox1;
    }
}