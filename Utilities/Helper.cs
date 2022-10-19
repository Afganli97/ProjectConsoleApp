using System;

namespace Utilities
{
    public class Helper
    {
        public static void Display(ConsoleColor color, string mesage)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(mesage);
            Console.ResetColor();
        }
        public enum GroupMethods
        {
            AddGroup = 1,
            UpdateGroup,
            DeleteGroup,
            GetGroupById,
            GetGroupByName,
            GetAllGroups
        }

    }
}
