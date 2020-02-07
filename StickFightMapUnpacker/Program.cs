using LevelEditor;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace fxco
{
    class Program
    {
        //SFMU.exe <input> <output>
        static void Main(string[] args) 
        {
            if (args.Length != 2) {
                Console.WriteLine("Use SFMU like so:");
                Console.WriteLine("To unpack: sfmu.exe <path to .bin input file> <path to .json output file>");
                Console.WriteLine("  To pack: sfmu.exe <path to .json input file> <path to .bin output file>");
            }
            if (args[0].EndsWith(".json") && args[1].EndsWith(".bin"))
            {
                reserializer(args[0], args[1]);
                Console.WriteLine("Done!");
            }
            else if (args[0].EndsWith(".bin") && args[1].EndsWith(".json"))
            {
                deserializer(args[0], args[1]);
                Console.WriteLine("Done!");
            }
            else {
                Console.WriteLine("Use SFMU like so:");
                Console.WriteLine("To unpack: sfmu.exe <path to .bin input file> <path to .json output file>");
                Console.WriteLine("  To pack: sfmu.exe <path to .json input file> <path to .bin output file>");
            }
        }
        static void reserializer(string input, string output) //Should be: reserializer(path to .json, path to .bin)
        {
            IFormatter formatter = new BinaryFormatter();
            string text = System.IO.File.ReadAllText(input);
            Stream stream = new FileStream(output, FileMode.Create, FileAccess.Write, FileShare.None);
            CustomLevel binOutput = JsonConvert.DeserializeObject<CustomLevel>(text);
            formatter.Serialize(stream, binOutput);
            stream.Close();
        }
        static void deserializer(string input, string output) //Should be: deserializer(path to .bin, path to .json)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(input, FileMode.Open, FileAccess.Read, FileShare.None);
            object result2 = formatter.Deserialize(stream);
            stream.Close();
            string jsonOutput = JsonConvert.SerializeObject(result2);
            System.IO.File.WriteAllText(output, jsonOutput);
        }
    }
}
