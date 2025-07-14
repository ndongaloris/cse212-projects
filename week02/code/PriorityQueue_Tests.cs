using System.Reflection.Metadata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Bob", 3);
        priorityQueue.Enqueue("Tim", 5);
        priorityQueue.Enqueue("Sue", 4);

        Assert.AreEqual("Tim", priorityQueue.Dequeue());
        Assert.AreEqual("Sue", priorityQueue.Dequeue());
        Assert.AreEqual("Bob", priorityQueue.Dequeue());
        
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Bob", 3);
        priorityQueue.Enqueue("Tim", 8);
        priorityQueue.Enqueue("Lon", 67);
        priorityQueue.Enqueue("Sue", 4);
        priorityQueue.Enqueue("Suo", 24);
        priorityQueue.Enqueue("Mia", 8);
        priorityQueue.Enqueue("Tia", 67);
        priorityQueue.Enqueue("Tio", 24);

        Assert.AreEqual("Lon", priorityQueue.Dequeue());
        Assert.AreEqual("Tia", priorityQueue.Dequeue());
        Assert.AreEqual("Suo", priorityQueue.Dequeue());
        Assert.AreEqual("Tio", priorityQueue.Dequeue());
        Assert.AreEqual("Tim", priorityQueue.Dequeue());
        Assert.AreEqual("Mia", priorityQueue.Dequeue());
        Assert.AreEqual("Sue", priorityQueue.Dequeue());
        Assert.AreEqual("Bob", priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.
}