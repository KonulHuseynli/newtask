﻿using System;

namespace ConsoleApp39
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 2, 3, 4, 7 };//2347
            int[] arr2 = { 3,2};//34
           
            Console.WriteLine( IsArrayContains(arr1,arr2));
        }
        static bool IsArrayContains(int [] arr1,int [] arr2)
        {
            int counter = 0;
            for (int i = 0; i <arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                { 
                    if(arr2[j]==arr1[i] &&  )
                    {
                        counter++;
                        if(counter==arr2.Length)
                        {
                            return true;
                        }
                    }

                }

            }return false;
        }
    }
}

