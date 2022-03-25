using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;

namespace GameProject.Entities
{
    public class Member:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public long IdentificationNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime BirthDay { get; set; }
    }
}
