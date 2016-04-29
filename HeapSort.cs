using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class HeapSort
    {
        public static void heapSort(int[] arr)
        {
            int heapSize = arr.Length;

            for (int i = (heapSize - 1) / 2; i >= 0; i--)
            {
                maxHeapify(arr, heapSize, i);
            }

            for (int j = heapSize - 1; j > 0; j--)
            {
                int temp = arr[j];
                arr[j] = arr[0];
                arr[0] = temp;

                heapSize--;

                maxHeapify(arr, heapSize, 0);
            }
        }

        private static void maxHeapify(int[] arr, int heapSize, int index)
        {
            int leftChild = index * 2 + 1;
            int rightChild = index * 2 + 2;
            int largest = 0;

            if (leftChild < heapSize && arr[leftChild] > arr[index])
            {
                largest = leftChild;
            }
            else
            {
                largest = index;
            }

            if (rightChild < heapSize && arr[rightChild] > arr[largest])
            {
                largest = rightChild;
            }

            if (largest != index)
            {
                int temp = arr[index];
                arr[index] = arr[largest];
                arr[largest] = temp;

                maxHeapify(arr, heapSize, largest);
            }
        }
    }
}
