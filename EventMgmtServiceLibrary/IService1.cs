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
        DataSet GetParticipants();

        [OperationContract]
        Participant GetParticipant(int id);

        [OperationContract]
        bool DeleteParticipant(int id);

        //Venue services
        [OperationContract]
        DataSet GetVenues();

        [OperationContract]
        Venue GetVenue(int id);

        [OperationContract]
        bool DeleteVenue(int id);

        //Venue services
        [OperationContract]
        DataSet GetVenues();

        [OperationContract]
        Venue GetVenue(int id);

        [OperationContract]
        bool DeleteVenue(int id);
<<<<<<< HEAD

        [OperationContract]
        DataSet GetOrganizers();

        [OperationContract]
        Organizer GetOrganizer(int id);

        [OperationContract]
        bool DeleteOrganizer(int id);
=======
>>>>>>> 5ce38c263403f41e1ae47d2d855e0b1c5dc6d2c3
    }
}

