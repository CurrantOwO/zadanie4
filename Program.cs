using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            string a = "0123456789qwertyuiopasdfghjklzxcvbnm0123456789QWERTYUIOPASDFGHJKLZXCVBNM0123456789"; //база для создания рандомных элементов
            string num = "0123456789";
            string zag = "QWERTYUIOPASDFGHJKLZXCVBNM";
            int ir = 0;
            var one = new List<char>();
            for(int i = 0; i < 15; i++) {
                one.Add(a[ran.Next(0, a.Length)]);
            }
            Console.WriteLine();
            var Z = new List<char>();
            for (int l = 0; l < 15; l++) //заглавные буквы
            {
                for(int i = 0;  i < zag.Length; i++) {
                    if(one[l] == zag[i]) { Z.Add(one[l]); ir++; } 
                }
            }
            for (int i = 0; i < ir; i++) {
                Console.Write(Z[i] + "\t");
            }
            for (int l = 0; l < 15; l++) //удаляем не числа
            {
                int o = 0;
                for (int i = 0; i < num.Length; i++){
                    if (one[l] == num[i]) { o++; }
                }
                if (o == 0) { one.RemoveAt(l); }
            }
        }
    }
}
