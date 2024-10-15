

var prioQueue = new PriorityQueue<string, int>();
prioQueue.Enqueue("A", 1);
prioQueue.Enqueue("B", 2);
prioQueue.Enqueue("C", 1);
prioQueue.Enqueue("D", 2);
prioQueue.Enqueue("E", 2);
prioQueue.Enqueue("F", 3);

// Update the priority for an item.
prioQueue.Remove("A", out _, out _);
prioQueue.Enqueue("A", 3);


while (prioQueue.Count > 0)
{
    Console.WriteLine(prioQueue.Dequeue());
}