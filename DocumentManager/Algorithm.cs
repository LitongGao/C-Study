using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManager
{
    public static class Algorithm
    {
        public static decimal AccumulateSimple(IEnumerable<Account> e)
        {
            decimal sum = 0;
            foreach (Account a in e)
            {
                sum += a.Balance;
            }
            return sum;
        }

        public static decimal Accumulate<TAccount>(IEnumerable<TAccount> coll)
            where TAccount:IAccount
        {
            decimal sum = 0;
            foreach (TAccount a in coll)
            {
                sum += a.Balance;
            }
            return sum;
        }

        //public sealed delegate void EventHandler1<TEventArgs>(object sender, TEventArgs e)
        //    where TEventArgs : EventArgs;

        public delegate TSummary Action<TInput, TSummary>(TInput t, TSummary s);
        public static TSummary AccumulateDelegate<TInput,TSummary>(IEnumerable<TInput> coll,Action<TInput,TSummary> action)
        {
            TSummary sum = default(TSummary);
            foreach (TInput input in coll)
            {
                sum = action(input, sum);
            }
            return sum;
        }

        public static TSum AccumulateIf<TInput,TSum>(IEnumerable<TInput> col,Action<TInput,TSum> actionIf,Predicate<TInput> match)
        {
            TSum sum = default(TSum);
            foreach (TInput input in col)
            {
                if(match(input))
                {
                    sum = actionIf(input, sum);
                }
                
            }
            return sum;
        }
    }
}
