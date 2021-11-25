using System;
using System.Collections.Generic;
using System.Text;

namespace xml_laba
{
    class Global
    {
        public static List< Person> FileData = new List<Person>();
        public static Strategy ParsingStrategy;
        public static string[] Field = { "name", "department", "catedra", "date", "degree","sex" };
        public static Dictionary<string, string> ActiveFilter = new Dictionary<string, string>();

    }
}
