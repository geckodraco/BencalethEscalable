namespace PantallaInicio
{
    partial class IngresoNiños
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
            this.fech_ingre = new System.Windows.Forms.DateTimePicker();
            this.fech_niños = new System.Windows.Forms.DateTimePicker();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nomniños = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_idniños = new System.Windows.Forms.TextBox();
            this.btn_saveNiños = new System.Windows.Forms.Button();
            this.radio_mas_Niños = new System.Windows.Forms.RadioButton();
            this.radio_fem_Niños = new System.Windows.Forms.RadioButton();
            this.bencalethDataSet = new PantallaInicio.BencalethDataSet();
            this.comboboxResponsablesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboboxResponsablesTableAdapter = new PantallaInicio.BencalethDataSetTableAdapters.ComboboxResponsablesTableAdapter();
            this.tableAdapterManager = new PantallaInicio.BencalethDataSetTableAdapters.TableAdapterManager();
            this.comboboxResponsablesComboBox = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bencalethDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboboxResponsablesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fech_ingre
            // 
            this.fech_ingre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fech_ingre.Location = new System.Drawing.Point(230, 452);
            this.fech_ingre.Name = "fech_ingre";
            this.fech_ingre.Size = new System.Drawing.Size(193, 26);
            this.fech_ingre.TabIndex = 6;
            // 
            // fech_niños
            // 
            this.fech_niños.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fech_niños.Location = new System.Drawing.Point(481, 452);
            this.fech_niños.Name = "fech_niños";
            this.fech_niños.Size = new System.Drawing.Size(193, 26);
            this.fech_niños.TabIndex = 3;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido.Location = new System.Drawing.Point(481, 294);
            this.txt_apellido.MaxLength = 30;
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(193, 26);
            this.txt_apellido.TabIndex = 2;
            this.txt_apellido.TextChanged += new System.EventHandler(this.txt_apellido_TextChanged_1);
            // 
            // txt_nomniños
            // 
            this.txt_nomniños.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomniños.Location = new System.Drawing.Point(230, 294);
            this.txt_nomniños.MaxLength = 30;
            this.txt_nomniños.Name = "txt_nomniños";
            this.txt_nomniños.Size = new System.Drawing.Size(193, 26);
            this.txt_nomniños.TabIndex = 1;
            this.txt_nomniños.TextChanged += new System.EventHandler(this.txt_nomniños_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(224, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 31);
            this.label9.TabIndex = 26;
            this.label9.Text = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(224, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 31);
            this.label8.TabIndex = 25;
            this.label8.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(475, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 31);
            this.label7.TabIndex = 24;
            this.label7.Text = "Apellidos";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(224, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 31);
            this.label6.TabIndex = 23;
            this.label6.Text = "Género";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(475, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 31);
            this.label5.TabIndex = 22;
            this.label5.Text = "Cumpleaños";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(224, 504);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 31);
            this.label4.TabIndex = 21;
            this.label4.Text = "Responsable";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(224, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 31);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ingreso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(383, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 42);
            this.label1.TabIndex = 18;
            this.label1.Text = "Niños";
            // 
            // txt_idniños
            // 
            this.txt_idniños.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idniños.Location = new System.Drawing.Point(230, 216);
            this.txt_idniños.MaxLength = 30;
            this.txt_idniños.Name = "txt_idniños";
            this.txt_idniños.Size = new System.Drawing.Size(193, 26);
            this.txt_idniños.TabIndex = 0;
            this.txt_idniños.TextChanged += new System.EventHandler(this.txt_idniños_TextChanged);
            // 
            // btn_saveNiños
            // 
            this.btn_saveNiños.BackColor = System.Drawing.Color.White;
            this.btn_saveNiños.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveNiños.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveNiños.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_saveNiños.Location = new System.Drawing.Point(510, 631);
            this.btn_saveNiños.Name = "btn_saveNiños";
            this.btn_saveNiños.Size = new System.Drawing.Size(164, 64);
            this.btn_saveNiños.TabIndex = 8;
            this.btn_saveNiños.Text = "Guardar";
            this.btn_saveNiños.UseVisualStyleBackColor = false;
            this.btn_saveNiños.Click += new System.EventHandler(this.btn_saveNiños_Click_1);
            // 
            // radio_mas_Niños
            // 
            this.radio_mas_Niños.AutoSize = true;
            this.radio_mas_Niños.Checked = true;
            this.radio_mas_Niños.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_mas_Niños.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.radio_mas_Niños.Location = new System.Drawing.Point(230, 371);
            this.radio_mas_Niños.Name = "radio_mas_Niños";
            this.radio_mas_Niños.Size = new System.Drawing.Size(140, 33);
            this.radio_mas_Niños.TabIndex = 4;
            this.radio_mas_Niños.TabStop = true;
            this.radio_mas_Niños.Tag = "m";
            this.radio_mas_Niños.Text = "Masculino";
            this.radio_mas_Niños.UseVisualStyleBackColor = true;
            this.radio_mas_Niños.CheckedChanged += new System.EventHandler(this.radio_mas_Niños_CheckedChanged);
            // 
            // radio_fem_Niños
            // 
            this.radio_fem_Niños.AutoSize = true;
            this.radio_fem_Niños.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_fem_Niños.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.radio_fem_Niños.Location = new System.Drawing.Point(376, 371);
            this.radio_fem_Niños.Name = "radio_fem_Niños";
            this.radio_fem_Niños.Size = new System.Drawing.Size(140, 33);
            this.radio_fem_Niños.TabIndex = 5;
            this.radio_fem_Niños.Tag = "f";
            this.radio_fem_Niños.Text = "Femenino";
            this.radio_fem_Niños.UseVisualStyleBackColor = true;
            // 
            // bencalethDataSet
            // 
            this.bencalethDataSet.DataSetName = "BencalethDataSet";
            this.bencalethDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboboxResponsablesBindingSource
            // 
            this.comboboxResponsablesBindingSource.DataMember = "ComboboxResponsables";
            this.comboboxResponsablesBindingSource.DataSource = this.bencalethDataSet;
            // 
            // comboboxResponsablesTableAdapter
            // 
            this.comboboxResponsablesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = PantallaInicio.BencalethDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // comboboxResponsablesComboBox
            // 
            this.comboboxResponsablesComboBox.DataSource = this.comboboxResponsablesBindingSource;
            this.comboboxResponsablesComboBox.DisplayMember = "Nombre";
            this.comboboxResponsablesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxResponsablesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboboxResponsablesComboBox.FormattingEnabled = true;
            this.comboboxResponsablesComboBox.Location = new System.Drawing.Point(230, 538);
            this.comboboxResponsablesComboBox.Name = "comboboxResponsablesComboBox";
            this.comboboxResponsablesComboBox.Size = new System.Drawing.Size(193, 28);
            this.comboboxResponsablesComboBox.TabIndex = 7;
            this.comboboxResponsablesComboBox.ValueMember = "Id";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PantallaInicio.Properties.Resources.Sin_nombre_EN_BLANCO;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 123;
            this.pictureBox1.TabStop = false;
            // 
            // IngresoNiños
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(883, 770);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboboxResponsablesComboBox);
            this.Controls.Add(this.radio_fem_Niños);
            this.Controls.Add(this.radio_mas_Niños);
            this.Controls.Add(this.btn_saveNiños);
            this.Controls.Add(this.txt_idniños);
            this.Controls.Add(this.fech_ingre);
            this.Controls.Add(this.fech_niños);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nomniños);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IngresoNiños";
            this.Load += new System.EventHandler(this.IngresoNiños_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bencalethDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboboxResponsablesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fech_ingre;
        private System.Windows.Forms.DateTimePicker fech_niños;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_nomniños;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_idniños;
        private System.Windows.Forms.Button btn_saveNiños;
        private System.Windows.Forms.RadioButton radio_mas_Niños;
        private System.Windows.Forms.RadioButton radio_fem_Niños;
        private BencalethDataSet bencalethDataSet;
        private System.Windows.Forms.BindingSource comboboxResponsablesBindingSource;
        private BencalethDataSetTableAdapters.ComboboxResponsablesTableAdapter comboboxResponsablesTableAdapter;
        private BencalethDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox comboboxResponsablesComboBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}