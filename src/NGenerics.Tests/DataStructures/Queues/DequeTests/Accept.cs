/*  
  Copyright 2007-2017 The NGenerics Team
 (https://github.com/ngenerics/ngenerics/wiki/Team)

 This program is licensed under the MIT License.  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at https://opensource.org/licenses/MIT.
*/

using System;
using NGenerics.DataStructures.Queues;
using NGenerics.Patterns.Visitor;
using NGenerics.Tests.Util;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.Queues.DequeTests
{
    [TestFixture]
    public class Accept : DequeTest
    {

        [Test]
        public void Simple()
        {
            var deque = new Deque<int>();
            deque.EnqueueHead(5);
            deque.EnqueueHead(3);
            deque.EnqueueHead(2);

            var visitor = new TrackingVisitor<int>();

            deque.AcceptVisitor(visitor);

            Assert.AreEqual(visitor.TrackingList.Count, 3);
            Assert.IsTrue(visitor.TrackingList.Contains(5));
            Assert.IsTrue(visitor.TrackingList.Contains(3));
            Assert.IsTrue(visitor.TrackingList.Contains(2));
        }

        [Test]
        public void Done()
        {
            var dequeeque = new Deque<int>();
            dequeeque.EnqueueHead(5);
            dequeeque.EnqueueHead(3);
            dequeeque.EnqueueHead(2);

            var visitor = new CompletedTrackingVisitor<int>();

            dequeeque.AcceptVisitor(visitor);
        }

        [Test]
        public void ExceptionNullVisitor()
        {
            var dequeeque = new Deque<int>();
            Assert.Throws<ArgumentNullException>(() => dequeeque.AcceptVisitor(null));
        }

    }
}