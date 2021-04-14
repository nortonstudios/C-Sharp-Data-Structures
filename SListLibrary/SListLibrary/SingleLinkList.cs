using System;

namespace SListLibrary 
{
    public class SingleLinkList : ILList
    {
        private int _location = 0;
        private int _length = 0;
        private IListNode _cursor = null;
        private IListNode _head;

        //Methods
        public bool IsEmpty()
        //Returns true if list's length is 0. 
        {
            return (_length <= 0);
        }
        
        public object GetCursor()
            //Returns payload at cursor.
        {
            if (IsEmpty())
            {
                throw new Exception("Empty List");
            }
            object payload = _cursor.GetPayload();
            return payload;
        }

        public void GoToBeginning()
        //Sets cursor position to the head node.
        {
            _cursor = _head;
            _location = 0;
        }

        public void GoToEnd()
        //Sets cursor to final node in list, as determined by null pointer.
        {
            while (_cursor.GetNext() != null)
            {
                GoToNext();
                _location++;
            }
        }

        public bool GoToNext()
        //Sets cursor to next location. Returns false if already at end of list. 
        {
            if (_cursor.GetNext() == null)
            {
                return false;
            }
            _cursor = _cursor.GetNext();
            _location++;
            return true;
        }

        public bool GoToPrevious()
        //Returns true. Empty list returns false.
        {
            if (IsEmpty())
            {
                return false; 
            }
            
            int tempLocation = _location;
            _cursor = _head;
            for (int i = 0; i < (tempLocation - 1); i++)
            {
                _cursor = _cursor.GetNext();
            }

            _location = tempLocation - 1;
            
            return true;
        }
        
        public int GetIndex() 
        //Returns current cursor location, throws error if list is empty. 
        {
            if (IsEmpty())
            {
                throw new Exception("Empty List!");
            }
            return _location;
        }

        public void Insert(object payload)
        //Inserts new node after current node if list is not empty.
        {
            if (IsEmpty())
            {
                _cursor = new SLNode(payload, null);
                _head = _cursor;
            }
            else
            {
                IListNode newNode = new SLNode(payload, _cursor.GetNext());
                _cursor.SetNext(newNode);
                _cursor = newNode; 
                _location++;
            }
            _length++;
        }

        public void Replace(object payload)
        //Throws if list is empty.
        {
            if (IsEmpty())
            {
                throw new Exception("Empty List");
            }
            else
            {
                _cursor.SetPayload(payload);
            
            }
        }

        public void Remove()
        //Reduces length by 1. Throws if list is empty.
        {
            if (IsEmpty())
            {
                throw new Exception("Empty List");
            }

            if (_location == 0)
            {
                _head = _head.GetNext();
                _cursor = _head;
            }
            else
            {
                IListNode tempNext = _cursor.GetNext();
                this.GoToPrevious();
                _cursor.SetNext(tempNext);
            }

            _length--;
        }

        public void Clear()
        {
            _location = 0;
            _length = 0;
            _head = null;
            _cursor = _head;
        }

        public int GetLength()
        {
            return _length;
        }
        
        //Constructors
        public SingleLinkList()
        {
           
        }
    }
}