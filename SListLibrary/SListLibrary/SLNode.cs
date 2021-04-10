

namespace SListLibrary
{
    public class SLNode : IListNode
    {
        private object _payload;
        private SLNode _next;

        public object GetPayload()
        {
            return _payload;
        }

        public SLNode GetNext()
        {
            return _next;
        }

        public void SetNext(IListNode next)
        {
            //SLNode newNext = new SLNode(next);
            _next = next;
        }

        public SLNode(object payload)
        {
            _payload = payload;
            _next = null;
        }
        public SLNode(object payload, SLNode next)
        {
            _payload = payload;
            _next = next;
        }

        public SLNode(IListNode newNode)
        {
            _payload = newNode.GetPayload();
            _next = newNode.GetNext();
        }

    }
}