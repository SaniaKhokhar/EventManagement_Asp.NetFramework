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
        [OperationContract]
        DataSet GetParticipants();

        [OperationContract]
        Participant GetParticipant(int id);

        [OperationContract]
        bool DeleteParticipant(int id);
    }
}

