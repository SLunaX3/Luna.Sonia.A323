namespace FormPrincipal
{
    partial class FormPrincipal
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
            rtbAppInstaladas = new RichTextBox();
            rtbAppNoInstaladas = new RichTextBox();
            SuspendLayout();
            // 
            // rtbAppInstaladas
            // 
            rtbAppInstaladas.BackColor = Color.Black;
            rtbAppInstaladas.ForeColor = Color.White;
            rtbAppInstaladas.Location = new Point(26, 24);
            rtbAppInstaladas.Name = "rtbAppInstaladas";
            rtbAppInstaladas.Size = new Size(248, 403);
            rtbAppInstaladas.TabIndex = 0;
            rtbAppInstaladas.Text = "";
            rtbAppInstaladas.UseWaitCursor = true;
            // 
            // rtbAppNoInstaladas
            // 
            rtbAppNoInstaladas.BackColor = Color.Black;
            rtbAppNoInstaladas.ForeColor = Color.White;
            rtbAppNoInstaladas.Location = new Point(315, 24);
            rtbAppNoInstaladas.Name = "rtbAppNoInstaladas";
            rtbAppNoInstaladas.Size = new Size(248, 403);
            rtbAppNoInstaladas.TabIndex = 1;
            rtbAppNoInstaladas.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(581, 450);
            Controls.Add(rtbAppNoInstaladas);
            Controls.Add(rtbAppInstaladas);
            Name = "Form1";
            Text = "RPP.Luna.Sonia";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtbAppInstaladas;
        private RichTextBox rtbAppNoInstaladas;
    }
}