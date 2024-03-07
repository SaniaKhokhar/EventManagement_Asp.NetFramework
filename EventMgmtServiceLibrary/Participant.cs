using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EventMgmtServiceLibrary
{
    [DataContract]
    public class Participant
    {
        private int pid;
        private string fname;
        private string lname;
        private long mob_no;
        private string email;

        [DataMember]
        public int ParticipantId { 
            get { return pid; } 
            set { pid = value; }
        }

        [DataMember]
        public string ParticipantfName {
            get {return fname; }
            set {fname = value; }
        }

        [DataMember]
        public string ParticipantlName
        {
            get { return lname; }
            set { lname = value; }
        }

        [DataMember]
        public long MobileNo
        {
            get { return mob_no; }
            set { mob_no = value; }
        }

        [DataMember]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
