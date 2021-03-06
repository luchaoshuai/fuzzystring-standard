﻿using System;
using System.Collections.Generic;
using FuzzyString;

namespace FuzzyStringConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string kevin = "kevin";
            string kevyn = "kevyn";

            var options = new FuzzyStringComparisonOptions[]
            {
                FuzzyStringComparisonOptions.UseJaccardDistance,
                FuzzyStringComparisonOptions.UseNormalizedLevenshteinDistance,
                FuzzyStringComparisonOptions.UseOverlapCoefficient,
                FuzzyStringComparisonOptions.UseLongestCommonSubsequence,
                FuzzyStringComparisonOptions.CaseSensitive
            };

            Console.WriteLine(kevin.ApproximatelyEquals(kevyn, FuzzyStringComparisonTolerance.Weak, options));
            Console.WriteLine(kevin.ApproximatelyEquals(kevyn, FuzzyStringComparisonTolerance.Normal, options));
            Console.WriteLine(kevin.ApproximatelyEquals(kevyn, FuzzyStringComparisonTolerance.Strong, options));

            Console.ReadLine();
        }
    }
}