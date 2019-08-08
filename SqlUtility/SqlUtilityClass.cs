using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CRUD_Operations_Using_EF.Models;
using System.Configuration;
using System.Web.Mvc;
using System.Data.SqlClient;

namespace CRUD_Operations_Using_EF.SqlUtility
{
    public static class SqlUtilityClass
    {
        public static void Insertion(Student modelData)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ToString();
            string InsertQuery = "INSERT INTO Student_TB (Id, Name, Email, City) VALUES  ('" + modelData.ID + "','" + modelData.NAME + "','" + modelData.EMAIL + "','" + modelData.CITY + "')";

            try
            {


                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(InsertQuery))
                    {
                        command.Connection = connection;
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }



            }

            catch (Exception)
            {
                new Exception("Could not save data, please try again !!");
            }

        }

        public static void Update(Student modelData)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ToString();
            string UpdateQuery = "UPDATE Student_TB SET Id='" + modelData.ID + "', Name='" + modelData.NAME + "', Email='" + modelData.EMAIL + "', City='" + modelData.CITY + "'";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(UpdateQuery))
                    {
                        command.Connection = connection;
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }

            catch (Exception)
            {
                new Exception("Could not save data, please try again !!");
            }
        }

        public static void Delete(Student modelData)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ToString();
            string DeleteQuery = "DELETE FROM Student_TB where (Student_TB.Id = '" + modelData.ID + "')";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(DeleteQuery))
                    {
                        command.Connection = connection;
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }

            catch (Exception)
            {
                new Exception("Could not save data, please try again !!");
            }
        }

        public static void StudentDetails(Student studentDetails)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ToString();
            string DetailsQuery = "SELECT * FROM Student_TB where (Student_TB.Id = '" + studentDetails.ID + "')";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(DetailsQuery))
                    {
                        command.Connection = connection;
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }

            catch (Exception)
            {
                new Exception("Could not save data, please try again !!");
            }
            
        }
    }
}