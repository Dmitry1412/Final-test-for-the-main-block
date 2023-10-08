Introduction();
Console.WriteLine("Введите пожалуйста первую букву операцию, которую хотите совершить: \n Сложение (1) \n Вычитание (2) \n Умножение (3) \n Транспонирование (4)");
int inputData = int.Parse(Console.ReadLine());
switch (inputData)
{
    case 1:
        int inputMethodSum = SelectInput();
        if (inputMethodSum == 1)
        {
            int[] sizeMatrix = IntroductionCreate();
            int[,] firstMatrix = CreateMatrix(sizeMatrix[0], sizeMatrix[1]);
            int[,] secondMatrix = CreateMatrix(sizeMatrix[0], sizeMatrix[1]);
            int[,] resultMatrix = GetMatrixSum(firstMatrix, secondMatrix);
            Console.Clear();
            PrintArray(firstMatrix);
            Console.WriteLine();
            PrintArray(secondMatrix);
            Console.WriteLine();
            PrintArray(resultMatrix);
        }
        else
        {
            int[] sizeMatrixRand = IntroductionCreateRandom();
            int[,] firstMatrix = RandMatrix(sizeMatrixRand[0], sizeMatrixRand[1], sizeMatrixRand[2], (sizeMatrixRand[3]));
            int[,] secondMatrix = RandMatrix(sizeMatrixRand[0], sizeMatrixRand[1], sizeMatrixRand[2], sizeMatrixRand[3]);
            int[,] resultMatrix = GetMatrixSum(firstMatrix, secondMatrix);
            Console.Clear();
            PrintArray(firstMatrix);
            Console.WriteLine();
            PrintArray(secondMatrix);
            Console.WriteLine();
            PrintArray(resultMatrix);
        }
        break;
    
    case 2:
        int inputMethodDif = SelectInput();
        if (inputMethodDif == 1)
        {
            int[] sizeMatrix = IntroductionCreate();
            int[,] firstMatrix = CreateMatrix(sizeMatrix[0], sizeMatrix[1]);
            int[,] secondMatrix = CreateMatrix(sizeMatrix[0], sizeMatrix[1]);
            int[,] resultMatrix = GetMatrixDifference(firstMatrix, secondMatrix);
            Console.Clear();
            PrintArray(firstMatrix);
            Console.WriteLine();
            PrintArray(secondMatrix);
            Console.WriteLine();
            PrintArray(resultMatrix);
        }
        else
        {
            int[] sizeMatrixRand = IntroductionCreateRandom();
            int[,] firstMatrix = RandMatrix(sizeMatrixRand[0], sizeMatrixRand[1], sizeMatrixRand[2], sizeMatrixRand[3]);
            int[,] secondMatrix = RandMatrix(sizeMatrixRand[0], sizeMatrixRand[1], sizeMatrixRand[2], sizeMatrixRand[3]);
            int[,] resultMatrix = GetMatrixDifference(firstMatrix, secondMatrix);
            Console.Clear();
            PrintArray(firstMatrix);
            Console.WriteLine();
            PrintArray(secondMatrix);
            Console.WriteLine();
            PrintArray(resultMatrix);
        }
        break;
    case 3:
        int inputMethodMul= SelectInput();
        if (inputMethodMul == 1)
        {
            int[] sizeFirstMatrix = IntroductionCreate();
            int[,] firstMatrix = CreateMatrix(sizeFirstMatrix[0], sizeFirstMatrix[1]);
            int[] sizeSecMatrix = IntroductionCreate();
            int[,] secondMatrix = CreateMatrix(sizeSecMatrix[0], sizeSecMatrix[1]);
            int[,] resultMatrix = MultiplicationMatrix(firstMatrix, secondMatrix);
            Console.Clear();
            PrintArray(firstMatrix);
            Console.WriteLine();
            PrintArray(secondMatrix);
            Console.WriteLine();
            PrintArray(resultMatrix);
        }
        else
        {
            int[] sizeFirstMatrixRand = IntroductionCreateRandom();
            int[] sizeSecMatrixRand = IntroductionCreateRandom();
            int[,] firstMatrix = RandMatrix(sizeFirstMatrixRand[0], sizeFirstMatrixRand[1], sizeFirstMatrixRand[2], sizeFirstMatrixRand[3]);
            int[,] secondMatrix = RandMatrix(sizeSecMatrixRand[0], sizeSecMatrixRand[1], sizeSecMatrixRand[2], sizeSecMatrixRand[3]);
            int[,] resultMatrix = MultiplicationMatrix(firstMatrix, secondMatrix);
            Console.Clear();
            PrintArray(firstMatrix);
            Console.WriteLine();
            PrintArray(secondMatrix);
            Console.WriteLine();
            PrintArray(resultMatrix);
        }
        break;
    case 4:
        int inputMethodTrp = SelectInput();
        if (inputMethodTrp == 1)
        {
            int[] sizeMatrix = IntroductionCreate();
            int[,] firstMatrix = CreateMatrix(sizeMatrix[0], sizeMatrix[1]);
            int[,] resultMatrix = GetTranspose(firstMatrix);
            Console.Clear();
            PrintArray(firstMatrix);
            Console.WriteLine();
            PrintArray(resultMatrix);
        }
        else
        {
            int[] sizeMatrixRand = IntroductionCreateRandom();
            int[,] firstMatrix = RandMatrix(sizeMatrixRand[0], sizeMatrixRand[1], sizeMatrixRand[2], sizeMatrixRand[3]);
            int[,] resultMatrix = GetTranspose(firstMatrix);
            Console.Clear();
            PrintArray(firstMatrix);
            Console.WriteLine();
            PrintArray(resultMatrix);
        }
        break;
    default:
        Console.WriteLine("Введите пожалуйста один из символов: \"1\", \"2\", \"3\", \"4\"");
        break;
}

