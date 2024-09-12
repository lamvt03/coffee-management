using CoffeeManagement.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManagement.BLL
{
    public class AccountService
    {

        #region Singleton pattern
        private static AccountService instance;
        public static AccountService Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountService();
                return instance;
            }
            private set { instance = value; }
        }
        #endregion

        public bool isLoginSucess(string username, string password)
        {
            return AccountDAL.Instance.CountByUsernameAndPassword(username, password) > 0;
        }

        public DataRow GetAccountByUsername(string username)
        {
            return AccountDAL.Instance.GetAccountByUsername(username);
        }
    }
}
