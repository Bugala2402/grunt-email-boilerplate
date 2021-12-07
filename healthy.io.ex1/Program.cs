using System;
using System.Collections.Generic;
using System.Linq;

namespace healthy.io.ex1
{

    class Program
    {
        public class I_J
        {
            public int i { get; set; }
            public int j { get; set; }
            public I_J(int I, int J) { i = I; j = J; }

        }
        
        public static int islandsCount;
        public static void spanningTree(I_J ta, int[,] bitMap)
        {
            //התא הראשון במטריצה AD
            if (ta.i == 0 && ta.j == 0)
            {
                //לבדוק מזרח, דרום מזרח,דרום
                if (bitMap[ta.i, ta.j + 1] == 1)//מזרח
                {
                    bitMap[ta.i, ta.j] = 0;
                    ta.i = ta.i;
                    ta.j = ta.j + 1;
                    spanningTree(ta, bitMap);
                }
                if (bitMap[ta.i + 1, ta.j] == 1)// דרום
                {

                    bitMap[ta.i, ta.j] = 0;
                    ta.i = ta.i + 1;
                    ta.j = ta.j;
                    spanningTree(ta, bitMap);
                }
                if (bitMap[ta.i + 1, ta.j + 1] == 1)// דרום מזרח
                {

                    bitMap[ta.i, ta.j] = 0;
                    ta.i = ta.i + 1;
                    ta.j = ta.j + 1;
                    spanningTree(ta, bitMap);
                }
                if (bitMap[ta.i, ta.j + 1] == 0 && bitMap[ta.i + 1, ta.j] == 0 && bitMap[ta.i + 1, ta.j + 1] == 0)
                {
                    bitMap[ta.i, ta.j] = 0;
                    return;

                }
            }
           // סוף השורה הראשונה DC
             if (ta.i == 0 && ta.j == bitMap.GetLength(1))
            {
           //     דרום,דרום מערב, מערב
         if (bitMap[ta.i + 1, ta.j] == 1)// דרום
                {

                    bitMap[ta.i, ta.j] = 0;
                    ta.i = ta.i + 1;
                    ta.j = ta.j;
                    spanningTree(ta, bitMap);
                }
                if (bitMap[ta.i, ta.j - 1] == 1)// מערב 
                {

                    bitMap[ta.i, ta.j] = 0;
                    ta.i = ta.i;
                    ta.j = ta.j - 1;
                    spanningTree(ta, bitMap);
                }
                if (bitMap[ta.i + 1, ta.j - 1] == 1)// דרום-מערב 
                {

                    bitMap[ta.i, ta.j] = 0;
                    ta.i = ta.i + 1;
                    ta.j = ta.j - 1;
                    spanningTree(ta, bitMap);
                }
                if (bitMap[ta.i + 1, ta.j] == 0 && bitMap[ta.i, ta.j - 1] == 0 && bitMap[ta.i + 1, ta.j - 1] == 0)
                {
                    bitMap[ta.i, ta.j] = 0;
                    return;

                }
            }
           // AB התא השמאלי למטה
             if (ta.i == bitMap.GetLength(0) && ta.j == 0)
            {
                מזרח,צפון מזרח, צפון
         if (bitMap[ta.i, ta.j + 1] == 1)//מזרח
                {

                    bitMap[ta.i, ta.j] = 0;
                    ta.i = ta.i;
                    ta.j = ta.j + 1;
                    spanningTree(ta, bitMap);
                }
                if (bitMap[ta.i - 1, ta.j] == 1)// צפון 
                {

                    bitMap[ta.i, ta.j] = 0;
                    ta.i = ta.i - 1;
                    ta.j = ta.j;
                    spanningTree(ta, bitMap);
                }
                if (bitMap[ta.i - 1, ta.j + 1] == 1)// צפון-מזרח 
                {

                    bitMap[ta.i, ta.j] = 0;
                    ta.i = ta.i - 1;
                    ta.j = ta.j + 1;
                    spanningTree(ta, bitMap);
                }
                if (bitMap[ta.i, ta.j + 1] == 0 && bitMap[ta.i - 1, ta.j] == 0 && bitMap[ta.i - 1, ta.j + 1] == 0)
                {
                    bitMap[ta.i, ta.j] = 0; return;

                }
            }
            //BC התא בסוף המטריצה
             if (ta.i == bitMap.GetLength(0) && ta.j == bitMap.GetLength(1))
            {
           //     מערב,צפון מערב, צפון
         if (bitMap[ta.i - 1, ta.j] == 1)// צפון 
                {

                    bitMap[ta.i, ta.j] = 0;
                    ta.i = ta.i - 1;
                    ta.j = ta.j;
                    spanningTree(ta, bitMap);
                }
                if (bitMap[ta.i, ta.j - 1] == 1)// מערב 
                {

                    bitMap[ta.i, ta.j] = 0;
                    ta.i = ta.i;
                    ta.j = ta.j - 1;
                    spanningTree(ta, bitMap);
                }
                if (bitMap[ta.i - 1, ta.j - 1] == 1)// צפון מערב
                {

                    bitMap[ta.i, ta.j] = 0;
                    ta.i = ta.i - 1;
                    ta.j = ta.j - 1;
                    spanningTree(ta, bitMap);
                }
                if (bitMap[ta.i - 1, ta.j] == 0 && bitMap[ta.i, ta.j - 1] == 0 && bitMap[ta.i - 1, ta.j - 1] == 0)
                {
                    bitMap[ta.i, ta.j] = 0; return;

                }
            }
            //A
             if (ta.i >= 1 && ta.i < bitMap.GetLength(0) && ta.j == 0)
            {
          //      צפון,צפון מזרח, מזרח, דרום מזרח,דרום
         if (bitMap[ta.i + 1, ta.j] == 1)// דרום
                {

                    bitMap[ta.i, ta.j] = 0;
                    ta.i = ta.i + 1;
                    ta.j = ta.j;
                    spanningTree(ta, bitMap);
                }
                if (bitMap[ta.i + 1, ta.j + 1] == 1)// דרום מזרח
                {
                    bitMap[ta.i, ta.j] = 0;
                    ta.i = ta.i + 1;
                    ta.j = ta.j + 1;
                    spanningTree(ta, bitMap);
                }
                if (bitMap[ta.i, ta.j + 1] == 1)//מזרח
                {

                    bitMap[ta.i, ta.j] = 0;
                    ta.i = ta.i;
                    ta.j = ta.j + 1;
                    spanningTree(ta, bitMap);
                }
                if (bitMap[ta.i - 1, ta.j] == 1)// צפון 
                {

                    bitMap[ta.i, ta.j] = 0;
                    ta.i = ta.i - 1;
                    ta.j = ta.j;
                    spanningTree(ta, bitMap);
                }
                if (bitMap[ta.i - 1, ta.j + 1] == 1)// צפון-מזרח 
                {

                    bitMap[ta.i, ta.j] = 0;
                    ta.i = ta.i - 1;
                    ta.j = ta.j + 1;
                    spanningTree(ta, bitMap);
                }
                if (bitMap[ta.i + 1, ta.j] == 0 && bitMap[ta.i + 1, ta.j + 1] == 0 && bitMap[ta.i, ta.j + 1] == 0 && bitMap[ta.i - 1, ta.j] == 0 && bitMap[ta.i - 1, ta.j + 1] == 0)
                {
                    bitMap[ta.i, ta.j] = 0; return;
                }
            }
           // c
             if (ta.i >= 1 && ta.i < bitMap.GetLength(0) && ta.j == bitMap.GetLength(1) - 1)
            {//צפון,צפון מערב,מערב,דרום מערב,דרום
                if (bitMap[ta.i + 1, ta.j] == 1)// דרום
                {

                    bitMap[ta.i, ta.j] = 0;
                    ta.i = ta.i + 1;
                    ta.j = ta.j;
                    spanningTree(ta, bitMap);
                }
                if (bitMap[ta.i - 1, ta.j - 1] == 1)// צפון מערב
                {

                    bitMap[ta.i, ta.j] = 0;
                    ta.i = ta.i - 1;
                    ta.j = ta.j - 1;
                    spanningTree(ta, bitMap);
                }
                if (bitMap[ta.i - 1, ta.j] == 1)// צפון 
                {

                    bitMap[ta.i, ta.j] = 0;
                    ta.i = ta.i - 1;
                    ta.j = ta.j;
                    spanningTree(ta, bitMap);
                }
                if (bitMap[ta.i, ta.j - 1] == 1)// מערב 
                {

                    bitMap[ta.i, ta.j] = 0;
                    ta.i = ta.i;
                    ta.j = ta.j - 1;
                    spanningTree(ta, bitMap);
                }
                if (bitMap[ta.i + 1, ta.j - 1] == 1)// דרום-מערב 
                {

                    bitMap[ta.i, ta.j] = 0;
                    ta.i = ta.i + 1;
                    ta.j = ta.j - 1;
                    spanningTree(ta, bitMap);
                }
                if (bitMap[ta.i + 1, ta.j] == 0 && bitMap[ta.i - 1, ta.j - 1] == 0 && bitMap[ta.i - 1, ta.j] == 0 && bitMap[ta.i, ta.j - 1] == 0 && bitMap[ta.i + 1, ta.j - 1] == 0)
                {
                    bitMap[ta.i, ta.j] = 0; return;

                }
            }
           // B
             if (ta.i == bitMap.GetLength(0) - 1 && ta.j >= 1 && ta.j < bitMap.GetLength(1) - 1)
            {
              //  מערב,צפון מערב, צפון, צפון מזרח,מזרח
         if (bitMap[ta.i, ta.j + 1] == 1)//מזרח
                {

                    bitMap[ta.i, ta.j] = 0;
                    ta.i = ta.i;
                    ta.j = ta.j + 1;
                    spanningTree(ta, bitMap);
                }
                if (bitMap[ta.i - 1, ta.j - 1] == 1)// צפון מערב
                {

                    bitMap[ta.i, ta.j] = 0;
                    ta.i = ta.i - 1;
                    ta.j = ta.j - 1;
                    spanningTree(ta, bitMap);
                }
                if (bitMap[ta.i - 1, ta.j] == 1)// צפון 
                {

                    bitMap[ta.i, ta.j] = 0;
                    ta.i = ta.i - 1;
                    ta.j = ta.j;
                    spanningTree(ta, bitMap);
                }
                if (bitMap[ta.i, ta.j - 1] == 1)// מערב 
                {

                    bitMap[ta.i, ta.j] = 0;
                    ta.i = ta.i;
                    ta.j = ta.j - 1;
                    spanningTree(ta, bitMap);
                }
                if (bitMap[ta.i - 1, ta.j + 1] == 1)// צפון-מזרח 
                {

                    bitMap[ta.i, ta.j] = 0;
                    ta.i = ta.i - 1;
                    ta.j = ta.j + 1;
                    spanningTree(ta, bitMap);
                }
                if (bitMap[ta.i, ta.j + 1] == 0 && bitMap[ta.i - 1, ta.j - 1] == 0 && bitMap[ta.i - 1, ta.j] == 0 && bitMap[ta.i, ta.j - 1] == 0 && bitMap[ta.i - 1, ta.j + 1] == 0)
                {
                    bitMap[ta.i, ta.j] = 0;
                    return;


                }
            }
            //D
             if (ta.i == 0 && ta.j >= 1 && ta.j < bitMap.GetLength(1) - 1)
            { //מזרח,דרום מזרח,דרום,דרום מערב,מערב
                if (bitMap[ta.i + 1, ta.j] == 1)// דרום
                {

                    bitMap[ta.i, ta.j] = 0;
                    ta.i = ta.i + 1;
                    ta.j = ta.j;
                    spanningTree(ta, bitMap);
                }
                if (bitMap[ta.i + 1, ta.j + 1] == 1)// דרום מזרח
                {

                    bitMap[ta.i, ta.j] = 0;
                    ta.i = ta.i + 1;
                    ta.j = ta.j + 1;
                    spanningTree(ta, bitMap);
                }
                if (bitMap[ta.i, ta.j + 1] == 1)//מזרח
                {

                    bitMap[ta.i, ta.j] = 0;
                    ta.i = ta.i;
                    ta.j = ta.j + 1;
                    spanningTree(ta, bitMap);
                }
                if (bitMap[ta.i, ta.j - 1] == 1)// מערב 
                {

                    bitMap[ta.i, ta.j] = 0;
                    ta.i = ta.i;
                    ta.j = ta.j - 1;
                    spanningTree(ta, bitMap);
                }
                if (bitMap[ta.i + 1, ta.j - 1] == 1)// דרום-מערב 
                {

                    bitMap[ta.i, ta.j] = 0;
                    ta.i = ta.i + 1;
                    ta.j = ta.j - 1;
                    spanningTree(ta, bitMap);
                }
                if (bitMap[ta.i + 1, ta.j] == 0 && bitMap[ta.i + 1, ta.j + 1] == 0 && bitMap[ta.i, ta.j + 1] == 0 && bitMap[ta.i, ta.j - 1] == 0 && bitMap[ta.i + 1, ta.j - 1] == 0)
                {
                    bitMap[ta.i, ta.j] = 0;
                    return;

                }
            }
           // פנים המטריצה
             if (ta.i >= 1 && ta.i < bitMap.GetLength(0) && ta.j >= 1 && ta.j < bitMap.GetLength(1))
            {
                if (bitMap[ta.i + 1, ta.j] == 1)// דרום
                {

                    bitMap[ta.i, ta.j] = 0;
                    ta.i = ta.i + 1;
                    ta.j = ta.j;
                    spanningTree(ta, bitMap);
                }
                if (bitMap[ta.i + 1, ta.j + 1] == 1)// דרום מזרח
                {

                    bitMap[ta.i, ta.j] = 0;
                    ta.i = ta.i + 1;
                    ta.j = ta.j + 1;
                    spanningTree(ta, bitMap);
                }
                if (bitMap[ta.i, ta.j + 1] == 1)//מזרח
                {

                    bitMap[ta.i, ta.j] = 0;
                    ta.i = ta.i;
                    ta.j = ta.j + 1;
                    spanningTree(ta, bitMap);
                }
                if (bitMap[ta.i - 1, ta.j - 1] == 1)// צפון מערב
                {

                    bitMap[ta.i, ta.j] = 0;
                    ta.i = ta.i - 1;
                    ta.j = ta.j - 1;
                    spanningTree(ta, bitMap);
                }
                if (bitMap[ta.i - 1, ta.j] == 1)// צפון 
                {

                    bitMap[ta.i, ta.j] = 0;
                    ta.i = ta.i - 1;
                    ta.j = ta.j;
                    spanningTree(ta, bitMap);
                }
                if (bitMap[ta.i, ta.j - 1] == 1)// מערב 
                {

                    bitMap[ta.i, ta.j] = 0;
                    ta.i = ta.i;
                    ta.j = ta.j - 1;
                    spanningTree(ta, bitMap);
                }
                if (bitMap[ta.i + 1, ta.j - 1] == 1)// דרום-מערב 
                {

                    bitMap[ta.i, ta.j] = 0;
                    ta.i = ta.i + 1;
                    ta.j = ta.j - 1;
                    spanningTree(ta, bitMap);
                }
                if (bitMap[ta.i - 1, ta.j + 1] == 1)// צפון-מזרח 
                {

                    bitMap[ta.i, ta.j] = 0;
                    ta.i = ta.i - 1;
                    ta.j = ta.j + 1;
                    spanningTree(ta, bitMap);
                }
                if (bitMap[ta.i + 1, ta.j] == 0 && bitMap[ta.i + 1, ta.j + 1] == 0 && bitMap[ta.i, ta.j + 1] == 0 && bitMap[ta.i - 1, ta.j + 1] == 0 &&
                    bitMap[ta.i - 1, ta.j] == 0 && bitMap[ta.i - 1, ta.j - 1] == 0 && bitMap[ta.i, ta.j - 1] == 0 && bitMap[ta.i + 1, ta.j - 1] == 0)
                {//end
                    bitMap[ta.i, ta.j] = 0;
                    return;

                }
            }

        }

        public static void Main(string[] args)
        {

            Random rnd = new Random();
            int[,] bitMap = new int[5, 10];
            I_J currentTa;

            for (int i = 0; i < bitMap.GetLength(0); ++i)
            {
                for (int j = 0; j < bitMap.GetLength(1); ++j)
                {
                    bitMap[i, j] = rnd.Next(0, 2);
                    Console.Write(bitMap[i, j]);
                    Console.Write("  ");

                }
                Console.WriteLine(" ");
            }


            for (int i = 0; i < bitMap.GetLength(0); ++i)
            {
                for (int j = 0; j < bitMap.GetLength(1); ++j)
                {
                    if (bitMap[i, j] == 1)
                    {
                        currentTa = new I_J(i,j);
                        spanningTree(currentTa,  bitMap);
                        islandsCount++;
                    }
                }
            }
            Console.WriteLine(" islands size   " + islandsCount + "        ");
            Console.WriteLine(" ");
        }
    }
}

