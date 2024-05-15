namespace Formulario
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSalir = new Button();
            btnAtender = new Button();
            lblMedico = new Label();
            lblPaciente = new Label();
            lstPacientes = new ListBox();
            rtbInfoMedico = new RichTextBox();
            lstMedicos = new ListBox();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(786, 471);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(307, 78);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir\r\n";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAtender
            // 
            btnAtender.Location = new Point(786, 41);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(307, 78);
            btnAtender.TabIndex = 2;
            btnAtender.Text = "Atender";
            btnAtender.UseVisualStyleBackColor = true;
            btnAtender.Click += btnAtender_Click;
            // 
            // lblMedico
            // 
            lblMedico.AutoSize = true;
            lblMedico.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMedico.Location = new Point(12, 20);
            lblMedico.Name = "lblMedico";
            lblMedico.Size = new Size(150, 25);
            lblMedico.TabIndex = 3;
            lblMedico.Text = "Personal Médico";
            lblMedico.Click += label1_Click;
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPaciente.Location = new Point(410, 20);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(82, 25);
            lblPaciente.TabIndex = 4;
            lblPaciente.Text = "Paciente";
            // 
            // lstPacientes
            // 
            lstPacientes.FormattingEnabled = true;
            lstPacientes.ItemHeight = 25;
            lstPacientes.Location = new Point(399, 72);
            lstPacientes.Name = "lstPacientes";
            lstPacientes.Size = new Size(355, 279);
            lstPacientes.TabIndex = 6;
            // 
            // rtbInfoMedico
            // 
            rtbInfoMedico.Location = new Point(12, 377);
            rtbInfoMedico.Name = "rtbInfoMedico";
            rtbInfoMedico.Size = new Size(742, 188);
            rtbInfoMedico.TabIndex = 8;
            rtbInfoMedico.Text = "";
            // 
            // lstMedicos
            // 
            lstMedicos.FormattingEnabled = true;
            lstMedicos.ItemHeight = 25;
            lstMedicos.Location = new Point(12, 72);
            lstMedicos.Name = "lstMedicos";
            lstMedicos.Size = new Size(355, 279);
            lstMedicos.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 592);
            Controls.Add(lstMedicos);
            Controls.Add(rtbInfoMedico);
            Controls.Add(lstPacientes);
            Controls.Add(lblPaciente);
            Controls.Add(lblMedico);
            Controls.Add(btnAtender);
            Controls.Add(btnSalir);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alumno";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSalir;
        private Button btnAtender;
        private Label lblMedico;
        private Label lblPaciente;
        private ListBox lstPacientes;
        private RichTextBox rtbInfoMedico;
        private ListBox lstMedicos;
    }
}
