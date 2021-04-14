namespace SListLibrary
{
    public interface ILList 
    {
        public bool IsEmpty();
        public object GetCursor();
        public void GoToBeginning();
        public void GoToEnd();
        public bool GoToNext();
        public bool GoToPrevious();
        public int GetIndex();
        public void Insert(object payload);
        public void Replace(object payload);
        public void Remove();
        public void Clear();
        
    }
}