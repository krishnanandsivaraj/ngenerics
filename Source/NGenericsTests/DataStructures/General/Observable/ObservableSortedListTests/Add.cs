/*  
  Copyright 2007-2013 The NGenerics Team
 (https://github.com/ngenerics/ngenerics/wiki/Team)

 This program is licensed under the GNU Lesser General Public License (LGPL).  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at http://www.gnu.org/copyleft/lesser.html.
*/
using System;
using NGenerics.DataStructures.General.Observable;
using NGenerics.Tests.TestObjects;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.General.Observable.ObservableSortedListTests
{
    [TestFixture]
    public class Add
    {
        [Test]
        public void Simple()
        {
            var hashList = new ObservableSortedList<string>();
            ObservableCollectionTester.ExpectEvents(hashList, obj => obj.Add("foo"), "Count", "Item[]", "IsEmpty");
        }
        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ExceptionSimpleReentrancy()
        {
            var hashList = new ObservableSortedList<string>();
            new ReentracyTester<ObservableSortedList<string>>(hashList, obj => obj.Add("foo"));
        }



    }
}