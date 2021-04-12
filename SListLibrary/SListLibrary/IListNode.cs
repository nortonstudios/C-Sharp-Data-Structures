namespace SListLibrary
{
    public interface IListNode
    {
        object GetPayload();
        void SetPayload(object payload);
        IListNode GetNext();
        void SetNext(IListNode next);
    }
}