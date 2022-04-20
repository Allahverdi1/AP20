using System;
using StadionTask.Data.DAL;
using StadionTask.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;


namespace StadionTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string con = @"Server=WIN-IVUSE4PLT5F\SQLEXPRESS;Database=StadionsDb;Trusted_Connection=True";
            bool check = true;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1.Stadion elave et");
                Console.WriteLine("2.Stadionlari goster");
                Console.WriteLine("3.User elave et");
                Console.WriteLine("4.Userleri goster");
                Console.WriteLine("5.Rezervasiyalari goster");
                Console.WriteLine("6.Rezarvasiya yarat");
                Console.WriteLine("7.Verilmish Id-li Stadionun rezarvasyalarini goster");
                Console.WriteLine("8.Verilmish Id-li Userin rezarvasyalarini goster");
                Console.WriteLine("7.Verilmish Id-li rezarvasyani sil");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        string Stadions = Console.ReadLine();
                        
                        
                        using (StadionDbContext dbContext = new StadionDbContext())
                        {
                            dbContext.Stadions.Add(Stadion);
                            dbContext.SaveChanges();
                        }
                        break;


                    case "2":
                }


            } while (true);

            
        }
    }
}
