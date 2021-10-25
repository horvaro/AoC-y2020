using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public bool IsRealyValid()
        {
            return IsByrValid() &&
                IsIyrValid() &&
                IsEyrValid() &&
                IsHgtValid() &&
                IsHclValid() &&
                IsEclValid() &&
                IsPidValid() &&
                IsCidValid();
        }

        private bool IsByrValid()
        {
            return Byr <= 2002 && Byr >= 1920;
        }

        private bool IsIyrValid()
        {
            return Iyr <= 2020 && Iyr >= 2010;
        }

        private bool IsEyrValid()
        {
            return Eyr <= 2030 && Eyr >= 2020;
        }

        private bool IsHgtValid()
        {
            if (string.IsNullOrWhiteSpace(Hgt)) return false;

            var unit = Hgt[^2..];
            var value = StrToInt(Hgt[..^2]);

            return unit switch
            {
                "cm" => value <= 193 && value >= 150,
                "in" => value <= 76 && value >= 59,
                _ => false,
            };
        }

        private bool IsHclValid()
        {
            if (string.IsNullOrWhiteSpace(Hcl)) return false;

            var pat = "#[a-f0-9]{6}$";
            var regex = new Regex(pat);
            var match = regex.Match(Hcl);

            return match.Success;
        }

        private bool IsEclValid()
        {
            if (string.IsNullOrWhiteSpace(Ecl)) return false;

            var pat = "amb|blu|brn|gry|grn|hzl|oth";
            var regex = new Regex(pat);
            var match = regex.Match(Ecl);

            return match.Success;
        }

        private bool IsPidValid()
        {
            if (string.IsNullOrWhiteSpace(Pid)) return false;

            var pat = "^[0-9]{9}$";
            var regex = new Regex(pat);
            var match = regex.Match(Pid);

            return match.Success;
        }

        private bool IsCidValid()
        {
            return true;
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
