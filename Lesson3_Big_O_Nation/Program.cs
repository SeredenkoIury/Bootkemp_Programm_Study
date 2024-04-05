Console.Clear();
Console.WriteLine("Bootkemp_Lesson_03_Algoritms_And_Analys");
Console.WriteLine("");

//===================================================================================== theory
// Списки могут хранить много разных типов данных но работают медленнее
// Массивы хранят один тип данных, но при том работают быстрее
// Console.WriteLine(array[3]); //===> сложность алгоритма в этой строчке -  О(1)

//===================================================================================== array with fill in from the console step by step


// int n = 5;
// int [] array = new int [n];
// for (int i = 0; i < array.Length; i++)
//     {
//         Console.WriteLine("Add the array element for position with number " + i + " and  press the Enter.");
//         array [i] = Convert.ToInt32(Console.ReadLine());
//         Console.Clear();
//         Console.WriteLine("Bootkemp_Lesson_03_Algoritms_And_Analys");
//         Console.WriteLine("");
//     }

// Console.Write("Your array is ");
// Console.WriteLine("[ " + string.Join(" | ", array) + " ]");

// //[4, 5, 3, 2, 1]//сложность алгоритма при вычислении суммы элементов O(n)

// //[1, 2, 3, 4, 5]//сложность алгоритма при сортировке элементов O(n*log n)
// //((5 + 1)/2) * 5 //сложность алгоритма при вычислении суммы элементов O(n)

// //==> n < n * Log(n) + 1, значит поиск суммы обычным циклом сработает в этой ситуации быстрее
//===================================================================================== array with fill in from the console step by step

//===================================================================================== The multiply table O(n^2)
// int n = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <=n; i++)
//     {
//     for (int j = 1; j < 10; j++)
//         {
//             Console.Write("|" + j*i + "|"+ "\t");
//         }
//     Console.WriteLine();   
//     }
//===================================================================================== optimized multiply table О(n^2 /2)
Console.WriteLine("Add the multiply matrix size and press the Enter.");
int n = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine("Bootkemp_Lesson_03_Algoritms_And_Analys");
Console.WriteLine("");
Console.WriteLine("Your multiply matrix is " + n + " to " + n);
int [, ] matrix = new int [n,n];
for (int i = 0; i < n; i++)
    {
        for (int j = i; j < n; j++)
            {
                    matrix [i, j] = (i + 1) * (j + 1);
                    matrix [j, i] = (i + 1) * (j + 1);
                   
            }
            
    }
for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
            {
                    Console.Write(matrix [i,j] + "\t");
            }
                Console.WriteLine();
    }







