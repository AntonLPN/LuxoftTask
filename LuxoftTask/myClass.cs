using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuxoftTask
{
    public class myClass
    {

       public myClass()
        {

        }

        /// <summary>
        /// The method sorts from smallest
        /// to largest number of the list.
        /// Outputs a user-defined number of items
        /// </summary>
        /// <param name="count"></param>
        /// <param name="list"></param>
        /// <returns></returns>
        public List<int> LargestX(int count, List<int> list)
        {
            List<int> result = new List<int>();

            list.Sort();
            list.Reverse();
            for (int i = 0; i < count; i++)
            {
                result.Add(list[i]);
            }
            result.Reverse();

            return result ;

        }




    }
}
