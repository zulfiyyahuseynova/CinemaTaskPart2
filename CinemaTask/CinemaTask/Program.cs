using System;
using System.Data;
using System.Data.SqlClient;

namespace CinemaTask
{
    class Program
    {
        private static string connectionString = @"Server=213-16;Database=CinemaTask;Trusted_Connection=True;";
        static void Main(string[] args)
        {
            //CreateActors("Will","Smith",53);
            //DeleteActors(9);
            //GetActorsInfo();

            //CreateGenre("Thriller");
            //DeleteGenre(9);
            //GetGenresInfo();

            //CreateFilm("Bergen","2022-03-04");
            //DeleteFilm(9);
            //GetFilmsInfo();

            //CreateFilmGenres(5, 7);
            //DeleteFilmGenre(10);
            //GetFilmGenresInfo();

            //CreateFilmActor(2,6);
            //DeleteFilmActor(9);
            //GetFilmActorsInfo();

            //CreateCustomer("Anar","Qandayev");
            //DeleteCustomer(6);
            //GetCustomersInfo();

            //CreateHall(150);
            //DeleteHall(7);
            //GetHallsInfo();

            //CreateTicket("2022-04-01 00:00:00.000", 13, 45, 5, 6, 8, 12 );
            //DeleteTicket(5);
            //GetTicketInfo();

            //CreateSession("22:45");
            //DeleteSession(13);
            //GetSessionsInfo();
        }

        #region Actor
        static void GetActorsInfo()
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = "SELECT * FROM Actors";
                using (SqlDataAdapter sda = new SqlDataAdapter(command, conn))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        Console.WriteLine($"{dataRow["Id"]} {dataRow["Name"]} {dataRow["Surname"]} {dataRow["Age"]}");
                    }
                }
            }
        }

        static void CreateActor(string Name, string Surname, int Age)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"INSERT INTO Actors VALUES (N'{Name}', N'{Surname}', N'{Age}')";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("Actor create");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
            }
        }

        static void DeleteActor(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"DELETE Actors WHERE Id ={id}";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("Actor deleted");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
            }
        }

        static void UpdateActor(string Name, string Surname, int Age, int Id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string command = $"UPDATE Actors SET Name='{Name}', Surname='{Surname}', Age='{Age}', WHERE Id={Id}";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("Actor updated");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
            }
        }
        #endregion

        #region Genre
        static void GetGenresInfo()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = "SELECT * FROM Genres";
                using (SqlDataAdapter sda = new SqlDataAdapter(command, conn))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        Console.WriteLine($"{dataRow["Id"]} {dataRow["Name"]}");
                    }
                }
            }
        }

        static void CreateGenre(string Name)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"INSERT INTO Genres VALUES (N'{Name}')";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("Genre create");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
            }
        }

        static void DeleteGenre(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"DELETE Genres WHERE Id ={id}";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("Genre deleted");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
            }
        }
        #endregion

        #region Film
        static void GetFilmsInfo()
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = "SELECT * FROM Films";
                using (SqlDataAdapter sda = new SqlDataAdapter(command, conn))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        Console.WriteLine($"{dataRow["Id"]} {dataRow["Name"]} {dataRow["ReleaseDate"]}");
                    }
                }
            }
        }
        static void CreateFilm(string Name, string ReleaseDate)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"INSERT INTO Films VALUES (N'{Name}', N'{ReleaseDate}')";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("Film create");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
            }
        }
        static void DeleteFilm(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"DELETE Films WHERE Id ={id}";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("Film deleted");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
            }
        }
        #endregion

        #region Film Genre
        static void GetFilmGenresInfo()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = "SELECT * FROM FilmGenres";
                using (SqlDataAdapter sda = new SqlDataAdapter(command, conn))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        Console.WriteLine($"{dataRow["Id"]} {dataRow["FilmId"]} {dataRow["GenreId"]}");
                    }
                }
            }
        }
        static void CreateFilmGenres(int FilmId, int GenreId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"INSERT INTO FilmGenres VALUES (N'{FilmId}', N'{GenreId}')";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("Film Genre create");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
            }
        }
        static void DeleteFilmGenre(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"DELETE FilmGenres WHERE Id ={id}";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("Film Genre deleted");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
            }
        }
        #endregion

        #region Film Actor
        static void GetFilmActorsInfo()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = "SELECT * FROM FilmActors";
                using (SqlDataAdapter sda = new SqlDataAdapter(command, conn))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        Console.WriteLine($"{dataRow["Id"]} {dataRow["FilmId"]} {dataRow["ActorId"]}");
                    }
                }
            }
        }

        static void CreateFilmActor(int FilmId, int ActorId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"INSERT INTO FilmActors VALUES (N'{FilmId}', N'{ActorId}')";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("Film Actor create");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
            }
        }

        static void DeleteFilmActor(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"DELETE FilmActors WHERE Id ={id}";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("Film Actor deleted");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
            }
        }

        #endregion

        #region Customer
        static void GetCustomersInfo()
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = "SELECT * FROM Customers";
                using (SqlDataAdapter sda = new SqlDataAdapter(command, conn))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        Console.WriteLine($"{dataRow["Id"]} {dataRow["Name"]} {dataRow["Surname"]}");
                    }
                }
            }
        }

        static void CreateCustomer(string Name, string Surname)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"INSERT INTO Customers VALUES (N'{Name}', N'{Surname}')";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("Customer create");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
            }
        }

        static void DeleteCustomer(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"DELETE Customers WHERE Id ={id}";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("Customer deleted");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
            }
        }
        #endregion

        #region Hall
        static void GetHallsInfo()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = "SELECT * FROM Halls";
                using (SqlDataAdapter sda = new SqlDataAdapter(command, conn))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        Console.WriteLine($"{dataRow["Id"]}. {dataRow["SeatCount"]}");
                    }
                }
            }
        }

        static void CreateHall(int SeatCount)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"INSERT INTO Halls VALUES (N'{SeatCount}')";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("Hall create");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
            }
        }

        static void DeleteHall(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"DELETE Halls WHERE Id ={id}";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("Hall deleted");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
            }
        }
        #endregion

        #region Ticket
        static void GetTicketInfo()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = "SELECT * FROM Tickets";
                using (SqlDataAdapter sda = new SqlDataAdapter(command, conn))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        Console.WriteLine($"{dataRow["Id"]} {dataRow["SalesDate"]} {dataRow["Price"]} {dataRow["Place"]} {dataRow["CustomerId"]} {dataRow["HallId"]} {dataRow["FilmId"]} {dataRow["SessionId"]}");
                    }
                }
            }
        }

        static void CreateTicket(string SalesDate, double Price, int Place, int CustomerId, int HallId, int FilmId, int SessionId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"INSERT INTO Tickets VALUES ('{SalesDate}' '{Price}' '{Place}' '{CustomerId}' '{HallId}' '{FilmId}' '{SessionId}')";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("Ticket create");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
            }
        }

        static void DeleteTicket(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"DELETE Tickets WHERE Id ={id}";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("Ticket deleted");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
            }
        }
        #endregion

        #region Session
        static void GetSessionsInfo()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = "SELECT * FROM Sessionss";
                using (SqlDataAdapter sda = new SqlDataAdapter(command, conn))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        Console.WriteLine($"{dataRow["Id"]}. {dataRow["Time"]}");
                    }
                }
            }
        }

        static void CreateSession(string Time)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"INSERT INTO Sessionss VALUES ('{Time}')";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("Session created");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
            }
        }

        static void DeleteSession(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"DELETE Sessionss WHERE Id ={id}";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("Session deleted");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
            }
        }
        #endregion
    }
}
