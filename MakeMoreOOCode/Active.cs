using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeMoreOOCode
{
    class Active : IAccountState
    {
        private Action OnUnfreeze { get; }

        public Active(Action onUnfreeze)
        {
            OnUnfreeze = onUnfreeze;
        }

        public IAccountState Deposit(Action addToBalance)
        {
            addToBalance();
            return this;
        }


        public IAccountState Freeze() => new Frozen(OnUnfreeze);

        public IAccountState Withdraw(Action subtractFrombalance)
        {
            subtractFrombalance();
            return this;
        }

        public IAccountState HolderVerified() => this;

        public IAccountState Close()
        {
            throw new NotImplementedException();
        }
    }
}
