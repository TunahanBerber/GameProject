using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Adapters
{
    public class EDevletServiceAdapter:IMemberCheckService
    {
        public bool IsRealPerson(Member member)
        {
            return true;
        }
    }
}
