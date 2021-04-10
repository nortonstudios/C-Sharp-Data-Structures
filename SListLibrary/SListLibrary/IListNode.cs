namespace SListLibrary
{
    public interface IListNode
    {
        object GetPayload();
        SLNode GetNext();

        void SetNext(IListNode next);
    }
}