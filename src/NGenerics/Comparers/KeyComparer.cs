/*  
  Copyright 2007-2017 The NGenerics Team
 (https://github.com/ngenerics/ngenerics/wiki/Team)

 This program is licensed under the MIT License.  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at https://opensource.org/licenses/MIT.
*/


using System;
using System.Collections.Generic;
using NGenerics.DataStructures.General;

namespace NGenerics.Comparers
{
    /// <summary>
    /// A comparer for comparing keys in KeyValuePairs.
    /// </summary>
    /// <typeparam name="TKey">The key type.</typeparam>
	/// <typeparam name="TValue">The value type.</typeparam>
    [Serializable]
    public class KeyComparer<TKey, TValue> : IComparer<KeyValuePair<TKey, TValue>>, IComparer<TKey> where TKey : IComparable
    {
        
        #region Globals

        private readonly IComparer<TKey> comparer;

        #endregion

        #region Construction

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyComparer{TKey,TValue}"/> class.
        /// </summary>
        public KeyComparer()
        {
            comparer = Comparer<TKey>.Default;
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="KeyComparer{TKey,TValue}"/> class.
        /// </summary>
        /// <param name="comparer">The comparer.</param>
        public KeyComparer(IComparer<TKey> comparer)
        {
            this.comparer = comparer;
        }

        #endregion

        #region IComparer<Association<TKey,TValue>> Members

        /// <inheritdoc />
        public int Compare(KeyValuePair<TKey, TValue> x, KeyValuePair<TKey, TValue> y)
        {
            return comparer.Compare( x.Key,y.Key);
        }

        #endregion

        #region IComparer<TKey> Members

        /// <inheritdoc />
        public int Compare(TKey x, TKey y)
        {
            return comparer.Compare(x,y);
        }

        #endregion
    }
}