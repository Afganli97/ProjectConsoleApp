using Business.Interfaces;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Services
{
    public class GroupService : IGroup
    {
        public GroupRepository groupRepository { get; set; }
        public static int Count { get; set; }
        public GroupService()
        {
            groupRepository = new GroupRepository();
        }
        public Group Create(Group group)
        {
            try
            {
                Group existGroup = groupRepository.Get(g => g.Name.ToLower() == group.Name.ToLower());
                if (existGroup != null)
                    return null;
                group.Id = ++Count;
                groupRepository.Add(group);
                return group;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Group Delete(int id)
        {
            try
            {
                Group existGroup = groupRepository.Get(g => g.Id == id);
                if (existGroup != null)
                {
                    groupRepository.Remove(existGroup);
                    return existGroup;
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }

        }

        public Group Get(int id)
        {
            throw new NotImplementedException();
        }

        public Group Get(string name)
        {
            throw new NotImplementedException();
        }

        public List<Group> GetAll()
        {
            return groupRepository.GetAll();
        }

        public Group Update(int id, Group group)
        {
            try
            {
                Group existGroup = groupRepository.Get(g => g.Id == id);
                if (existGroup != null)
                {
                    existGroup.Name = group.Name;
                    existGroup.Capacity = group.Capacity;
                    return existGroup;
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
