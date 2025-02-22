using NUnit.Framework;
using System;
using System.IO;
using FileHandlingApp;

namespace FileHandlingTests
{
    [TestFixture]
    public class FileProcessorTests
    {
        private FileProcessor fileProcessor;
        private string testFile;

        [SetUp]
        public void Setup()
        {
            fileProcessor = new FileProcessor();
            testFile = "testFile.txt";
        }

        [TearDown]
        public void Teardown()
        {
            if (File.Exists(testFile))
            {
                File.Delete(testFile);
            }
        }

        [Test]
        public void WriteToFile_ReadFromFile_ContentIsCorrect()
        {
            string content = "Hello, NUnit!";
            fileProcessor.WriteToFile(testFile, content);
            string result = fileProcessor.ReadFromFile(testFile);
            Assert.AreEqual(content, result);
        }

        [Test]
        public void WriteToFile_FileShouldExist()
        {
            string content = "File existence test";
            fileProcessor.WriteToFile(testFile, content);
            Assert.IsTrue(File.Exists(testFile));
        }

        [Test]
        public void ReadFromFile_NonExistentFile_ShouldThrowIOException()
        {
            string nonExistentFile = "noSuchFile.txt";
            var ex = Assert.Throws<IOException>(() => fileProcessor.ReadFromFile(nonExistentFile));
            Assert.AreEqual("File does not exist.", ex.Message);
        }
    }
}
