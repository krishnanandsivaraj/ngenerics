/*  
  Copyright 2007-2013 The NGenerics Team
 (https://github.com/ngenerics/ngenerics/wiki/Team)

 This program is licensed under the GNU Lesser General Public License (LGPL).  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at http://www.gnu.org/copyleft/lesser.html.
*/
using NGenerics.DataStructures.Queues.Observable;
using NGenerics.Tests.TestObjects;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.Queues.ObservableDequeTests
{
    [TestFixture]
    public class EnqueueHead
    {
        [Test]
        public void Simple()
        {
            var deque = new ObservableDeque<string>();
            ObservableCollectionTester.ExpectEvents(deque, obj => obj.EnqueueHead("foo"), "Count", "IsEmpty", "Head", "Tail");
        }

    }
}