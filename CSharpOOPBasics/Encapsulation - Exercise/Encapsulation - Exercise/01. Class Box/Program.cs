﻿using System;

namespace _01.Class_Box
{
    public class Program
    {
        public static void Main()
        {
            var l = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
           
            var box = new Box(l, w, h);
            Console.WriteLine($"Surface Area - {box.SurfaceArea():F2}");
            Console.WriteLine($"Lateral Surface Area - {box.LateralSurfaceArea():F2}");
            Console.WriteLine($"Volume - {box.Volume():F2}");
        }
    }
}
