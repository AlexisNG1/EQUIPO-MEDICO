namespace MultiForm
{
    partial class Form2
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.ColumnaNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnaApellido1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnaTelefono = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnaEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnaNombre,
            this.ColumnaApellido1,
            this.ColumnaTelefono,
            this.ColumnaEstado});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(19, 112);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(641, 273);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ColumnaNombre
            // 
            this.ColumnaNombre.Text = "Nombre(s)";
            this.ColumnaNombre.Width = 104;
            // 
            // ColumnaApellido1
            // 
            this.ColumnaApellido1.Text = "Apellido";
            this.ColumnaApellido1.Width = 98;
            // 
            // ColumnaTelefono
            // 
            this.ColumnaTelefono.Text = "Telefono";
            this.ColumnaTelefono.Width = 101;
            // 
            // ColumnaEstado
            // 
            this.ColumnaEstado.Text = "Estado";
            this.ColumnaEstado.Width = 144;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "sd";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ColumnaNombre;
        private System.Windows.Forms.ColumnHeader ColumnaApellido1;
        private System.Windows.Forms.ColumnHeader ColumnaTelefono;
        private System.Windows.Forms.ColumnHeader ColumnaEstado;
    }
}