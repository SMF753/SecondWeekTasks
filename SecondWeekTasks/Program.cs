using System;

namespace SecondWeekTasks
{
    internal class Program
    {

        //7 masala
        // for loop
        public static int Sum1(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }
        //while
        public static int Sum2(int[] nums)
        {
            int sum = 0, i = 0;
            while (i < nums.Length)
            {
                sum += nums[i];
                i++;
            }
            return sum;
        }
        public static int s = 0;
        // recursion
        public static int Sum3(int[] nums, int n)
        {
            if (n == 0) return 0;
            s += Sum3(nums, n - 1) + nums[n - 1];
            return s;
        }





        static void Main(string[] args)
        {

            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(Sum1(nums));
            Console.WriteLine(Sum2(nums));
            Console.WriteLine(Sum3(nums, nums.Length));


        }
    }
}
////14 masala
//public static int[] Digits(int n)
//{
//    int k = Convert.ToString(n).Length;
//    int[] nums = new int[k];
//    for(int i=k-1;i>=0;i--)
//    {
//        nums[i] = n % 10;
//        n = n / 10;
//    }
//    return nums;
//}




////13 masala
//public static decimal[] Fibonacci()
//{
//    decimal[] F = new decimal[100];
//    F[0] = 1;
//    F[1] = 1;
//    for (int i = 2; i < 100; i++)
//    {
//        F[i] = F[i - 1] + F[i - 2];
//        F[i - 2] = F[i - 1];

//    }
//    return F;
//}



////12 masala
//public static int[] Rotates(int[] nums)
//{ 
//    int n = nums[0];
//    for(int i=0;i<nums.Length-1;i++)
//    {
//        nums[i] = nums[i + 1];
//    }
//    nums[nums.Length - 1] = n;
//    return nums;
//}
//public static int[] Rotated(int[] nums,int k)
//{
//    for (int i = 0; i < k; i++)
//    {
//        nums = Rotates(nums);
//    }
//    return nums;
//}





////11 masala
//public static int[] TwoArray(int[] num1, int[] num2)
//{
//    int n = num1.Length + num2.Length, i = 0, k = 0;
//    int[] nums = new int[n];
//    Array.Sort(num1);
//    Array.Sort(num2);
//    for (int j = 0; j < nums.Length;)
//    {
//        if (i<num1.Length&&k<num2.Length)
//        {

//            if (num1[i] < num2[k])
//            {
//                nums[j] = num1[i];
//                i++;
//                j++;
//            }
//            else 
//            {
//                nums[j] = num2[k];
//                k++;
//                j++;
//            }

//        }
//        else if(i < num1.Length)
//        {
//            nums[j] = num1[i];
//            i++;
//            j++;
//        }
//        else if(k<num2.Length)
//        {
//            nums[j] = num2[k];
//            k++;
//            j++;
//        }

//    }


//    return nums;
//}




////10 masala
//public static int[] TwoArray(int[] num1, int[] num2)
//{
//    int n = num1.Length + num2.Length, i = 0,k=0;
//    int[] nums = new int[n];
//    for (int j = 0; j < nums.Length;)
//    {
//        if(i<num1.Length)
//        {
//            nums[j] = num1[i];
//            i++;
//            j++;
//        }
//        if (k < num2.Length)
//        {
//            nums[j] = num2[k];
//            k++;
//            j++;
//        }

//    }


//    return nums;
//}







////9 masala
//public static int[] TwoArray(int[] num1,int[] num2)
//{
//    int n = num1.Length + num2.Length,i=0;
//    int[] nums = new int[n];
//    for(int j=0;j<num1.Length;j++,i++)
//    {
//        nums[i] = num1[j];
//    }

//    for (int j = 0; j < num2.Length; j++, i++)
//    {
//        nums[i] = num2[j];
//    }
//    return nums;
//}



//// 8 masala
//public static int[] Task8(int[] nums)
//{
//    int k = 0,m=0,t;
//    for(int i=0;i<nums.Length;i++)
//    {
//        k +=(int) Math.Sqrt(nums[i]);
//    }
//    int[] square = new int[k];
//    for(int i=0;i<nums.Length;i++)
//    {
//        t = (int)Math.Sqrt(nums[i]);
//        for (int j=1;j<=t;j++,m++)
//        {
//            square[m] = j * j;
//        }
//    }
//    return square;
//}




////7 masala
//// for loop
//public static int Sum1(int[] nums)
//{
//    int sum = 0;
//    for (int i = 0; i < nums.Length; i++)
//    {
//        sum += nums[i];
//    }
//    return sum;
//}
////while
//public static int Sum2(int[] nums)
//{
//    int sum = 0,i=0;
//    while(i<nums.Length)
//    {
//        sum += nums[i];
//        i++;
//    }
//    return sum;
//}
//public static int s = 0;
//// recursion
//public static int Sum3(int[] nums, int n)
//{
//    if ( n==0) return 0;
//    s += Sum3(nums, n - 1) + nums[n-1];
//    return s;
//}





//// 6 masala
//public static bool CheckPalindrome( string s)
//{
//    for(int i=0;i<s.Length/2;i++)
//    {
//        if (s[i] != s[s.Length - i-1]) return false;
//    }

//    return true;
//}



//5 masala
//public static int Sum(int[] nums)
//{
//    int sum = 0;
//    for(int i=0;i<nums.Length;i++)
//    {
//        sum += nums[i];
//    }
//    return sum;
//}



//4 masala
//public static int[] OddPosition(int[] nums)
//{
//    int[] num1 = new int[nums.Length / 2];
//    int j = 1;
//    for(int i=0;i<num1.Length;i++)
//    {
//        num1[i] = nums[j];
//        j += 2;
//    }
//    return num1;
//}



//3 masala
//public static bool Check(int [] nums,int n)
//{
//    for(int i=0;i<nums.Length;i++)
//    {
//        if (n == nums[i]) return true;
//    }
//    return false;
//}




//2 masala
//public static double[] Reverse(double[] nums, double n)
// {
//     for(int i=0;i<nums.Length;i++)
//     {
//         if (n == nums[i]) nums[i] = 1 / nums[i];
//     }
//     return nums;
// }



// 1 masala
//public static int MaxElement(int[] a)
//{
//    int max = a[0];
//    for(int i=1;i<a.Length;i++)
//    {
//        if (max < a[i]) max = a[i];
//    }
//    return max;
//}