using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EventMgmtServiceLibrary
{
    [DataContract]
    public class Venue
    {
        private int vid;
        private string venue_name;
        private string location;
        private int capacity;

        [DataMember]
        public int VenueId
        {
            get { return vid; }
            set { vid = value; }
        }

        [DataMember]
        public string VenueName
        {
            get { return venue_name; }
            set { venue_name = value; }
        }

        [DataMember]
        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        [DataMember]
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
    }
}
