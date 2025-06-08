using System;

namespace ATMMachine.Core
{
    public class Account
    {
        public string CardNumber { get; set; }
        public string Pin { get; set; }
        public decimal Balance { get; set; }
    }

    public interface IAccountService
    {
        bool ValidatePin(string cardNumber, string pin);
        decimal GetBalance(string cardNumber);
        bool Withdraw(string cardNumber, decimal amount);
        void Deposit(string cardNumber, decimal amount);
    }
}
