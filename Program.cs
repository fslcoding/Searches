using System;

class MainClass
{
  public static void Main (string[] args)   
  {
    Console.WriteLine("***RANDOM NUMBER GENERATOR AND SEARCH GAME***\n\n");
    int [] randNums= new int[10];
    randNums = randomNumberGenerator();
    int guess =0;
    int numAttempts=0;
    
    Console.WriteLine("BINARY SEARCH");

    do
    {
      Console.WriteLine("Entered guessed number");
      guess=Convert.ToInt16(Console.ReadLine());
      numAttempts++;
    }
    while((binarySearch(randNums, guess)<0));

    Console.WriteLine("The number " + guess + " was found in the array using a binary search. \nThis took " + numAttempts + " searches of the array");

    Console.WriteLine("LINEAR SEARCH");
    do
    {
      Console.WriteLine("Entered guessed number");
      guess=Convert.ToInt16(Console.ReadLine());
      numAttempts++;
    }
    while((linearSearch(randNums, guess)<0));

    Console.WriteLine("The number " + guess + " was found in the array using a linear search. \nThis took " + numAttempts + " searches of the array");
  }

  static int [] randomNumberGenerator ()
  {
    Random rand = new Random();
    int [] randomNumbers= new int[10];


    for(int i=0;i<10;i++)
    {
      randomNumbers[i] = rand.Next(1,20);
    }

    return randomNumbers;
  }

  static int binarySearch(int[] numbers, int searchNumber)  
{ 
  int min = 0;
  int max = numbers.Length - 1; 
    while (min <=max)  
    {  
       int mid = (min + max) / 2;  
       if (searchNumber == numbers[mid])  
       {  
            return numbers[mid];  
       }  
       else if (searchNumber < numbers[mid])  
       {  
           max = mid - 1;  
       }  
       else  
       {  
            min = mid + 1;  
       }  
   }  
   //If number isnt found return -1
   return -1;  
}

static int linearSearch(int[] numbers, int searchNumber)  
{ 
  for(int i =0;i<numbers.Length;i++)
  {
    if(searchNumber == numbers[i]);
    {
      return i;
    }

  }
  
  return -1;

}
}
