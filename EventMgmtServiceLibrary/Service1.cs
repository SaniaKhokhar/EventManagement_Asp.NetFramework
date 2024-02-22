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


        DataSet IService1.GetOrganizers()
        {
            string query = "SELECT oid,org_name,org_email FROM organizer";
            SqlDataAdapter da = new SqlDataAdapter(query, constr);
            DataSet ds = new DataSet();
            da.Fill(ds, "orgenizers");
            
            return ds;
        }

        public Organizer GetOrganizer(int id) 
        {
            SqlConnection cnn = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "Select oid, org_name, org_contact, org_email from organizer where oid = @id";
            SqlParameter p = new SqlParameter("@id", id);
            cmd.Parameters.Add(p);
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Organizer org = new Organizer();

            while (reader.Read())
            {
                org.OrganizerId = reader.GetInt32(0);
                org.OrganizerName = reader.GetString(1);
                org.OrganizerContact = reader.GetInt32(2);
                org.OrganizerEmail = reader.GetString(3);
                
            }

            reader.Close();
            cnn.Close();

            return org;
        }

        public bool DeleteOrganizer(int id) 
        {

            SqlConnection cnn = new SqlConnection(constr);
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand
                {
                    Connection = cnn,
                    CommandText = @"DELETE from organizer WHERE oid = @id"

                };

                SqlParameter p = new SqlParameter("@id", id);
                cmd.Parameters.Add(p);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }

        }


        DataSet IService1.GetEvents()
        {
            string query = "SELECT e.eid, e.event_name, e.date, e.start_time, e.end_time, " +
                "(SELECT org_name FROM Organizer WHERE oid = e.oid), " +
                "(SELECT venue_name FROM Venue WHERE vid = e.vid) " +
                "FROM Event e";
            SqlDataAdapter da = new SqlDataAdapter(query, constr);
            DataSet ds = new DataSet();
            da.Fill(ds, "events");

            return ds;
        }

        public Event GetEvent(int id)
        {
            SqlConnection cnn = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "Select eid, event_name, date, start_time, end_time, oid from event where eid = @id";
            SqlParameter p = new SqlParameter("@id", id);
            cmd.Parameters.Add(p);
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Event evnt = new Event();

            while (reader.Read())
            {
                evnt.OrganizerId = reader.GetInt32(0);
                evnt.EventName = reader.GetString(1);
                evnt.Date = reader.GetDateTime(2);
                evnt.StartTime = reader.GetTimeSpan(3);
                evnt.EndTime = reader.GetTimeSpan(4);
                evnt.OrganizerId = reader.GetInt32(5);

            }

            reader.Close();
            cnn.Close();

            return evnt;
        }

        public bool DeleteEvent(int id)
        {
            SqlConnection cnn = new SqlConnection(constr);
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand
                {
                    Connection = cnn,
                    CommandText = @"DELETE from event WHERE eid = @id"

                };

                SqlParameter p = new SqlParameter("@id", id);
                cmd.Parameters.Add(p);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }

        }

        DataSet IService1.GetRegistrations()
        {
            string query = "SELECT r.rid , " +
                "(SELECT fname FROM Participant WHERE pid = r.pid), " +
                "(SELECT event_name FROM Event WHERE eid = r.eid), " +
                " r.reg_date, r.fees " +
                "FROM Registration r";
            SqlDataAdapter da = new SqlDataAdapter(query, constr);
            DataSet ds = new DataSet();
            da.Fill(ds, "registrations");

            return ds;
        }

        public Registration GetRegistration(int id)
        {
            SqlConnection cnn = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "Select rid, pid, eid, reg_date, fees from registration where rid = @id";
            SqlParameter p = new SqlParameter("@id", id);
            cmd.Parameters.Add(p);
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Registration reg = new Registration();

            while (reader.Read())
            {
                reg.RegistrationId = reader.GetInt32(0);
                reg.ParticipantId = reader.GetInt32(1);
                reg.EventId = reader.GetInt32(2);
                reg.RegistrationDate = reader.GetDateTime(3);
                reg.Fees = reader.GetInt32(4);
                
            }

            reader.Close();
            cnn.Close();

            return reg;
        }

        public bool DeleteRegistration(int id)
        {
            SqlConnection cnn = new SqlConnection(constr);
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand
                {
                    Connection = cnn,
                    CommandText = @"DELETE from registration WHERE rid = @id"

                };

                SqlParameter p = new SqlParameter("@id", id);
                cmd.Parameters.Add(p);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
}
