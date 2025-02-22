using NUnit.Framework;
using DatabaseConnectionApp;

namespace DatabaseConnectionTests {
    [TestFixture]
    public class DatabaseConnectionTests {
        private DatabaseConnection dbConnection;

        [SetUp]
        public void Setup() {
            dbConnection = new DatabaseConnection();
            dbConnection.Connect();
        }

        [Test]
        public void Connect_ConnectionIsEstablished_ReturnsTrue() {
            Assert.IsTrue(dbConnection.IsConnected);
        }

        [Test]
        public void Connect_MethodWorksCorrectly() {
            dbConnection.Disconnect();
            dbConnection.Connect();
            Assert.IsTrue(dbConnection.IsConnected);
        }

        [Test]
        public void Disconnect_ConnectionIsClosed_ReturnsFalse() {
            dbConnection.Disconnect();
            Assert.IsFalse(dbConnection.IsConnected);
        }

        [TearDown]
        public void Teardown() {
            dbConnection.Disconnect();
        }
    }
}
