/*  
  Copyright 2007-2013 The NGenerics Team
 (https://github.com/ngenerics/ngenerics/wiki/Team)

 This program is licensed under the GNU Lesser General Public License (LGPL).  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at http://www.gnu.org/copyleft/lesser.html.
*/
using System.Collections;
using NGenerics.DataStructures.General;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.General.ListTests
{
    [TestFixture]
    public class CopyTo
    {
        [Test]
        public void Simple()
        {
            var listBase = new ListBase<string> {"a", "b"};

            var array = new string[2];

            listBase.CopyTo(array);

            Assert.AreEqual("a", array[0]);
            Assert.AreEqual("b", array[1]);
        }
        [Test]
        public void Interface()
        {
            var listBase = (ICollection)new ListBase<string>{"a","b"};


            var array = new string[2];

            listBase.CopyTo(array,0);

            Assert.AreEqual("a", array[0]);
            Assert.AreEqual("b", array[1]);
        }
        [Test]
        public void ArrayIndex()
        {
            var listBase = new ListBase<string> {"a", "b"};

            var array = new string[2];

            listBase.CopyTo(array, 0);

            Assert.AreEqual("a", array[0]);
            Assert.AreEqual("b", array[1]);
        }
        [Test]
        public void Complex()
        {
            var listBase = new ListBase<string> {"a", "b"};

            var array = new string[2];

            listBase.CopyTo(0, array, 0, 2);

            Assert.AreEqual("a", array[0]);
            Assert.AreEqual("b", array[1]);
        }
    }
}