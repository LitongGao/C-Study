using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManager
{
    public interface IAccount
    {
        decimal Balance { get; }
        string Name { get; }
    }
    public class Account : IAccount
    {
        #region field,propertice
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
        }
        private decimal balance;
        public decimal Balance
        {
            get
            {
                return balance;
            }
        }
        #endregion

        public Account(string name, Decimal balance)
        {
            this.name = name;
            this.balance = balance;
        }
    }
}
