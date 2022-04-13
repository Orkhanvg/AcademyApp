using AcademyApp.Controllers;
using Business.Services;
using Entities.Models;
using System;
using System.Collections.Generic;
using Utilities.Helper;

namespace AcademyApp
{
    class Program
    {
        //private static GroupService groupService;
        //public Program()
        //{
        //    groupService = new GroupService();
        //}
        static void Main(string[] args)
        {
           Extention.Print(ConsoleColor.Green, "Welcome");
            while (true)
            {
                GroupController groupController=new GroupController();
                Extention.Print(ConsoleColor.Cyan, "1-Create Group\n" +
                    "2-Update Group\n" +
                    "3-Remove Group\n" +
                    "4-Get Group \n" +
                    "5-GetAll Group");
                string num = Console.ReadLine();
                int input;

                bool IsNum = int.TryParse(num, out input);
                if (IsNum&&input<7&&input>0)
                {
                    switch (input)
                    {
                        case (int)Extention.Menu.CreateGroup:
                            groupController.CreateGroup();
                            break;
                        case (int)Extention.Menu.UpdateGroup:
                            groupController.UpdateGroup();
                            break;

                            break;
                        case (int)Extention.Menu.RemoveGroup:
                            groupController.RemoveGroup();
                            break;
                        case 4:
                            break;
                        case (int)Extention.Menu.GetAllGroup:
                            groupController.GetAllGroup();
                            break;
                    }
                }

            }
        }
    }
}
