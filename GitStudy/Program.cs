﻿namespace GitStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("이름을 입력해주세요! : ");
            
            var input = Console.ReadLine();
            Console.WriteLine("입력하신 이름은 {0} 입니다", input);

        }
    }
}
