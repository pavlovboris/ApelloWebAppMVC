using ApelloWebAppMVC.Models;
using System.Data.SqlClient;

namespace ApelloWebAppMVC.Services
{
    public class UsersDAO
    {

        string connectionstring = "Data Source=definedsolutions-sql-server.database.windows.net;Initial Catalog = OrdersHandling; User ID = CstmDBDefSol; Password=uncloak-TAIWAN-peccary-listless;Connect Timeout = 30; Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public bool FindUserByNameAndPassowrd(UserModel user)
        {
            bool success = false;

            string sqlStatement = "SELECT * from dbo.Users WHERE UserName=@name AND Password=@password";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);

                command.Parameters.Add("@name", System.Data.SqlDbType.VarChar,50).Value = user.Name;
                command.Parameters.Add("@password", System.Data.SqlDbType.VarChar,50).Value = user.Password;

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        success = true;
                    }
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return success;
            }
        }
    }
}
