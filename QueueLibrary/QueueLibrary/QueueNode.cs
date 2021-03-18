using System;
namespace QueueLibrary
{
    public class QueueNode
    {
        //Props and fields
        public object Payload { get; private set; }
        public QueueNode Next { get; private set; }

        //Constructor
        public QueueNode(object payload, QueueNode next)
        {
            Payload = payload;
            Next = next;
        }
    }
}
