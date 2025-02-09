﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace Crayon.ConsoleApp
{
    static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Output.Green($"green {Output.Red($"{Output.Bold("bold")} red")} green"));
            Console.WriteLine("normal");
            Console.WriteLine(Output.BrightBlue($"Bright {Output.Green("and normal green")}"));

            Console.WriteLine(Output.Green(
                $"The difference {Output.Bold("between bold")}, {Output.BrightGreen("bright green")} and {Output.Dim("dim")}"));

            Console.WriteLine(Output.Green().Bold().Underline().Reversed().Text("hoi!"));

            Console.WriteLine(
                Output.Bold().Green().Text($"starting green {Output.Red("then red")} must be green again"));

            Console.WriteLine(Output.FromRgb(55, 115, 155).Text("from rgb!"));

            var rainbow = new Rainbow(0.5);
            for (var i = 0; i < 15; i++)
            {
                Console.WriteLine(rainbow.Next().Bold().Text("rainbow"));
            }
        }
    }
}