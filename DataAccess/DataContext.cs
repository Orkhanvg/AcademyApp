using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class DataContext:DbContext
    {
        public static List<Student> Students { get; set; }
        public static List<Group> Groups { get; set; }

        static DataContext()
        {
            Students = new List<Student>();
            Groups = new List<Group>();
        }
        

        //public DbSet<Student> Students { get; set; }
        //public DbSet<Group> Groups { get; set; }
        //dbContext.Students.tolist();
        //     dbContext.Students.firstordefaul(x=>x.id==id);


    }
}
