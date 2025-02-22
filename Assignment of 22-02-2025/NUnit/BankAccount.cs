using NUnit.Framework;
using BankingApp;

namespace BankingTests {
    [TestFixture]
    public class BankAccountTests {
        private BankAccount bankAccount;

        [SetUp]
        public void Setup() {
            bankAccount = new BankAccount();
        }

        [Test]
        public void Deposit_ValidAmount_UpdatesBalance() {
            bankAccount.Deposit(100);
            Assert.AreEqual(100, bankAccount.GetBalance());
        }

        [Test]
        public void Deposit_NegativeAmount_ThrowsArgumentException() {
            Assert.Throws<ArgumentException>(() => bankAccount.Deposit(-50));
        }

        [Test]
        public void Deposit_ZeroAmount_ThrowsArgumentException() {
            Assert.Throws<ArgumentException>(() => bankAccount.Deposit(0));
        }

        [Test]
        public void Withdraw_ValidAmount_UpdatesBalance() {
            bankAccount.Deposit(200);
            bankAccount.Withdraw(100);
            Assert.AreEqual(100, bankAccount.GetBalance());
        }

        [Test]
        public void Withdraw_InsufficientFunds_ThrowsInvalidOperationException() {
            bankAccount.Deposit(50);
            Assert.Throws<InvalidOperationException>(() => bankAccount.Withdraw(100));
        }

        [Test]
        public void Withdraw_NegativeAmount_ThrowsArgumentException() {
            Assert.Throws<ArgumentException>(() => bankAccount.Withdraw(-30));
        }

        [Test]
        public void Withdraw_ZeroAmount_ThrowsArgumentException() {
            Assert.Throws<ArgumentException>(() => bankAccount.Withdraw(0));
        }

        [Test]
        public void GetBalance_InitialBalance_IsZero() {
            Assert.AreEqual(0, bankAccount.GetBalance());
        }

        [Test]
        public void MultipleTransactions_AccurateBalance() {
            bankAccount.Deposit(100);
            bankAccount.Deposit(50);
            bankAccount.Withdraw(30);
            Assert.AreEqual(120, bankAccount.GetBalance());
        }
    }
}
