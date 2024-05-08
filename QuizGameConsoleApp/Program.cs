using System.IO;

string[] text = File.ReadAllLines("questions.txt");

for (int i = 0; i < text.Length; i++)
{
    Console.WriteLine(text[i]);
}