namespace PantallaInicio
{
    partial class Inventarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventarios));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.combobox_nomempresaComboBox = new System.Windows.Forms.ComboBox();
            this.combobox_nomempresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bencalethDataSet = new PantallaInicio.BencalethDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Can_Invd = new System.Windows.Forms.TextBox();
            this.txt_Des_Invd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Id_Invd = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboboxResponsablesComboBox = new System.Windows.Forms.ComboBox();
            this.comboboxResponsablesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_save_InTF = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Can_Invf = new System.Windows.Forms.TextBox();
            this.txt_Des_Invf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id_InvF = new System.Windows.Forms.TextBox();
            this.btn_Home = new System.Windows.Forms.Button();
            this.btn_Show_Invs = new System.Windows.Forms.Button();
            this.combobox_nomempresaTableAdapter = new PantallaInicio.BencalethDataSetTableAdapters.combobox_nomempresaTableAdapter();
            this.tableAdapterManager = new PantallaInicio.BencalethDataSetTableAdapters.TableAdapterManager();
            this.comboboxResponsablesTableAdapter = new PantallaInicio.BencalethDataSetTableAdapters.ComboboxResponsablesTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.combobox_nomempresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bencalethDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboboxResponsablesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-9, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(947, 764);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage1.Controls.Add(this.combobox_nomempresaComboBox);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txt_Can_Invd);
            this.tabPage1.Controls.Add(this.txt_Des_Invd);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txt_Id_Invd);
            this.tabPage1.Location = new System.Drawing.Point(4, 43);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(939, 717);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inventario Donaciones";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // combobox_nomempresaComboBox
            // 
            this.combobox_nomempresaComboBox.DataSource = this.combobox_nomempresaBindingSource;
            this.combobox_nomempresaComboBox.DisplayMember = "Nombre";
            this.combobox_nomempresaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_nomempresaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobox_nomempresaComboBox.FormattingEnabled = true;
            this.combobox_nomempresaComboBox.Location = new System.Drawing.Point(256, 337);
            this.combobox_nomempresaComboBox.Name = "combobox_nomempresaComboBox";
            this.combobox_nomempresaComboBox.Size = new System.Drawing.Size(193, 28);
            this.combobox_nomempresaComboBox.TabIndex = 92;
            this.combobox_nomempresaComboBox.ValueMember = "Id";
            // 
            // combobox_nomempresaBindingSource
            // 
            this.combobox_nomempresaBindingSource.DataMember = "combobox_nomempresa";
            this.combobox_nomempresaBindingSource.DataSource = this.bencalethDataSet;
            // 
            // bencalethDataSet
            // 
            this.bencalethDataSet.DataSetName = "BencalethDataSet";
            this.bencalethDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.AliceBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.SteelBlue;
            this.button2.Location = new System.Drawing.Point(572, 451);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 50);
            this.button2.TabIndex = 92;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(250, 303);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 31);
            this.label12.TabIndex = 90;
            this.label12.Text = "Donante";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(503, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 31);
            this.label11.TabIndex = 89;
            this.label11.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(250, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 31);
            this.label6.TabIndex = 88;
            this.label6.Text = "Descripción";
            // 
            // txt_Can_Invd
            // 
            this.txt_Can_Invd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Can_Invd.Location = new System.Drawing.Point(509, 242);
            this.txt_Can_Invd.MaxLength = 8;
            this.txt_Can_Invd.Name = "txt_Can_Invd";
            this.txt_Can_Invd.Size = new System.Drawing.Size(193, 26);
            this.txt_Can_Invd.TabIndex = 87;
            this.txt_Can_Invd.TextChanged += new System.EventHandler(this.txt_Can_Invd_TextChanged);
            // 
            // txt_Des_Invd
            // 
            this.txt_Des_Invd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Des_Invd.Location = new System.Drawing.Point(256, 242);
            this.txt_Des_Invd.MaxLength = 30;
            this.txt_Des_Invd.Name = "txt_Des_Invd";
            this.txt_Des_Invd.Size = new System.Drawing.Size(193, 26);
            this.txt_Des_Invd.TabIndex = 86;
            this.txt_Des_Invd.TextChanged += new System.EventHandler(this.txt_Des_Invd_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(250, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 31);
            this.label9.TabIndex = 85;
            this.label9.Text = "ID";
            // 
            // txt_Id_Invd
            // 
            this.txt_Id_Invd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Id_Invd.Location = new System.Drawing.Point(256, 153);
            this.txt_Id_Invd.MaxLength = 30;
            this.txt_Id_Invd.Name = "txt_Id_Invd";
            this.txt_Id_Invd.Size = new System.Drawing.Size(193, 26);
            this.txt_Id_Invd.TabIndex = 84;
            this.txt_Id_Invd.TextChanged += new System.EventHandler(this.txt_Id_Invd_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage2.Controls.Add(this.comboboxResponsablesComboBox);
            this.tabPage2.Controls.Add(this.btn_save_InTF);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txt_Can_Invf);
            this.tabPage2.Controls.Add(this.txt_Des_Invf);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txt_id_InvF);
            this.tabPage2.Location = new System.Drawing.Point(4, 43);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(939, 717);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Inventario Terapia";
            // 
            // comboboxResponsablesComboBox
            // 
            this.comboboxResponsablesComboBox.DataSource = this.comboboxResponsablesBindingSource;
            this.comboboxResponsablesComboBox.DisplayMember = "Nombre";
            this.comboboxResponsablesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxResponsablesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboboxResponsablesComboBox.FormattingEnabled = true;
            this.comboboxResponsablesComboBox.Location = new System.Drawing.Point(254, 373);
            this.comboboxResponsablesComboBox.Name = "comboboxResponsablesComboBox";
            this.comboboxResponsablesComboBox.Size = new System.Drawing.Size(193, 28);
            this.comboboxResponsablesComboBox.TabIndex = 86;
            this.comboboxResponsablesComboBox.ValueMember = "Id";
            // 
            // comboboxResponsablesBindingSource
            // 
            this.comboboxResponsablesBindingSource.DataMember = "ComboboxResponsables";
            this.comboboxResponsablesBindingSource.DataSource = this.bencalethDataSet;
            // 
            // btn_save_InTF
            // 
            this.btn_save_InTF.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_save_InTF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save_InTF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_InTF.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_save_InTF.Location = new System.Drawing.Point(562, 475);
            this.btn_save_InTF.Name = "btn_save_InTF";
            this.btn_save_InTF.Size = new System.Drawing.Size(130, 50);
            this.btn_save_InTF.TabIndex = 86;
            this.btn_save_InTF.Text = "Guardar";
            this.btn_save_InTF.UseVisualStyleBackColor = false;
            this.btn_save_InTF.Click += new System.EventHandler(this.btn_save_InTF_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(248, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 31);
            this.label5.TabIndex = 84;
            this.label5.Text = "Responsable";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(508, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 31);
            this.label4.TabIndex = 83;
            this.label4.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(248, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 31);
            this.label3.TabIndex = 82;
            this.label3.Text = "Descripción";
            // 
            // txt_Can_Invf
            // 
            this.txt_Can_Invf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Can_Invf.Location = new System.Drawing.Point(517, 270);
            this.txt_Can_Invf.MaxLength = 8;
            this.txt_Can_Invf.Name = "txt_Can_Invf";
            this.txt_Can_Invf.Size = new System.Drawing.Size(193, 26);
            this.txt_Can_Invf.TabIndex = 80;
            this.txt_Can_Invf.TextChanged += new System.EventHandler(this.txt_Can_Invf_TextChanged);
            // 
            // txt_Des_Invf
            // 
            this.txt_Des_Invf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Des_Invf.Location = new System.Drawing.Point(254, 270);
            this.txt_Des_Invf.MaxLength = 30;
            this.txt_Des_Invf.Name = "txt_Des_Invf";
            this.txt_Des_Invf.Size = new System.Drawing.Size(193, 26);
            this.txt_Des_Invf.TabIndex = 79;
            this.txt_Des_Invf.TextChanged += new System.EventHandler(this.txt_Des_Invf_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(248, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 31);
            this.label2.TabIndex = 78;
            this.label2.Text = "ID";
            // 
            // txt_id_InvF
            // 
            this.txt_id_InvF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_InvF.Location = new System.Drawing.Point(254, 170);
            this.txt_id_InvF.MaxLength = 30;
            this.txt_id_InvF.Name = "txt_id_InvF";
            this.txt_id_InvF.Size = new System.Drawing.Size(193, 26);
            this.txt_id_InvF.TabIndex = 76;
            this.txt_id_InvF.TextChanged += new System.EventHandler(this.txt_id_InvF_TextChanged);
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Home.Location = new System.Drawing.Point(1017, 401);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(209, 80);
            this.btn_Home.TabIndex = 6;
            this.btn_Home.Text = "Menú";
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // btn_Show_Invs
            // 
            this.btn_Show_Invs.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Show_Invs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Show_Invs.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Show_Invs.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Show_Invs.Location = new System.Drawing.Point(1017, 273);
            this.btn_Show_Invs.Name = "btn_Show_Invs";
            this.btn_Show_Invs.Size = new System.Drawing.Size(209, 80);
            this.btn_Show_Invs.TabIndex = 7;
            this.btn_Show_Invs.Text = "Ver";
            this.btn_Show_Invs.UseVisualStyleBackColor = false;
            this.btn_Show_Invs.Click += new System.EventHandler(this.btn_Show_Invs_Click);
            // 
            // combobox_nomempresaTableAdapter
            // 
            this.combobox_nomempresaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = PantallaInicio.BencalethDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // comboboxResponsablesTableAdapter
            // 
            this.comboboxResponsablesTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PantallaInicio.Properties.Resources.Logo_Bencaleth_2;
            this.pictureBox1.Location = new System.Drawing.Point(944, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Inventarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1276, 754);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Show_Invs);
            this.Controls.Add(this.btn_Home);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inventarios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Inventarios_FormClosed);
            this.Load += new System.EventHandler(this.Inventarios_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.combobox_nomempresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bencalethDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboboxResponsablesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_id_InvF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_save_InTF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Can_Invf;
        private System.Windows.Forms.TextBox txt_Des_Invf;
        private System.Windows.Forms.TextBox txt_Can_Invd;
        private System.Windows.Forms.TextBox txt_Des_Invd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Id_Invd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Button btn_Show_Invs;
        private BencalethDataSet bencalethDataSet;
        private System.Windows.Forms.BindingSource combobox_nomempresaBindingSource;
        private BencalethDataSetTableAdapters.combobox_nomempresaTableAdapter combobox_nomempresaTableAdapter;
        private BencalethDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox combobox_nomempresaComboBox;
        private System.Windows.Forms.BindingSource comboboxResponsablesBindingSource;
        private BencalethDataSetTableAdapters.ComboboxResponsablesTableAdapter comboboxResponsablesTableAdapter;
        private System.Windows.Forms.ComboBox comboboxResponsablesComboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
    }
}