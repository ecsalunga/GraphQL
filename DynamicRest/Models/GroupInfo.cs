using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicRest.Models
{
    public class GroupInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<PersonInfo> Members { get; set; }

        public GroupInfo()
        {
            this.Members = new List<PersonInfo>();
        }
    }
}
