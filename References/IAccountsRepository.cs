using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References
{
    public interface IAccountsRepository
    {
        IEnumerable<Account> GetAccounts();
        Account GetAccount(int id);
    }
}
