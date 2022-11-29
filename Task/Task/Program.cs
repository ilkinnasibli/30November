int[] numbers = {2, 3,5, 14, 59 };
int FindAll(int num1) 
{
	//int arraysize = 0;
	for (int i = 0; i < numbers.Length; i++)
    {int sum =0;
        int[] array = new int[2];

        if (numbers[i] > num1) 
		{
			sum++;
			//arraysize++;
			//array[i] = numbers[i];
        }
       
  //      foreach (var item in array)
		//{
		//	Console.WriteLine(item);
           return sum;

  //      }
	}
	return -1;
}
Console.WriteLine(FindAll(6));