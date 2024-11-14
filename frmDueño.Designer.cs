
namespace CatDogVeterinaria
{
    partial class frmDueño
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDDueño = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreDueño = new System.Windows.Forms.TextBox();
            this.txtApellidoDueño = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefonoDueño = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDireccionDueño = new System.Windows.Forms.TextBox();
            this.btnGuardarDueño = new System.Windows.Forms.Button();
            this.txtModificarDueño = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnCerrarDueño = new System.Windows.Forms.Button();
            this.dgvDueños = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDueños)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID del dueño:";
            // 
            // txtIDDueño
            // 
            this.txtIDDueño.Location = new System.Drawing.Point(167, 28);
            this.txtIDDueño.Name = "txtIDDueño";
            this.txtIDDueño.Size = new System.Drawing.Size(111, 24);
            this.txtIDDueño.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre del dueño:";
            // 
            // txtNombreDueño
            // 
            this.txtNombreDueño.Location = new System.Drawing.Point(484, 22);
            this.txtNombreDueño.Name = "txtNombreDueño";
            this.txtNombreDueño.Size = new System.Drawing.Size(100, 24);
            this.txtNombreDueño.TabIndex = 3;
            // 
            // txtApellidoDueño
            // 
            this.txtApellidoDueño.Location = new System.Drawing.Point(167, 87);
            this.txtApellidoDueño.Name = "txtApellidoDueño";
            this.txtApellidoDueño.Size = new System.Drawing.Size(100, 24);
            this.txtApellidoDueño.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido del dueño:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Numero de Telefono: ";
            // 
            // txtTelefonoDueño
            // 
            this.txtTelefonoDueño.Location = new System.Drawing.Point(484, 84);
            this.txtTelefonoDueño.Name = "txtTelefonoDueño";
            this.txtTelefonoDueño.Size = new System.Drawing.Size(100, 24);
            this.txtTelefonoDueño.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Direccion: ";
            // 
            // txtDireccionDueño
            // 
            this.txtDireccionDueño.Location = new System.Drawing.Point(111, 147);
            this.txtDireccionDueño.Name = "txtDireccionDueño";
            this.txtDireccionDueño.Size = new System.Drawing.Size(493, 24);
            this.txtDireccionDueño.TabIndex = 9;
            // 
            // btnGuardarDueño
            // 
            this.btnGuardarDueño.Location = new System.Drawing.Point(17, 198);
            this.btnGuardarDueño.Name = "btnGuardarDueño";
            this.btnGuardarDueño.Size = new System.Drawing.Size(110, 51);
            this.btnGuardarDueño.TabIndex = 10;
            this.btnGuardarDueño.Text = "Guardar Informacion";
            this.btnGuardarDueño.UseVisualStyleBackColor = true;
            this.btnGuardarDueño.Click += new System.EventHandler(this.btnGuardarDueño_Click);
            // 
            // txtModificarDueño
            // 
            this.txtModificarDueño.Location = new System.Drawing.Point(151, 198);
            this.txtModificarDueño.Name = "txtModificarDueño";
            this.txtModificarDueño.Size = new System.Drawing.Size(116, 51);
            this.txtModificarDueño.TabIndex = 11;
            this.txtModificarDueño.Text = "Modificar Informacion";
            this.txtModificarDueño.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(281, 198);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 51);
            this.button3.TabIndex = 12;
            this.button3.Text = "Eliminar Informacion";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(403, 201);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 50);
            this.button4.TabIndex = 13;
            this.button4.Text = "Limpiar Formulario";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnCerrarDueño
            // 
            this.btnCerrarDueño.Location = new System.Drawing.Point(538, 200);
            this.btnCerrarDueño.Name = "btnCerrarDueño";
            this.btnCerrarDueño.Size = new System.Drawing.Size(122, 51);
            this.btnCerrarDueño.TabIndex = 14;
            this.btnCerrarDueño.Text = "Cerrar formulario";
            this.btnCerrarDueño.UseVisualStyleBackColor = true;
            // 
            // dgvDueños
            // 
            this.dgvDueños.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDueños.Location = new System.Drawing.Point(93, 283);
            this.dgvDueños.Name = "dgvDueños";
            this.dgvDueños.Size = new System.Drawing.Size(385, 150);
            this.dgvDueños.TabIndex = 15;
            // 
            // frmDueño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(672, 445);
            this.Controls.Add(this.dgvDueños);
            this.Controls.Add(this.btnCerrarDueño);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtModificarDueño);
            this.Controls.Add(this.btnGuardarDueño);
            this.Controls.Add(this.txtDireccionDueño);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTelefonoDueño);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtApellidoDueño);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreDueño);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDDueño);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDueño";
            this.Text = "frmDueño";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDueños)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDDueño;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreDueño;
        private System.Windows.Forms.TextBox txtApellidoDueño;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefonoDueño;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDireccionDueño;
        private System.Windows.Forms.Button btnGuardarDueño;
        private System.Windows.Forms.Button txtModificarDueño;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnCerrarDueño;
        private System.Windows.Forms.DataGridView dgvDueños;
    }
}