// See https://aka.ms/new-console-template for more information

int intRows = 0;
int intColumns = 0;

Console.WriteLine("Number of columns?");
string stringColumns = Console.ReadLine();
intColumns = CheckInput(stringColumns, intColumns, "columns");

Console.WriteLine("Number of rows?");
string stringRows = Console.ReadLine();
intRows = CheckInput(stringRows, intRows, "rows");

GenerateText(intRows, intColumns);
static int CheckInput(string value, int intValue, string context)
{
    while (!Int32.TryParse(value, out intValue))
    {
        Console.WriteLine("Not valid input");

        value = Console.ReadLine();
    }

    intValue = Convert.ToInt32(value);
    return intValue;
}

static void GenerateText(int rows, int columns)
{
    // nested loop

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write("@");
        }
        Console.WriteLine("");
    }
}

Console.ReadKey();
