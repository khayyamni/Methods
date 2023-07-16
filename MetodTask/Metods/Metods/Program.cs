//1.Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın.

//int n = 63;

//if (IsDivision(n))
//{
//    Console.WriteLine("Bolunur");

//}
//else
//{
//    Console.WriteLine("Bolunmur");
//}

//static bool IsDivision(int n)
//{
//    if (n % 3 == 0 && n % 7 == 0)
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }
//}int result = n;
//Console.WriteLine(IsDivision(20));






//2.n və m ədədləri verilir. Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.

//static void SumOfNumders(int n, int m)
//{
//    int sum = 0;

//    if (n % 2 == 0 && m % 2 == 0)

//    {
//        sum = n + m;

//    }

//    Console.WriteLine(sum);

//}



//int N;
//int M;

//SumOfNumders(22,66); 





//3.Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin.

//static void IsSingleNumber(int n, int m)
//{
//    int sum = 0;

//    for (int i = n; i < m; i++)
//    {
//        if (i % 2 == 1)
//        {
//            sum += i;
//        }

//    }
//        Console.WriteLine(sum);
//}

//int a;
//int b;
//IsSingleNumber(13,25);




//4. Verilmish arrayin icindeki tek ededlerin cemini tapin.

//static void VarArray()
//{
//    int[] arrs = { 14,15,11,24 };

//    int sum = 0;

//    for (int i = 0; i < arrs.Length; i++)
//    {
//        if (arrs[i] % 2 != 0)
//        {
//            sum += arrs[i];
//        }
//    }
//    Console.WriteLine(sum);
//}
//;
//VarArray();




//5.Verilmish arrayin icindeki cut ededlerin sayini tapin

//static void DoubleArray(int[] nums)
//{
//    int count = 0;
//    {
//        foreach (var item in nums)
//            if (item % 2 == 0)
//            {
//                count++;
//            }
//    }
//    Console.WriteLine(count);
//}
//int[] nums = { 1, 25, 14, 9 };

//DoubleArray(nums);



//6.Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapin

//static void CountNumbery()
//{
//    int n = 15;
//    int m = 23;
//    int count = 0;


//    for (int i = n; i < m; i++)
//    {
//        if (i % 2 == 1 && n != i)
//        {
//            count++;
//        }
//    }
//    Console.WriteLine(count);
//}

//CountNumbery();



//8. Verilmis n ve m (n<m) ededleri arasindaki cut ededlerin cemini tapin.




//static void GiveNum()
//{
//    int n = 3;
//    int m = 6;
//    int sum = 0;


//    for (int i = n; i < m; i++)
//    {
//        if (i % 2 == 0 && n != i)
//        {
//            sum+=i;
//        }
//    }
//    Console.WriteLine(sum);
//}

//GiveNum();

//9. Verilmis n ve m (n<m) ededleri arasindaki cut ededlerin sayini tapin.


//static void DoubleCountNumbers()
//{
//    int n = 3;
//    int m = 6;
//    int count = 0;


//    for (int i = n; i < m; i++)
//    {
//        if (i % 2 == 0 && n != i)
//        {
//            count ++;
//        }
//    }
//    Console.WriteLine(count);
//}

//DoubleCountNumbers();



//11. n ededinin faktorialini hesablamaq.


//static int FactorialNums(int n)
//{ 
//	int count = 1;

//	for (int i = 1; i <= n; i++)
//	{
//		count *= i;
//	}
//	return count;
//}

//Console.WriteLine(FactorialNums(7));