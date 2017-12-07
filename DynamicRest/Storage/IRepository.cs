using DynamicRest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicRest.Storage
{
    public interface IRepository
    {
        IEnumerable<PersonInfo> GetPersons();
        PersonInfo GetPersonById(int id);

        IEnumerable<GroupInfo> GetGroups();
        GroupInfo GetGroupById(int id);
    }
}
