namespace SE_Concepts_and_Methods_Assignment
{
    partial class Form1
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
            this.Welcome = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grpBxLogin = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.UserNameInput = new System.Windows.Forms.TextBox();
            this.accoutCreate = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCreateAccess = new System.Windows.Forms.TextBox();
            this.txtCreatePass = new System.Windows.Forms.TextBox();
            this.txtCreateUser = new System.Windows.Forms.TextBox();
            this.btnSetPrefferences = new System.Windows.Forms.Button();
            this.btnDateSubmission = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.chckBoxShowPeople = new System.Windows.Forms.CheckedListBox();
            this.txtBxEnterRoom = new System.Windows.Forms.TextBox();
            this.lblEnterLocation = new System.Windows.Forms.Label();
            this.txtBxEnterBuilding = new System.Windows.Forms.TextBox();
            this.grpBoxDates = new System.Windows.Forms.GroupBox();
            this.btnShowInvites = new System.Windows.Forms.Button();
            this.inviteSelector = new System.Windows.Forms.ComboBox();
            this.txtBxMeetingTopic = new System.Windows.Forms.TextBox();
            this.roomName = new System.Windows.Forms.Label();
            this.buildingName = new System.Windows.Forms.Label();
            this.meetingTopic = new System.Windows.Forms.Label();
            this.showDates = new System.Windows.Forms.ComboBox();
            this.txtBxEnterRequire = new System.Windows.Forms.TextBox();
            this.lblRequirements = new System.Windows.Forms.Label();
            this.acceptInvite = new System.Windows.Forms.Button();
            this.DenyInvite = new System.Windows.Forms.Button();
            this.grpBxLogin.SuspendLayout();
            this.accoutCreate.SuspendLayout();
            this.grpBoxDates.SuspendLayout();
            this.SuspendLayout();
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Location = new System.Drawing.Point(245, 32);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(177, 13);
            this.Welcome.TabIndex = 0;
            this.Welcome.Text = "Welcome to the meeting schedualar";
            this.Welcome.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpBxLogin
            // 
            this.grpBxLogin.Controls.Add(this.label5);
            this.grpBxLogin.Controls.Add(this.label4);
            this.grpBxLogin.Controls.Add(this.PasswordInput);
            this.grpBxLogin.Controls.Add(this.button1);
            this.grpBxLogin.Controls.Add(this.UserNameInput);
            this.grpBxLogin.Location = new System.Drawing.Point(12, 114);
            this.grpBxLogin.Name = "grpBxLogin";
            this.grpBxLogin.Size = new System.Drawing.Size(148, 100);
            this.grpBxLogin.TabIndex = 2;
            this.grpBxLogin.TabStop = false;
            this.grpBxLogin.Text = "Login";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Username";
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(7, 47);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(76, 20);
            this.PasswordInput.TabIndex = 1;
            // 
            // UserNameInput
            // 
            this.UserNameInput.Location = new System.Drawing.Point(7, 20);
            this.UserNameInput.Name = "UserNameInput";
            this.UserNameInput.Size = new System.Drawing.Size(76, 20);
            this.UserNameInput.TabIndex = 0;
            // 
            // accoutCreate
            // 
            this.accoutCreate.Controls.Add(this.button2);
            this.accoutCreate.Controls.Add(this.label3);
            this.accoutCreate.Controls.Add(this.label2);
            this.accoutCreate.Controls.Add(this.label1);
            this.accoutCreate.Controls.Add(this.txtCreateAccess);
            this.accoutCreate.Controls.Add(this.txtCreatePass);
            this.accoutCreate.Controls.Add(this.txtCreateUser);
            this.accoutCreate.Location = new System.Drawing.Point(12, 220);
            this.accoutCreate.Name = "accoutCreate";
            this.accoutCreate.Size = new System.Drawing.Size(200, 132);
            this.accoutCreate.TabIndex = 3;
            this.accoutCreate.TabStop = false;
            this.accoutCreate.Text = "Create Account";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Create Account";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Access Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // txtCreateAccess
            // 
            this.txtCreateAccess.Location = new System.Drawing.Point(7, 71);
            this.txtCreateAccess.Name = "txtCreateAccess";
            this.txtCreateAccess.Size = new System.Drawing.Size(100, 20);
            this.txtCreateAccess.TabIndex = 2;
            // 
            // txtCreatePass
            // 
            this.txtCreatePass.Location = new System.Drawing.Point(7, 45);
            this.txtCreatePass.Name = "txtCreatePass";
            this.txtCreatePass.Size = new System.Drawing.Size(100, 20);
            this.txtCreatePass.TabIndex = 1;
            // 
            // txtCreateUser
            // 
            this.txtCreateUser.Location = new System.Drawing.Point(7, 19);
            this.txtCreateUser.Name = "txtCreateUser";
            this.txtCreateUser.Size = new System.Drawing.Size(100, 20);
            this.txtCreateUser.TabIndex = 0;
            // 
            // btnSetPrefferences
            // 
            this.btnSetPrefferences.Location = new System.Drawing.Point(811, 47);
            this.btnSetPrefferences.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSetPrefferences.Name = "btnSetPrefferences";
            this.btnSetPrefferences.Size = new System.Drawing.Size(125, 36);
            this.btnSetPrefferences.TabIndex = 4;
            this.btnSetPrefferences.Text = "Click here to select your available dates";
            this.btnSetPrefferences.UseVisualStyleBackColor = true;
            this.btnSetPrefferences.Visible = false;
            this.btnSetPrefferences.Click += new System.EventHandler(this.btnSetPrefferences_Click);
            // 
            // btnDateSubmission
            // 
            this.btnDateSubmission.Location = new System.Drawing.Point(811, 89);
            this.btnDateSubmission.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDateSubmission.Name = "btnDateSubmission";
            this.btnDateSubmission.Size = new System.Drawing.Size(97, 39);
            this.btnDateSubmission.TabIndex = 10;
            this.btnDateSubmission.Text = "Click this to submit dates";
            this.btnDateSubmission.UseVisualStyleBackColor = true;
            this.btnDateSubmission.Visible = false;
            this.btnDateSubmission.Click += new System.EventHandler(this.btnDateSubmission_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 23);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.Visible = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(12, 49);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker2.TabIndex = 12;
            this.dateTimePicker2.Visible = false;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(12, 77);
            this.dateTimePicker3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker3.TabIndex = 13;
            this.dateTimePicker3.Visible = false;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(12, 103);
            this.dateTimePicker4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker4.TabIndex = 14;
            this.dateTimePicker4.Visible = false;
            // 
            // chckBoxShowPeople
            // 
            this.chckBoxShowPeople.FormattingEnabled = true;
            this.chckBoxShowPeople.Location = new System.Drawing.Point(100, 464);
            this.chckBoxShowPeople.Name = "chckBoxShowPeople";
            this.chckBoxShowPeople.Size = new System.Drawing.Size(185, 79);
            this.chckBoxShowPeople.TabIndex = 16;
            this.chckBoxShowPeople.Visible = false;
            // 
            // txtBxEnterRoom
            // 
            this.txtBxEnterRoom.Location = new System.Drawing.Point(298, 286);
            this.txtBxEnterRoom.Name = "txtBxEnterRoom";
            this.txtBxEnterRoom.Size = new System.Drawing.Size(114, 20);
            this.txtBxEnterRoom.TabIndex = 17;
            this.txtBxEnterRoom.Visible = false;
            // 
            // lblEnterLocation
            // 
            this.lblEnterLocation.AutoSize = true;
            this.lblEnterLocation.Location = new System.Drawing.Point(245, 268);
            this.lblEnterLocation.Name = "lblEnterLocation";
            this.lblEnterLocation.Size = new System.Drawing.Size(89, 13);
            this.lblEnterLocation.TabIndex = 18;
            this.lblEnterLocation.Text = "Meeting Location";
            this.lblEnterLocation.Visible = false;
            // 
            // txtBxEnterBuilding
            // 
            this.txtBxEnterBuilding.Location = new System.Drawing.Point(298, 309);
            this.txtBxEnterBuilding.Name = "txtBxEnterBuilding";
            this.txtBxEnterBuilding.Size = new System.Drawing.Size(114, 20);
            this.txtBxEnterBuilding.TabIndex = 19;
            this.txtBxEnterBuilding.Visible = false;
            // 
            // grpBoxDates
            // 
            this.grpBoxDates.Controls.Add(this.dateTimePicker1);
            this.grpBoxDates.Controls.Add(this.dateTimePicker2);
            this.grpBoxDates.Controls.Add(this.dateTimePicker3);
            this.grpBoxDates.Controls.Add(this.dateTimePicker4);
            this.grpBoxDates.Location = new System.Drawing.Point(600, 265);
            this.grpBoxDates.Name = "grpBoxDates";
            this.grpBoxDates.Size = new System.Drawing.Size(200, 132);
            this.grpBoxDates.TabIndex = 20;
            this.grpBoxDates.TabStop = false;
            this.grpBoxDates.Text = "Select Your Dates";
            this.grpBoxDates.Visible = false;
            // 
            // btnShowInvites
            // 
            this.btnShowInvites.Location = new System.Drawing.Point(811, 145);
            this.btnShowInvites.Name = "btnShowInvites";
            this.btnShowInvites.Size = new System.Drawing.Size(97, 32);
            this.btnShowInvites.TabIndex = 21;
            this.btnShowInvites.Text = "Show Invites";
            this.btnShowInvites.UseVisualStyleBackColor = true;
            this.btnShowInvites.Click += new System.EventHandler(this.btnShowInvites_Click);
            // 
            // inviteSelector
            // 
            this.inviteSelector.FormattingEnabled = true;
            this.inviteSelector.Location = new System.Drawing.Point(265, 57);
            this.inviteSelector.Name = "inviteSelector";
            this.inviteSelector.Size = new System.Drawing.Size(121, 21);
            this.inviteSelector.TabIndex = 22;
            this.inviteSelector.Visible = false;
            this.inviteSelector.SelectedIndexChanged += new System.EventHandler(this.inviteSelector_SelectedIndexChanged);
            // 
            // txtBxMeetingTopic
            // 
            this.txtBxMeetingTopic.Location = new System.Drawing.Point(298, 331);
            this.txtBxMeetingTopic.Name = "txtBxMeetingTopic";
            this.txtBxMeetingTopic.Size = new System.Drawing.Size(114, 20);
            this.txtBxMeetingTopic.TabIndex = 23;
            this.txtBxMeetingTopic.Visible = false;
            // 
            // roomName
            // 
            this.roomName.AutoSize = true;
            this.roomName.Location = new System.Drawing.Point(225, 288);
            this.roomName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.roomName.Name = "roomName";
            this.roomName.Size = new System.Drawing.Size(69, 13);
            this.roomName.TabIndex = 24;
            this.roomName.Text = "Room Name:";
            this.roomName.Visible = false;
            // 
            // buildingName
            // 
            this.buildingName.AutoSize = true;
            this.buildingName.Location = new System.Drawing.Point(215, 312);
            this.buildingName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.buildingName.Name = "buildingName";
            this.buildingName.Size = new System.Drawing.Size(78, 13);
            this.buildingName.TabIndex = 25;
            this.buildingName.Text = "Building Name:";
            this.buildingName.Visible = false;
            // 
            // meetingTopic
            // 
            this.meetingTopic.AutoSize = true;
            this.meetingTopic.Location = new System.Drawing.Point(258, 333);
            this.meetingTopic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.meetingTopic.Name = "meetingTopic";
            this.meetingTopic.Size = new System.Drawing.Size(37, 13);
            this.meetingTopic.TabIndex = 26;
            this.meetingTopic.Text = "Topic:";
            this.meetingTopic.Visible = false;
            // 
            // showDates
            // 
            this.showDates.FormattingEnabled = true;
            this.showDates.Location = new System.Drawing.Point(412, 57);
            this.showDates.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.showDates.Name = "showDates";
            this.showDates.Size = new System.Drawing.Size(91, 21);
            this.showDates.TabIndex = 27;
            this.showDates.Visible = false;
            // 
            // txtBxEnterRequire
            // 
            this.txtBxEnterRequire.Location = new System.Drawing.Point(298, 357);
            this.txtBxEnterRequire.Name = "txtBxEnterRequire";
            this.txtBxEnterRequire.Size = new System.Drawing.Size(114, 20);
            this.txtBxEnterRequire.TabIndex = 28;
            this.txtBxEnterRequire.Visible = false;
            // 
            // lblRequirements
            // 
            this.lblRequirements.AutoSize = true;
            this.lblRequirements.Location = new System.Drawing.Point(220, 360);
            this.lblRequirements.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRequirements.Name = "lblRequirements";
            this.lblRequirements.Size = new System.Drawing.Size(75, 13);
            this.lblRequirements.TabIndex = 29;
            this.lblRequirements.Text = "Requirements:";
            this.lblRequirements.Visible = false;
            // 
            // acceptInvite
            // 
            this.acceptInvite.Location = new System.Drawing.Point(521, 55);
            this.acceptInvite.Name = "acceptInvite";
            this.acceptInvite.Size = new System.Drawing.Size(75, 23);
            this.acceptInvite.TabIndex = 30;
            this.acceptInvite.Text = "Accept";
            this.acceptInvite.UseVisualStyleBackColor = true;
            this.acceptInvite.Visible = false;
            this.acceptInvite.Click += new System.EventHandler(this.acceptInvite_Click);
            // 
            // DenyInvite
            // 
            this.DenyInvite.Location = new System.Drawing.Point(521, 85);
            this.DenyInvite.Name = "DenyInvite";
            this.DenyInvite.Size = new System.Drawing.Size(75, 23);
            this.DenyInvite.TabIndex = 31;
            this.DenyInvite.Text = "Decline";
            this.DenyInvite.UseVisualStyleBackColor = true;
            this.DenyInvite.Visible = false;
            this.DenyInvite.Click += new System.EventHandler(this.DenyInvite_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 562);
            this.Controls.Add(this.DenyInvite);
            this.Controls.Add(this.acceptInvite);
            this.Controls.Add(this.lblRequirements);
            this.Controls.Add(this.txtBxEnterRequire);
            this.Controls.Add(this.showDates);
            this.Controls.Add(this.meetingTopic);
            this.Controls.Add(this.buildingName);
            this.Controls.Add(this.roomName);
            this.Controls.Add(this.txtBxMeetingTopic);
            this.Controls.Add(this.inviteSelector);
            this.Controls.Add(this.btnShowInvites);
            this.Controls.Add(this.grpBoxDates);
            this.Controls.Add(this.txtBxEnterBuilding);
            this.Controls.Add(this.lblEnterLocation);
            this.Controls.Add(this.txtBxEnterRoom);
            this.Controls.Add(this.chckBoxShowPeople);
            this.Controls.Add(this.btnDateSubmission);
            this.Controls.Add(this.btnSetPrefferences);
            this.Controls.Add(this.accoutCreate);
            this.Controls.Add(this.grpBxLogin);
            this.Controls.Add(this.Welcome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBxLogin.ResumeLayout(false);
            this.grpBxLogin.PerformLayout();
            this.accoutCreate.ResumeLayout(false);
            this.accoutCreate.PerformLayout();
            this.grpBoxDates.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grpBxLogin;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.TextBox UserNameInput;
        private System.Windows.Forms.GroupBox accoutCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCreateAccess;
        private System.Windows.Forms.TextBox txtCreatePass;
        private System.Windows.Forms.TextBox txtCreateUser;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSetPrefferences;
        private System.Windows.Forms.Button btnDateSubmission;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.CheckedListBox chckBoxShowPeople;
        private System.Windows.Forms.TextBox txtBxEnterRoom;
        private System.Windows.Forms.Label lblEnterLocation;
        private System.Windows.Forms.TextBox txtBxEnterBuilding;
        private System.Windows.Forms.GroupBox grpBoxDates;
        private System.Windows.Forms.Button btnShowInvites;
        private System.Windows.Forms.ComboBox inviteSelector;
        private System.Windows.Forms.TextBox txtBxMeetingTopic;
        private System.Windows.Forms.Label roomName;
        private System.Windows.Forms.Label buildingName;
        private System.Windows.Forms.Label meetingTopic;
        private System.Windows.Forms.ComboBox showDates;
        private System.Windows.Forms.TextBox txtBxEnterRequire;
        private System.Windows.Forms.Label lblRequirements;
        private System.Windows.Forms.Button acceptInvite;
        private System.Windows.Forms.Button DenyInvite;
    }
}

