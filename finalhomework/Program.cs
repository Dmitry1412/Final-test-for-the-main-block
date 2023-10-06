

int num = Introduction();


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