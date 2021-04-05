namespace SListLibrary
{
    public class SLClass 
    {
        private int _location;
        
        public int GetLocation()
        {
            return _location;
        }
        
        //Methods
        public bool IsEmpty()
        {
            return true;
        }

        public void Insert(object payload)
        {
                
        }
        
        //Constructors
        public SLClass()
        {
            _location = 0;
        }
    }
}