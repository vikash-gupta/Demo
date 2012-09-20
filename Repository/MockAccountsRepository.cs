using References;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockRepository
{
    public class MockAccountsRepository: IAccountsRepository
    {
        Random random;
        public MockAccountsRepository()
        {
            random = new Random();
        }
        
        public IEnumerable<Models.Account> GetAccounts()
        {
            return new List<Models.Account>{new Models.Account{Id=random.Next(200,300), Balance=23.35, NickName="checking"}, 
                new Models.Account{Id=random.Next(100,200), Balance=12.78, NickName="saving"}};
        }

        public Models.Account GetAccount(int id)
        {
            return new Models.Account { Id = id, Balance = id*1.05, NickName = "Random" };
        }
    }

}
