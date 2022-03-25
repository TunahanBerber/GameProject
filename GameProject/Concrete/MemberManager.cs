using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    class MemberManager:BaseMemberManager
    {
        private IMemberCheckService memberCheckService;

        public MemberManager(IMemberCheckService memberCheckService)
        {
            this.memberCheckService = memberCheckService;
        }

        public override void Save(Member member)
        {
            if (memberCheckService.IsRealPerson(member))
            {
                base.Save(member);
            }
            else
            {
                throw new Exception("Upps.. There is no Real Person!!");
            }
          
        }
    }
}
