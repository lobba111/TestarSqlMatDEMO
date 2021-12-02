
using System.Data;

using System.Data.SqlClient;

using (SqlConnection conn = new SqlConnection())
{
    conn.ConnectionString = "Data Source=LAPTOP-P0SKFSEV;Initial Catalog=DishesTest;Integrated Security=True;TrustServerCertificate = True;";
    try
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "SELECT TOP 5 mat FROM Maträtter ORDER BY NEWID()";
        cmd.Connection = conn;  
        conn.Open();
        Console.WriteLine("Anslutningen fungerar! : Här har du din matmeny för veckan");
        SqlDataReader sdr = cmd.ExecuteReader();
        int count = 0;
        string veckodag;
        string mat;
        while (sdr.Read())
        {
            if (count == 0)
            {
                veckodag = "Måndag";
                mat = (string)sdr["mat"];
                Console.WriteLine("{0} : {1}",veckodag,mat);
            }
            if (count == 1)
            {
                veckodag = "Tisdag";
                mat = (string)sdr["mat"];
                Console.WriteLine("{0} : {1}", veckodag, mat);
            }
            if (count == 2)
            {
                veckodag = "Onsdag";
                mat = (string)sdr["mat"];
                Console.WriteLine("{0} : {1}", veckodag, mat);
            }
            if (count == 3)
            {
                veckodag = "Torsdag";
                mat = (string)sdr["mat"];
                Console.WriteLine("{0} : {1}", veckodag, mat);
            }
            if (count == 4)
            {
                veckodag = "Fredag";
                mat = (string)sdr["mat"];
                Console.WriteLine("{0} : {1}", veckodag, mat);
            }
            count++;

        }
        conn.Close();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    Console.WriteLine("Är du nöjd med veckans meny eller vill du generera en ny?");
    Console.WriteLine("För ny meny tryck : 1 ");
    Console.WriteLine("För att avsluta tryck : 0");
    string input = Console.ReadLine();
    Console.Clear();
    while (input == "1")
    {
        switch (input)
        {
            case "1":
                {
                    conn.ConnectionString = "Data Source=LAPTOP-P0SKFSEV;Initial Catalog=DishesTest;Integrated Security=True;TrustServerCertificate = True;";
                    try
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT TOP 5 mat FROM Maträtter ORDER BY NEWID()";
                        cmd.Connection = conn;
                        conn.Open();
                        Console.WriteLine("Anslutningen fungerar! : Här har du din nya matmeny för veckan");
                        SqlDataReader sdr = cmd.ExecuteReader();
                        int count = 0;
                        string veckodag;
                        string mat;
                        while (sdr.Read())
                        {
                            if (count == 0)
                            {
                                veckodag = "Måndag";
                                mat = (string)sdr["mat"];
                                Console.WriteLine("{0} : {1}", veckodag, mat);
                            }
                            if (count == 1)
                            {
                                veckodag = "Tisdag";
                                mat = (string)sdr["mat"];
                                Console.WriteLine("{0} : {1}", veckodag, mat);
                            }
                            if (count == 2)
                            {
                                veckodag = "Onsdag";
                                mat = (string)sdr["mat"];
                                Console.WriteLine("{0} : {1}", veckodag, mat);
                            }
                            if (count == 3)
                            {
                                veckodag = "Torsdag";
                                mat = (string)sdr["mat"];
                                Console.WriteLine("{0} : {1}", veckodag, mat);
                            }
                            if (count == 4)
                            {
                                veckodag = "Fredag";
                                mat = (string)sdr["mat"];
                                Console.WriteLine("{0} : {1}", veckodag, mat);
                            }
                            count++;

                        }
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    Console.WriteLine("Är du nöjd med veckans meny eller vill du generera en ny?");
                    Console.WriteLine("För ny meny tryck : 1 ");
                    Console.WriteLine("För att avsluta tryck : 0");
                    input = Console.ReadLine();
                    Console.Clear();
                    break;
                }
            
        } 
    }
}

