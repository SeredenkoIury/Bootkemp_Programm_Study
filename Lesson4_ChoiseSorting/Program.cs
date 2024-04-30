Console.Clear();
Console.WriteLine("Bootkemp_Lesson_04_Choise_Sorting");
Console.WriteLine("");

//===========Choise sorting O(n^2)
/*
Example [45, 23, -10, 5, 3, 9, 1]
1) find min fron all elements fron the 1st, min = -10
2) Change min and the 1st element => [-10, 23, 45, 5, 3, 9, 1]
3) Find min fron all elements fron the 2nd, min2 = 1, 
4) Change min2 and the 2nd element => [-10, 1, 45, 5, 3, 9, 23]
5) Find min fron all elements fron the 3rd, min3 = 3, 
6) Change min3 and the 3nd element => [-10, 1, 3, 5, 45, 9, 23]
7) Find min fron all elements fron the 4th, min4 = 5, 
8) Change min4 and the 4nd element => [-10, 1, 3, 5, 45, 9, 23]
9) Find min fron all elements fron the 5th, min5 = 9, 
10) Change min5 and the 5nd element => [-10, 1, 3, 5, 9, 45, 23]
11) Find min fron all elements fron the 6th, min6 = 23, 
12) Change min6 and the 6nd element => [-10, 1, 3, 5, 9, 23, 45]
*/
int [] FillinTheArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-20, 21); //[-20; 20]
        return array;
}
// int [] PrintTheArray(int[] array)
// {
//     Console.WriteLine();
//     for (int i = 0; i < array.Length; i++)
//          Console.Write(array[i] + "\t");
//     Console.WriteLine();
// }

int[] sortChoise(int[] array)
{
    for (int i = 0; i < array.Length; i++)//better name i, j, k, m, n
    {
        int indexOfMin = i;
        for(int j = i; j < array.Length; j++)
        {
            if (array[j] < array[indexOfMin]) indexOfMin = j;
        }
        
        if (array[indexOfMin] == array[i]) continue; // needed for stop all operations and going for the next 1st for operations circle
        
        int temp = array[i];
        array[i] = array[indexOfMin];
        array[indexOfMin] = temp;
    }
    return array;
}

Console.WriteLine("Add number of the array elements and press enter =>> ");
int n = int.Parse(Console.ReadLine()!);
int [] array = new int[n];
FillinTheArray(array);
//PrintTheArray(array);
Console.WriteLine($"Your random array is [{string.Join(", ", array)}]");
Console.WriteLine($"Your sorted array is [{string.Join(", ", sortChoise(array))}]");
