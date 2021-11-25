using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Xml;

namespace xml_laba
{
    interface Strategy
    {
        public abstract void Parse(string path);
    }
    class LinqToXML : Strategy
    {
        public void Parse(string path)
        {
            try
            {
                XDocument file = XDocument.Load(path);
                var peopleEnum = from person in file.Descendants("professor")
                                   select new Person
                                   {
                                       Name = person.Element("name").Value,
                                       Department = person.Element("department").Value,
                                       Catedra = person.Element("catedra").Value,
                                       Sex = person.Element("sex").Value,
                                       Date = person.Element("date").Value,
                                       Degree = person.Element("degree").Value
                                   };
                Global.FileData = peopleEnum.ToList();
            }
            catch
            {
                MessageBox.Show("ERROR");
                return;
            }
        }
    }

    class SAX : Strategy
    {
        public void Parse(string path)
        {
            try
            {
                List<Person> personList = new List<Person>();
                string name = string.Empty;
                string department = string.Empty;
                string catedra = string.Empty;
                string date = string.Empty;
                string degree = string.Empty;
                string sex = string.Empty;

                string element = string.Empty;

                XmlReader file = XmlReader.Create(path);
                while (file.Read())
                {
                    if (file.NodeType == XmlNodeType.Element)
                    {
                        element = file.Name;
                    }
                    else if (file.NodeType == XmlNodeType.Text)
                    {
                        switch (element)
                        {
                            case "department":
                                department = file.Value;
                                break;
                            case "name":
                                name = file.Value;
                                break;
                            case "catedra":
                                catedra = file.Value;
                                break;
                            case "date":
                                date = file.Value;
                                break;
                            case "degree":
                                degree = file.Value;
                                break;
                            case "sex":
                                sex = file.Value;
                                break;
                        }
                    }
                    else if ((file.NodeType == XmlNodeType.EndElement)
                            && (file.Name == "professor"))
                    {
                        personList.Add(new Person
                        {
                            Name = name,
                            Department = department,
                            Catedra = catedra,
                            Date = date,
                            Degree = degree,
                            Sex = sex
                        });
                    }
                }
                Global.FileData = personList;
            }
            catch
            {
                MessageBox.Show("ERROR");
                return;
            }
        }
    }
    class DOMstrategy : Strategy
    {
        public void Parse(string path)
        {
            try
            {
                List<Person> personList = new List<Person>();
                XmlDocument file = new XmlDocument();
                file.Load(path);
                foreach (XmlNode professorNode in file.GetElementsByTagName("professor"))
                {
                    personList.Add(new Person
                    {
                        Name = professorNode["name"].ChildNodes[0].Value,
                        Department = professorNode["department"].ChildNodes[0].Value,
                        Catedra = professorNode["catedra"].ChildNodes[0].Value,
                        Date = professorNode["date"].ChildNodes[0].Value,
                        Degree = professorNode["degree"].ChildNodes[0].Value,
                        Sex = professorNode["sex"].ChildNodes[0].Value
                    });
                }
                Global.FileData = personList;
            }
            catch
            {
                MessageBox.Show("ERROR");
                return;
            }
        }
    }
}
