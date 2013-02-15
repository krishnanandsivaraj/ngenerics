/*  
  Copyright 2007-2013 The NGenerics Team
 (https://github.com/ngenerics/ngenerics/wiki/Team)

 This program is licensed under the GNU Lesser General Public License (LGPL).  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at http://www.gnu.org/copyleft/lesser.html.
*/
using NGenerics.DataStructures.Trees;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.Trees.SplayTreeTests
{
    [TestFixture]
    public class Clear : SplayTreeTest
    {

        [Test]
        public void Simple()
        {
            var splayTree = new SplayTree<int, string>();
            splayTree.Clear();

            Assert.AreEqual(splayTree.Count, 0);

            splayTree = GetTestTree();
            Assert.IsTrue(splayTree.ContainsKey(19));

            splayTree.Clear();
            Assert.AreEqual(splayTree.Count, 0);
            Assert.IsFalse(splayTree.ContainsKey(19));
        }

    }
}