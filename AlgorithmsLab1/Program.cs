using AlgLab1;
using System.Diagnostics;

var stopWatch = new Stopwatch();


TestCases(); // Вывод всех тестов для 3-алгоритмов,        с 2-мя типами заполнения матрицы
//BinTest(); // Вывод всех тестов для BinarySearch,        с 2-мя типами заполнения матрицы
//ExpTest(); // Вывод всех тестов для ExponentionalSearch, с 2-мя типами заполнения матрицы
//LadTest(); // Вывод всех тестов для LadderySearch,       с 2-мя типами заполнения матрицы




/// Вывод происходит в таком формате: --------Matrix size : 2^12x2^13--------
// 1) Binary search: matrix type ->[2]        result: (-1, -1)        time: 752500

// 2) Exponentional search: matrix type ->[2] result:(-1, -1)         time: 108100

// 3) Laddery search: matrix type ->[2]       result: (-1, -1)        time: 63000
///

//Указан размер матрицы, [1 or 2] -> тип заполнения матрицы. Time -> время в наносекундах
// за которое алгоритм был выполнен
// result (-1,-1) -> элемент не найден false, иначе (X,X) true, если такой элемент есть


void BinTest() 
{
    int N = (int)Math.Pow(2, 13);
    var target_1 = 2 * N + 1;
    var target_2 = 16 * N + 1;
    for (int x = 0; x <= 13; x++)
    {
        var M = (int)Math.Pow(2, x);
        var matrix_1 = Matrix.FillMatrix_1(M, N);
        Console.WriteLine($"|Matrix size : 2^{x}x2^13|");
        BinSearch(matrix_1, target_1, 1);
    }
    Console.WriteLine("\n\n\n");
    for (int x = 0; x <= 13; x++)
    {
        var M = (int)Math.Pow(2, x);
        var matrix_2 = Matrix.FillMatrix_2(M, N);
        Console.WriteLine($"|Matrix size : 2^{x}x2^13|");
        BinSearch(matrix_2, target_2, 2);
    }
}
void ExpTest()
{
    int N = (int)Math.Pow(2, 13);
    var target_1 = 2 * N + 1;
    var target_2 = 16 * N + 1;
    for (int x = 0; x <= 13; x++)
    {
        var M = (int)Math.Pow(2, x);
        var matrix_1 = Matrix.FillMatrix_1(M, N);
        Console.WriteLine($"|Matrix size : 2^{x}x2^13|");
        ExpSearch(matrix_1, target_1, 1);
    }
    Console.WriteLine("\n\n\n");
    for (int x = 0; x <= 13; x++)
    {
        var M = (int)Math.Pow(2, x);
        var matrix_2 = Matrix.FillMatrix_2(M, N);
        Console.WriteLine($"|Matrix size : 2^{x}x2^13|");
        ExpSearch(matrix_2, target_2, 2);
    }
}
void LadTest()
{
    int N = (int)Math.Pow(2, 13);
    var target_1 = 2 * N + 1;
    var target_2 = 16 * N + 1;
    for (int x = 0; x <= 13; x++)
    {
        var M = (int)Math.Pow(2, x);
        var matrix_1 = Matrix.FillMatrix_1(M, N);
        Console.WriteLine($"|Matrix size : 2^{x}x2^13|");
        LadSearch(matrix_1, target_1, 1);
    }
    Console.WriteLine("\n\n\n");
    for (int x = 0; x <= 13; x++)
    {
        var M = (int)Math.Pow(2, x);
        var matrix_2 = Matrix.FillMatrix_2(M, N);
        Console.WriteLine($"|Matrix size : 2^{x}x2^13|");
        LadSearch(matrix_2, target_2, 2);
    }
}
void TestCases()
{
    int N = (int)Math.Pow(2, 13);
    var target_1 = 2 * N + 1;
    var target_2 = 16 * N + 1;
    for (int x = 0; x <= 13; x++)
    {
        var M = (int)Math.Pow(2,x);
        var matrix_1 = Matrix.FillMatrix_1(M,N);
        Console.WriteLine($"|Matrix size : 2^{x}x2^13|");
        BinSearch(matrix_1,target_1,1);
        ExpSearch(matrix_1,target_1,1);
        LadSearch(matrix_1,target_1,1);
    }
    Console.WriteLine("\n\n\n");
    for (int x = 0; x <= 13; x++)
    {
        var M = (int)Math.Pow(2, x);
        var matrix_2 = Matrix.FillMatrix_2(M, N);
        Console.WriteLine($"--------Matrix size : 2^{x}x2^13--------");
        BinSearch(matrix_2, target_2, 2);
        ExpSearch(matrix_2, target_2, 2);
        LadSearch(matrix_2, target_2, 2);
    }
}
void BinSearch(int[][] matrix, int target, int fillType)
{
    stopWatch.Restart();
    for (int i = 0; i < matrix.Length; i++)
    {
        var res = BinarySearch.BinSearch(matrix[i], target);
        if (matrix[i][res] == target) {
            stopWatch.Stop();
            Console.WriteLine($" 1) Binary search: matrix type ->[{fillType}]\t result: ({i},{res})\t time: {stopWatch.Elapsed.TotalNanoseconds}\n");
            //File.AppendAllText(Path.Combine(Environment.CurrentDirectory,"binarySearch.txt"),$"{stopWatch.Elapsed.TotalNanoseconds}\n");
            return;
        }
    }
    stopWatch.Stop();
    //File.AppendAllText(Path.Combine(Environment.CurrentDirectory, "binarySearch.txt"), $"{stopWatch.Elapsed.TotalNanoseconds}\n");
    Console.WriteLine($" 1) Binary search: matrix type ->[{fillType}]\t result: (-1, -1)\t time: {stopWatch.Elapsed.TotalNanoseconds}\n");
    
}
void ExpSearch(int[][] matrix, int target, int fillType)
{
    stopWatch.Restart();
    var res = ExponentionalSearch.ExpSearch(matrix, target);
    stopWatch.Stop();
    //File.AppendAllText(Path.Combine(Environment.CurrentDirectory, "expSearch_matrix_2.txt"), $"{stopWatch.Elapsed.TotalNanoseconds}\n");
    Console.WriteLine($" 2) Exponentional search: matrix type ->[{fillType}] result:({res.Item1}, {res.Item2})\t time: {stopWatch.Elapsed.TotalNanoseconds}\n");
}
void LadSearch(int[][] matrix, int target, int fillType)
{
    stopWatch.Restart();
    var res = LadderSearch.LadSearch(matrix, target);
    stopWatch.Stop();
    //File.AppendAllText(Path.Combine(Environment.CurrentDirectory, "ladSearch.txt"), $"{stopWatch.Elapsed.TotalNanoseconds}\n");
    Console.WriteLine($" 3) Laddery search: matrix type ->[{fillType}]\t result: ({res.Item1}, {res.Item2})\t time: {stopWatch.Elapsed.TotalNanoseconds}\n");
}
