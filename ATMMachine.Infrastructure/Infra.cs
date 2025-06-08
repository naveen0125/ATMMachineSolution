using System.Collections.Generic;
using ATMMachine.Core;

namespace ATMMachine.Infrastructure
{
    public class AccountService : IAccountService
    {
        private readonly Dictionary<string, Account> _accounts = new()
        {
            { "1234567890", new Account { CardNumber = "1234567890", Pin = "1234", Balance = 1000 } }
        };

        public bool ValidatePin(string cardNumber, string pin) =>
            _accounts.ContainsKey(cardNumber) && _accounts[cardNumber].Pin == pin;

        public decimal GetBalance(string cardNumber) =>
            _accounts.ContainsKey(cardNumber) ? _accounts[cardNumber].Balance : 0;

        public bool Withdraw(string cardNumber, decimal amount)
        {
            if (_accounts.ContainsKey(cardNumber) && _accounts[cardNumber].Balance >= amount)
            {
                _accounts[cardNumber].Balance -= amount;
                return true;
            }
            return false;
        }

        public void Deposit(string cardNumber, decimal amount)
        {
            if (_accounts.ContainsKey(cardNumber))
                _accounts[cardNumber].Balance += amount;
        }
    }
}
