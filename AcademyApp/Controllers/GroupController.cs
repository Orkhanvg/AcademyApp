using Business.Services;
using Entities.Models;
using System;
using Utilities.Helper;

namespace AcademyApp.Controllers
{
    class GroupController
    {
        private GroupService groupService;
        public GroupController()
        {
            groupService = new GroupService();
        }
        public void CreateGroup()
        {
        EnterName:
            Extention.Print(ConsoleColor.Green, $"Group Name");
            string name = Console.ReadLine();

            Extention.Print(ConsoleColor.Green, $"Group Size");
            string groupSize = Console.ReadLine();
            int size;


            bool isSize = int.TryParse(groupSize, out size);
            if (isSize)
            {
                Group group = new Group
                {
                    Name = name,
                    MaxSize = size
                };

                groupService.Create(group);
                Extention.Print(ConsoleColor.Green, $"{group.Name} created");
            }
            else
            {
                Extention.Print(ConsoleColor.Red, "Duzgun daxil et");
                goto EnterName;
            }


        }



        public void GetAllGroup()
        {

            foreach (var item in groupService.GetAll())
            {
                Extention.Print(ConsoleColor.Yellow, $"{item.Name}");
            }


        }
        public void RemoveGroup()
        {
            int id = int.Parse(Console.ReadLine());
            Extention.Print(ConsoleColor.Green, $"{groupService.Delete(id).Name}");

        }
        public void UpdateGroup()
        {
        update_group:
            Extention.Print(ConsoleColor.Cyan, "Enter Id");
            int id;

            Extention.Print(ConsoleColor.Cyan, "Enter new Name");
            string name = Console.ReadLine();

            bool isId = int.TryParse(Console.ReadLine(), out id);
            if (isId)
            {
                Group group = new Group
                {
                    Name = name
                };
                Extention.Print(ConsoleColor.Cyan, $"{groupService.Update(id, group).Name}");

            }

            else
            {
                Extention.Print(ConsoleColor.Cyan, "Try again");
                goto update_group;
            }



        }
    }
}
