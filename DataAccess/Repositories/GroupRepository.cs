using DataAccess.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class GroupRepository : IRepository<Group>
    {
        public bool Add(Group entity)
        {
            try
            {
                DbContext.groups.Add(entity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Group Get(Predicate<Group> filter = null)
        {
            return filter == null ? DbContext.groups[0] : DbContext.groups.Find(filter);
        }

        public List<Group> GetAll(Predicate<Group> filter = null)
        {
            return filter == null ? DbContext.groups : DbContext.groups.FindAll(filter);
        }

        public bool Remove(Group entity)
        {
            try
            {
                DbContext.groups.Remove(entity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(Group entity)
        {
            try
            {
                Group groups = Get(n => n.Name == entity.Name);
                groups = entity;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
