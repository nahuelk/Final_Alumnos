
namespace GUI
{
    partial class FrmMaterias
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.mATERIASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalDataSet1 = new GUI.FinalDataSet1();
            this.mATERIASTableAdapter = new GUI.FinalDataSet1TableAdapters.MATERIASTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.eXAMENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalDataSet2 = new GUI.FinalDataSet2();
            this.eXAMENTableAdapter = new GUI.FinalDataSet2TableAdapters.EXAMENTableAdapter();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.finalDataSet3 = new GUI.FinalDataSet3();
            this.mATERIASBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mATERIASTableAdapter1 = new GUI.FinalDataSet3TableAdapters.MATERIASTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mATERIASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXAMENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATERIASBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.mATERIASBindingSource1;
            this.comboBox1.DisplayMember = "Materia";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(196, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // mATERIASBindingSource
            // 
            this.mATERIASBindingSource.DataMember = "MATERIAS";
            this.mATERIASBindingSource.DataSource = this.finalDataSet1;
            // 
            // finalDataSet1
            // 
            this.finalDataSet1.DataSetName = "FinalDataSet1";
            this.finalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mATERIASTableAdapter
            // 
            this.mATERIASTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.mATERIASBindingSource1;
            this.comboBox2.DisplayMember = "id_Catedra";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(196, 122);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Materia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Catedra";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Inscribirse a la materia";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(196, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Volver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // eXAMENBindingSource
            // 
            this.eXAMENBindingSource.DataMember = "EXAMEN";
            this.eXAMENBindingSource.DataSource = this.finalDataSet2;
            // 
            // finalDataSet2
            // 
            this.finalDataSet2.DataSetName = "FinalDataSet2";
            this.finalDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eXAMENTableAdapter
            // 
            this.eXAMENTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.mATERIASBindingSource1;
            this.comboBox3.DisplayMember = "horarios";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(196, 170);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 6;
            // 
            // finalDataSet3
            // 
            this.finalDataSet3.DataSetName = "FinalDataSet3";
            this.finalDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mATERIASBindingSource1
            // 
            this.mATERIASBindingSource1.DataMember = "MATERIAS";
            this.mATERIASBindingSource1.DataSource = this.finalDataSet3;
            // 
            // mATERIASTableAdapter1
            // 
            this.mATERIASTableAdapter1.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Horario";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // FrmMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "FrmMaterias";
            this.Text = "Examenes";
            this.Load += new System.EventHandler(this.Examenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mATERIASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXAMENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATERIASBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private FinalDataSet1 finalDataSet1;
        private System.Windows.Forms.BindingSource mATERIASBindingSource;
        private FinalDataSet1TableAdapters.MATERIASTableAdapter mATERIASTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private FinalDataSet2 finalDataSet2;
        private System.Windows.Forms.BindingSource eXAMENBindingSource;
        private FinalDataSet2TableAdapters.EXAMENTableAdapter eXAMENTableAdapter;
        private System.Windows.Forms.ComboBox comboBox3;
        private FinalDataSet3 finalDataSet3;
        private System.Windows.Forms.BindingSource mATERIASBindingSource1;
        private FinalDataSet3TableAdapters.MATERIASTableAdapter mATERIASTableAdapter1;
        private System.Windows.Forms.Label label3;
    }
}