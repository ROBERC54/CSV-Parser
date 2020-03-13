using System;
using System.Collections.Generic;
using System.Text;

namespace CSV_Parser
{
    public abstract class CSVableAbstraction
    {//those public properties of the class derived from this abstraction will be able to be reformatted to CSV
        public virtual string ToCSV()
        {
            string output = "";
            var properties = GetType().GetProperties();//user reflection to collect an array of PropertyInfo
            for (int i = 0; i < properties.Length; i++)
            {
                output += properties[i].GetValue(this).ToString();
                if (i != properties.Length - 1)
                {
                    output += ",";
                }
            }
            return output;
        }
    }
}
