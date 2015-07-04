namespace PantallaInicio
{
    partial class Agregar_Usuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Nom_Adduser = new System.Windows.Forms.TextBox();
            this.txt_Pass_Adduser = new System.Windows.Forms.TextBox();
            this.txt_Confir_Adduser = new System.Windows.Forms.TextBox();
            this.btn_Cancel_Adduser = new System.Windows.Forms.Button();
            this.btn_Acep_Adduseer = new System.Windows.Forms.Button();
            this.bencalethDataSet = new PantallaInicio.BencalethDataSet();
            this.mostarCargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mostarCargoTableAdapter = new PantallaInicio.BencalethDataSetTableAdapters.mostarCargoTableAdapter();
            this.tableAdapterManager = new PantallaInicio.BencalethDataSetTableAdapters.TableAdapterManager();
            this.mostarCargoComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bencalethDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostarCargoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(129, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(102, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(16, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirmar Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(147, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cargo";
            // 
            // txt_Nom_Adduser
            // 
            this.txt_Nom_Adduser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nom_Adduser.Location = new System.Drawing.Point(242, 71);
            this.txt_Nom_Adduser.MaxLength = 30;
            this.txt_Nom_Adduser.Name = "txt_Nom_Adduser";
            this.txt_Nom_Adduser.Size = new System.Drawing.Size(157, 26);
            this.txt_Nom_Adduser.TabIndex = 5;
            this.txt_Nom_Adduser.TextChanged += new System.EventHandler(this.txt_Nom_Adduser_TextChanged);
            // 
            // txt_Pass_Adduser
            // 
            this.txt_Pass_Adduser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pass_Adduser.Location = new System.Drawing.Point(242, 120);
            this.txt_Pass_Adduser.MaxLength = 30;
            this.txt_Pass_Adduser.Name = "txt_Pass_Adduser";
            this.txt_Pass_Adduser.Size = new System.Drawing.Size(157, 26);
            this.txt_Pass_Adduser.TabIndex = 6;
            this.txt_Pass_Adduser.TextChanged += new System.EventHandler(this.txt_Pass_Adduser_TextChanged);
            // 
            // txt_Confir_Adduser
            // 
            this.txt_Confir_Adduser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Confir_Adduser.Location = new System.Drawing.Point(242, 171);
            this.txt_Confir_Adduser.MaxLength = 30;
            this.txt_Confir_Adduser.Name = "txt_Confir_Adduser";
            this.txt_Confir_Adduser.Size = new System.Drawing.Size(157, 26);
            this.txt_Confir_Adduser.TabIndex = 7;
            this.txt_Confir_Adduser.TextChanged += new System.EventHandler(this.txt_Confir_Adduser_TextChanged);
            // 
            // btn_Cancel_Adduser
            // 
            this.btn_Cancel_Adduser.BackColor = System.Drawing.Color.White;
            this.btn_Cancel_Adduser.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel_Adduser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel_Adduser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel_Adduser.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_Cancel_Adduser.Location = new System.Drawing.Point(269, 280);
            this.btn_Cancel_Adduser.Name = "btn_Cancel_Adduser";
            this.btn_Cancel_Adduser.Size = new System.Drawing.Size(130, 50);
            this.btn_Cancel_Adduser.TabIndex = 11;
            this.btn_Cancel_Adduser.Text = "Cancelar";
            this.btn_Cancel_Adduser.UseVisualStyleBackColor = false;
            this.btn_Cancel_Adduser.Click += new System.EventHandler(this.btn_Cancel_Adduser_Click);
            // 
            // btn_Acep_Adduseer
            // 
            this.btn_Acep_Adduseer.BackColor = System.Drawing.Color.White;
            this.btn_Acep_Adduseer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Acep_Adduseer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Acep_Adduseer.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_Acep_Adduseer.Location = new System.Drawing.Point(78, 280);
            this.btn_Acep_Adduseer.Name = "btn_Acep_Adduseer";
            this.btn_Acep_Adduseer.Size = new System.Drawing.Size(130, 50);
            this.btn_Acep_Adduseer.TabIndex = 10;
            this.btn_Acep_Adduseer.Text = "Aceptar";
            this.btn_Acep_Adduseer.UseVisualStyleBackColor = false;
            this.btn_Acep_Adduseer.Click += new System.EventHandler(this.btn_Acep_Adduseer_Click);
            // 
            // bencalethDataSet
            // 
            this.bencalethDataSet.DataSetName = "BencalethDataSet";
            this.bencalethDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mostarCargoBindingSource
            // 
            this.mostarCargoBindingSource.DataMember = "mostarCargo";
            this.mostarCargoBindingSource.DataSource = this.bencalethDataSet;
            // 
            // mostarCargoTableAdapter
            // 
            this.mostarCargoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = PantallaInicio.BencalethDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mostarCargoComboBox
            // 
            this.mostarCargoComboBox.DataSource = this.mostarCargoBindingSource;
            this.mostarCargoComboBox.DisplayMember = "descripcion";
            this.mostarCargoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mostarCargoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostarCargoComboBox.FormattingEnabled = true;
            this.mostarCargoComboBox.Location = new System.Drawing.Point(242, 216);
            this.mostarCargoComboBox.Name = "mostarCargoComboBox";
            this.mostarCargoComboBox.Size = new System.Drawing.Size(157, 28);
            this.mostarCargoComboBox.TabIndex = 12;
            this.mostarCargoComboBox.ValueMember = "id";
            // 
            // Agregar_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(494, 381);
            this.ControlBox = false;
            this.Controls.Add(this.mostarCargoComboBox);
            this.Controls.Add(this.btn_Cancel_Adduser);
            this.Controls.Add(this.btn_Acep_Adduseer);
            this.Controls.Add(this.txt_Confir_Adduser);
            this.Controls.Add(this.txt_Pass_Adduser);
            this.Controls.Add(this.txt_Nom_Adduser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Agregar_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.bencalethDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostarCargoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Nom_Adduser;
        private System.Windows.Forms.TextBox txt_Pass_Adduser;
        private System.Windows.Forms.TextBox txt_Confir_Adduser;
        private System.Windows.Forms.Button btn_Cancel_Adduser;
        private System.Windows.Forms.Button btn_Acep_Adduseer;
        private BencalethDataSet bencalethDataSet;
        private System.Windows.Forms.BindingSource mostarCargoBindingSource;
        private BencalethDataSetTableAdapters.mostarCargoTableAdapter mostarCargoTableAdapter;
        private BencalethDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox mostarCargoComboBox;
    }
}