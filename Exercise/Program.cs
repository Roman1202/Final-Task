string[] array1 = new string[5] {"fox", "go", "create", "burn", "001"};
string[] array2 = new string[array1.Length];
void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++){
    if(array1[i].Length <= 3){
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array){
    for (int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
System.Console.WriteLine("Из имеющегося массива строк сформируем новый массив, изымая из первого значения с <=3 символами");
SecondArrayWithIF(array1, array2);
PrintArray(array2);