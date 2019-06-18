using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeMoreOOCode
{
    class Account
    {
        public decimal Balance { get; set;  }

        private IAccountState State { get; set; }


        public Account(Action onUnfreeze)
        {
            State = new NotVerified(onUnfreeze);
        }

        public void Deposit(decimal amount)
        {
            State = State.Deposit(() => { Balance += amount});
        }

        public void WithDraw(decimal amount)
        {
            State = State.Withdraw(() => { Balance -= amount;});
        }

        private void StayUnfrozen() { }

        public void HolderVerified()
        {
            State = State.HolderVerified();
        }

        public void Close()
        {
            State = State.Close();
        }

        public void Freeze()
        {
            State = State.Freeze();
        }
    }
}
