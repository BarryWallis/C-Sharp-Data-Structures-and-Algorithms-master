using System;
using System.Diagnostics;

namespace SortLib
{
    public static class Sort
    {
        /// <summary>
        /// Sort an array using selection sort. 
        /// </summary>
        /// <typeparam name="T">The type of array to sort. Must support IComparable.</typeparam>
        /// <param name="array">The array to sort,</param>
        public static void SelectionSort<T>(T[] array) where T : IComparable
        {
            #region Preconditions
            // None
            #endregion

            for (int i = 0; i < array.Length - 1; i++)
            {
                int minimumIndex = i;
                T minimumValue = array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j].CompareTo(minimumValue) < 0)
                    {
                        minimumIndex = j;
                        minimumValue = array[j];
                    }
                }

                Swap(array, i, minimumIndex);
            }

            #region Postconditions
            // None
            #endregion
        }

        /// <summary>
        /// Sort an array using insertion sort.
        /// </summary>
        /// <typeparam name="T">The type of the array.</typeparam>
        /// <param name="array">The array to be sorted.</param>
        public static void InsertionSort<T>(T[] array) where T : IComparable
        {
            #region Preconditions
            // None
            #endregion

            for (int i = 1; i < array.Length; i++)
            {
                int j = i;
                while (j > 0 && array[j].CompareTo(array[j - 1]) < 0)
                {
                    Swap(array, j, j - 1);
                    j--;
                }
            }

            #region Postconditions
            // None
            #endregion
        }

        /// <summary>
        /// Sort an array using bubble sort.
        /// </summary>
        /// <typeparam name="T">The type of the array.</typeparam>
        /// <param name="array">The array. </param>
        public static void BubbleSort<T>(T[] array) where T : IComparable
        {
            #region Preconditions
            // None
            #endregion

            for (int i = 0; i < array.Length; i++)
            {
                bool isAnyChange = false;
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        isAnyChange = true;
                        Swap(array, j, j + 1);
                    }
                }

                if (!isAnyChange)
                {
                    break;
                }
            }

            #region Postconditions
            // None
            #endregion
        }

        /// <summary>
        /// Sort an array using quick sort.
        /// </summary>
        /// <typeparam name="T">The type of the array.</typeparam>
        /// <param name="array">The array. </param>
        public static void Quicksort<T>(T[] array) where T : IComparable
        {
            #region Preconditions
            // None
            #endregion

            Sort(array, 0, array.Length - 1);

            #region Postconditions
            // None
            #endregion

            static void Sort<T1>(T1[] array, int lower, int upper) where T1 : IComparable
            {
                #region Preconditions
                Debug.Assert(lower >= 0 && lower < array.Length);
                Debug.Assert(upper >= 0 && upper < array.Length);
                #endregion  

                if (lower < upper)
                {
                    int partition = Partition(array, lower, upper);
                    Sort(array, lower, partition);
                    Sort(array, partition + 1, upper);
                }

                #region Postconditions
                // None
                #endregion
            }

            static int Partition<T1>(T1[] array, int lower, int upper) where T1 : IComparable
            {
                #region Preconditions
                Debug.Assert(lower >= 0 && lower < array.Length);
                Debug.Assert(upper >= 0 && upper < array.Length);
                #endregion  

                int i = lower;
                int j = upper;
                T1 pivot = array[lower];
                do
                {
                    while (array[i].CompareTo(pivot) < 0)
                    {
                        i += 1;
                    }
                    while (array[j].CompareTo(pivot) > 0)
                    {
                        j -= 1;
                    }
                    if (i >= j)
                    {
                        break;
                    }
                    Swap(array, i, j);
                } while (i <= j);

                #region Postconditions
                // None
                #endregion
                return j;
            }
        }


        private static void Swap<T>(T[] array, int first, int second)
        {
            #region Preconditions
            Debug.Assert(first >= 0 && first < array.Length);
            Debug.Assert(second >= 0 && second < array.Length);
            #endregion

            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;

            #region Postcinditions
            // None
            #endregion
        }
    }
}
