namespace MultiForm
{
    partial class Form1
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
            this.loginBtn = new System.Windows.Forms.Button();
            this.userTxtBox = new System.Windows.Forms.TextBox();
            this.pswTxtBox = new System.Windows.Forms.TextBox();
            this.usrLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(68, 182);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(147, 45);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // userTxtBox
            // 
            this.userTxtBox.Location = new System.Drawing.Point(47, 45);
            this.userTxtBox.Name = "userTxtBox";
            this.userTxtBox.Size = new System.Drawing.Size(183, 20);
            this.userTxtBox.TabIndex = 1;
            this.userTxtBox.TextChanged += new System.EventHandler(this.userTxtBox_TextChanged);
            // 
            // pswTxtBox
            // 
            this.pswTxtBox.Location = new System.Drawing.Point(47, 138);
            this.pswTxtBox.Name = "pswTxtBox";
            this.pswTxtBox.Size = new System.Drawing.Size(183, 20);
            this.pswTxtBox.TabIndex = 2;
            this.pswTxtBox.TextChanged += new System.EventHandler(this.pswTxtBox_TextChanged);
            // 
            // usrLbl
            // 
            this.usrLbl.AutoSize = true;
            this.usrLbl.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrLbl.Location = new System.Drawing.Point(103, 9);
            this.usrLbl.Name = "usrLbl";
            this.usrLbl.Size = new System.Drawing.Size(84, 25);
            this.usrLbl.TabIndex = 3;
            this.usrLbl.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Contraseña:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 252);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usrLbl);
            this.Controls.Add(this.pswTxtBox);
            this.Controls.Add(this.userTxtBox);
            this.Controls.Add(this.loginBtn);
            this.Name = "Form1";
            this.Text = "asd";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox userTxtBox;
        private System.Windows.Forms.TextBox pswTxtBox;
        private System.Windows.Forms.Label usrLbl;
        private System.Windows.Forms.Label label1;
    }
}

