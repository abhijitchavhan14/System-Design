
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

}






























//using ConsoleApp1;
//using Npgsql;

//var connectionString = "Host=turntable.proxy.rlwy.net;Port=18468;Database=railway;Username=postgres;Password=VjsQBXyUyLRpvVmvSACgRxuNxqtSRtAR;SSL Mode=Require;Trust Server Certificate=True";
//try
//{
//    using (var conn = new NpgsqlConnection(connectionString))
//    {
//        await conn.OpenAsync();
//        Console.WriteLine("✅ Connection successful!");
//        // Optional: check server version
//        Console.WriteLine("Server version: " + conn.PostgreSqlVersion);
//        using (var cmd = new NpgsqlCommand("SELECT NOW()", conn))
//        {
//            var result = await cmd.ExecuteScalarAsync();
//            Console.WriteLine("Database time: " + result);
//        }
//    }
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}   
