

namespace SListLibrary
{
    public class SLNode 
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

    }
}