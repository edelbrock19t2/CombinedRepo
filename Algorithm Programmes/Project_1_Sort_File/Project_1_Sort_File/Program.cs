
using Project_1_Sort_File;
using Project_1_Sort_File.Strategy;
using System.Diagnostics;
using System.Text.RegularExpressions;

Console.ForegroundColor = ConsoleColor.White;

void DisplayArr(int[] arr)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine();
}

void DisplayArrStr(string[] arr)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine();
}


string SearchForAFile(string fileName)
{
    DirectoryInfo hdDirectoryInWhichToSearch = new DirectoryInfo(@"C:\Users\Xopero\Desktop");
    FileInfo[] filesInDir = hdDirectoryInWhichToSearch.GetFiles("*" + fileName + ".*");

    string fullFillePath = "";
    foreach (FileInfo foundFile in filesInDir)
    {
        fullFillePath = foundFile.FullName;    }

    return fullFillePath;
}

bool TryConvertToInt(string line)
{
    try
    {
        Convert.ToInt32(line);
        return true;
    }catch(Exception e)
    {
        return false;
    }
}


void ReadAndDefineFileType(string filePath, Sortener sortener)
{
    using (StreamReader reader = new StreamReader(filePath)) {

        string? line;
        bool onlyStrings = true;
        bool onlyNumbers = true;
        int count = 0;

        while ((line = reader.ReadLine()) != null)
        {
            count++;
            if (!Regex.IsMatch(line, @"^[a-zA-Z]*$") && TryConvertToInt(line))
            {
                onlyStrings = false;
            }

            if (!Regex.IsMatch(line, @"^[0-9]*$") && !TryConvertToInt(line))
            {
                onlyNumbers = false;
            }

            if (!onlyStrings && !onlyNumbers)
            {
                break;
            }
        }

        if (onlyStrings)
        {
            Console.WriteLine("-----------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("File contains only strings: " + count);
            Console.ForegroundColor = ConsoleColor.White;
            // WriteDataToArray<string>(count, filePath);
            WriteDataToArray2(count, filePath, "str", sortener);
        }
        else if (onlyNumbers)
        {
            Console.WriteLine("-----------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("File contains only numbers: " + count);
            Console.ForegroundColor = ConsoleColor.White;
            WriteDataToArray2(count, filePath, "int", sortener);
        }
        else
        {
            Console.WriteLine("-----------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("File contains numbers and strings: " + count);
            Console.ForegroundColor = ConsoleColor.White;
            WriteDataToArray2(count, filePath, "str", sortener);
        }
    }
}

void WriteDataToArray2(int count, string filePath, string dataType, Sortener sortener)
{
    Stopwatch stopwatch = new Stopwatch();

    if (dataType.Equals("int"))
    {
        List<int> elements = new List<int>();
        using(StreamReader reader = new StreamReader(filePath))
        {
            string? line;
            while((line = reader.ReadLine()) != null){
                elements.Add(Convert.ToInt32(line));
            }
        }
        Console.Write("Array before sorting: ");
        DisplayArr(elements.ToArray());
        
        Console.Write("Array after sorting: ");
        stopwatch.Start();

        int[] sortedArray = sortener.sortArray(elements.ToArray());
        stopwatch.Stop();
        
        DisplayArr(sortedArray);
        Console.WriteLine(sortener.sortStrategy + " time(int): " + stopwatch);
    }
    else if(dataType.Equals("str"))
    {
        List<string> elements = new List<string>();
        using (StreamReader reader = new StreamReader(filePath))
        {
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                elements.Add(line);
            }
        }

        Console.Write("Array before sorting: ");
        DisplayArrStr(elements.ToArray());

        Console.Write("Array before sorting: ");
        DisplayArrStr(sortener.sortArray(elements.ToArray()));
    }

}
////////////////////----^-Functions-^----\\\\\\\\\\\\\\\\\\\\\\

Sortener sortener = new Sortener();

Console.WriteLine("--------------\nWelcome to Program");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Place your file at the Desktop");

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Choose an option to continue: ");
Console.WriteLine("1 - Bubble Sort\n" +
                  "2 - Quick Sort\n" +
                  "3 - Merge Sort");
Console.Write("Input num: ");

int num = Convert.ToInt32(Console.ReadLine());

if(num == 1)
{
    sortener.sortStrategy = new Project_1_Sort_File.Strategy.BubbleSort();
}else if (num == 2)
{
    sortener.sortStrategy = new QuickSort();
}else if(num == 3)
{
    sortener.sortStrategy = new MergeSort();
}
else
{
    Console.WriteLine("Undefined manage id");
}

Console.Write("Input a filename: ");
string? fileName = Console.ReadLine();
Console.WriteLine("Searching for file...");


string fullFilePath = SearchForAFile(fileName);
Console.WriteLine(fullFilePath);

Console.Write("\nIs that your file?(y/n): ");
string? yesNoFile = Console.ReadLine();

if(yesNoFile.Equals("y"))
{
    ReadAndDefineFileType(fullFilePath, sortener);
}
else
{
    Console.WriteLine("Sorry, We can't find your file(");
}
