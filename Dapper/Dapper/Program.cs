using Dapper.Connection;

namespace Dapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionStr = ConnectionString.GetConnectionString("appsettings.json", "DefaultConnection");
            
            
        }
    }
}