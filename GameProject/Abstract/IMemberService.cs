using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Entities;

namespace GameProject.Abstract
{
    public interface IMemberService
    {
        void Save(Member member);
        void Update(Member member, string newUserName);
        void Delete(Member member);
    }
}
