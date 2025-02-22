using NUnit.Framework;
using LongRunningApp;

namespace LongRunningTests
{
    [TestFixture]
    public class TaskProcessorTests
    {
        private TaskProcessor taskProcessor;

        [SetUp]
        public void Setup()
        {
            taskProcessor = new TaskProcessor();
        }

        [Test, Timeout(2000)]
        public void LongRunningTask_ShouldCompleteWithin2Seconds()
        {
            string result = taskProcessor.LongRunningTask();
            Assert.AreEqual("Task Completed", result);
        }
    }
}
