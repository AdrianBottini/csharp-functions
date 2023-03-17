esegui(request());

int smallInArray(int[] array, int index)
{
    if (index == 1)
    {
        return array[0];
    }
    int n = smallInArray(array, index - 1);

    return array[index - 1] < n ? array[index - 1] : n;
}
int[] request()
{
    Console.WriteLine("Quanto deve essere lungo l'array?");
    int[] nums = new int[Convert.ToInt32(Console.ReadLine())];
    for (int i = 0; i < nums.Length; i++)
    {
        Console.WriteLine($"immetti il numero in  posizione {i}:");
        nums[i] = Convert.ToInt32(Console.ReadLine());
    }
    return nums;
}


void esegui(int[] numbers)
{
    Console.WriteLine("Array originale: ");

    printArray(numbers);

    Console.WriteLine("Array al quadrato: ");

    printArray(ElevaArrayAlQuadrato(numbers));

    Console.WriteLine("Array originale: ");

    printArray(numbers);

    Console.WriteLine("somma di tutti i numeri: ");

    Console.WriteLine(sommaElementiArray(numbers));

    Console.WriteLine("somma di tutti i numeri al quadrato: ");

    Console.WriteLine(sommaElementiArray(ElevaArrayAlQuadrato(numbers)));

    Console.WriteLine("il numero più piccolo nell'array è: ");

    Console.WriteLine(smallInArray(numbers, numbers.Length));
}
void printArray(int[] array)
{
    Console.WriteLine(arrayToString(array));
}

string arrayToString(int[] array)
{
    var result = "[";

    for (int i = 0; i < array.Length; i++)
    {
        result += array[i].ToString();

        if (i < array.Length - 1)
        {
            result += ", ";
        }
    }

    result += "]";

    return result;
}

int Quadrato(int num)
{
    return num * num;
}

int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = Quadrato(array[i]);
    }
    return newArray;
}

int sommaElementiArray(int[] array)
{
    var sum = 0;
    foreach (int num in array)
    {
        sum += num;
    }
    return sum;
}