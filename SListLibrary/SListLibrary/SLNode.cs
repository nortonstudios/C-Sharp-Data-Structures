

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

        public void SetPayload(object payload)
        {
            _payload = payload;
        }

        public IListNode GetNext()
        {
            return _next;
        }

        public void SetNext(IListNode next)
        {
            //SLNode newNext = new SLNode(next);
            _next = (SLNode) next;
        }

        public SLNode(object payload)
        {
            _payload = payload;
            _next = null;
        }
        public SLNode(object payload, IListNode next)
        {
            _payload = payload;
            _next = (SLNode)next;
        }

        public SLNode(IListNode newNode)
        {
            _payload = newNode.GetPayload();
            _next = (SLNode) newNode.GetNext();
        }

    }
}