using LogicBuildigProjects;




//int[] arr = { 10, 20, 20, 10, 10, 20, 5, 20, 5, 5, 5 };
//ElementsFrequencyCount efc = new ElementsFrequencyCount();
//efc.frequencyCount(arr);


//Console.WriteLine("==================LETS START BUILDING LOGICS==================");
//int[] myArray = { 11, 2, 33, 4, 45 };
//int[] myArray2 = { 41, 22, 35, 14, 5 };
//int size = myArray.Length;

//SortingAlgos sa = new SortingAlgos();

//Console.WriteLine("Before Sorting: ");

//for (int i = 0; i < size; i++)
//{
//    Console.Write(myArray[i]+",");

//}

//Console.WriteLine("\nAfter Selection Sorting: ");
//int[] result = sa.SelectionSort(myArray2);
//result.ToList().ForEach(x => Console.Write(x + ","));


//Console.WriteLine("\nAfter Bubble Sorting: ");
//int[] result2 = sa.BubbleSort(myArray);
//result2.ToList().ForEach(x => Console.Write(x + ","));


//Console.WriteLine("\n=========BINARY SEARCH WITHOUT RECURSION:===================== ");
//int[] myArrayElement = { 11, 2, 33, 4, 45 };
//BinarySearchAlgo bs = new BinarySearchAlgo();
//Console.WriteLine("\nIs 45 present in array? " + bs.BinarySearchWithoutRecursion(myArrayElement, 45));

//Console.WriteLine("\n=========BINARY SEARCH RECURSION:===================== ");
//Console.WriteLine("\nIs 5 present in array? " + bs.BinarySearchWithRecursion(myArrayElement, 5));


Console.WriteLine("\n=========  WAVE ARRAY SORTING:===================== ");
//int[] nonWave = { 10, 5, 6, 3, 2, 20, 100, 80 };
//int[] nonWave = { 20, 10, 8, 6, 4, 2 };
int[] nonWave = { 10, 90, 49, 2, 1, 5, 23 };
Console.WriteLine("Before wave array: ");
nonWave.ToList().ForEach(x => Console.Write(x + ","));

ArrayAlgos wa = new ArrayAlgos();
int[] wave = wa.waveArray(nonWave);
Console.WriteLine("\nAfter wave array: ");
wave.ToList().ForEach(x => Console.Write(x + ","));

Console.WriteLine("\n=========OPTIMIZE  WAVE ARRAY SORTING:===================== ");
int[] nonOptWave = { 10, 5, 6, 3, 2, 20, 100, 80 };
Console.WriteLine("Before optimize wave array: ");
nonOptWave.ToList().ForEach(x => Console.Write(x + ","));

int[] optWave = wa.optimizeWaveArray(nonOptWave);
Console.WriteLine("\nAfter optimize wave array: ");
optWave.ToList().ForEach(x => Console.Write(x + ","));

Console.WriteLine("\n=========Find Subarray with given sum:===================== ");
int[] arr = { 1, 4, 20, 3, 10, 5 };
int sum = 33;
wa.findSubArrayWithGivenSum(arr, sum);
int[] arr1 = { 1, 4, 0, 0, 3, 10, 5 };
int sum1 = 5;
wa.findSubArrayWithGivenSum(arr1, sum1);


