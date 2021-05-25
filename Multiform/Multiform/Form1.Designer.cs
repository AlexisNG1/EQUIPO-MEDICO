
namespace Multiform
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.loginbtn = new System.Windows.Forms.Button();
            this.userTxtBox = new System.Windows.Forms.TextBox();
            this.UserTxtBox2 = new System.Windows.Forms.TextBox();
            this.usuario = new System.Windows.Forms.Label();
            this.contra = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginbtn
            // 
            this.loginbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginbtn.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.Location = new System.Drawing.Point(103, 218);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(143, 61);
            this.loginbtn.TabIndex = 0;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // userTxtBox
            // 
            this.userTxtBox.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTxtBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.userTxtBox.Location = new System.Drawing.Point(70, 100);
            this.userTxtBox.Name = "userTxtBox";
            this.userTxtBox.Size = new System.Drawing.Size(214, 21);
            this.userTxtBox.TabIndex = 1;
            this.userTxtBox.Text = "Ingresa tu usuario";
            this.userTxtBox.TextChanged += new System.EventHandler(this.userTxtBox_TextChanged);
            // 
            // UserTxtBox2
            // 
            this.UserTxtBox2.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTxtBox2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.UserTxtBox2.Location = new System.Drawing.Point(70, 158);
            this.UserTxtBox2.Name = "UserTxtBox2";
            this.UserTxtBox2.Size = new System.Drawing.Size(214, 21);
            this.UserTxtBox2.TabIndex = 2;
            this.UserTxtBox2.Text = "Ingresa tu contraseña ";
            this.UserTxtBox2.TextChanged += new System.EventHandler(this.UserTxtBox2_TextChanged);
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.Location = new System.Drawing.Point(133, 69);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(89, 19);
            this.usuario.TabIndex = 3;
            this.usuario.Text = "Usuario:";
            this.usuario.Click += new System.EventHandler(this.usuario_Click);
            // 
            // contra
            // 
            this.contra.AutoSize = true;
            this.contra.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contra.Location = new System.Drawing.Point(114, 136);
            this.contra.Name = "contra";
            this.contra.Size = new System.Drawing.Size(119, 19);
            this.contra.TabIndex = 4;
            this.contra.Text = "Contraseña:";
            this.contra.Click += new System.EventHandler(this.contra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "Departamento de Biomédica\r\nInventario del equipo médico";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(347, 308);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contra);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.UserTxtBox2);
            this.Controls.Add(this.userTxtBox);
            this.Controls.Add(this.loginbtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario.exe";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.TextBox userTxtBox;
        private System.Windows.Forms.TextBox UserTxtBox2;
        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.Label contra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

