using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_Concepts_and_Methods_Assignment
{
    class MeetingNotification
    {
        // Attributes
        private string topic;
        private List<DateTime> suggestedTimes;
        private List<string> invitees;
        private string location;
        private string requirements;

        public MeetingNotification(string Topic, List<DateTime> Times, List<string>attendees, string loc, string requirement)
        {
            this.topic = Topic;
            this.suggestedTimes = Times;
            this.invitees = attendees;
            this.location = loc;
            this.requirements = requirement;
        }

        // Functions
        public List<DateTime> getTimes()
        {
            return this.suggestedTimes;
        }
        public List<string> getInvitees()
        {
            return this.invitees;
        }
        public string displayAttendees()
        {
            string info = "";
            foreach (string person in invitees)
            {
                info += person + ", ";
            }
            return info;
            
        }
        public string getLocation()
        {
            return this.location;
        }

        public string getTopic()
        {
            return this.topic;
        }
        public string getRequire()
        {
            return this.requirements;
        }
    }
}
