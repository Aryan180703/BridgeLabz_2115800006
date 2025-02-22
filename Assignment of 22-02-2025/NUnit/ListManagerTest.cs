using NUnit.Framework;
using ListManagerApp;
using System;
using System.Collections.Generic;

namespace ListManagerTests {
    [TestFixture]
    public class ListManagerTests {
        private ListManager listManager;
        private List<int> testList;

        [SetUp]
        public void Setup() {
            listManager = new ListManager();
            testList = new List<int>();
        }

        [Test]
        public void AddElement_ValidElement_IsAddedToList() {
            listManager.AddElement(testList, 10);
            Assert.Contains(10, testList);
        }

        [Test]
        public void AddElement_NullList_ThrowsArgumentNullException() {
            Assert.Throws<ArgumentNullException>(() => listManager.AddElement(null, 5));
        }

        [Test]
        public void RemoveElement_ExistingElement_IsRemovedFromList() {
            testList.Add(10);
            listManager.RemoveElement(testList, 10);
            Assert.IsFalse(testList.Contains(10));
        }

        [Test]
        public void RemoveElement_NonExistingElement_ListUnchanged() {
            testList.Add(20);
            listManager.RemoveElement(testList, 99);
            Assert.AreEqual(1, testList.Count);
        }

        [Test]
        public void RemoveElement_NullList_ThrowsArgumentNullException() {
            Assert.Throws<ArgumentNullException>(() => listManager.RemoveElement(null, 5));
        }

        [Test]
        public void GetSize_NonEmptyList_ReturnsCorrectCount() {
            testList.Add(10);
            testList.Add(20);
            int size = listManager.GetSize(testList);
            Assert.AreEqual(2, size);
        }

        [Test]
        public void GetSize_EmptyList_ReturnsZero() {
            int size = listManager.GetSize(testList);
            Assert.AreEqual(0, size);
        }

        [Test]
        public void GetSize_NullList_ThrowsArgumentNullException() {
            Assert.Throws<ArgumentNullException>(() => listManager.GetSize(null));
        }
    }
}
