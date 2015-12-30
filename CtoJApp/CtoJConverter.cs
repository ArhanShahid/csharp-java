using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Text.RegularExpressions;


namespace CtoJApp
{
    public class CtoJConverter
    {
        string sourceFile;
        string resultFile;


        static bool StringIsNullOrEmpty(string s)
        {
            if (String.IsNullOrEmpty(s))
                return true;
            else
                return false;
        }
        public Dictionary<string, string> readRulesFile()
        {
            Dictionary<string, string> rulesDictionary = new Dictionary<string, string>();

            string[] rules = File.ReadAllLines("rules.txt");
            foreach (var rule in rules)
            {
                if (!rule.Contains("///") && !StringIsNullOrEmpty(rule))
                {
                    string[] singleRule = rule.Split(new string[] { ":::" }, StringSplitOptions.None);
                    rulesDictionary.Add(singleRule[0].Trim(), singleRule[1].Trim());
                }
            }
            return rulesDictionary;
        }
        public void convertPassOne(string inputFile, Dictionary<string, string> rulesDictionary)
        {
            int i = 1;
            string input = inputFile;
            string output;
            foreach (var pair in rulesDictionary)
            {
                string pattern = String.Format(@"\b{0}\b", pair.Key);
                string replace = pair.Value;
                output = Regex.Replace(input, pattern, replace);
                input = output;
                if (i == rulesDictionary.Count)
                {

                    convertPassTwo(output);
                               
                }

                i++;
            }

        }


        public void convertPassTwo(string file)
        {

            File.WriteAllText("temp.txt", file);
            string[] tempArray = File.ReadAllLines("temp.txt");
            File.Delete("temp.txt");

            for (int i = 0; i < tempArray.Length; i++)
            {
                if (tempArray[i].Contains("//"))
                {
                    tempArray[i] = "";
                }
            }

            tempArray = removeEmptyIndex(tempArray);

            if (tempArray[0] == "{" && tempArray[(tempArray.Length - 1)] == "}")
            {
                tempArray[0] = "";
                tempArray[(tempArray.Length - 1)] = "";
            }

            tempArray = removeEmptyIndex(tempArray);

            for (int i = 0; i <  tempArray.Length; i++)
            {
                if (tempArray[i].Contains("class"))
                {
                    tempArray[i] = "public class main";
                }
                if (tempArray[i].Contains("Main"))
                {
                     tempArray[i] = "public static void main(String[] args)";
                }
                
            }

            File.WriteAllLines("temp.txt", tempArray);
            string tempText = File.ReadAllText("temp.txt");
            File.Delete("temp.txt");
            resultFile = tempText;
        }


        public string[] removeEmptyIndex(string[] arr)
        {
            List<string> remove = arr.OfType<string>().ToList(); ;
            remove.RemoveAll(str => String.IsNullOrEmpty(str));
            return remove.ToArray();
        }

        public void saveFile(string resultFile)
        {
            File.WriteAllText("output.java", resultFile);
        }

        public void setSourceFile(string sourceFile)
        {
            this.sourceFile = sourceFile;
        }
        public string getSourceFile()
        {
            return sourceFile;
        }
        public void setResultFile(string resultFile)
        {
            this.resultFile = resultFile;
        }
        public string getResultFile()
        {
            return resultFile;
        }

    }
}
