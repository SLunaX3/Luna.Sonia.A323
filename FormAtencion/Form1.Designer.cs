using System.ComponentModel;

namespace FormAtencion
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
            if (disposing && (Components != null))
            {
                Components.Dispose();
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
            btnAtender = new Button();
            btnSalir = new Button();
            lblMedicos = new Label();
            lblPacientes = new Label();
            lstMedicos = new ListBox();
            lstPacientes = new ListBox();
            rtbInfoMedico = new RichTextBox();
            SuspendLayout();
            // 
            // btnAtender
            // 
            btnAtender.Location = new Point(539, 41);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(159, 56);
            btnAtender.TabIndex = 0;
            btnAtender.Text = "Atender";
            btnAtender.UseVisualStyleBackColor = true;
            btnAtender.Click += button1_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(539, 382);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(159, 56);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblMedicos
            // 
            lblMedicos.AutoSize = true;
            lblMedicos.Location = new Point(35, 41);
            lblMedicos.Name = "lblMedicos";
            lblMedicos.Size = new Size(59, 20);
            lblMedicos.TabIndex = 2;
            lblMedicos.Text = "Medico";
            lblMedicos.Click += label1_Click;
            // 
            // lblPacientes
            // 
            lblPacientes.AutoSize = true;
            lblPacientes.Location = new Point(283, 41);
            lblPacientes.Name = "lblPacientes";
            lblPacientes.Size = new Size(64, 20);
            lblPacientes.TabIndex = 3;
            lblPacientes.Text = "Paciente";
            // 
            // lstMedicos
            // 
            lstMedicos.FormattingEnabled = true;
            lstMedicos.Location = new Point(35, 76);
            lstMedicos.Name = "lstMedicos";
            lstMedicos.Size = new Size(195, 124);
            lstMedicos.TabIndex = 4;
            lstMedicos.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // lstPacientes
            // 
            lstPacientes.FormattingEnabled = true;
            lstPacientes.Location = new Point(283, 76);
            lstPacientes.Name = "lstPacientes";
            lstPacientes.Size = new Size(204, 124);
            lstPacientes.TabIndex = 5;
            // 
            // rtbInfoMedico
            // 
            rtbInfoMedico.Location = new Point(64, 272);
            rtbInfoMedico.Name = "rtbInfoMedico";
            rtbInfoMedico.Size = new Size(384, 127);
            rtbInfoMedico.TabIndex = 6;
            rtbInfoMedico.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 450);
            Controls.Add(rtbInfoMedico);
            Controls.Add(lstPacientes);
            Controls.Add(lstMedicos);
            Controls.Add(lblPacientes);
            Controls.Add(lblMedicos);
            Controls.Add(btnSalir);
            Controls.Add(btnAtender);
            Name = "Form1";
            Text = "Luna.Sonia";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAtender;
        private Button btnSalir;
        private Label lblMedicos;
        private Label lblPacientes;
        private ListBox lstMedicos;
        private ListBox lstPacientes;
        private RichTextBox rtbInfoMedico;

        public IContainer Components { get => components; set => components = value; }
    }
}
