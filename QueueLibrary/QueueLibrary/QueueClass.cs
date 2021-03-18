using System;
namespace QueueLibrary
{
    public class QueueClass
    {
        //Props and fields
        public QueueNode Front { get; private set; }
        public QueueNode Back { get; private set; }

        //public methods
        public void enqueue(object payload)
        {

            Back = new QueueNode(payload, Back);
            throw new NotImplementedException();
            //Front and Back need to be the same node in a 1 node queue.
            //Eliminate one or the other?
            //


        }

        public object dequeue()
        {
            throw new NotImplementedException();
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



        public QueueClass()
        {
        }
    }
}
