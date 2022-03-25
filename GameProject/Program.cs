using System;
using GameProject.Abstract;
using GameProject.Adapters;
using GameProject.Concrete;
using GameProject.Entities;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Member member1 = new Member();
            member1.UserName = "YüceTunahan";
            member1.FirstName = "Tunahan";
            member1.LastName = "Berber";
            member1.BirthDay = new DateTime(1999,02, 19);
            member1.IdentificationNumber = 98765432100;

            Member member2 = new Member();
            member2.UserName = "AyşeBerber123";
            member2.FirstName = "Ayşe";
            member2.LastName = "Berber";
            member2.BirthDay = new DateTime(1972, 6, 5);
            member2.IdentificationNumber = 10212345678;

            BaseMemberManager member = new MemberManager(new EDevletServiceAdapter());
            member.Save(member1);
            member.Update(member2, "YüceAyşe");
            member.Delete(member2);

            Campaign campaign1 = new Campaign()
            {
                Id = 1,
                CampaignName = "50% Discount",
                Description = "All Games has 50% Discount until end of month",
                StartOfCampaignDate = new DateTime(2022, 1, 1),
                EndOfCampaignDate = new DateTime(2023, 1, 31),
                Discount = 0.2

            };

            Game game1 = new Game()
            {
                Id = 1,
                GameName = "Mount And Blade",
                Price = 399.99,
                Stock = 3
            };

            Game game2 = new Game()
            {
                Id = 2,
                GameName = "Fifa 2022",
                Price = 359.99,
                Stock = 2
            };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.AddCampaign(campaign1);
            campaignManager.AddProduct(campaign1, game2);



            SaleManager saleManager = new SaleManager();
            saleManager.Sale(game1);
            saleManager.ClearenceSale(game2, campaign1);

        }
    }

    
}
