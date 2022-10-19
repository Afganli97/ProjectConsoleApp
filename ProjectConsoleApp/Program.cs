using Business.Services;
using Entities.Models;
using ProjectConsoleApp.Controllers;
using System;
using System.Collections.Generic;
using Utilities;

namespace ProjectConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            GroupController groupController = new GroupController();
            while (true)
            {
                Console.Clear();
                Helper.Display(ConsoleColor.Blue, "1.Add Group\n2.Update Group\n3.Delete Group\n4.Get Group by Id\n5.Get Group by Name\n6.Get All Groups");

                string selectMenu = Console.ReadLine();
                int menu;
                bool isChangeMenu = Int32.TryParse(selectMenu,out menu);
                if (isChangeMenu && menu > 0 && menu < 7)
                {
                    switch (menu)
                    {
                        case (int)Helper.GroupMethods.AddGroup:
                            groupController.Create();
                            break;
                        case (int)Helper.GroupMethods.GetAllGroups:
                            groupController.GetAll();
                            break;
                        case (int)Helper.GroupMethods.DeleteGroup:
                            groupController.Delete();
                            break;
                        case (int)Helper.GroupMethods.UpdateGroup:
                            groupController.Update();
                            break;
                    }
                }
                else if (isChangeMenu && menu == 0)
                {
                    Helper.Display(ConsoleColor.White, "Bye Bye");
                    break;
                }
                else
                {
                    Helper.Display(ConsoleColor.Red,"Menu secimi duzgun daxil edilmeyib!");
                }
                Console.WriteLine("S");







                Helper.Display(ConsoleColor.Green, "Press Enter");
                Console.ReadLine();
            }
        }
    }
}
