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
<<<<<<< HEAD

        //Venue services
        [OperationContract]
        DataSet GetVenues();

        [OperationContract]
        Venue GetVenue(int id);

        [OperationContract]
        bool DeleteVenue(int id);
=======
>>>>>>> 6541e3cf421210a3d9f4536b896f519b14c409d7
    }
}

