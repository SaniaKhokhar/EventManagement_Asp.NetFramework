using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace EventMgmtServiceLibrary
{
    public class Service1 : IService1
    {
        //const string constr = @"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = EventMgmt;Integrated Security = True;";
        const string constr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EventMgmt;Integrated Security=True;";

        public bool AddParticipant(string fname, string lname, long mob_no, string email)
        {
            SqlConnection cnn = new SqlConnection(constr);
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand
                {
                    Connection = cnn,
                    CommandText = @"INSERT into participant (fname,lname,mob_no,email) values (@fname, @lname, @mob_no, @email)",
                };
                SqlParameter p1 = new SqlParameter("@fname", fname);
                cmd.Parameters.Add(p1);
                SqlParameter p2 = new SqlParameter("@lname", lname);
                cmd.Parameters.Add(p2);
                SqlParameter p3 = new SqlParameter("@mob_no", mob_no);
                cmd.Parameters.Add(p3);
                SqlParameter p4 = new SqlParameter("@email", email);
                cmd.Parameters.Add(p4);


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
            string query = "SELECT pid as Id, fname as First_Name,lname as Last_Name, email as Email, mob_no as Mobile_No FROM participant";
            SqlDataAdapter da = new SqlDataAdapter(query, constr);
            DataSet ds = new DataSet();
            da.Fill(ds, "participants");
            //throw new NotImplementedException();
            return ds;
        }

        public bool DeleteParticipant(int id)
        {
            SqlConnection cnn = new SqlConnection(constr);
            {
                /*
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
            }*/

                cnn.Open();

                // Check if there are any associated registrations
                SqlCommand checkCmd = new SqlCommand
                {
                    Connection = cnn,
                    CommandText = @"SELECT COUNT(*) FROM Registration WHERE pid = @id"
                };
                checkCmd.Parameters.AddWithValue("@id", id);
                int registrationCount = (int)checkCmd.ExecuteScalar();

                if (registrationCount > 0)
                {
                    // If there are associated registrations, you might want to handle this situation.
                    // For example, you could delete the associated registrations or update foreign key references.

                    // Example: Deleting associated registrations
                    SqlCommand deleteRegistrationsCmd = new SqlCommand
                    {
                        Connection = cnn,
                        CommandText = @"DELETE FROM Registration WHERE pid = @id"
                    };
                    deleteRegistrationsCmd.Parameters.AddWithValue("@id", id);
                    deleteRegistrationsCmd.ExecuteNonQuery();
                }

                // Now, delete the participant record
                SqlCommand deleteParticipantCmd = new SqlCommand
                {
                    Connection = cnn,
                    CommandText = @"DELETE FROM participant WHERE pid = @id"
                };
                deleteParticipantCmd.Parameters.AddWithValue("@id", id);
                int rowsAffected = deleteParticipantCmd.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }

        //Venues 
        public bool AddVenue(string venue_name, string location, int capacity)
        {
            SqlConnection cnn = new SqlConnection(constr);
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand
                {
                    Connection = cnn,
                    CommandText = @"INSERT into venue (venue_name,location,capacity) values (@venue_name, @location, @capacity)",
                };
                SqlParameter p1 = new SqlParameter("@venue_name", venue_name);
                cmd.Parameters.Add(p1);
                SqlParameter p2 = new SqlParameter("@location", location);
                cmd.Parameters.Add(p2);
                SqlParameter p3 = new SqlParameter("@capacity", capacity);
                cmd.Parameters.Add(p3);
             
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
        public DataSet GetVenues()
        {
        //throw new NotImplementedException();
            string query = "SELECT vid as Id, venue_name as Venue_Name, location as Location, capacity as Capacity FROM venue";
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
        
       public bool AddOrganizer(string org_name, long org_contact, string org_email)
        {
            SqlConnection cnn = new SqlConnection(constr);
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand
                {
                    Connection = cnn,
                    CommandText = @"INSERT into organizer (org_name,org_contact,org_email) values (@org_name, @org_contact, @org_email)",
                };
                SqlParameter p1 = new SqlParameter("@org_name", org_name);
                cmd.Parameters.Add(p1);
                SqlParameter p2 = new SqlParameter("@org_contact", org_contact);
                cmd.Parameters.Add(p2);               
                SqlParameter p3 = new SqlParameter("@org_email", org_email);
                cmd.Parameters.Add(p3);


                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
       }

        DataSet IService1.GetOrganizers()
        {
            string query = "SELECT oid as Id, org_name as Name,org_email as Email FROM organizer";
            SqlDataAdapter da = new SqlDataAdapter(query, constr);
            DataSet ds = new DataSet();
            da.Fill(ds, "organizers");

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

        public bool AddEvent(string event_name, DateTime date, TimeSpan start_time, TimeSpan end_time, int oid, int vid)
        {
            SqlConnection cnn = new SqlConnection(constr);
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand
                {
                    Connection = cnn,
                    CommandText = @"INSERT into event (event_name,date,start_time,end_time,oid,vid) values (@event_name, @date,@start_time, @end_time, @oid, @vid)",
                };
                SqlParameter p1 = new SqlParameter("@event_name", event_name);
                cmd.Parameters.Add(p1);
                SqlParameter p2 = new SqlParameter("@date", date);
                cmd.Parameters.Add(p2);
                SqlParameter p3 = new SqlParameter("@start_time", start_time);
                cmd.Parameters.Add(p3);
                SqlParameter p4 = new SqlParameter("@end_time", end_time);
                cmd.Parameters.Add(p4);
                SqlParameter p5 = new SqlParameter("@oid", oid);
                cmd.Parameters.Add(p5);
                SqlParameter p6 = new SqlParameter("@vid", vid);
                cmd.Parameters.Add(p6);


                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
        DataSet IService1.GetEvents()
        {
            string query = "SELECT e.eid as Id, e.event_name as Event_Name, e.date as Date, e.start_time as Start_Time, e.end_time as End_Time, " +
                "(SELECT org_name FROM Organizer WHERE oid = e.oid) as Organizer, " +
                "(SELECT venue_name FROM Venue WHERE vid = e.vid) as Venue " +
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

        public bool AddRegistration(int pid, int eid, DateTime reg_date, int fees)
        {
            SqlConnection cnn = new SqlConnection(constr);
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand
                {
                    Connection = cnn,
                    CommandText = @"INSERT into registration (pid,eid, reg_date,fees) values (@pid, @eid, @reg_date, @fees)",
                };
                SqlParameter p1 = new SqlParameter("@pid", pid);
                cmd.Parameters.Add(p1);
                SqlParameter p2 = new SqlParameter("@eid", eid);
                cmd.Parameters.Add(p2);
                SqlParameter p3 = new SqlParameter("@reg_date", reg_date);
                cmd.Parameters.Add(p3);
                SqlParameter p4 = new SqlParameter("@fees", fees);
                cmd.Parameters.Add(p4);


                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
        DataSet IService1.GetRegistrations()
        {
            string query = "SELECT r.rid as Id, " +
                "(SELECT fname FROM Participant WHERE pid = r.pid) as Name, " +
                "(SELECT event_name FROM Event WHERE eid = r.eid) as Event, " +
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