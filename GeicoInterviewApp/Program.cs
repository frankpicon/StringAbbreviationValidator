// See https://aka.ms/new-console-template for more information
using System.Numerics;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;


Console.WriteLine("data:foobar abbr:f2b2 is Abbreviation = " + StringAbbreviation.isMatchAbbr("foobar", "f2b2"));
Console.WriteLine("data:picon abbr:p3n is Abbreviation = " + StringAbbreviation.isMatchAbbr("picon", "p3n"));
Console.WriteLine("data:foobare abbr:f2b3 is Abbreviation = " + StringAbbreviation.isMatchAbbr("foobare", "f2b3"));
Console.WriteLine("data:foobar abbr:g2d3 is Abbreviation = " + StringAbbreviation.isMatchAbbr("foobar", "g2d3"));
Console.WriteLine("data:test abbr:t2t is Abbreviation = " + StringAbbreviation.isMatchAbbr("test", "t2t"));
Console.WriteLine("data:test abbr:t02t is Abbreviation = " + StringAbbreviation.isMatchAbbr("test", "t02t"));


/*
Following Test Cases are : 
1) "foobar" abbr "f2b2"
2) "picon"  abbr "p3n"
3) "foobare" abbr "f2b3"
4) "foobar" abbr "g2d3"

A string can be abbreviated by replacing any number of non-adjacent, 
non-empty substrings with their length. The length should not have leading zeros.
Give a string word and abbr , return whether the string matches the given abbreviation. 

For example
Word = “test” , abbr =”t2t”         returns true
Word = “test” , abbr =”t02t”         returns false
*/



public sealed class StringAbbreviation
{

    private StringAbbreviation() { }

    private static readonly Lazy<StringAbbreviation> _lazy = new Lazy<StringAbbreviation>(() => new StringAbbreviation());

    public static StringAbbreviation instance => _lazy.Value;
    
    public static bool isMatchAbbr(string data, string abbr)
    {
        List<int> nonAdjacentCounts = new List<int>();
        int dataLen = data.Length; 
        int abbrLen = abbr.Length;        
        int dataIndex = 0;
        int abbrIndex = 0; 
        
        while (abbrIndex < abbrLen && dataIndex < dataLen)
        {
            if (isCharMatch(abbr[abbrIndex], data[dataIndex]))
            {
                abbrIndex++;
                dataIndex++;
                continue;
            }

            if (int.TryParse(abbr[abbrIndex].ToString(), out int numAdjacent))
            {
                if (numAdjacent == 0) return false;
                dataIndex += numAdjacent;
                abbrIndex++;

                if (abbrIndex < abbrLen && dataIndex < dataLen)
                {
                    if (isCharMatch(abbr[abbrIndex] , data[dataIndex]))
                    {
                        abbrIndex++;
                        dataIndex++;
                        continue;
                    }
                }
            }
            else return false;
        }
        return dataLen == dataIndex && abbrIndex == abbrLen;
    }

    public static bool isCharMatch(char data, char abbr ) {

        if (abbr == data) return true;
        else return false;

    }
}



