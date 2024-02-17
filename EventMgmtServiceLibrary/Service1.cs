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
            string query = "SELECT pid,fname,lname FROM participant";
            SqlDataAdapter da = new SqlDataAdapter(query,constr);
            DataSet ds = new DataSet();
            da.Fill(ds,"participants");
            //throw new NotImplementedException();
            return ds;
        }

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


        public DataSet GetVenues()
        {
            //throw new NotImplementedException();
            string query = "SELECT vid,venue_name, location, capacity FROM venue";
            SqlDataAdapter da = new SqlDataAdapter(query, constr);
            DataSet ds = new DataSet();
            da.Fill(ds, "venues");
            //throw new NotImplementedException();
            return ds;
        }

        public Venue GetVenue(int id)
        {
            SqlConnection cnn = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "Select vid, venue_name,location, capacity from venue where vid = @id";
            SqlParameter p = new SqlParameter("@id", id);
            cmd.Parameters.Add(p);
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Venue ven = new Venue();

            while (reader.Read())
            {
                ven.VenueId = reader.GetInt32(0);
                ven.VenueName = reader.GetString(1);
                ven.Location = reader.GetString(2);
                ven.Capacity = reader.GetInt32(3);
            }

            reader.Close();
            cnn.Close();
            return ven;
            // throw new NotImplementedException();
        }

        public bool DeleteVenue(int id)
        {
            SqlConnection cnn = new SqlConnection(constr);
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand
                {
                    Connection = cnn,
                    CommandText = @"DELETE from venue WHERE vid = @id"
                };

                SqlParameter p = new SqlParameter("@id", id);
                cmd.Parameters.Add(p);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            //throw new NotImplementedException();
        }
    }
}
