using System;
using System.Text;

//Write a program that encodes and decodes a string using given encryption key (cipher).
//The key consists of a sequence of characters.
//The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, 
//the second – with the second, etc. When the last key character is reached, the next is the first.

class EncodeDecode
{
    static void Main()
    {
        Console.WriteLine("Program that encodes and decodes a string using given encryption key (cipher).\n");

        Console.Write("Enter a message: ");
        string message = Console.ReadLine();
        Console.Write("Enter a key: ");
        string key = Console.ReadLine();

        string cryptedMess = CryptingingMessage(message, key).ToString();

        Console.WriteLine("Crypted message: {0} ", cryptedMess);

        string encryptedMess = CryptingingMessage(cryptedMess, key).ToString();

        Console.WriteLine("Encrypted message: {0} ", encryptedMess);

        Console.ReadLine();
    }

    static StringBuilder CryptingingMessage(string message, string key)
    {
        StringBuilder builder = new StringBuilder();

        for (int index = 0; index < message.Length; index++)
        {
            builder.Append((char)(message[index] ^ key[index % key.Length]));
        }

        return builder;
    }
}
