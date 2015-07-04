namespace PantallaInicio
{
    partial class Cambio_Contraseña
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Newpassw = new System.Windows.Forms.TextBox();
            this.txt_Confimpassw = new System.Windows.Forms.TextBox();
            this.btn_Acep = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.bencalethDataSet = new PantallaInicio.BencalethDataSet();
            this.mostarUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mostarUsuariosTableAdapter = new PantallaInicio.BencalethDataSetTableAdapters.MostarUsuariosTableAdapter();
            this.tableAdapterManager = new PantallaInicio.BencalethDataSetTableAdapters.TableAdapterManager();
            this.mostarUsuariosComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bencalethDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostarUsuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(150, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = " Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(55, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nueva Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(25, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirmar Contraseña";
            // 
            // txt_Newpassw
            // 
            this.txt_Newpassw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Newpassw.Location = new System.Drawing.Point(258, 146);
            this.txt_Newpassw.MaxLength = 30;
            this.txt_Newpassw.Name = "txt_Newpassw";
            this.txt_Newpassw.Size = new System.Drawing.Size(157, 26);
            this.txt_Newpassw.TabIndex = 6;
            this.txt_Newpassw.TextChanged += new System.EventHandler(this.txt_Newpassw_TextChanged_1);
            this.txt_Newpassw.Leave += new System.EventHandler(this.txt_Newpassw_Leave);
            // 
            // txt_Confimpassw
            // 
            this.txt_Confimpassw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Confimpassw.Location = new System.Drawing.Point(258, 203);
            this.txt_Confimpassw.MaxLength = 30;
            this.txt_Confimpassw.Name = "txt_Confimpassw";
            this.txt_Confimpassw.Size = new System.Drawing.Size(157, 26);
            this.txt_Confimpassw.TabIndex = 7;
            this.txt_Confimpassw.TextChanged += new System.EventHandler(this.txt_Confimpassw_TextChanged_1);
            this.txt_Confimpassw.Leave += new System.EventHandler(this.txt_Confimpassw_Leave);
            // 
            // btn_Acep
            // 
            this.btn_Acep.BackColor = System.Drawing.Color.White;
            this.btn_Acep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Acep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Acep.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_Acep.Location = new System.Drawing.Point(107, 261);
            this.btn_Acep.Name = "btn_Acep";
            this.btn_Acep.Size = new System.Drawing.Size(130, 50);
            this.btn_Acep.TabIndex = 8;
            this.btn_Acep.Text = "Aceptar";
            this.btn_Acep.UseVisualStyleBackColor = false;
            this.btn_Acep.Click += new System.EventHandler(this.btn_Acep_Click_1);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.White;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_Cancel.Location = new System.Drawing.Point(285, 261);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(130, 50);
            this.btn_Cancel.TabIndex = 9;
            this.btn_Cancel.Text = "Cancelar";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // bencalethDataSet
            // 
            this.bencalethDataSet.DataSetName = "BencalethDataSet";
            this.bencalethDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mostarUsuariosBindingSource
            // 
            this.mostarUsuariosBindingSource.DataMember = "MostarUsuarios";
            this.mostarUsuariosBindingSource.DataSource = this.bencalethDataSet;
            // 
            // mostarUsuariosTableAdapter
            // 
            this.mostarUsuariosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = PantallaInicio.BencalethDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mostarUsuariosComboBox
            // 
            this.mostarUsuariosComboBox.DataSource = this.mostarUsuariosBindingSource;
            this.mostarUsuariosComboBox.DisplayMember = "Nombre";
            this.mostarUsuariosComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mostarUsuariosComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostarUsuariosComboBox.FormattingEnabled = true;
            this.mostarUsuariosComboBox.Location = new System.Drawing.Point(258, 92);
            this.mostarUsuariosComboBox.Name = "mostarUsuariosComboBox";
            this.mostarUsuariosComboBox.Size = new System.Drawing.Size(157, 28);
            this.mostarUsuariosComboBox.TabIndex = 10;
            this.mostarUsuariosComboBox.ValueMember = "Nombre";
            // 
            // Cambio_Contraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(494, 381);
            this.ControlBox = false;
            this.Controls.Add(this.mostarUsuariosComboBox);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Acep);
            this.Controls.Add(this.txt_Confimpassw);
            this.Controls.Add(this.txt_Newpassw);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cambio_Contraseña";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambio de Contraseña";
            this.Load += new System.EventHandler(this.Cambio_Contraseña_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bencalethDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostarUsuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Newpassw;
        private System.Windows.Forms.TextBox txt_Confimpassw;
        private System.Windows.Forms.Button btn_Acep;
        private System.Windows.Forms.Button btn_Cancel;
        private BencalethDataSet bencalethDataSet;
        private System.Windows.Forms.BindingSource mostarUsuariosBindingSource;
        private BencalethDataSetTableAdapters.MostarUsuariosTableAdapter mostarUsuariosTableAdapter;
        private BencalethDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox mostarUsuariosComboBox;
    }
}