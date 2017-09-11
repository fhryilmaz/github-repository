namespace ANN_TrainingTool
{
    partial class mainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnLoadDataSet = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageDataEntry = new System.Windows.Forms.TabPage();
            this.gBoxSettings = new System.Windows.Forms.GroupBox();
            this.btnRunTraining = new System.Windows.Forms.Button();
            this.chkListBoxIndependentVar = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBoxDependentVar = new System.Windows.Forms.ComboBox();
            this.tabPageTrainingResults = new System.Windows.Forms.TabPage();
            this.tabPageCalculations = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPageDataEntry.SuspendLayout();
            this.gBoxSettings.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.Location = new System.Drawing.Point(7, 39);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView.RowHeadersWidth = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.ShowCellErrors = false;
            this.dataGridView.ShowCellToolTips = false;
            this.dataGridView.ShowEditingIcon = false;
            this.dataGridView.ShowRowErrors = false;
            this.dataGridView.Size = new System.Drawing.Size(604, 470);
            this.dataGridView.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "csv";
            this.openFileDialog.FileName = "*.csv";
            this.openFileDialog.Title = "Data Set File";
            // 
            // btnLoadDataSet
            // 
            this.btnLoadDataSet.Location = new System.Drawing.Point(7, 6);
            this.btnLoadDataSet.Name = "btnLoadDataSet";
            this.btnLoadDataSet.Size = new System.Drawing.Size(100, 23);
            this.btnLoadDataSet.TabIndex = 1;
            this.btnLoadDataSet.Text = "Load Data Set";
            this.btnLoadDataSet.UseVisualStyleBackColor = true;
            this.btnLoadDataSet.Click += new System.EventHandler(this.btnLoadDataSet_Click);
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.Controls.Add(this.tabPageDataEntry);
            this.tabControl.Controls.Add(this.tabPageTrainingResults);
            this.tabControl.Controls.Add(this.tabPageCalculations);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(884, 562);
            this.tabControl.TabIndex = 3;
            // 
            // tabPageDataEntry
            // 
            this.tabPageDataEntry.Controls.Add(this.gBoxSettings);
            this.tabPageDataEntry.Controls.Add(this.dataGridView);
            this.tabPageDataEntry.Controls.Add(this.btnLoadDataSet);
            this.tabPageDataEntry.Location = new System.Drawing.Point(4, 25);
            this.tabPageDataEntry.Name = "tabPageDataEntry";
            this.tabPageDataEntry.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDataEntry.Size = new System.Drawing.Size(876, 533);
            this.tabPageDataEntry.TabIndex = 0;
            this.tabPageDataEntry.Text = "Data Set Entry";
            this.tabPageDataEntry.UseVisualStyleBackColor = true;
            // 
            // gBoxSettings
            // 
            this.gBoxSettings.Controls.Add(this.btnRunTraining);
            this.gBoxSettings.Controls.Add(this.chkListBoxIndependentVar);
            this.gBoxSettings.Controls.Add(this.label2);
            this.gBoxSettings.Controls.Add(this.label1);
            this.gBoxSettings.Controls.Add(this.cmbBoxDependentVar);
            this.gBoxSettings.Location = new System.Drawing.Point(617, 6);
            this.gBoxSettings.Name = "gBoxSettings";
            this.gBoxSettings.Size = new System.Drawing.Size(251, 503);
            this.gBoxSettings.TabIndex = 3;
            this.gBoxSettings.TabStop = false;
            this.gBoxSettings.Text = "Settings";
            // 
            // btnRunTraining
            // 
            this.btnRunTraining.Location = new System.Drawing.Point(6, 455);
            this.btnRunTraining.Name = "btnRunTraining";
            this.btnRunTraining.Size = new System.Drawing.Size(239, 42);
            this.btnRunTraining.TabIndex = 4;
            this.btnRunTraining.Text = "Run Training";
            this.btnRunTraining.UseVisualStyleBackColor = true;
            this.btnRunTraining.Click += new System.EventHandler(this.btnRunTraining_Click);
            // 
            // chkListBoxIndependentVar
            // 
            this.chkListBoxIndependentVar.FormattingEnabled = true;
            this.chkListBoxIndependentVar.Location = new System.Drawing.Point(6, 88);
            this.chkListBoxIndependentVar.Name = "chkListBoxIndependentVar";
            this.chkListBoxIndependentVar.Size = new System.Drawing.Size(239, 225);
            this.chkListBoxIndependentVar.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Independent Variables (Inputs)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dependent Variable (Output)";
            // 
            // cmbBoxDependentVar
            // 
            this.cmbBoxDependentVar.FormattingEnabled = true;
            this.cmbBoxDependentVar.Location = new System.Drawing.Point(6, 48);
            this.cmbBoxDependentVar.Name = "cmbBoxDependentVar";
            this.cmbBoxDependentVar.Size = new System.Drawing.Size(239, 21);
            this.cmbBoxDependentVar.TabIndex = 0;
            // 
            // tabPageTrainingResults
            // 
            this.tabPageTrainingResults.Location = new System.Drawing.Point(4, 25);
            this.tabPageTrainingResults.Name = "tabPageTrainingResults";
            this.tabPageTrainingResults.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTrainingResults.Size = new System.Drawing.Size(876, 533);
            this.tabPageTrainingResults.TabIndex = 1;
            this.tabPageTrainingResults.Text = "Training Results";
            this.tabPageTrainingResults.UseVisualStyleBackColor = true;
            // 
            // tabPageCalculations
            // 
            this.tabPageCalculations.Location = new System.Drawing.Point(4, 25);
            this.tabPageCalculations.Name = "tabPageCalculations";
            this.tabPageCalculations.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCalculations.Size = new System.Drawing.Size(876, 533);
            this.tabPageCalculations.TabIndex = 2;
            this.tabPageCalculations.Text = "Calculations";
            this.tabPageCalculations.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 540);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(884, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(172, 17);
            this.toolStripStatusLabel1.Text = "Copy Rights 2017 Fahri YILMAZ";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Traning Tool Set";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPageDataEntry.ResumeLayout(false);
            this.gBoxSettings.ResumeLayout(false);
            this.gBoxSettings.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnLoadDataSet;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageDataEntry;
        private System.Windows.Forms.TabPage tabPageTrainingResults;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabPage tabPageCalculations;
        private System.Windows.Forms.GroupBox gBoxSettings;
        private System.Windows.Forms.Button btnRunTraining;
        private System.Windows.Forms.CheckedListBox chkListBoxIndependentVar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBoxDependentVar;
    }
}

