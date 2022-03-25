using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Entities;

namespace GameProject.Abstract
{
    public abstract class BaseMemberManager:IMemberService
    {
        public virtual void Save(Member member)
        {
            Console.WriteLine("New User " + member.UserName + "is Saved to the System");
        }

        public void Update(Member member, string newUserName)
        {
            string oldUserName = member.UserName;
            member.UserName = newUserName;
            Console.WriteLine("Your Username is Changed From " + oldUserName + "to" + member.UserName);
        }

        public void Delete(Member member)
        {
            Console.WriteLine(member.UserName + " is Deleted from the System");
        }
    }
}
