using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EventMgmtServiceLibrary
{
    [DataContract]
    public class Event
    {
        private int eid;
        private string event_name;
        private DateTime date;
        private String start_time;
        private String end_time;

        public Organizer Organizer { get; set; }
        private int oid;

        public Venue Venue { get; set; }
        private int vid;

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
        public String StartTime
        {
            get { return start_time; }
            set { start_time = value; }
        }

        [DataMember]
        public String EndTime
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

        [DataMember]
        public int VenueId
        {
            get { return vid; }
            set { vid = value; }
        }
    }
}