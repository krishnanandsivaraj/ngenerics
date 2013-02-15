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

namespace NGenerics.Tests.DataStructures.General.Observable.ObservableDictionaryTests
{
    [TestFixture]
    public class Add
    {
        [Test]
        public void Simple()
        {
            var observableDictionary = new ObservableDictionary<string, string>();
            ObservableCollectionTester.ExpectEvents(observableDictionary, obj => obj.Add("foo", "bar"), "Count", "Item[]", "IsEmpty", "ValueCount", "KeyCount");
        }
        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ExceptionSimpleReentrancy()
        {
            var observableDictionary = new ObservableDictionary<string, string>();
            new ReentracyTester<ObservableDictionary<string, string>>(observableDictionary, obj => obj.Add("foo", "bar"));
        }


        [Test]
        public void KeyValue()
        {
            var observableDictionary = new ObservableDictionary<string, string>();
            ObservableCollectionTester.ExpectEvents(observableDictionary, obj => obj.Add("foo", "Value"), "Count", "Item[]", "IsEmpty", "ValueCount", "KeyCount");
        }
        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ExceptionKeyValueReentrancy()
        {
            var observableDictionary = new ObservableDictionary<string, string>();
            new ReentracyTester<ObservableDictionary<string, string>>(observableDictionary, obj => obj.Add("foo", "Value"));
        }
    }
}