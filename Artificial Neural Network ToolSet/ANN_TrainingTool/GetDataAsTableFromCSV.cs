using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANN_TrainingTool
{
    class GetDataAsTableFromCSV
    {
        public static DataTable GetDataAsTable(string FilePath)
        {
            StreamReader streamReader = new StreamReader(FilePath);
            List<string> csvLineList = new List<string>();
            DataTable dataTable = new DataTable();

            dataTable.Clear();
            dataTable.Columns.Clear();

            try
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    line = line.Replace(',', '.');
                    csvLineList.Add(line);
                }
                string firstRowforHeader = csvLineList[0].ToString();
                string seperator = ";";
                string[] ColumnNames = firstRowforHeader.Split(new string[] { seperator }, StringSplitOptions.RemoveEmptyEntries);

                //Parallel.For(0, ColumnNames.Count(), i =>
                //    {
                //        dataTable.Columns.Add(ColumnNames[i].ToUpper());
                //        i++;
                //    });


                for (int i = 0; i < ColumnNames.Count(); i++)
                {
                    //dataTable.Columns.Add(ColumnNames[i].ToUpper());
                    dataTable.Columns.Add(ColumnNames[i]);
                }
                string[] dataRow;
                //Parallel.For(8, csvLineList.Count, i =>
                //    {
                //        dataRow = csvLineList[i].ToString().Split(new string[] { seperator }, StringSplitOptions.RemoveEmptyEntries);
                //        dataTable.Rows.Add(dataRow);
                //        i++;
                //    });


                for (int i = 1; i < csvLineList.Count; i++)
                {
                    dataRow = csvLineList[i].ToString().Split(new string[] { seperator }, StringSplitOptions.RemoveEmptyEntries);
                    dataTable.Rows.Add(dataRow);
                }
            }
            catch (Exception exp)
            {

            }
            return dataTable;
        }
    }
}
