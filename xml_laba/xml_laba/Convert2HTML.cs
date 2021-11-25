using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace xml_laba
{
     static class Convert2HTML
    {

        public static void BuildHtml(DataGridView table, string path)
        {
            
            string result = string.Empty;
            result += "<!DOCTYPE HTML>\n<html>\n<style>table, th, td {border:1px solid black;}</style>\n<body>\n<table>\n";
            result += "<tr>\n";

            foreach (DataGridViewColumn header in table.Columns)
            {
                result += ("<th>" + header.HeaderText + "</th>\n");
            }
            result += "</tr>\n";
            foreach (DataGridViewRow row in table.Rows)
            {
                result += "<tr>\n";
                foreach (DataGridViewCell cell in row.Cells)
                {
                    result += ("<td>" + cell.Value + "</td>\n");
                }
                result += "</tr>\n";
            }
            result += "</table>\n</body>\n</html>";

            File.WriteAllText(path, result);
            
        }
    }
}
