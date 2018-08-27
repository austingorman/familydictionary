using System;
using System.Collections.Generic;

namespace family_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>(){
                {"name", "Brenna"},
                {"age", "26"}
            });

            myFamily.Add("Mom", new Dictionary<string, string>(){
                {"name", "Barbie"},
                {"age", "54"}
            });

            myFamily.Add("Wife", new Dictionary<string, string>(){
                {"name", "Anna"},
                {"age", "26"}
            });

            foreach (KeyValuePair<string, Dictionary<string, string>> familyMember in myFamily)
            {
                Console.WriteLine($"{familyMember.Value["name"]} is my {familyMember.Key} and is {familyMember.Value["age"]} years old");
            }
        }
    }
}
