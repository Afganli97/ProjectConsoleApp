using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface IGroup
    {
        Group Create(Group group);
        Group Update(int id, Group group);
        Group Delete(int id);
        List<Group> GetAll();
        Group Get(int id);
        Group Get(string name);
    }
}
