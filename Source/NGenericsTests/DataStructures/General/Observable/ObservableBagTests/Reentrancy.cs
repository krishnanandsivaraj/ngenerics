/*  
  Copyright 2007-2013 The NGenerics Team
 (https://github.com/ngenerics/ngenerics/wiki/Team)

 This program is licensed under the GNU Lesser General Public License (LGPL).  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at http://www.gnu.org/copyleft/lesser.html.
*/
using System.Collections.Specialized;
using System.Diagnostics;
using System.Threading;
using NGenerics.DataStructures.General.Observable;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.General.Observable.ObservableBagTests
{
    [TestFixture]
    public class Reentrancy
    {
        ObservableBag<int> bag;
        [Test]
        public void Simple()
        {
            bag = new ObservableBag<int>();
            bag.CollectionChanged += bag_CollectionChanged1;

            ThreadStart start = FireAdd;
            Debug.WriteLine("1");
            var thread = new Thread(start);
            thread.Start();
            Debug.WriteLine("2");
            bag.Add(3);
            Debug.WriteLine("3");
            thread.Join(5000);
        }

        private void FireAdd()
        {
            Debug.WriteLine("FireAdd start");
            bag.Add(2);
            Debug.WriteLine("FireAdd end");
        }

        static void bag_CollectionChanged1(object sender, NotifyCollectionChangedEventArgs e)
        {
            Debug.WriteLine("bag_CollectionChanged1");
            Thread.Sleep(10000);
        }

    }
}