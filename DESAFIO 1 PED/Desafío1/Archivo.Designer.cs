
namespace Desafío1
{
    partial class Archivo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.nPaciente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pGenero = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tSangre = new System.Windows.Forms.Label();
            this.Sangre = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.npresion = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnDraw
            // 
            this.btnDraw.BackColor = System.Drawing.Color.LightCoral;
            this.btnDraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDraw.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDraw.Location = new System.Drawing.Point(1270, 544);
            this.btnDraw.Margin = new System.Windows.Forms.Padding(4);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(167, 28);
            this.btnDraw.TabIndex = 4;
            this.btnDraw.Text = "Mostrar Paciente";
            this.btnDraw.UseVisualStyleBackColor = false;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.LightCoral;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBorrar.Location = new System.Drawing.Point(1270, 508);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(167, 28);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Limpiar pantalla";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.LightCoral;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegistrar.Location = new System.Drawing.Point(1268, 472);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(169, 28);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.AllowDrop = true;
            this.btnSalir.BackColor = System.Drawing.Color.LightCoral;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(53, 704);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(99, 43);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // nPaciente
            // 
            this.nPaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nPaciente.Location = new System.Drawing.Point(1213, 130);
            this.nPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.nPaciente.Name = "nPaciente";
            this.nPaciente.Size = new System.Drawing.Size(257, 22);
            this.nPaciente.TabIndex = 0;
            this.nPaciente.TextChanged += new System.EventHandler(this.nPaciente_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(1204, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese Nombre y Apellido";
            // 
            // pGenero
            // 
            this.pGenero.FormattingEnabled = true;
            this.pGenero.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.pGenero.Location = new System.Drawing.Point(1270, 203);
            this.pGenero.Margin = new System.Windows.Forms.Padding(4);
            this.pGenero.Name = "pGenero";
            this.pGenero.Size = new System.Drawing.Size(160, 24);
            this.pGenero.TabIndex = 2;
            this.pGenero.SelectedIndexChanged += new System.EventHandler(this.pGenero_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(1320, 173);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Genero";
            // 
            // tSangre
            // 
            this.tSangre.AutoSize = true;
            this.tSangre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tSangre.Location = new System.Drawing.Point(1297, 269);
            this.tSangre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tSangre.Name = "tSangre";
            this.tSangre.Size = new System.Drawing.Size(101, 16);
            this.tSangre.TabIndex = 4;
            this.tSangre.Text = "Tipo de Sangre";
            // 
            // Sangre
            // 
            this.Sangre.FormattingEnabled = true;
            this.Sangre.Items.AddRange(new object[] {
            "A",
            "B",
            "AB",
            "O"});
            this.Sangre.Location = new System.Drawing.Point(1270, 300);
            this.Sangre.Margin = new System.Windows.Forms.Padding(4);
            this.Sangre.Name = "Sangre";
            this.Sangre.Size = new System.Drawing.Size(160, 24);
            this.Sangre.TabIndex = 5;
            this.Sangre.SelectedIndexChanged += new System.EventHandler(this.Sangre_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(1297, 367);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nivel de Presión";
            // 
            // npresion
            // 
            this.npresion.FormattingEnabled = true;
            this.npresion.Items.AddRange(new object[] {
            "Baja",
            "Media",
            "Alta"});
            this.npresion.Location = new System.Drawing.Point(1270, 397);
            this.npresion.Margin = new System.Windows.Forms.Padding(4);
            this.npresion.Name = "npresion";
            this.npresion.Size = new System.Drawing.Size(160, 24);
            this.npresion.TabIndex = 7;
            this.npresion.SelectedIndexChanged += new System.EventHandler(this.npresion_SelectedIndexChanged);
            // 
            // Archivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1600, 762);
            this.Controls.Add(this.npresion);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.Sangre);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.tSangre);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.pGenero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nPaciente);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Archivo";
            this.Text = "Control de Pacientes";
            this.Load += new System.EventHandler(this.archivo_Load);
            this.Click += new System.EventHandler(this.btnBorrar_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.archivo_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox nPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox pGenero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tSangre;
        private System.Windows.Forms.ComboBox Sangre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox npresion;
    }
}

