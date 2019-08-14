using System;
using System.Text.RegularExpressions;

namespace LinkPhoneMails
{
    static class TextWorker
    {
        public static string[] GetMails(string source)
        {
            string pattern = @"[A-z0-9]+@[A-z0-9]+\.[A-z]{2,3}";

            MatchCollection matches = Regex.Matches(source, pattern);

            string[] result = new string[0];
            foreach (var item in matches)
            {
                Array.Resize(ref result, result.Length + 1);
                result[result.Length - 1] = item.ToString();
            }

            return result;
        }

        public static string[] GetPhoneNumbers(string source)
        {
            string pattern = @"\+{0,1}[0-9]{1}[-| |:]{0,1}[0-9]{3}[-| |:]{0,1}[0-9]{3}[-| |:]{0,1}[0-9]{2}[-| |:]{0,1}[0-9]{2}";

            MatchCollection matches = Regex.Matches(source, pattern);

            string[] result = new string[0];

            foreach (var item in matches)
            {
                Array.Resize(ref result, result.Length + 1);

                string temp = Regex.Replace(item.ToString(),
                    @"(?<1>\+{0,1}[0-9]{1})[-| |:]{0,1}(?<2>[0-9]{3})[-| |:]{0,1}(?<3>[0-9]{3})[-| |:]{0,1}(?<4>[0-9]{2})[-| |:]{0,1}(?<5>[0-9]{2})",
                    @"${1}-${2}-${3}-${4}-${5}");
                if (Regex.IsMatch(item.ToString(), @"\+"))
                {
                    int first = Convert.ToInt32(Regex.Match(temp, @"\d").ToString());
                    first++;
                    result[result.Length - 1] = Regex.Replace(temp, @"\+\d", first.ToString());//заменяю первую циферку на нужную
                }
                else result[result.Length - 1] = temp;
            }

            return result;
        }

        public static string[] GetLinks(string source)
        {
            string pattern = @"(http[s]{0,1}://){0,1}[A-z]+[\.]{0,1}[A-z0-9]+\.[a-z]{2,3}(/[A-z\+=%0-9\.-\?&]*)*";

            string[] result = new string[0];
            MatchCollection matches = Regex.Matches(source, pattern);

            foreach (var item in matches)
            {
                Array.Resize(ref result, result.Length + 1);
                result[result.Length - 1] = item.ToString();
            }

            return result;
        }
    }
}
