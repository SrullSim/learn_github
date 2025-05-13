// See https://aka.ms/new-console-template for more information



using System.Text;

class Program
    {
    static void Main(string[] args)
    {
        CasesToChoise();
    }

    
    
    
    
    
    //  build a menu 
    static bool ValidInput(string[] input)
    {
        if (input.Length < 3)
        {
            return false;
        }
        else 
            foreach(string s in input)
            {
                if (!(int.TryParse(s, out int number)))
                    {
                    if (!(number < 0))
                    {
                        return false;
                    }}
            }

        return true;
    }


    // keep the program alive 
    static void WriteMenu(string menuName)
    {
        Console.WriteLine("");
    }


    // cases 
    static void CasesToChoise()
    {
        Console.WriteLine("1 - enter a new series");
        Console.WriteLine("2 - print the series as is");
        Console.WriteLine("3 - print the series revers");
        Console.WriteLine("4 - print sorted series ");
        Console.WriteLine("5 - find the mwa number in the series");
        Console.WriteLine("6 - find the min number ");
        Console.WriteLine("7 - find the average of the series");
        Console.WriteLine("8 - number of elents in the series");
        Console.WriteLine("9 - sum of the elements");
        Console.WriteLine("10 - exit");
    }


    // get new input - case 1
    static List<string> GetNewList(string[] args)
    {
        List<string> input_list = new List<string>();

        Console.ReadLine();

        

        return new List<string>();
    }


    // write input - case 2
    static void PrintInput(List<string> input)
    {
        
    }


    // print revers - case 3
    static void PrintRevers(List<string> revers)
    {
        Console.WriteLine("");
    }


    // print sort - case 4
    static void PrintSort(List<string> input)
    {
        Console.WriteLine("");
    }
        

    // print max - case 5
    static void PrintMax(List<string> input)
    {
        int max = 0;
        foreach(string chr in input)
        {
            int int_chr = Convert.ToInt32(chr);
            if(int_chr > max)
            {
                max = int_chr;
            }
        }
        Console.WriteLine(max);
    }


    // print min - case 6
    static void PrintMin(List<string> input)
    {
        Console.WriteLine("");
    }


    // print average - case 7
    static void PrintAverage(List<string> input)
    {
        Console.WriteLine("");
    }


    // print lengh of list - case 8
    static void Printlen(List<string> input)
    {
        Console.WriteLine("");
    }


    //  print sum of list - case 9 
    static void PrintSum(List<string> input)
    {
        Console.WriteLine("");
    }


    // convert to list 
    static List<int> ConvertToList(string[] input)
    {
        return new List<int> (ConvertToList(input));
    }


    // convert to int 
    static int ConverttoInt(string[] input)
    {
        return 1;
    }


    
}

