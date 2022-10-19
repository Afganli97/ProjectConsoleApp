using DataAccess.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    internal class StudentRepository : IRepository<Student>
    {
        public bool Add(Student entity)
        {
            try
            {
                DbContext.students.Add(entity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Student Get(Predicate<Student> filter = null)
        {
            return filter == null ? DbContext.students[0] : DbContext.students.Find(filter);
        }

        public List<Student> GetAll(Predicate<Student> filter = null)
        {
            return filter == null ? DbContext.students : DbContext.students.FindAll(filter);
        }

        public bool Remove(Student entity)
        {
            try
            {
                DbContext.students.Remove(entity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(Student entity)
        {
            try
            {
                Student student = Get(n => n.Name == entity.Name);
                student = entity;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
