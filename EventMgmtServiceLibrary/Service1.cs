using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace EventMgmtServiceLibrary
{
    public class Service1 : IService1
    {
        //const string constr = @"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = EventMgmt;Integrated Security = True;";
        const string constr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Eventmgnt;Integrated Security=True;";

        public bool DeleteParticipant(int id)
        {
            SqlConnection cnn = new SqlConnection(constr);
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand
                {
                    Connection = cnn,
                    CommandText = @"DELETE from participant WHERE pid = @id"
                };

                SqlParameter p = new SqlParameter("@id", id);
                cmd.Parameters.Add(p);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        public Participant GetParticipant(int id)
        {
            SqlConnection cnn = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "Select pid, fname,lname from participant where pid = @id";
            SqlParameter p = new SqlParameter("@id", id);
            cmd.Parameters.Add(p);
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Participant part = new Participant();

            while (reader.Read())
            {
                part.ParticipantId = reader.GetInt32(0);
                part.ParticipantfName = reader.GetString(1);
                part.ParticipantlName = reader.GetString(2);
            }

            reader.Close();
            cnn.Close();
            return part;
            //throw new NotImplementedException();
        }

        DataSet IService1.GetParticipants()
        {
            //const string constr =@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = EventMgmt;Integrated Security = True; Connect Timeout = 30; Encrypt=False;Trust Server Certificate=False;Application Intent = ReadWrite;Multi Subnet Failover=False";
            string query = "SELECT pid,fname,lname FROM participant";
            SqlDataAdapter da = new SqlDataAdapter(query,constr);
            DataSet ds = new DataSet();
            da.Fill(ds,"participants");
            //throw new NotImplementedException();
            return ds;
        }
       
    }
}
