using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xml_laba
{
    public partial class Pensia : Form
    {
        private string path;
        private readonly string pathXsl = @"XSL.xsl";
        private readonly string pathHtml = @"HTML.html";
        private bool istoHtmlPressed = false;
        bool isNew;

        public Pensia()
        {
            InitializeComponent();
        }

        private void pension_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void name_CheckedChanged(object sender, EventArgs e)
        {
            if (name.Checked == true) 
            {
                Global.ActiveFilter.Add("name", null);
            }
            else
            {
                Global.ActiveFilter.Remove("name");
            }
        }

        private void faculty_CheckedChanged(object sender, EventArgs e)
        {
            if (faculty.Checked == true)
            {
                Global.ActiveFilter.Add("faculty", null);
            }
            else
            {
                Global.ActiveFilter.Remove("faculty");
            }
        }

        private void catedra_CheckedChanged(object sender, EventArgs e)
        {
            if (catedra.Checked == true)
            {
                Global.ActiveFilter.Add("catedra", null);
            }
            else
            {
                Global.ActiveFilter.Remove("catedra");
            }
        }

        private void date_CheckedChanged(object sender, EventArgs e)
        {
            if (date.Checked == true)
            {
                Global.ActiveFilter.Add("date", null);
            }
            else
            {
                Global.ActiveFilter.Remove("date");
            }
        } 
        private void degree_CheckedChanged(object sender, EventArgs e)
        {
            if (degree.Checked == true)
            {
                Global.ActiveFilter.Add("degree", null);
            }
            else
            {
                Global.ActiveFilter.Remove("degree");
            }
        }

        private void sex_CheckedChanged(object sender, EventArgs e)
        {
            if (sex.Checked == true)
            {
                Global.ActiveFilter.Add("sex", null);
            }
            else
            {
                Global.ActiveFilter.Remove("sex");
            }
        }

 
        private void SAX_CheckedChanged(object sender, EventArgs e)
        {
            Global.ParsingStrategy = new SAX();
        }

        private void DOM_CheckedChanged(object sender, EventArgs e)
        {
            Global.ParsingStrategy = new DOMstrategy();
        }

        private void LINQ_CheckedChanged(object sender, EventArgs e)
        {
            Global.ParsingStrategy = new LinqToXML();
        }

        private void search_Click(object sender, EventArgs e)
        {
            var filterData = new List<Person>();
            if (Global.ActiveFilter.TryGetValue("name", out var name))
            {
                foreach (var person in Global.FileData)
                {
                    if (person.Name == name) filterData.Add(person);
                }
            }

            if (Global.ActiveFilter.TryGetValue("department", out var department))
            {
                foreach (var person in Global.FileData)
                {
                    if (person.Department == department) filterData.Add(person);
                }
            }

            if (Global.ActiveFilter.TryGetValue("catedra", out var catedra))
            {
                foreach (var person in Global.FileData)
                {
                    if (person.Catedra == catedra) filterData.Add(person);
                }
            }

            if (Global.ActiveFilter.TryGetValue("date", out var date))
            {
                foreach (var person in Global.FileData)
                {
                    if (person.Date == date) filterData.Add(person);
                }
            }

            if (Global.ActiveFilter.TryGetValue("degree", out var degree))
            {
                foreach (var person in Global.FileData)
                {
                    if (person.Degree == degree) filterData.Add(person);
                }
            }

            if (Global.ActiveFilter.TryGetValue("sex", out var sex))
            {
                foreach (var person in Global.FileData)
                {
                    if (person.Sex == sex) filterData.Add(person);
                }
            }

            if (filterData.Count == 0)
            {
                outData(Global.FileData);
            }
            else
                outData(filterData);
        }

        private void convert_Click(object sender, EventArgs e)
        {
            if
                (
           save.ShowDialog() == DialogResult.Cancel
                )
                return;
            Convert2HTML.BuildHtml(pension, save.FileName);
        }

        private void open_Click(object sender, EventArgs e)
        {
            if
                (
            openXMLfile.ShowDialog() == DialogResult.Cancel
                )
                return;
            Global.ParsingStrategy.Parse(openXMLfile.FileName);

            outData(Global.FileData);

            var allnames = new List<string>();
            var alldepartments = new List<string>();
            var allcatedras = new List<string>();
            var alldatas = new List<string>();
            var alldegrees = new List<string>();
            var allsexes = new List<string>();

            foreach
             (
             var person in Global.FileData
             )
            {
                allnames.Add(person.Name);
                alldepartments.Add(person.Department);
                allcatedras.Add(person.Catedra);
                alldatas.Add(person.Date);
                alldegrees.Add(person.Degree);
                allsexes.Add(person.Sex);
            }
            namebox.DataSource = allnames;
            facultybox.DataSource = alldepartments;
            catedrabox.DataSource = allcatedras;
            databox.DataSource = alldatas;
            degreebox.DataSource = alldegrees;
            sexbox.DataSource = allsexes;
        }
        private void outData(List<Person> data)
        {
            pension.Columns.Clear();
            pension.Rows.Clear();
            foreach
               (
               var columnName in Global.Field
               )
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.HeaderCell.Value = columnName;
                pension.Columns.Add(column);
            }
            foreach
                (
                var person in data
                )
            {
                pension.Rows.Add(new DataGridViewRow());

                pension.Rows[pension.RowCount - 1].Cells[0].Value = person.Name;
                pension.Rows[pension.RowCount - 1].Cells[1].Value = person.Department;
                pension.Rows[pension.RowCount - 1].Cells[2].Value = person.Catedra;
                pension.Rows[pension.RowCount - 1].Cells[3].Value = person.Date;
                pension.Rows[pension.RowCount - 1].Cells[4].Value = person.Degree;
                pension.Rows[pension.RowCount - 1].Cells[5].Value = person.Sex;

            }
        }

        

        //private void Namebox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    Global.ActiveFilter["name"] = namebox.SelectedItem.ToString();
        //}

        //private void facultybox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    Global.ActiveFilter["department"] = facultybox.SelectedItem.ToString();
        //}

        //private void catedrabox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    Global.ActiveFilter["catedra"] = catedrabox.SelectedItem.ToString();
        //}

        //private void databox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    Global.ActiveFilter["data"] = databox.SelectedItem.ToString();
        //}

        //private void degreebox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (degree.Checked == true)
        //        Global.ActiveFilter["degree"] = degreebox.SelectedItem.ToString();
        //}

        //private void sexbox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (degree.Checked == true)
        //        Global.ActiveFilter["sex"] = sexbox.SelectedItem.ToString();
        //}
        private void namebox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (name.Checked == true)
                Global.ActiveFilter["name"] = namebox.SelectedItem.ToString();
        }
        private void facultybox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (faculty.Checked == true)
                Global.ActiveFilter["faculty"] = facultybox.SelectedItem.ToString();
        }

        private void catedrabox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (catedra.Checked == true)
                Global.ActiveFilter["catedra"] = catedrabox.SelectedItem.ToString();
        }

        private void databox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (date.Checked == true)
                Global.ActiveFilter["date"] = databox.SelectedItem.ToString();
        }

        private void degreebox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (degree.Checked == true)
                Global.ActiveFilter["degree"] = degreebox.SelectedItem.ToString();
        }

        private void sexbox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sex.Checked == true)
                Global.ActiveFilter["sex"] = sexbox.SelectedItem.ToString();
        }
    }
}
