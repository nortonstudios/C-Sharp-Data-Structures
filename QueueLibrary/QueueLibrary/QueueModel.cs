using System;

namespace QueueLibrary
{
    public class QueueModel
    {
        //Props and fields
        public QueueNode Front { get; private set; }
        public QueueNode Back { get; private set; }
        public int QueueLength { get; set; }

        //public methods
        public void enqueue(object payload)
        {
            if(IsEmpty())
            {
                InitialEnqueue(payload);
                return;
            }

            Back = new QueueNode(payload, Back);
        }

        public object dequeue()
        {
            object payload = Front.GetPayload();
            Front = Front.GetNext();
            return payload;
        }

        public bool IsEmpty()
        { 
            if (Front == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void InitialEnqueue(object payload)
        {
            Front = new QueueNode(payload, null);
            Back = Front;
        }

        public int GetLength()
        {
            return QueueLength;
        }

        //Constructor
        public QueueModel()
        {
        }
    }
}
