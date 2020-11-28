using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_Concepts_and_Methods_Assignment
{
    public partial class Form1 : Form
    {
        private int ID = 1;
        private int inviteID = 0;
        Dictionary<int, object> personDic = new Dictionary<int, object>();
        Dictionary<int, object> inviteDic = new Dictionary<int, object>();
        Person login = new Person(0, "test", "test", 1);
        Person Dave = new Person(1, "Dave", "test", 1);
        Person John = new Person(2, "John", "test", 1);
        Person Joe = new Person(3, "Joe", "test", 1);
        Person Stew = new Person(4, "Stew", "test", 1);
        public void showOptions()
        {
            btnSetPrefferences.Visible = true;
        }
        public void clearLoginPage()
        {
            grpBxLogin.Visible = false;
            accoutCreate.Visible = false;
            Welcome.Visible = false;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            personDic.Add(login.getID(), login);
            personDic.Add(Dave.getID(), Dave);
            personDic.Add(John.getID(), John);
            personDic.Add(Joe.getID(), Joe);
            personDic.Add(Stew.getID(), Stew);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Person user in personDic.Values)
            {
                if (user.getUser() == UserNameInput.Text)
                {
                    if (user.getPass() == PasswordInput.Text)
                    {
                        Welcome.Text = "Login Success!";
                        user.logIn();
                        clearLoginPage();
                        showOptions();
                    }
                    if (user.getPass() != PasswordInput.Text)
                    {
                        Welcome.Text = "Login unsuccessful";
                        break;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = txtCreateUser.Text;
            string pass = txtCreatePass.Text;
            int LOA = int.Parse(txtCreateAccess.Text);
            Person Alpha = new Person(ID, name, pass, LOA);
            if (Alpha != null)
            {
                Welcome.Text = "Account created successfully!";
                txtCreatePass.Text = "";
                txtCreateUser.Text = "";
                txtCreateAccess.Text = "";
            }
            personDic.Add(ID, Alpha);


            ID++;
        }

        

        private void btnSetPrefferences_Click(object sender, EventArgs e)
        {
            grpBoxDates.Visible = true;
            dateTimePicker1.Visible = true;
            dateTimePicker2.Visible = true;
            dateTimePicker3.Visible = true;
            dateTimePicker4.Visible = true;
            chckBoxShowPeople.Visible = true;
            lblEnterLocation.Visible = true;
            lblRequirements.Visible = true;
            meetingTopic.Visible = true;
            buildingName.Visible = true;
            roomName.Visible = true;
            txtBxEnterRequire.Visible = true;
            txtBxEnterBuilding.Visible = true;
            txtBxMeetingTopic.Visible = true;
            txtBxEnterRoom.Visible = true;
            btnDateSubmission.Visible = true;
            foreach(Person person in personDic.Values)
            {
                chckBoxShowPeople.Items.Add(person.getUser());
            }
        }

        private void btnDateSubmission_Click(object sender, EventArgs e)
        {
            List<DateTime> suggestedTimes = new List<DateTime>();
            List<string> invitees = new List<string>();
            DateTime suggestedDate1 = dateTimePicker1.Value;
            DateTime suggestedDate2 = dateTimePicker2.Value;
            DateTime suggestedDate3 = dateTimePicker3.Value;
            DateTime suggestedDate4 = dateTimePicker4.Value;
            suggestedTimes.Add(suggestedDate1);
            suggestedTimes.Add(suggestedDate2);
            suggestedTimes.Add(suggestedDate3);
            suggestedTimes.Add(suggestedDate4);
            string Tpic = txtBxMeetingTopic.Text;
            foreach (string person in chckBoxShowPeople.CheckedItems)
            {
                invitees.Add(person);
            }
            string location = txtBxEnterBuilding.Text + txtBxEnterRoom.Text;
            string require = lblRequirements.Text;
            MeetingNotification invite = new MeetingNotification(Tpic, suggestedTimes, invitees, location, require);
            inviteDic.Add(inviteID, invite);
            inviteID++;
            foreach (string invitee in invitees)
            {
                foreach (Person person in personDic.Values)
                {
                    if (invitee == person.getUser())
                    {
                        person.recieveInvite(invite);
                    }
                }
                
            }
            Welcome.Text = "Meeting Invites sent!";
            Welcome.Visible = true;
            grpBoxDates.Visible = false;
            txtBxEnterBuilding.Visible = false;
            txtBxEnterRoom.Visible = false;
            txtBxEnterRequire.Visible = false;
            lblEnterLocation.Visible = false;
            btnDateSubmission.Visible = false;
            lblEnterLocation.Visible = false;
            lblRequirements.Visible = false;
            roomName.Visible = false;
            buildingName.Visible = false;
            meetingTopic.Visible = false;
            chckBoxShowPeople.Visible = false;
            txtBxMeetingTopic.Visible = false;
        }

        private void btnShowInvites_Click(object sender, EventArgs e)
        {
            inviteSelector.Visible = true;
            showDates.Visible = true;
            acceptInvite.Visible = true;
            DenyInvite.Visible = true;

            foreach (Person person in personDic.Values)
            {
                if (person.getStatus() == true)
                {
                    foreach (MeetingNotification notif in person.getInvitesList())
                    {
                        
                        inviteSelector.Items.Add(notif.getTopic());

                        
                        
                    }
                }
                

            }
        }

        private void inviteSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (MeetingNotification notif in inviteDic.Values)
            {
                if (inviteSelector.SelectedItem == notif.getTopic())
                {
                    showDates.Items.Clear();
                    foreach (DateTime dates in notif.getTimes())
                    {
                        showDates.Items.Add(dates.ToString("MM/dd/yyyy"));
                    }
                }
            }
        }

        private void acceptInvite_Click(object sender, EventArgs e)
        {
            foreach (Person person in personDic.Values)
            {
                if (person.getStatus() == true)
                {
                    foreach (MeetingNotification notifi in person.getInvitesList())
                    {
                        if (notifi.getTopic() == inviteSelector.SelectedItem.ToString())
                        {
                            Meeting meet = new Meeting(showDates.SelectedItem.ToString(), notifi.getInvitees(), notifi.getRequire(), notifi.getLocation());
                            person.addInviteToList(meet);
                        }
                    }
                    
                }
            }
        }

        private void DenyInvite_Click(object sender, EventArgs e)
        {
            foreach (Person person in personDic.Values)
            {
                if (person.getStatus() == true)
                {
                    foreach (MeetingNotification notifi in person.getInvitesList())
                    {
                        if (notifi.getTopic() == inviteSelector.SelectedItem.ToString())
                        {
                            
                            
                        }
                    }

                }
            }
        }
    }
}
