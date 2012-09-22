using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using References;

namespace Web.Controllers
{
    
    public class AccountsController : ApiController
    {
        public IAccountsRepository AccountsRepository { get; set; }
        public AccountsController(IAccountsRepository repository)
        {
            AccountsRepository = repository;
        }
        // GET api/accounts
        public IEnumerable<Account> Get()
        {
            return AccountsRepository.GetAccounts();
        }

        // GET api/accounts/5
        [Authorize]
        public Account Get(int id)
        {
            return AccountsRepository.GetAccount(id);
        }

        // POST api/accounts
        public void Post([FromBody]string value)
        {
        }

        // PUT api/accounts/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/accounts/5
        public void Delete(int id)
        {
        }
    }
}
