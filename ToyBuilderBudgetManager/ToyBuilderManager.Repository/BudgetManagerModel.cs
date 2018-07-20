using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using Dapper;
using ToyBuilderBudgetManager.Model;

namespace ToyBuilderManager.Repository
{
    public class BudgetManagerModel
    {
        private static string _connectionString; 
        public BudgetManagerModel(string dataBase)
        {
            _connectionString = $"Server=(LocalDb)\\MSSQLLocalDB;Integrated Security=true;initial Catalog={dataBase}";
        }

        public UserProfile AddUser(UserProfile userProfile)
        {
            using (var connnection = new SqlConnection(_connectionString))
            {
                const string sqlQuery = "insert into dbo.UserProfile (FirstName, LastName, Salary) Values (@FirstName, @LastName,@Salary)";
                connnection.Execute(sqlQuery, userProfile);
            }

            return userProfile;
        }

        public List<UserProfile> GetAllUsers()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                const string sqlQuery = "Select * from UserProfile";
                return connection.Query<UserProfile>(sqlQuery).ToList();
            }
            
        }
    }
}