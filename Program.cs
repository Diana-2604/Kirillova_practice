// Задача: написать программу, которая из имеющегося массива строк
// формирует массив из строк, длина которых меньше либо равна 3 символа.

int elemLenght = 3;

Console.WriteLine($"TASK: Create new array from input array with elements less than or equal to {elemLenght} characters \n");

int CountElements(string[] array)
  {
    int result = 0;
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
      if (array[i].Length <= elemLenght) result++;
    }
    return result;
  }

string[] MainTask(string[] inputArray)
{
    string[] outputArray = new string[CountElements(inputArray)];
    int count = inputArray.Length;
    int index = 0;
    int i = 0;
    while (i < count)
    {
        if (inputArray[i].Length <= elemLenght)
        {
        outputArray[index] = inputArray[i];
        index = index + 1;
        }
        i = i + 1;
    }
    return outputArray;
}

string Print(string[] array)
{
  int length = array.Length;
  string output = String.Empty;
  for (int i = 0; i < length; i++)
  {
    output += ($"array[{i + 1}]: {array[i]} \n");
  }
  return output;
}

string[] inputArray1 = {"hello", "2", "world", ":-)"};
string input1 = Print(inputArray1);
Console.WriteLine($"input: \n{input1}");

string[] outputArray1 = MainTask(inputArray1);
string output1 = Print(outputArray1);
Console.WriteLine($"output: \n{output1}");

Console.WriteLine();

string[] inputArray2 = {"1234", "1567", "-2", "computer science"};
string input2 = Print(inputArray2);
Console.WriteLine($"input: \n{input2}");

string[] outputArray2 = MainTask(inputArray2);
string output2 = Print(outputArray2);
Console.WriteLine($"output: \n{output2}");

Console.WriteLine();

string[] inputArray3 = {"Russia", "Denmark", "Kazan"};
string input3 = Print(inputArray3);
Console.WriteLine($"input: \n{input3}");

string[] outputArray3 = MainTask(inputArray3);
string output3 = Print(outputArray3);
Console.WriteLine($"output: \n{output3}");
