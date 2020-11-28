using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_Concepts_and_Methods_Assignment
{
    class Meeting
    {
        // Properties
        private string meetingDate;
        private List<string> Attendees;
        private string specialRequirements;
        private string meetingRoom;
        private string meetingBuilding;
        private string topic;
        private string loc;

        // Constructor 
        public Meeting(string meetTime, List<string> attendents, string requirements, string location)
        {
            this.meetingDate = meetTime;
            this.Attendees = attendents;
            this.specialRequirements = requirements;
            this.loc = location;
        }
    }
}
