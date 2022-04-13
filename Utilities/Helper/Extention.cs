using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities.Helper
{
    public static class Extention
    {
        public static void Print( ConsoleColor color,string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public enum Menu
        {
            CreateGroup=1,
            UpdateGroup,
            RemoveGroup,
            GetAllGroup=5


        }
    }
}
