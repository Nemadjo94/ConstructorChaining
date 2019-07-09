using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChaining
{
    //U ovom primeru je odlicno objasnjen pojam chainovanja constructora
    //Npr ocekujemo od korisnika da prosledi direktorijum konstruktoru
    //Korisnik ne zna koji direktorijum da prosledi i dodeljuje se default direktorijum
    //
    class ConstructorChaining
    {
        private string baseDir;
        private static readonly string defaultDir = @"C:\Program Files (x86)\Default\";

        public string BaseDir { get; set; }
        public static string DefaultDir { get => defaultDir; }

        public ConstructorChaining(): this(null)
        {

        }

        public ConstructorChaining(string baseDir) : this(baseDir, DefaultDir)
        {

        }

        public ConstructorChaining(string baseDir, string defaultDir)
        {
            BaseDir = baseDir ?? defaultDir;
        }

        internal void Dump()
        {
            if (BaseDir != null)
                Console.WriteLine($"Dumping in: {BaseDir}");
            else
                Console.WriteLine($"Dumping in: {DefaultDir}");
        }
    }
}
