using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EventMgmtServiceLibrary
{
    [DataContract]
    public class Registration
    {
        private int rid;
        public Participant Participant { get; set; }
        private int pid;
        public Event Event { get; set; }
        private int eid;
        private DateTime reg_date;
        private int fees;

        [DataMember]
        public int RegistrationId
        {
            get { return rid; }
            set { rid = value; }
        }

        [DataMember]
        public int ParticipantId
        {
            get { return pid; }
            set { pid = value; }
        }

        [DataMember]
        public int EventId
        {
            get { return eid; }
            set { eid = value; }
        }

        [DataMember]
        public DateTime RegistrationDate
        {
            get { return reg_date; }
            set { reg_date = value; }
        }

        [DataMember]
        public int Fees
        {
            get { return fees; }
            set { fees = value; }
        }
    }
}