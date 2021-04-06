using System;
using System.ComponentModel.DataAnnotations;

namespace SListLibrary
{
    public class SLClass 
    {
        private int _location = 0;
        private int _length = 0;
        private SLNode _cursor = null;
        
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
        {
            return !(_length > 0);
        }

        public void Insert(object payload)
        {
            if (IsEmpty())
            {
                _cursor = new SLNode(payload, null);
            }
            _length++;
        }
        
        //Constructors
        public SLClass()
        {
           
        }
    }
}