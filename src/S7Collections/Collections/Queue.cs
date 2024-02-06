using S7Collections.Models;

namespace S7Collections.Collections;

public class Queue
{
    public static void QueueMain()
    {
        Queue<Order> queue = new Queue<Order>();

        queue.Enqueue(new Order(1, 100));
        queue.Enqueue(new Order(2, 10));
        queue.Enqueue(new Order(3, 3));
        queue.Enqueue(new Order(4, 1000));

        Order top = queue.Peek();
        top.ProcessOrder();
        queue.Dequeue();

        while(queue.Count > 0){
            Order order = queue.Dequeue();
            order.ProcessOrder();
        }
    }
}