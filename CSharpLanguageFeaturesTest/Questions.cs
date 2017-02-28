﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpLanguageFeaturesTest
{
    /// <summary>
    /// INSTRUCTIONS:
    /// 
    /// Follow the directions in the docstring for each question. Do not change the method signature
    /// in any way, including the output type. You may run the provided unit tests in Answers.cs to
    /// check your progress. If you need to create any additional classes, make sure that they are public
    /// and are defined inside the CSharpLanguageFeaturesTest namespace. You may include any private helper
    /// methods you like in Questions.cs.
    /// </summary>
    public static class Questions
    {
        /// <summary>
        /// STRINGS
        /// 
        /// Convert the given string into Title Case. I.e., the first letter of each word
        /// is uppercase, and all other letters are lowercase. Words are separated by spaces.
        /// Punctuation and other whitespace characters do not constitute word boundaries.
        /// </summary>
        public static string Question1(string input)
        {
            
            throw new NotImplementedException(); 
        }

        /// <summary>
        /// STRINGS & COLLECTIONS
        /// 
        /// Sort the given list of strings by the number of A's ("a" or "A") it contains,
        /// ascending. Don't worry about breaking ties.
        /// </summary>
        public static List<string> Question2(List<string> input)
        {
           
            throw new NotImplementedException();
        }

        /// <summary>
        /// CLASSES
        /// 
        /// Create a new class with three public getter/setter properties named First,
        /// Second, and Third. First should be of type int. Second should be of type string.
        /// Third should have a private setter.
        /// 
        /// In the question method, instantiate this class and return the instantiated object.
        /// </summary>
        /// 

        public class GetNumbers
        {
            public int First { get; set; }
            public string Second { get; set; }
            private int Third { get; set; }
        }

        public static object Question3()
        {
            GetNumbers getNumbers = new GetNumbers();
           // getNumbers.First = 15;
           // getNumbers.Second = "Hello!";
            return getNumbers;
            throw new NotImplementedException();
        }

        
        /// <summary>
        /// CLASSES & INHERITANCE
        /// 
        /// Create a subclass of the class from Question3(). The subclass should have a
        /// parameterless constructor that sets the value of First to 7, and it should have
        /// a method named GetFirstPlusParam() that takes one integer parameter and returns
        /// the value of First plus the value of that parameter.
        /// 
        /// In the question method, instantiate this class and return the instantiated object.
        /// </summary>
        /// 
        public class MyClass: GetNumbers
        {
            public int setFirst;            

            public int GetFirstPlusParam()
            {
                First = 7;
                return First + setFirst;
            }
        }

        public static object Question4()
        {
            MyClass myClass = new MyClass();
            myClass.GetFirstPlusParam();
            
            throw new NotImplementedException();
        }

        /// <summary>
        /// DATETIMES & NULLABLE TYPES & ERROR-HANDLING
        /// 
        /// Given two DateTimes, take whichever DateTime comes later in its respective calendar year
        /// and return a DateTime representing the day after that date, at 3:00 p.m.
        /// 
        /// If the return value would fall out of the possible range of DateTime values, return null.
        /// </summary>
        public static DateTime? Question5(DateTime d1, DateTime d2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// MATH & TYPE CONVERSION
        /// 
        /// Given two integers, return the cubed root of the first integer raised to the power of the second integer.
        /// The answer should not be rounded.
        /// </summary>
        public static double Question6(int i1, int i2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// COLLECTION SEARCH
        /// 
        /// Given a list of integer, return the largest odd integer. If there are no odd
        /// integers in the input list, return the smallest possible int.
        /// </summary>
        public static int Question7(List<int> ints)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// EXTRA CREDIT - ALGORITHM DESIGN
        /// 
        /// Given a list of strings, return all sets of anagrams (a set of words that
        /// contain the same letters in a different order) as lists of strings.
        /// 
        /// Do not allow words to be an anagram of themselves, even if repeated in the
        /// input list. Ignore case. The tests will be case-insensitive and will not
        /// include non-alpha characters. Sort each anagram set in alphabetical order,
        /// and sort the list of anagram sets in alphabetical order, based on the first
        /// word of each set.
        /// </summary>
        public static List<List<string>> Question8(List<string> words)
        {
            throw new NotImplementedException();
        }
    }
}
