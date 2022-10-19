using Entities.Models;
using System;
using System.Collections.Generic;

namespace DataAccess
{
    public static class DbContext
    {
        public static List<Student> students;
        public static List<Group> groups;
        static DbContext()
        {
            students = new List<Student>();
            groups = new List<Group>();
        }

    }
}
