using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DynamicRest.Models;

namespace DynamicRest.Storage
{
    public class Repository : IRepository
    {
        List<GroupInfo> _groups;
        List<PersonInfo> _persons;
        public Repository()
        {
            this._groups = new List<GroupInfo>();
            for (int x = 1; x <= 10; x++)
            {
                GroupInfo g = new GroupInfo() { Id = x, Name = "Group " + x };
                for (int y = 1; y <= 10; y++)
                    g.Members.Add(new PersonInfo() { Id = x, Name = "Person " + x + " " + y, Address = "Address " + x + " " + y, Contact = "Contact " + x + " " + y });

                this._groups.Add(g);
            }

            this._persons = new List<PersonInfo>();
            for(int x = 1; x <= 10; x++)
                this._persons.Add(new PersonInfo() { Id = x, Name = "Person " + x, Address = "Address " + x, Contact = "Contact " + x });
        }
       
        public PersonInfo GetPersonById(int id)
        {
            return this._persons.FirstOrDefault(item => item.Id == id);
        }

        public IEnumerable<PersonInfo> GetPersons()
        {
            return this._persons;
        }

        public GroupInfo GetGroupById(int id)
        {
            return this._groups.FirstOrDefault(item => item.Id == id);
        }

        public IEnumerable<GroupInfo> GetGroups()
        {
            return this._groups;
        }

    }
}
