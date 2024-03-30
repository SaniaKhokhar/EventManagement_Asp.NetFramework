using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EventMgmtServiceLibrary
{
    [ServiceContract]
    public interface IService1
    {
        //Participant services
        [OperationContract]
        bool AddParticipant(string fname, string lname, long mob_no, string email);

        [OperationContract]
        DataSet GetParticipants();

        [OperationContract]
        Participant GetParticipant(int id);

        [OperationContract]
        bool DeleteParticipant(int id);

        [OperationContract]
        bool UpdateParticipant(int pid, string fname, string lname, long mob_no, string email);

        //Venue services
        [OperationContract]
        bool AddVenue(string venue_name, string location, int capacity);

        [OperationContract]
        DataSet GetVenues();

        [OperationContract]
        Venue GetVenue(int id);

        [OperationContract]
        bool DeleteVenue(int id);

        [OperationContract]
        bool UpdateVenue(int vid, string venue_name, string location, int capacity);


        //Organizer services
        [OperationContract]
        bool AddOrganizer(string org_name, long org_contact, string org_email);

        [OperationContract]
        DataSet GetOrganizers();

        [OperationContract]
        Organizer GetOrganizer(int id);

        [OperationContract]
        bool DeleteOrganizer(int id);

        [OperationContract]
        bool UpdateOrganizer(int oid, string org_name, long org_contact, string org_email);

        //Event services
        [OperationContract]
        bool AddEvent(string event_name, DateTime date, string start_time, string  end_time,int oid, int vid);

        [OperationContract]
        DataSet GetEvents();

        [OperationContract]
        Event GetEvent(int id);

        [OperationContract]
        bool DeleteEvent(int id);

        [OperationContract]
        bool UpdateEvent(int eid, string event_name, DateTime date, String start_time, String end_time, int oid, int vid);

        // Event Regitration
        [OperationContract]
        bool AddRegistration(int pid, int eid, DateTime reg_date, int fees);
        
        [OperationContract]
        DataSet GetRegistrations();

        [OperationContract]
        Registration GetRegistration(int id);

        [OperationContract]
        bool DeleteRegistration(int id);

        [OperationContract]
        bool UpdateRegistration(int rid, int pid, int eid, DateTime reg_date, int fees);
    }
}
