using FiladeEspera;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestProjectFila
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodTotal()
        {
            var client1 = new Client
            {
                Num = 1,
                Data = DateTime.Now,
                Priority = 5

            };

            var client2 = new Client
            {
                Num = 2,
                Data = DateTime.Now,
                Priority = 5

            };

            var client3 = new Client
            {
                Num = 3,
                Data = DateTime.Now,
                Priority = 5

            };



            var fila = new Queue<Client>();

            var myQueue = new PQueue(fila);
            myQueue.Add(client1);
            myQueue.Add(client3);
            myQueue.Add(client2);

            Assert.AreEqual(3, myQueue.Total());
        }

        [TestMethod]
        public void TestMethodNext()
        {
            var client1 = new Client
            {
                Num = 100,
                Data = DateTime.Now,
                Priority = 5

            };

            var client2 = new Client
            {
                Num = 2,
                Data = DateTime.Now,
                Priority = 5

            };

            var client3 = new Client
            {
                Num = 3,
                Data = DateTime.Now,
                Priority = 5

            };



            var fila = new Queue<Client>();

            var myQueue = new PQueue(fila);
            myQueue.Add(client1);
            myQueue.Add(client3);
            myQueue.Add(client2);

            Assert.AreEqual(100, myQueue.Next());
        }


        [TestMethod]
        public void TestMethodRemove()
        {
            var client1 = new Client
            {
                Num = 100,
                Data = DateTime.Now,
                Priority = 5
            };

            var client2 = new Client
            {
                Num = 200,
                Data = DateTime.Now,
                Priority = 5
            };

            var client3 = new Client
            {
                Num = 3,
                Data = DateTime.Now,
                Priority = 5
            };



            var fila = new Queue<Client>();

            var myQueue = new PQueue(fila);
            myQueue.Add(client1);
            myQueue.Add(client2);
            myQueue.Add(client3);

            myQueue.Remove();
            

            Assert.AreEqual(2, myQueue.Total());
        }


        [TestMethod]
        public void TestMethodRemoveNext()
        {
            var client1 = new Client
            {
                Num = 100,
                Data = DateTime.Now,
                Priority = 5

            };

            var client2 = new Client
            {
                Num = 200,
                Data = DateTime.Now,
                Priority = 5
            };

            var client3 = new Client
            {
                Num = 3,
                Data = DateTime.Now,
                Priority = 5
            };



            var fila = new Queue<Client>();

            var myQueue = new PQueue(fila);
            myQueue.Add(client1);
            myQueue.Add(client2);
            myQueue.Add(client3);

            myQueue.Remove();
            myQueue.Remove();

            Assert.AreEqual(3, myQueue.Next());
        }
    }
}
