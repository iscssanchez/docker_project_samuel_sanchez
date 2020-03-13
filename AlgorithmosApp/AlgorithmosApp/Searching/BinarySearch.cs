using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmosApp.Searching
{
    public class BinarySearch
    {
        public int Sort(List<int> data, int searchedData)
        {
            return Sort(data, 0, data.Count - 1, searchedData);
        }

        private int Sort(List<int> data, int left, int right, int searchedData)
        {
            if(right >= left)
            {
                int mid = (left + right) / 2;
                //int mid = left + (right - left) / 2;
                int dataMid = data[mid];
                if (dataMid == searchedData)
                {
                    return mid;
                }
                if (dataMid > searchedData)
                {
                    return Sort(data, left, mid - 1, searchedData);
                }
                else
                {
                    return Sort(data, mid + 1, right, searchedData);
                }
            }
           
            return -1;
        }

        private int SortIterative(List<int> data, int searchedData)
        {
            int result = -1;
            int left = 0; int right = data.Count - 1;
            while(left <= right)
            {
                int mid = (left + right) / 2;
                if (data[mid] == searchedData) return mid;
                if(searchedData > data[mid])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return result;
        }
    }
}
