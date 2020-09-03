namespace BankApp_0._1_Solution
{
    partial class LoginForm
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
            this.label29 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.AgenciasComboBox = new System.Windows.Forms.ComboBox();
            this.AccederButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Nachlieli CLM", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label29.Location = new System.Drawing.Point(75, 126);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(77, 18);
            this.label29.TabIndex = 15;
            this.label29.Text = "Password";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Nachlieli CLM", 12F, System.Drawing.FontStyle.Bold);
            this.PasswordTextBox.Location = new System.Drawing.Point(161, 123);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(138, 26);
            this.PasswordTextBox.TabIndex = 14;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Nachlieli CLM", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label31.Location = new System.Drawing.Point(75, 79);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(63, 18);
            this.label31.TabIndex = 13;
            this.label31.Text = "Usuario";
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Font = new System.Drawing.Font("Nachlieli CLM", 12F, System.Drawing.FontStyle.Bold);
            this.UsuarioTextBox.Location = new System.Drawing.Point(160, 76);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Size = new System.Drawing.Size(139, 26);
            this.UsuarioTextBox.TabIndex = 12;
            this.UsuarioTextBox.TextChanged += new System.EventHandler(this.SetValue);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Nachlieli CLM", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label14.Location = new System.Drawing.Point(75, 167);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 18);
            this.label14.TabIndex = 17;
            this.label14.Text = "Agencia";
            // 
            // AgenciasComboBox
            // 
            this.AgenciasComboBox.Font = new System.Drawing.Font("Nachlieli CLM", 12F, System.Drawing.FontStyle.Bold);
            this.AgenciasComboBox.FormattingEnabled = true;
            this.AgenciasComboBox.Items.AddRange(new object[] {
            "."});
            this.AgenciasComboBox.Location = new System.Drawing.Point(160, 164);
            this.AgenciasComboBox.Name = "AgenciasComboBox";
            this.AgenciasComboBox.Size = new System.Drawing.Size(139, 26);
            this.AgenciasComboBox.TabIndex = 16;
            this.AgenciasComboBox.SelectedIndexChanged += new System.EventHandler(this.SetValue);
            // 
            // AccederButton
            // 
            this.AccederButton.BackColor = System.Drawing.Color.Yellow;
            this.AccederButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccederButton.Location = new System.Drawing.Point(160, 224);
            this.AccederButton.Name = "AccederButton";
            this.AccederButton.Size = new System.Drawing.Size(139, 61);
            this.AccederButton.TabIndex = 18;
            this.AccederButton.Text = "Acceder";
            this.AccederButton.UseVisualStyleBackColor = false;
            this.AccederButton.Click += new System.EventHandler(this.Login);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 47);
            this.panel1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Miriam Mono CLM", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Banpais";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 330);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AccederButton);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.UsuarioTextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.AgenciasComboBox);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox AgenciasComboBox;
        private System.Windows.Forms.Button AccederButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}