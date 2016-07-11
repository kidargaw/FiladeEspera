using System.Collections.Generic;

namespace FiladeEspera
{


    public class PQueue : IQueue
    {
        private Queue<Client> _lstQueue = null;
        private Client _next = null;

        public PQueue(Queue<Client> lstQueue)
        {
            _lstQueue = lstQueue;
        }

        public PQueue()
        {

        }

        /// <summary>
        /// Function add client to Queue
        /// </summary>
        /// <param name="clientQueue">Object Client</param>
        public void Add(Client clientQueue)
        {
            _lstQueue.Enqueue(clientQueue);

        }



        /// <summary>
        /// Function that show the next Client Id to be remove on Queue
        /// </summary>
        /// <returns>return int with next client Id</returns>
        public int Next()
        {
            if (_lstQueue.Count > 0)
            {
                _next = _lstQueue.Peek();
            }
            //else
            //{
            //    return 0;

            //}
            return _next.Num;
        }



        /// <summary>
        /// Remove client from the Queue
        /// </summary>
        public void Remove()
        {
            if (_lstQueue.Count > 0)
            {
                _lstQueue.Dequeue();
            }
        }


        /// <summary>
        /// Function that show number of element on Queue
        /// </summary>
        /// <returns>return int with number of element on Queue</returns>
        public int Total()
        {
            return _lstQueue.Count;
        }



    }
}
