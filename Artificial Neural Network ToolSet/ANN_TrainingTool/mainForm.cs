using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Neural.NET;

namespace ANN_TrainingTool
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
        }

        DataTable datasetTable;
        private void btnLoadDataSet_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.Cursor = Cursors.WaitCursor;
                    datasetTable = GetDataAsTableFromCSV.GetDataAsTable(openFileDialog.SafeFileName);
                    dataGridView.DataSource = datasetTable;
                    this.Cursor = Cursors.Default;
                    cmbBoxDependentVar.Items.Clear();
                    chkListBoxIndependentVar.Items.Clear();
                    for (int i = 0; i < datasetTable.Columns.Count; i++)
                    {
                        cmbBoxDependentVar.Items.Add(datasetTable.Columns[i].ColumnName.ToString());
                        chkListBoxIndependentVar.Items.Add(datasetTable.Columns[i].ColumnName.ToString());
                    }
                    cmbBoxDependentVar.SelectedIndex = 0;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRunTraining_Click(object sender, EventArgs e)
        {
            Network nn = new Network(4, new[] { 2, 2 }, 1);
            NetworkTrainer nt = new NetworkTrainer(nn);
            //Tuple<double[],double[]>[] testData = new Tuple<double[], double[]>[](new double[]{1,2},new double[]{2,3});
            //Tuple<double[], double[]>[] trainingData = new Tuple<double[], double[]>[](new double[] { 3, 4 }, new double[] { 3, 4 });
            //foreach (Tuple<int, double?> results in nt.StochasticGradientDescent(10000, trainingData, 1000, 100, .05, testData)) ;
            //{
            //
            //}
        }
    }

}





