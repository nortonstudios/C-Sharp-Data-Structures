using System;
using System.Collections.Generic;

namespace QueueLibrary
{
    public class QueueModel
    {
        //Props and fields
        public QueueNode Front { get; private set; }
        public QueueNode Back { get; private set; }
        public int QueueLength { get; set; } = 0;

        //public methods
        public void Enqueue(object payload)
        {
            if(IsEmpty())
            {
                InitialEnqueue(payload);
                return;
            }
            QueueNode newBack = new QueueNode(payload, null);
            Back.Next = newBack;
            Back = newBack;
            QueueLength++;
        }

        public object Dequeue()
        {
            object payload = Front.GetPayload();
            Front = Front.GetNext();
            QueueLength--;
            return payload;
        }

        public List<object> Dump()
        {
            List<object> output = new List<object>();
            while (IsEmpty() != true)
            {
                output.Add(this.Dequeue());
            }
            return output;
        }

        public bool IsEmpty()
        { 
            if (QueueLength == 0 )
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
            QueueLength++;
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
