using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EventMgmtServiceLibrary
{
    [DataContract]
    public class Organizer
    {
        private int oid;
        private String org_name;
        private long org_contact;
        private String org_email;

        [DataMember]
        public int OrganizerId
        {
            get { return oid; }
            set { oid = value; }
        }

        [DataMember]
        public String OrganizerName
        {
            get { return org_name; }
            set { org_name = value; }
        }

        [DataMember]
        public long OrganizerContact
        {
            get { return org_contact; }
            set { org_contact = value; }
        }

        [DataMember]
        public String OrganizerEmail
        {
            get { return org_email; }
            set { org_email = value; }
        }

    }
}
