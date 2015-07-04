namespace PantallaInicio
{
    partial class IngresarEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngresarEmpresa));
            this.txt_pasi_empresa = new System.Windows.Forms.TextBox();
            this.txt_email_empresa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_tel2_empresa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_dire_empresa = new System.Windows.Forms.TextBox();
            this.txt_nom_empresa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_contac_empresa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_tel1_empresa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_id_empresa = new System.Windows.Forms.TextBox();
            this.btn_save_empresa = new System.Windows.Forms.Button();
            this.bencalethDataSet1 = new PantallaInicio.BencalethDataSet1();
            this.combobox_empresasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.combobox_empresasTableAdapter = new PantallaInicio.BencalethDataSet1TableAdapters.combobox_empresasTableAdapter();
            this.tableAdapterManager = new PantallaInicio.BencalethDataSet1TableAdapters.TableAdapterManager();
            this.combobox_empresasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.combobox_empresasComboBox = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider7 = new System.Windows.Forms.ErrorProvider(this.components);
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bencalethDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combobox_empresasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combobox_empresasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_pasi_empresa
            // 
            this.txt_pasi_empresa.BackColor = System.Drawing.Color.White;
            this.txt_pasi_empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pasi_empresa.Location = new System.Drawing.Point(234, 302);
            this.txt_pasi_empresa.MaxLength = 30;
            this.txt_pasi_empresa.Name = "txt_pasi_empresa";
            this.txt_pasi_empresa.Size = new System.Drawing.Size(193, 26);
            this.txt_pasi_empresa.TabIndex = 4;
            this.txt_pasi_empresa.TextChanged += new System.EventHandler(this.txt_pasi_empresa_TextChanged);
            // 
            // txt_email_empresa
            // 
            this.txt_email_empresa.BackColor = System.Drawing.Color.White;
            this.txt_email_empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email_empresa.Location = new System.Drawing.Point(488, 384);
            this.txt_email_empresa.MaxLength = 30;
            this.txt_email_empresa.Name = "txt_email_empresa";
            this.txt_email_empresa.Size = new System.Drawing.Size(193, 26);
            this.txt_email_empresa.TabIndex = 6;
            this.txt_email_empresa.TextChanged += new System.EventHandler(this.txt_email_empresa_TextChanged);
            this.txt_email_empresa.Leave += new System.EventHandler(this.txt_email_empresa_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(228, 268);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 31);
            this.label10.TabIndex = 103;
            this.label10.Text = "País";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txt_tel2_empresa
            // 
            this.txt_tel2_empresa.BackColor = System.Drawing.Color.White;
            this.txt_tel2_empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tel2_empresa.Location = new System.Drawing.Point(488, 466);
            this.txt_tel2_empresa.MaxLength = 15;
            this.txt_tel2_empresa.Name = "txt_tel2_empresa";
            this.txt_tel2_empresa.Size = new System.Drawing.Size(193, 26);
            this.txt_tel2_empresa.TabIndex = 8;
            this.txt_tel2_empresa.TextChanged += new System.EventHandler(this.txt_tel2_empresa_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(482, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 31);
            this.label2.TabIndex = 101;
            this.label2.Text = "Email";
            // 
            // txt_dire_empresa
            // 
            this.txt_dire_empresa.BackColor = System.Drawing.Color.White;
            this.txt_dire_empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dire_empresa.Location = new System.Drawing.Point(488, 302);
            this.txt_dire_empresa.MaxLength = 30;
            this.txt_dire_empresa.Name = "txt_dire_empresa";
            this.txt_dire_empresa.Size = new System.Drawing.Size(193, 26);
            this.txt_dire_empresa.TabIndex = 3;
            this.txt_dire_empresa.TextChanged += new System.EventHandler(this.txt_dire_empresa_TextChanged);
            // 
            // txt_nom_empresa
            // 
            this.txt_nom_empresa.BackColor = System.Drawing.Color.White;
            this.txt_nom_empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nom_empresa.Location = new System.Drawing.Point(488, 216);
            this.txt_nom_empresa.MaxLength = 30;
            this.txt_nom_empresa.Name = "txt_nom_empresa";
            this.txt_nom_empresa.Size = new System.Drawing.Size(193, 26);
            this.txt_nom_empresa.TabIndex = 1;
            this.txt_nom_empresa.TextChanged += new System.EventHandler(this.txt_nom_empresa_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(482, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 31);
            this.label8.TabIndex = 92;
            this.label8.Text = "Nombre";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(227, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(219, 31);
            this.label7.TabIndex = 91;
            this.label7.Text = "Tipo de Empresa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(227, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 31);
            this.label4.TabIndex = 88;
            this.label4.Text = "Teléfono 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(482, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 31);
            this.label3.TabIndex = 87;
            this.label3.Text = "Dirección";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(371, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 42);
            this.label1.TabIndex = 86;
            this.label1.Text = "Empresa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(227, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 31);
            this.label5.TabIndex = 109;
            this.label5.Text = "Contacto";
            // 
            // txt_contac_empresa
            // 
            this.txt_contac_empresa.BackColor = System.Drawing.Color.White;
            this.txt_contac_empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contac_empresa.Location = new System.Drawing.Point(233, 384);
            this.txt_contac_empresa.MaxLength = 30;
            this.txt_contac_empresa.Name = "txt_contac_empresa";
            this.txt_contac_empresa.Size = new System.Drawing.Size(193, 26);
            this.txt_contac_empresa.TabIndex = 5;
            this.txt_contac_empresa.TextChanged += new System.EventHandler(this.txt_contac_empresa_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(480, 432);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 31);
            this.label6.TabIndex = 111;
            this.label6.Text = "Teléfono 2";
            // 
            // txt_tel1_empresa
            // 
            this.txt_tel1_empresa.BackColor = System.Drawing.Color.White;
            this.txt_tel1_empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tel1_empresa.Location = new System.Drawing.Point(234, 466);
            this.txt_tel1_empresa.MaxLength = 15;
            this.txt_tel1_empresa.Name = "txt_tel1_empresa";
            this.txt_tel1_empresa.Size = new System.Drawing.Size(193, 26);
            this.txt_tel1_empresa.TabIndex = 7;
            this.txt_tel1_empresa.TextChanged += new System.EventHandler(this.txt_tel1_empresa_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(227, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 31);
            this.label9.TabIndex = 93;
            this.label9.Text = "ID";
            // 
            // txt_id_empresa
            // 
            this.txt_id_empresa.BackColor = System.Drawing.Color.White;
            this.txt_id_empresa.Enabled = false;
            this.txt_id_empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_empresa.Location = new System.Drawing.Point(233, 131);
            this.txt_id_empresa.MaxLength = 30;
            this.txt_id_empresa.Name = "txt_id_empresa";
            this.txt_id_empresa.ReadOnly = true;
            this.txt_id_empresa.Size = new System.Drawing.Size(193, 26);
            this.txt_id_empresa.TabIndex = 0;
            this.txt_id_empresa.TextChanged += new System.EventHandler(this.txt_id_empresa_TextChanged);
            // 
            // btn_save_empresa
            // 
            this.btn_save_empresa.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_save_empresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save_empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_empresa.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_save_empresa.Location = new System.Drawing.Point(517, 625);
            this.btn_save_empresa.Name = "btn_save_empresa";
            this.btn_save_empresa.Size = new System.Drawing.Size(164, 64);
            this.btn_save_empresa.TabIndex = 9;
            this.btn_save_empresa.Text = "Guardar";
            this.btn_save_empresa.UseVisualStyleBackColor = false;
            this.btn_save_empresa.Click += new System.EventHandler(this.btn_save_empresa_Click);
            // 
            // bencalethDataSet1
            // 
            this.bencalethDataSet1.DataSetName = "BencalethDataSet1";
            this.bencalethDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // combobox_empresasBindingSource
            // 
            this.combobox_empresasBindingSource.DataMember = "combobox_empresas";
            this.combobox_empresasBindingSource.DataSource = this.bencalethDataSet1;
            // 
            // combobox_empresasTableAdapter
            // 
            this.combobox_empresasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = PantallaInicio.BencalethDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // combobox_empresasBindingSource1
            // 
            this.combobox_empresasBindingSource1.DataMember = "combobox_empresas";
            this.combobox_empresasBindingSource1.DataSource = this.bencalethDataSet1;
            // 
            // combobox_empresasComboBox
            // 
            this.combobox_empresasComboBox.BackColor = System.Drawing.Color.White;
            this.combobox_empresasComboBox.DataSource = this.combobox_empresasBindingSource1;
            this.combobox_empresasComboBox.DisplayMember = "Descripcion";
            this.combobox_empresasComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_empresasComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobox_empresasComboBox.FormattingEnabled = true;
            this.combobox_empresasComboBox.Location = new System.Drawing.Point(233, 216);
            this.combobox_empresasComboBox.Name = "combobox_empresasComboBox";
            this.combobox_empresasComboBox.Size = new System.Drawing.Size(193, 28);
            this.combobox_empresasComboBox.TabIndex = 2;
            this.combobox_empresasComboBox.ValueMember = "Id";
            this.combobox_empresasComboBox.SelectedIndexChanged += new System.EventHandler(this.combobox_empresasComboBox_SelectedIndexChanged);
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
            // errorProvider7
            // 
            this.errorProvider7.ContainerControl = this;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(233, 517);
            this.maskedTextBox1.Mask = "000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(193, 26);
            this.maskedTextBox1.TabIndex = 112;
            this.maskedTextBox1.Visible = false;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox2.HidePromptOnLeave = true;
            this.maskedTextBox2.Location = new System.Drawing.Point(486, 517);
            this.maskedTextBox2.Mask = "000-0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(193, 26);
            this.maskedTextBox2.TabIndex = 113;
            this.maskedTextBox2.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PantallaInicio.Properties.Resources.Sin_nombre_EN_BLANCO;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 122;
            this.pictureBox1.TabStop = false;
            // 
            // IngresarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1008, 756);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.combobox_empresasComboBox);
            this.Controls.Add(this.btn_save_empresa);
            this.Controls.Add(this.txt_tel1_empresa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_contac_empresa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_pasi_empresa);
            this.Controls.Add(this.txt_email_empresa);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_tel2_empresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_id_empresa);
            this.Controls.Add(this.txt_dire_empresa);
            this.Controls.Add(this.txt_nom_empresa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IngresarEmpresa";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.IngresarEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bencalethDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combobox_empresasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combobox_empresasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_pasi_empresa;
        private System.Windows.Forms.TextBox txt_email_empresa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_tel2_empresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_dire_empresa;
        private System.Windows.Forms.TextBox txt_nom_empresa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_contac_empresa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_tel1_empresa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_id_empresa;
        private System.Windows.Forms.Button btn_save_empresa;
        private BencalethDataSet1 bencalethDataSet1;
        private System.Windows.Forms.BindingSource combobox_empresasBindingSource;
        private BencalethDataSet1TableAdapters.combobox_empresasTableAdapter combobox_empresasTableAdapter;
        private BencalethDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource combobox_empresasBindingSource1;
        private System.Windows.Forms.ComboBox combobox_empresasComboBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.ErrorProvider errorProvider7;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}