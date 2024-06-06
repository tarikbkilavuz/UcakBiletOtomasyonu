using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Data;
using UcakBiletOtomasyonu.Models;

namespace UcakBiletOtomasyonu
{
    public static class DbInitializer
    {
        private static string connectionString = "Data Source=..\\..\\files\\UcakBiletOtomasyonu.db;Version=3;";

        public static void InitializeDatabase()
        {
            if (!File.Exists("..\\..\\files\\UcakBiletOtomasyonu.db")) 
            {
                SQLiteConnection.CreateFile("..\\..\\files\\UcakBiletOtomasyonu.db");
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                  
                    string createHavayoluTableQuery = @"
                        CREATE TABLE IF NOT EXISTS Havayolu(
                            id INTEGER PRIMARY KEY NOT NULL,
                            HavayoluSirketi TEXT NOT NULL
                            
                      );";
                    string insertHavayoluQuery = @"
                    INSERT INTO Havayolu (HavayoluSirketi) VALUES ('Türk Hava Yolları');
                    INSERT INTO Havayolu (uery = @""
                    INSERT INTO Havayolu (HavayoluSirketi) VALUES ('Pegasus');
                    INSERT INTO Havayolu (uery = @""
                    INSERT INTO Havayolu (HavayoluSirketi) VALUES ('Delta');
                    INSERT INTO Havayolu (uery = @""
                    INSERT INTO Havayolu (HavayoluSirketi) VALUES ('Lufthansa');";

                    string createUcakTableQuery = @"
                        CREATE TABLE IF NOT EXISTS Ucak(
                            UcakId INTEGER PRIMARY KEY NOT NULL,
                            Kapasite INTEGER NOT NULL
                        );";

                    string insertUcakQuery = @"
                    INSERT INTO Ucak (Kapasite) VALUES (96)";
                   
                    string createUcusTableQuery = @"
                        CREATE TABLE IF NOT EXISTS Ucak(
                            id INTEGER PRIMARY KEY NOT NULL,
                            tarih TEXT NOT NULL,
                            HavayoluId INTEGER NOT NULL,
                            UcakId INTEGER NOT NULL,
                            FOREIGN KEY (LokasyonId) REFERENCES Lokasyon(LokasyonId),
                            FOREIGN KEY (UcusId) REFERENCES Ucus(UcusId)

                        );";

                    string insertUcusQuery = @"
                    INSERT INTO Ucus (tarih, HavayoluId, UcakId ) VALUES ('20.04.2024', 1, 1);
                    INSERT INTO Ucus (tarih, HavayoluId, UcakId ) VALUES ('20.04.2024', 2, 1);
                    INSERT INTO Ucus (tarih, HavayoluId, UcakId ) VALUES ('20.04.2024', 3, 1);
                    INSERT INTO Ucus (tarih, HavayoluId, UcakId ) VALUES ('21.04.2024', 2, 1);
                    INSERT INTO Ucus (tarih, HavayoluId, UcakId ) VALUES ('21.04.2024', 1, 1);
                    INSERT INTO Ucus (tarih, HavayoluId, UcakId ) VALUES ('21.04.2024', 3, 1);
                    INSERT INTO Ucus (tarih, HavayoluId, UcakId ) VALUES ('22.04.2024', 1, 1);
                    INSERT INTO Ucus (tarih, HavayoluId, UcakId ) VALUES ('22.04.2024', 3, 1);
                    INSERT INTO Ucus (tarih, HavayoluId, UcakId ) VALUES ('22.04.2024', 2, 1);
                    INSERT INTO Ucus (tarih, HavayoluId, UcakId ) VALUES ('23.04.2024', 4, 1);
                    INSERT INTO Ucus (tarih, HavayoluId, UcakId ) VALUES ('23.04.2024', 4, 1)";
                    

                    string createRezervasyonTableQuery = @"
                    CREATE TABLE; IF NOT; EXISTS Ucus(
                            id INTEGER PRIMARY KEY NOT NULL,
                            koltukNo TEXT NOT NULL,
                          
                            UcusId INTEGER NOT NULL,
                            FOREIGN KEY (UcusId) REFERENCES Ucus(UcusId)
                           
                        );";

                    string insertRezervasyonQuery = @"
                   ;";


                    using (var command = new SQLiteCommand(connection))
                    {
                        command.CommandText = createHavayoluTableQuery;
                        command.ExecuteNonQuery();

                        command.CommandText = insertHavayoluQuery;
                        command.ExecuteNonQuery();

                        command.CommandText = createUcakTableQuery;
                        command.ExecuteNonQuery();

                        command.CommandText = insertUcakQuery;
                        command.ExecuteNonQuery();

                        command.CommandText = createUcusTableQuery;
                        command.ExecuteNonQuery();

                        command.CommandText = insertUcusQuery;
                        command.ExecuteNonQuery();

                        command.CommandText = createRezervasyonTableQuery;
                        command.ExecuteNonQuery();

                        command.CommandText = insertRezervasyonQuery;
                        command.ExecuteNonQuery();


                    }

                }
            }
        }
    }
}