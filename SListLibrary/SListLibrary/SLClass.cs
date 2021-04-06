using System;
using System.ComponentModel.DataAnnotations;

namespace SListLibrary
{
    public class SLClass 
    {
        private int _location = 0;
        private int _length = 0;
        private SLNode _cursor = null;
        private SLNode _head;


        public int GetLocation()
        //Returns current cursor location. 
        {
            if (IsEmpty())
            {
                throw new NotImplementedException("Empty List!");
            }
            return _location;
        }

        public object GetCursor()
        //Returns payload at cursor.
        {
            object payload = _cursor.GetPayload();
            return payload;
        }
        
        //Methods
        public bool IsEmpty()
        //Returns true if list's length is 0. 
        {
            return !(_length > 0);
        }

        public void GoToBeginning()
        //Sets cursor position to the head node.
        {
            _cursor = _head;
        }

        public void GoToEnd()
        //Sets cursor to final node in list, as determined by null pointer.
        {
            while (_cursor.GetNext() != null)
            {
                _cursor = _cursor.GetNext();
            }
        }

        public void Insert(object payload)
        //Inserts new node after current node if list is not empty.
        {
            if (IsEmpty())
            {
                _cursor = new SLNode(payload, null);
                _head = _cursor;
            }
            _length++;
        }

        //Constructors
        public SLClass()
        {
           
        }
    }
}