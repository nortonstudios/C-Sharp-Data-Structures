using System;

namespace QueueLibrary
{
    public class QueueNode
    {
        //Props and fields
        public object Payload { get; set; }
        public QueueNode Next { get; set; }

        //Constructor
        public QueueNode(object payload, QueueNode next)
        {
            Payload = payload;
            Next = next;
        }

        public object GetPayload()
        {
            return Payload;
        }

        public QueueNode GetNext()
        {
            return Next;
        }
    }
}
