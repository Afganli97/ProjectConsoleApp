using Business.Services;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Utilities;

namespace ProjectConsoleApp.Controllers
{
    public class GroupController
    {
        public GroupService groupService { get; set; }
        public GroupController()
        {
            groupService = new GroupService();
        }
        public void Create()
        {
            Helper.Display(ConsoleColor.Yellow, "Group adi daxil edin");
            string name = Console.ReadLine();
            Helper.Display(ConsoleColor.Yellow, "Group size-ni daxil edin");
        WriteSizeAgain: string groupSize = Console.ReadLine();
            int size;
            bool isChangeSize = Int32.TryParse(groupSize, out size);
            if (isChangeSize)
            {
                Group newGroup = new Group();
                newGroup.Name = name;
                newGroup.Capacity = size;
                if (groupService.Create(newGroup) != null)
                {
                    Helper.Display(ConsoleColor.Blue, newGroup.Name + " adli group yaradildi");
                }
                else
                {
                    Helper.Display(ConsoleColor.Red, "Group yaradilmadi");
                }
            }
            else
            {
                Helper.Display(ConsoleColor.Red, "Group size duzgun daxil edin");
                goto WriteSizeAgain;
            }
        }
        public void GetAll()
        {
            List<Group> groups = groupService.GetAll();
            foreach (var item in groups)
            {
                Console.WriteLine(item.Id + "." + item.Name);
            }
        }
        public void Delete()
        {
            Helper.Display(ConsoleColor.Yellow, "Silmek istediyin groupun id-sin daxil et");
            int id;
            WriteId: string idTemp = Console.ReadLine();
            bool isChangeId = Int32.TryParse(idTemp,out id);
            if (isChangeId)
            {
                if (groupService.Delete(id) != null)
                {
                    Helper.Display(ConsoleColor.Blue, "Group silindi");
                }
                else
                {
                    Helper.Display(ConsoleColor.Red, "Groupun Id-sin duzgun daxil et");
                    goto WriteId;
                }
            }
            else
            {
                Helper.Display(ConsoleColor.Red, "Groupun Id-sin duzgun daxil et");
                goto WriteId;
            }
        }
        public void Update()
        {
            Group group = new Group();
            int id;
            int capacity;
            Helper.Display(ConsoleColor.Yellow, "Update elemek istediyin groupun id-sin daxil et");
        WriteId: string idTemp = Console.ReadLine();
            Helper.Display(ConsoleColor.Yellow, "Group-a yeni ad ver");
            group.Name = Console.ReadLine();
            Helper.Display(ConsoleColor.Yellow, "Group-a yeni size ver");
            string capacityTemp = Console.ReadLine();
            bool isChangeCapacity = Int32.TryParse(capacityTemp,out capacity);
            bool isChangeId = Int32.TryParse(idTemp, out id);
            if (isChangeId && isChangeCapacity)
            {
                if (groupService.Update(id, group) != null)
                {
                    Helper.Display(ConsoleColor.Blue, "Group update olundu");
                }
                else
                {
                    Helper.Display(ConsoleColor.Red, "Sehv! Melumatlari duzgun daxil et");
                    goto WriteId;
                }
            }
            else
            {
                Helper.Display(ConsoleColor.Red, "Sehv! Melumatlari duzgun daxil et");
                goto WriteId;
            }
        }
    }
}
