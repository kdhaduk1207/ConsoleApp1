using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class UtilityDtl : IInteface1
    {

        const int percentage = 6;

        System.IO.DirectoryInfo directory1 = new System.IO.DirectoryInfo("D:\\test1");

        System.IO.DirectoryInfo directory2 = new System.IO.DirectoryInfo("D:\\test2");
        public static decimal CalculateEmpSalaryHike(decimal currentSalary)
        {
            return currentSalary + (currentSalary * percentage) / 100;
        }

        public void getData(int a)
        {
            Console.WriteLine($"Inteface 1-{a}");
        }

        //void IInteface2.getData(int a)
        //{
        //    Console.WriteLine($"Inteface 2-{a}");
        //}
    }

    public interface IInteface1
    {
        void getData(int a);
    }

    public interface IInteface2
    {
        void getData(int a);
    }



}
