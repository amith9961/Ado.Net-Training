using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Ado.Net_ConsoleApp
{
    internal class Program
    {
        //change connection based on your set up
        const string connectionString = "Server=localhost;Database=Training;User Id=SA;Password=Amith@123;TrustServerCertificate=true;";
        static void Main(string[] args)
        {
            CreateTable();
            var employees = new List<Employee>()
            {
                new Employee()
                {
                    Name= "Arjun",
                    ProjectName ="Frontiers"
                },
                new Employee()
                {
                    Name= "Rahul",
                    ProjectName ="Frontiers"
                },
                new Employee()
                {
                    Name= "Manu",
                    ProjectName ="Sharjah"
                },
                new Employee()
                {
                    Name= "Nandu",
                    ProjectName ="Sharjah"
                },
                new Employee()
                {
                    Name= "Nandu",
                    ProjectName ="Other"
                },
            };


            //Insert  employees to the table employee
            //select  all  the information from employee table
            //update the employee project whose id is 5
            // delete the employee : choose any id
        }

        private static void CreateTable()
        {
            using(var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Employee') " +    "BEGIN " +    "CREATE TABLE Employee(Id integer identity primary key, Name varchar(20), ProjectName varchar(20)) " +    "END", connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
    public class Employee
    {
        public string Name { get; set; }
        public string ProjectName { get; set; }
    }
}
