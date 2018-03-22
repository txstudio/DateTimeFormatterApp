using Newtonsoft.Json;
using System;
using System.Globalization;

namespace DateTimeFormatterApp
{
    class Program
    {
        const string culture_name = "en-us";

        static void Main(string[] args)
        {
            /*
             * 這是一個將日期進行轉換的範例應用程式
             */

            var _format = string.Empty;
            var _current = DateTime.Now;
            var _result = _current;

            var _cultureInfo = new CultureInfo(culture_name);
            var _dateTimeStyle = DateTimeStyles.AllowWhiteSpaces;

            string _out1;
            string _out2;
            string _out3;
            string _out4;

            Console.WriteLine(JsonConvert.SerializeObject(_current));


            //將日期轉換成指定格式文字
            Console.WriteLine("Parse DateTime to string");
            Console.WriteLine();

            _format = "yyyy/MM/dd HH:mm:ss";
            _out1 = _current.ToString(_format);
            Display(_format, _out1);

            _format = "yyyy/MM/dd";
            _out2 = _current.ToString(_format);
            Display(_format, _out2);

            _format = "yyyy-MM-dd";
            _out3 = _current.ToString(_format);
            Display(_format, _out3);

            _format = "MMM/dd/yyyy";
            _out4 = _current.ToString(_format, _cultureInfo);
            Display(_format, _out4);

            //將指定格式文字轉換成日期
            Console.WriteLine("Parse string to DateTime");
            Console.WriteLine();

            _format = "yyyy/MM/dd HH:mm:ss";
            if (DateTime.TryParseExact(_out1
                                        , _format
                                        , _cultureInfo
                                        , _dateTimeStyle
                                        , out _result) == true)
            {
                Display(_out1, _result);
            }

            _format = "yyyy/MM/dd";
            if (DateTime.TryParseExact(_out2
                                        , _format
                                        , _cultureInfo
                                        , _dateTimeStyle
                                        , out _result) == true)
            {
                Display(_out2, _result);
            }

            _format = "yyyy-MM-dd";
            if (DateTime.TryParseExact(_out3
                                        , _format
                                        , _cultureInfo
                                        , _dateTimeStyle
                                        , out _result) == true)
            {
                Display(_out3, _result);
            }

            _format = "MMM/dd/yyyy";
            if (DateTime.TryParseExact(_out4
                                        , _format
                                        , _cultureInfo
                                        , _dateTimeStyle
                                        , out _result) == true)
            {
                Display(_out4, _result);
            }

            Console.WriteLine("press any key to exit");
            Console.ReadKey();
        }

        static void Display(string format, string result)
        {
            Console.WriteLine("format\t{0}", format);
            Console.WriteLine("out\t{0}", result);
            Console.WriteLine();
        }

        static void Display(string input, DateTime result)
        {
            Console.WriteLine("input\t{0}", input);
            Console.WriteLine("out\t{0}", JsonConvert.SerializeObject(result));
            Console.WriteLine();
        }
    }
}
