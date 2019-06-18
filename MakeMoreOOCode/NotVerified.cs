using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeMoreOOCode
{
    class NotVerified : IAccountState 
    {
        public Action OnUnfreeze { get; }

        public IAccountState Close() => new Closed();

        public NotVerified(Action onUnfreeze)
        {
            OnUnfreeze = onUnfreeze;
        }
        public IAccountState Deposit(Action addToBalance)
        {
            addToBalance();
            return this;
        }

        public IAccountState Freeze() => this;

        public IAccountState HolderVerified() => new Active(OnUnfreeze);

        public IAccountState Withdraw(Action subtractFrombalance) => this;
    }
}
