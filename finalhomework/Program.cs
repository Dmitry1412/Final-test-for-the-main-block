

int num = Introduction();
int mum = SelectOperation();

int SelectOperation()
{
    int result = default;
    Console.WriteLine("Введите пожалуйста первую букву операции, которую хотите совершить: \n Сложение (С) \n Вычитание (В) \n Умножение (У) \n Транспонирование (Т)");
    string inputData = Console.ReadLine();
    inputData = inputData.ToLower();
    switch (inputData)
    {
        case "с":
            result = 1;
            break;
        case "в":
            result = 2;
            break;
        case "у":
            result = 3;
            break;
        case "т":
            result = 4;
            break;
        default:
            Console.WriteLine("Введите пожалуйста один из символов: \"c\", \"в\", \"у\", \"т\"");
            break;
    }

    Console.Clear();
    return result;
}

int Introduction()
{
    Console.WriteLine("Добрый день, данная программа позволяет осуществлять основные операции над матрицами: сложение, вычитание, умножение и транспонирование");
    Console.WriteLine("Для продолжения нажмите любую клавишу: ");
    Console.ReadKey();
    Console.Clear();
    Console.WriteLine("Каким образом хотите оссуществлять ввод данных: вручную (в) или доверите создание матриц генератору случайных чисел (р)?");
    Console.WriteLine("Укажите способ получения данных в/р: ");
    string inputData = Console.ReadLine();
    inputData = inputData.ToLower();
    int result = default;
    switch (inputData)
    {
        case "в":
            result = 1;
            break;
        case "р":
            result = 2;
            break;
        default:
            Console.WriteLine("Введите пожалуйста \"в\" или \"р\"");
            break;
    }
    return result;
}