// See https://aka.ms/new-console-template for more information



using System.Text;

class Program
    
  {
    static List<int> SeriesInput = new List<int>([12,34,655,55]);

    
    static bool valid = ValidInput(SeriesInput);
    
    static void Main(string[] args)
    {
        
        
        
        while (valid)
        {
            WriteMenu();
            
        }
      
        











    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    // convert to int list 
    static List<int> ConvertToIntList(string[] input)
    {
        List<int> int_list = new List<int>();
        foreach(string num in input)
        {
            if (int.TryParse(num, out int number))
            {
                SeriesInput.Add(number);
            }
            else
            {
                Console.WriteLine("please enter series of positive numbers");
            }
        }
        return SeriesInput;
    }





    //  build a menu 
    static bool ValidInput(List<int> input)
    {
        if (input.Count < 3)
        {
            return false;
        }
        else 
            foreach(int s in input)
            {
               if (!(s < 0))
               {
                    return false;
               }
            }
        return true;
    }


    // keep the program alive 
    static void WriteMenu()
    {
        Console.WriteLine("          Please select one of the options      ");
        Console.WriteLine("1 - enter a new series \n press q to send !!");
        Console.WriteLine("2 - print the series as is");
        Console.WriteLine("3 - print the series revers");
        Console.WriteLine("4 - print sorted series ");
        Console.WriteLine("5 - find the max number in the series");
        Console.WriteLine("6 - find the min number ");
        Console.WriteLine("7 - find the average of the series");
        Console.WriteLine("8 - number of elents in the series");
        Console.WriteLine("9 - sum of the elements");
        Console.WriteLine("10 - exit");
    }


    // cases 
    static void CasesToChoise()
    {
        string chois = Console.ReadLine();
        switch (chois)
        {
            case "1":
                GetNewList();
                break;
            
            case "2":
                PrintInput(SeriesInput);
                break;

            case "3":
                PrintRevers(SeriesInput);
                break;

            case "4":
                PrintSort(SeriesInput);
                break;

            case "5":
                PrintMax(SeriesInput);
                break;

            case "6":
                PrintMin(SeriesInput);
                break;

            case "7":
                PrintAverage(SeriesInput);
                break;

            case "8":
                Printlen(SeriesInput);
                break;

            case "9":
                PrintSum(SeriesInput);
                break;

            case "10":
                Console.WriteLine("see you 👋");
                break;
        }
    }


    // get new input - case 1
    static List<string> GetNewList()
    {
        List<string> input_list = new List<string>();

        while (true)
        {
            string NewList = Console.ReadLine();

            if (NewList == "q")
            {
                return input_list;
            }
            else
            {
                input_list.Add(NewList);
            }
        }
    }


    // write input - case 2
    static void PrintInput(List<int> input)
    {
        foreach (int num in input)
        {
            Console.Write(num + ",");
        }
    }


    // print revers - case 3
    static void PrintRevers(List<int> input)
    {
        int last = input.Count - 1;
        for (int i = last; i >= 0; i--)
        {
            Console.Write(input[i]+ ",");
        }
    }


    // print sort - case 4
    static void PrintSort(List<int> input)
    {
        List<int> SortedList = new List<int>(input);
        SortedList.Sort();
        foreach(int i in SortedList)
        {
            Console.Write("here the series in order - " + i + ",");
        }
    }
        

    // print max - case 5
    static void PrintMax(List<int> input)
    {
        int max = 0;
        foreach(int chr in input)
        {
            if(chr > max)
            {
                max = chr;
            }
        }
        Console.WriteLine(max + "is the bigger number in the series");
    }


    // print min - case 6
    static void PrintMin(List<int> input)
    {
        int min = input.Max();
        foreach(int num in input)
        {
            if(num > min)
            {
                min = num;
            }
        }
        Console.WriteLine(min + " - is the minimum number in your series");
    }


    // print average - case 7
    static void PrintAverage(List<int> input)
    {
        int average = 0;
        foreach(int num in input)
        {
            average += num;
        }
        Console.WriteLine("the average of your series is - " + average);
    }


    // print lengh of list - case 8
    static void Printlen(List<int> input)
    {
        int len = input.Count();
        Console.WriteLine("you have " + len +" in your series");

    }


    //  print sum of list - case 9 
    static void PrintSum(List<int> input)
    {
        int sum = input.Sum();
        Console.WriteLine("the sum of all your series is - " + sum);
    }



    // convert to int 
    static int ConverttoInt(string[] input)
    {
        return 1;
    }


    
}

