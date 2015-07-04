namespace PantallaInicio
{
    partial class IngresoEmpleados
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
            this.txt_Dir_Emple = new System.Windows.Forms.TextBox();
            this.txt_Email_Emple = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Tel_Emple = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Id_Emple = new System.Windows.Forms.TextBox();
            this.date_FechN_Emple = new System.Windows.Forms.DateTimePicker();
            this.txt_Apelli_Emple = new System.Windows.Forms.TextBox();
            this.txt_Nom_Emple = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Date_FechIn_Emple = new System.Windows.Forms.DateTimePicker();
            this.radio_fem_Emple = new System.Windows.Forms.RadioButton();
            this.radio_mas_Emple = new System.Windows.Forms.RadioButton();
            this.btn_save_Emple = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.bencalethDataSet = new PantallaInicio.BencalethDataSet();
            this.combobox_CargoTipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.combobox_CargoTipoTableAdapter = new PantallaInicio.BencalethDataSetTableAdapters.Combobox_CargoTipoTableAdapter();
            this.tableAdapterManager = new PantallaInicio.BencalethDataSetTableAdapters.TableAdapterManager();
            this.combobox_CargoTipoComboBox = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bencalethDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combobox_CargoTipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Dir_Emple
            // 
            this.txt_Dir_Emple.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Dir_Emple.Location = new System.Drawing.Point(486, 573);
            this.txt_Dir_Emple.MaxLength = 30;
            this.txt_Dir_Emple.Name = "txt_Dir_Emple";
            this.txt_Dir_Emple.Size = new System.Drawing.Size(195, 26);
            this.txt_Dir_Emple.TabIndex = 10;
            this.txt_Dir_Emple.TextChanged += new System.EventHandler(this.txt_Dir_Emple_TextChanged);
            // 
            // txt_Email_Emple
            // 
            this.txt_Email_Emple.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email_Emple.Location = new System.Drawing.Point(231, 573);
            this.txt_Email_Emple.MaxLength = 30;
            this.txt_Email_Emple.Name = "txt_Email_Emple";
            this.txt_Email_Emple.Size = new System.Drawing.Size(195, 26);
            this.txt_Email_Emple.TabIndex = 9;
            this.txt_Email_Emple.TextChanged += new System.EventHandler(this.txt_Email_Emple_TextChanged);
            this.txt_Email_Emple.Leave += new System.EventHandler(this.txt_Email_Emple_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(480, 463);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 31);
            this.label11.TabIndex = 79;
            this.label11.Text = "Teléfono";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(480, 539);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 31);
            this.label10.TabIndex = 78;
            this.label10.Text = "Dirección";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txt_Tel_Emple
            // 
            this.txt_Tel_Emple.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tel_Emple.Location = new System.Drawing.Point(486, 497);
            this.txt_Tel_Emple.MaxLength = 15;
            this.txt_Tel_Emple.Name = "txt_Tel_Emple";
            this.txt_Tel_Emple.Size = new System.Drawing.Size(195, 26);
            this.txt_Tel_Emple.TabIndex = 8;
            this.txt_Tel_Emple.TextChanged += new System.EventHandler(this.txt_Tel_Emple_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(225, 539);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 31);
            this.label2.TabIndex = 76;
            this.label2.Text = "Correo Electrónico";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_Id_Emple
            // 
            this.txt_Id_Emple.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Id_Emple.Location = new System.Drawing.Point(232, 162);
            this.txt_Id_Emple.MaxLength = 30;
            this.txt_Id_Emple.Name = "txt_Id_Emple";
            this.txt_Id_Emple.Size = new System.Drawing.Size(195, 26);
            this.txt_Id_Emple.TabIndex = 0;
            this.txt_Id_Emple.TextChanged += new System.EventHandler(this.txt_Id_Emple_TextChanged);
            // 
            // date_FechN_Emple
            // 
            this.date_FechN_Emple.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_FechN_Emple.Location = new System.Drawing.Point(231, 408);
            this.date_FechN_Emple.MaxDate = new System.DateTime(2015, 12, 31, 0, 0, 0, 0);
            this.date_FechN_Emple.MinDate = new System.DateTime(1995, 1, 1, 0, 0, 0, 0);
            this.date_FechN_Emple.Name = "date_FechN_Emple";
            this.date_FechN_Emple.Size = new System.Drawing.Size(195, 26);
            this.date_FechN_Emple.TabIndex = 5;
            this.date_FechN_Emple.Value = new System.DateTime(2015, 12, 31, 0, 0, 0, 0);
            this.date_FechN_Emple.ValueChanged += new System.EventHandler(this.date_FechN_Emple_ValueChanged);
            this.date_FechN_Emple.Leave += new System.EventHandler(this.date_FechN_Emple_Leave);
            // 
            // txt_Apelli_Emple
            // 
            this.txt_Apelli_Emple.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Apelli_Emple.Location = new System.Drawing.Point(486, 241);
            this.txt_Apelli_Emple.MaxLength = 30;
            this.txt_Apelli_Emple.Name = "txt_Apelli_Emple";
            this.txt_Apelli_Emple.Size = new System.Drawing.Size(195, 26);
            this.txt_Apelli_Emple.TabIndex = 2;
            this.txt_Apelli_Emple.TextChanged += new System.EventHandler(this.txt_Apelli_Emple_TextChanged);
            // 
            // txt_Nom_Emple
            // 
            this.txt_Nom_Emple.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nom_Emple.Location = new System.Drawing.Point(232, 241);
            this.txt_Nom_Emple.MaxLength = 30;
            this.txt_Nom_Emple.Name = "txt_Nom_Emple";
            this.txt_Nom_Emple.Size = new System.Drawing.Size(195, 26);
            this.txt_Nom_Emple.TabIndex = 1;
            this.txt_Nom_Emple.TextChanged += new System.EventHandler(this.txt_Nom_Emple_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(226, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 31);
            this.label9.TabIndex = 67;
            this.label9.Text = "ID";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(226, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 31);
            this.label8.TabIndex = 66;
            this.label8.Text = "Nombre";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(480, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 31);
            this.label7.TabIndex = 65;
            this.label7.Text = "Apellidos";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(226, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 31);
            this.label6.TabIndex = 64;
            this.label6.Text = "Género";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(225, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 31);
            this.label5.TabIndex = 63;
            this.label5.Text = "Fecha Nacimiento";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(480, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 31);
            this.label3.TabIndex = 61;
            this.label3.Text = "Fecha Ingreso";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(388, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 42);
            this.label1.TabIndex = 60;
            this.label1.Text = "Empleados";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Date_FechIn_Emple
            // 
            this.Date_FechIn_Emple.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_FechIn_Emple.Location = new System.Drawing.Point(486, 408);
            this.Date_FechIn_Emple.MaxDate = new System.DateTime(2015, 12, 31, 0, 0, 0, 0);
            this.Date_FechIn_Emple.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.Date_FechIn_Emple.Name = "Date_FechIn_Emple";
            this.Date_FechIn_Emple.Size = new System.Drawing.Size(195, 26);
            this.Date_FechIn_Emple.TabIndex = 6;
            this.Date_FechIn_Emple.Value = new System.DateTime(2015, 12, 31, 0, 0, 0, 0);
            this.Date_FechIn_Emple.ValueChanged += new System.EventHandler(this.Date_FechIn_Emple_ValueChanged);
            // 
            // radio_fem_Emple
            // 
            this.radio_fem_Emple.AutoSize = true;
            this.radio_fem_Emple.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_fem_Emple.ForeColor = System.Drawing.Color.White;
            this.radio_fem_Emple.Location = new System.Drawing.Point(378, 325);
            this.radio_fem_Emple.Name = "radio_fem_Emple";
            this.radio_fem_Emple.Size = new System.Drawing.Size(140, 33);
            this.radio_fem_Emple.TabIndex = 4;
            this.radio_fem_Emple.Tag = "f";
            this.radio_fem_Emple.Text = "Femenino";
            this.radio_fem_Emple.UseVisualStyleBackColor = true;
            this.radio_fem_Emple.CheckedChanged += new System.EventHandler(this.radio_fem_Emple_CheckedChanged);
            // 
            // radio_mas_Emple
            // 
            this.radio_mas_Emple.AutoSize = true;
            this.radio_mas_Emple.Checked = true;
            this.radio_mas_Emple.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_mas_Emple.ForeColor = System.Drawing.Color.White;
            this.radio_mas_Emple.Location = new System.Drawing.Point(232, 325);
            this.radio_mas_Emple.Name = "radio_mas_Emple";
            this.radio_mas_Emple.Size = new System.Drawing.Size(140, 33);
            this.radio_mas_Emple.TabIndex = 3;
            this.radio_mas_Emple.TabStop = true;
            this.radio_mas_Emple.Tag = "m";
            this.radio_mas_Emple.Text = "Masculino";
            this.radio_mas_Emple.UseVisualStyleBackColor = true;
            this.radio_mas_Emple.CheckedChanged += new System.EventHandler(this.radio_mas_Emple_CheckedChanged);
            // 
            // btn_save_Emple
            // 
            this.btn_save_Emple.BackColor = System.Drawing.Color.White;
            this.btn_save_Emple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save_Emple.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_Emple.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_save_Emple.Location = new System.Drawing.Point(517, 637);
            this.btn_save_Emple.Name = "btn_save_Emple";
            this.btn_save_Emple.Size = new System.Drawing.Size(164, 64);
            this.btn_save_Emple.TabIndex = 11;
            this.btn_save_Emple.Text = "Guardar";
            this.btn_save_Emple.UseVisualStyleBackColor = false;
            this.btn_save_Emple.Click += new System.EventHandler(this.btn_save_Emple_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(226, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 31);
            this.label4.TabIndex = 93;
            this.label4.Text = "Cargo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // bencalethDataSet
            // 
            this.bencalethDataSet.DataSetName = "BencalethDataSet";
            this.bencalethDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // combobox_CargoTipoBindingSource
            // 
            this.combobox_CargoTipoBindingSource.DataMember = "Combobox_CargoTipo";
            this.combobox_CargoTipoBindingSource.DataSource = this.bencalethDataSet;
            // 
            // combobox_CargoTipoTableAdapter
            // 
            this.combobox_CargoTipoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = PantallaInicio.BencalethDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // combobox_CargoTipoComboBox
            // 
            this.combobox_CargoTipoComboBox.DataSource = this.combobox_CargoTipoBindingSource;
            this.combobox_CargoTipoComboBox.DisplayMember = "Cargo";
            this.combobox_CargoTipoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_CargoTipoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobox_CargoTipoComboBox.FormattingEnabled = true;
            this.combobox_CargoTipoComboBox.Location = new System.Drawing.Point(232, 488);
            this.combobox_CargoTipoComboBox.Name = "combobox_CargoTipoComboBox";
            this.combobox_CargoTipoComboBox.Size = new System.Drawing.Size(195, 28);
            this.combobox_CargoTipoComboBox.TabIndex = 7;
            this.combobox_CargoTipoComboBox.ValueMember = "Empleado_Tipo";
            this.combobox_CargoTipoComboBox.SelectedIndexChanged += new System.EventHandler(this.combobox_CargoTipoComboBox_SelectedIndexChanged);
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
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(486, 621);
            this.maskedTextBox1.Mask = "0000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(195, 26);
            this.maskedTextBox1.TabIndex = 94;
            this.maskedTextBox1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PantallaInicio.Properties.Resources.Sin_nombre_EN_BLANCO;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 123;
            this.pictureBox1.TabStop = false;
            // 
            // IngresoEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1008, 756);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.combobox_CargoTipoComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_save_Emple);
            this.Controls.Add(this.radio_fem_Emple);
            this.Controls.Add(this.radio_mas_Emple);
            this.Controls.Add(this.Date_FechIn_Emple);
            this.Controls.Add(this.txt_Dir_Emple);
            this.Controls.Add(this.txt_Email_Emple);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_Tel_Emple);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Id_Emple);
            this.Controls.Add(this.date_FechN_Emple);
            this.Controls.Add(this.txt_Apelli_Emple);
            this.Controls.Add(this.txt_Nom_Emple);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IngresoEmpleados";
            this.Tag = "m";
            this.Load += new System.EventHandler(this.IngresoEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bencalethDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combobox_CargoTipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Dir_Emple;
        private System.Windows.Forms.TextBox txt_Email_Emple;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Tel_Emple;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Id_Emple;
        private System.Windows.Forms.DateTimePicker date_FechN_Emple;
        private System.Windows.Forms.TextBox txt_Apelli_Emple;
        private System.Windows.Forms.TextBox txt_Nom_Emple;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Date_FechIn_Emple;
        private System.Windows.Forms.RadioButton radio_fem_Emple;
        private System.Windows.Forms.RadioButton radio_mas_Emple;
        private System.Windows.Forms.Button btn_save_Emple;
        private System.Windows.Forms.Label label4;
        private BencalethDataSet bencalethDataSet;
        private System.Windows.Forms.BindingSource combobox_CargoTipoBindingSource;
        private BencalethDataSetTableAdapters.Combobox_CargoTipoTableAdapter combobox_CargoTipoTableAdapter;
        private BencalethDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox combobox_CargoTipoComboBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}