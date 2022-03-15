using System;

namespace newmethod
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*
             * int tipindən bir array olur içində müsbət və mənfi ədədlər olur 
             * elə bir method yazın ki, bu array-i parametr olaraq qəbul etsin 
             * və qəbul etdiyi array-in əvvəlcədən assign olunması məcburi olsun 
             * daha sonra içindəki mənfi ədədləri müsbətə çevirib 
             * həmin array-i geriyə qaytarsın
             */
            int[] numArr = { 12, 2321, 321, -3, -2 };
            int[] newNumArr = numbers(ref numArr);
            foreach (var item in newNumArr)
            {
                Console.WriteLine(item);
            }

          

        }

        static int[] numbers(ref int[] num)
        {

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] < 0)
                {
                    num[i] *= -1;
                }
            }

            return num;
              


        } 
    }
}
