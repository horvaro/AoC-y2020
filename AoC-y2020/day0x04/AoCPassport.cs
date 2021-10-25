using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day0x04
{
    class AoCPassport
    {
        public int Byr { get; set; }
        public int Iyr { get; set; }
        public int Eyr { get; set; }
        public string Hgt { get; set; }
        public string Hcl { get; set; }
        public string Ecl { get; set; }
        public string Pid { get; set; }
        public int Cid { get; set; }

        public AoCPassport(string rawPassport)
        {
            var kvPairs = rawPassport.Split(' ');

            foreach(var kvPair in kvPairs)
            {
                if (!kvPair.Contains(':'))
                {
                    continue;
                }

                var kv = kvPair.Split(':');

                if(kv.Length != 2)
                {
                    Console.WriteLine($"bad kvpair: {kvPair}");
                    continue;
                }

                var key = kv[0].ToLower();
                var value = kv[1];

                switch (key)
                {
                    case "byr":
                        Byr = StrToInt(value);
                        break;
                    case "iyr":
                        Iyr = StrToInt(value);
                        break;
                    case "eyr":
                        Eyr = StrToInt(value);
                        break;
                    case "hgt":
                        Hgt = value;
                        break;
                    case "hcl":
                        Hcl = value;
                        break;
                    case "ecl":
                        Ecl = value;
                        break;
                    case "pid":
                        Pid = value;
                        break;
                    case "cid":
                        Cid = StrToInt(value);
                        break;
                    default:
                        break;
                }
            }
        }

        public bool IsValid()
        {
            return Byr > 0 && Iyr > 0 && Eyr > 0 && !string.IsNullOrWhiteSpace(Hgt) &&
                !string.IsNullOrWhiteSpace(Hcl) &&
                !string.IsNullOrWhiteSpace(Ecl) &&
                !string.IsNullOrWhiteSpace(Pid);
        }

        private static int StrToInt(string input)
        {
            int ret;
            try
            {
                var result = Int32.TryParse(input, out ret);
            }
            catch (Exception)
            {
                ret = 0;
            }
            return ret;
        }
    }
}
