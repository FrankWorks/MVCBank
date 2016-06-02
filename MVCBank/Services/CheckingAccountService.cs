using MVCBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBank.Services
{
    public class CheckingAccountService
    {
        private ApplicationDbContext db;
            public CheckingAccountService (ApplicationDbContext dbContext)
	{
                    db = dbContext;
	}
        public void CreateCheckingAccount(string firstName, string lastName, string UserId, decimal initialBalance)
        {
                   
                    var accountnumber = (123456 + db.CheckingAccounts.Count()).ToString().PadLeft(10, '0');
                    var checkingAccount = new CheckingAccount
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        AccountingNumber = accountnumber,
                        Balance = initialBalance,
                        ApplicationUserId = UserId
                    };
                    db.CheckingAccounts.Add(checkingAccount);
                    db.SaveChanges();
        }
    }
}