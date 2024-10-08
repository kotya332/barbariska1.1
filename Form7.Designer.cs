
namespace praktika
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clinicDataSet6 = new praktika.clinicDataSet6();
            this.freetimeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clinicDataSet3 = new praktika.clinicDataSet3();
            this.clinicDataSet2 = new praktika.clinicDataSet2();
            this.freetimeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.freetimeTableAdapter = new praktika.clinicDataSet2TableAdapters.freetimeTableAdapter();
            this.freetimeTableAdapter1 = new praktika.clinicDataSet3TableAdapters.freetimeTableAdapter();
            this.clinicDataSet5 = new praktika.clinicDataSet5();
            this.timeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeTableAdapter = new praktika.clinicDataSet5TableAdapters.timeTableAdapter();
            this.timeTableAdapter1 = new praktika.clinicDataSet6TableAdapters.timeTableAdapter();
            this.clinicDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicDataSet6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialnostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starttimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freetimeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freetimeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet6BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(331, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.specialnostDataGridViewTextBoxColumn,
            this.dataaDataGridViewTextBoxColumn,
            this.starttimeDataGridViewTextBoxColumn,
            this.endtimeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.timeBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(77, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 283);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // timeBindingSource1
            // 
            this.timeBindingSource1.DataMember = "time";
            this.timeBindingSource1.DataSource = this.clinicDataSet6;
            // 
            // clinicDataSet6
            // 
            this.clinicDataSet6.DataSetName = "clinicDataSet6";
            this.clinicDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // freetimeBindingSource1
            // 
            this.freetimeBindingSource1.DataMember = "freetime";
            this.freetimeBindingSource1.DataSource = this.clinicDataSet3;
            // 
            // clinicDataSet3
            // 
            this.clinicDataSet3.DataSetName = "clinicDataSet3";
            this.clinicDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clinicDataSet2
            // 
            this.clinicDataSet2.DataSetName = "clinicDataSet2";
            this.clinicDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // freetimeBindingSource
            // 
            this.freetimeBindingSource.DataMember = "freetime";
            this.freetimeBindingSource.DataSource = this.clinicDataSet2;
            // 
            // freetimeTableAdapter
            // 
            this.freetimeTableAdapter.ClearBeforeFill = true;
            // 
            // freetimeTableAdapter1
            // 
            this.freetimeTableAdapter1.ClearBeforeFill = true;
            // 
            // clinicDataSet5
            // 
            this.clinicDataSet5.DataSetName = "clinicDataSet5";
            this.clinicDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timeBindingSource
            // 
            this.timeBindingSource.DataMember = "time";
            this.timeBindingSource.DataSource = this.clinicDataSet5;
            // 
            // timeTableAdapter
            // 
            this.timeTableAdapter.ClearBeforeFill = true;
            // 
            // timeTableAdapter1
            // 
            this.timeTableAdapter1.ClearBeforeFill = true;
            // 
            // clinicDataSet5BindingSource
            // 
            this.clinicDataSet5BindingSource.DataSource = this.clinicDataSet5;
            this.clinicDataSet5BindingSource.Position = 0;
            // 
            // clinicDataSet6BindingSource
            // 
            this.clinicDataSet6BindingSource.DataSource = this.clinicDataSet6;
            this.clinicDataSet6BindingSource.Position = 0;
            // 
            // timeBindingSource2
            // 
            this.timeBindingSource2.DataMember = "time";
            this.timeBindingSource2.DataSource = this.clinicDataSet6BindingSource;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // specialnostDataGridViewTextBoxColumn
            // 
            this.specialnostDataGridViewTextBoxColumn.DataPropertyName = "specialnost";
            this.specialnostDataGridViewTextBoxColumn.HeaderText = "specialnost";
            this.specialnostDataGridViewTextBoxColumn.Name = "specialnostDataGridViewTextBoxColumn";
            // 
            // dataaDataGridViewTextBoxColumn
            // 
            this.dataaDataGridViewTextBoxColumn.DataPropertyName = "dataa";
            this.dataaDataGridViewTextBoxColumn.HeaderText = "dataa";
            this.dataaDataGridViewTextBoxColumn.Name = "dataaDataGridViewTextBoxColumn";
            // 
            // starttimeDataGridViewTextBoxColumn
            // 
            this.starttimeDataGridViewTextBoxColumn.DataPropertyName = "starttime";
            this.starttimeDataGridViewTextBoxColumn.HeaderText = "starttime";
            this.starttimeDataGridViewTextBoxColumn.Name = "starttimeDataGridViewTextBoxColumn";
            // 
            // endtimeDataGridViewTextBoxColumn
            // 
            this.endtimeDataGridViewTextBoxColumn.DataPropertyName = "endtime";
            this.endtimeDataGridViewTextBoxColumn.HeaderText = "endtime";
            this.endtimeDataGridViewTextBoxColumn.Name = "endtimeDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 398);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form7";
            this.Text = "Свободное время и дата";
            this.Load += new System.EventHandler(this.Form7_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freetimeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freetimeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet6BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private clinicDataSet2 clinicDataSet2;
        private System.Windows.Forms.BindingSource freetimeBindingSource;
        private clinicDataSet2TableAdapters.freetimeTableAdapter freetimeTableAdapter;
        private clinicDataSet3 clinicDataSet3;
        private System.Windows.Forms.BindingSource freetimeBindingSource1;
        private clinicDataSet3TableAdapters.freetimeTableAdapter freetimeTableAdapter1;
        private clinicDataSet5 clinicDataSet5;
        private System.Windows.Forms.BindingSource timeBindingSource;
        private clinicDataSet5TableAdapters.timeTableAdapter timeTableAdapter;
        private clinicDataSet6 clinicDataSet6;
        private System.Windows.Forms.BindingSource timeBindingSource1;
        private clinicDataSet6TableAdapters.timeTableAdapter timeTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialnostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn starttimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource timeBindingSource2;
        private System.Windows.Forms.BindingSource clinicDataSet6BindingSource;
        private System.Windows.Forms.BindingSource clinicDataSet5BindingSource;
    }
}