namespace HolaMundo
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
            btnValidar = new Button();
            txtContraseña1 = new TextBox();
            txtContraseña2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnValidar
            // 
            btnValidar.BackColor = SystemColors.AppWorkspace;
            btnValidar.Location = new Point(260, 186);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(247, 47);
            btnValidar.TabIndex = 0;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = false;
            btnValidar.Click += btnValidar_Click;
            // 
            // txtContraseña1
            // 
            txtContraseña1.Location = new Point(260, 58);
            txtContraseña1.Name = "txtContraseña1";
            txtContraseña1.PasswordChar = '*';
            txtContraseña1.Size = new Size(247, 31);
            txtContraseña1.TabIndex = 1;
            // 
            // txtContraseña2
            // 
            txtContraseña2.Location = new Point(260, 119);
            txtContraseña2.Name = "txtContraseña2";
            txtContraseña2.PasswordChar = '*';
            txtContraseña2.Size = new Size(247, 31);
            txtContraseña2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 64);
            label1.Name = "label1";
            label1.Size = new Size(161, 25);
            label1.TabIndex = 3;
            label1.Text = "Ingresa contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 125);
            label2.Name = "label2";
            label2.Size = new Size(155, 25);
            label2.TabIndex = 4;
            label2.Text = "Repite Contraseña";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(559, 289);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtContraseña2);
            Controls.Add(txtContraseña1);
            Controls.Add(btnValidar);
            Name = "Form1";
            Text = "Validación de contraseña";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnValidar;
        private TextBox txtContraseña1;
        private TextBox txtContraseña2;
        private Label label1;
        private Label label2;
    }
}