void Introduction()
{
    Console.WriteLine("Добрый день, данная программа позволяет осуществлять основные операции над матрицами: сложение, вычитание, умножение и транспонирование");
    Console.WriteLine("Для продолжения нажмите любую клавишу: ");
    Console.ReadKey();
    Console.Clear();
}

int[,] RandMatrix(int rows = 5, int cols = 5, int minRand = 0, int maxRand = 10)
{
    Random random = new Random();
    int[,] array = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = random.Next(minRand, maxRand);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] GetTranspose(int[,] matrix)
{
    int[,] resultArray = new int[matrix.GetLength(1), matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0;j < matrix.GetLength(1); j++)
        {
            resultArray[j, i] = matrix[i, j];
        }
    }
    return resultArray;
}

int[,] GetMatrixSum(int[,] firstMatrix, int[,] secondMatrix)
{
    if (firstMatrix.GetLength(0) != secondMatrix.GetLength(0) && firstMatrix.GetLength(1) != secondMatrix.GetLength(1)) throw new Exception("Матрицы должны иметь одинаковую размерность!!!");
    int[,] resultMatrix = new int[firstMatrix.GetLength(0), firstMatrix.GetLength(1)];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for(int j = 0; j < firstMatrix.GetLength(1); j++)
        {
            resultMatrix[i,j] = firstMatrix[i, j] + secondMatrix[i, j];
        }
    }
    return resultMatrix;
}

int[,] GetMatrixDifference(int[,] firstMatrix, int[,] secondMatrix)
{
    if (firstMatrix.GetLength(0) != secondMatrix.GetLength(0) && firstMatrix.GetLength(1) != secondMatrix.GetLength(1)) throw new Exception("Матрицы должны иметь одинаковую размерность!!!");
    int[,] resultMatrix = new int[firstMatrix.GetLength(0), firstMatrix.GetLength(1)];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < firstMatrix.GetLength(1); j++)
        {
            resultMatrix[i, j] = firstMatrix[i, j] - secondMatrix[i, j];
        }
    }
    return resultMatrix;
}

int[,] MultiplicationMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0)) throw new Exception("Число столбцов первой матрицы должно совпадать с числом строк второй!!!");
    int[,] resultMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < secondMatrix.GetLength(0);  k++)
            {
                resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            }
        }
    }
    return resultMatrix;
}

int[,] CreateMatrix(int rows, int columns)
{
    Console.WriteLine("Введите пожалуйста через Enter элементы массива: ");
    int[,] userMatrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            userMatrix[i, j] = int.Parse(Console.ReadLine());
        }
    }
    Console.WriteLine("Массив заполнен!");
    return userMatrix;
}

int[] IntroductionCreate()
{
    Console.WriteLine("Введите пожалуйста через Enter размер матриц (количество строк и столбцов): ");
    int[] resultArray = new int[2];
    for (int i = 0; i < 2; i++)
    {
        resultArray[i] = int.Parse(Console.ReadLine());
    }
    return resultArray;
}

int SelectInput()
{
    Console.WriteLine("Каким образом хотите оссуществлять ввод данных: вручную (1) или доверите создание матриц генератору случайных чисел (2)?");
    Console.WriteLine("Укажите способ получения данных: ");
    int inputData = int.Parse(Console.ReadLine());
    int result = default;
    switch (inputData)
    {
        case 1:
            result = 1;
            break;
        case 2:
            result = 2;
            break;
        default:
            Console.WriteLine("Введите пожалуйста 1 или 2");
            break;
    }
    return result;
}

int[] IntroductionCreateRandom()
{
    Console.WriteLine("Введите пожалуйста через Enter размер матриц(ы) (количество строк и столбцов) и диапазон случайных чисел (минимум и максимум): ");
    int[] resultArray = new int[4];
    for (int i = 0; i < 4; i++)
    {
        resultArray[i] = int.Parse(Console.ReadLine());
    }
    return resultArray;
}
