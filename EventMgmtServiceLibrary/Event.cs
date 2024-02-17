using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EventMgmtServiceLibrary
{
    public class Event
    {
        private int eid;
        private string event_name;
        private DateTime date;
        private TimeSpan start_time;
        private TimeSpan end_time;
        private Organizer Organizer { get; set; }
        private int oid;

        [DataMember]
        public int EventId
        {
            get { return eid; }
            set { eid = value; }
        }

        [DataMember]
        public string EventName
        {
            get { return event_name; }
            set { event_name = value; }
        }

        [DataMember]
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        [DataMember]
        public TimeSpan StartTime
        {
            get { return start_time; }
            set { start_time = value; }
        }

        [DataMember]
        public TimeSpan EndTime
        {
            get { return end_time; }
            set { end_time = value; }
        }

        [DataMember]
        public int OrganizerId
        {
            get { return oid; }
            set { oid = value; }
        }
    }
}
