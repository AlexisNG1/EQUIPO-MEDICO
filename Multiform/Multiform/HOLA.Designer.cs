
namespace Multiform
{
    partial class HOLA
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HOLA));
            this.Text1 = new System.Windows.Forms.Label();
            this.Inventario = new System.Windows.Forms.ListView();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Equipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Marca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Estado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Text2 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtEquipo = new System.Windows.Forms.TextBox();
            this.TxtMarca = new System.Windows.Forms.TextBox();
            this.TxtNS = new System.Windows.Forms.TextBox();
            this.TxtEstado = new System.Windows.Forms.TextBox();
            this.Equipotxt = new System.Windows.Forms.Label();
            this.MarcaTxt = new System.Windows.Forms.Label();
            this.NStxt = new System.Windows.Forms.Label();
            this.EstadoTxt = new System.Windows.Forms.Label();
            this.Añadirbtn = new System.Windows.Forms.Button();
            this.Mostrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Text1
            // 
            this.Text1.AutoSize = true;
            this.Text1.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text1.Location = new System.Drawing.Point(12, 9);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(88, 29);
            this.Text1.TabIndex = 0;
            this.Text1.Text = "texto";
            this.Text1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Inventario
            // 
            this.Inventario.BackColor = System.Drawing.Color.LightCyan;
            this.Inventario.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Equipo,
            this.Marca,
            this.NS,
            this.Estado});
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "listViewGroup2";
            listViewGroup3.Header = "ListViewGroup";
            listViewGroup3.Name = "listViewGroup3";
            listViewGroup4.Header = "ListViewGroup";
            listViewGroup4.Name = "listViewGroup4";
            this.Inventario.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4});
            this.Inventario.HideSelection = false;
            this.Inventario.Location = new System.Drawing.Point(33, 213);
            this.Inventario.Name = "Inventario";
            this.Inventario.Size = new System.Drawing.Size(569, 171);
            this.Inventario.TabIndex = 1;
            this.Inventario.UseCompatibleStateImageBehavior = false;
            this.Inventario.View = System.Windows.Forms.View.Details;
            this.Inventario.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 104;
            // 
            // Equipo
            // 
            this.Equipo.Text = "Equipo";
            this.Equipo.Width = 110;
            // 
            // Marca
            // 
            this.Marca.Text = "Marca";
            this.Marca.Width = 109;
            // 
            // NS
            // 
            this.NS.Text = "NS";
            this.NS.Width = 103;
            // 
            // Estado
            // 
            this.Estado.Text = "Estado";
            this.Estado.Width = 146;
            // 
            // Text2
            // 
            this.Text2.AutoSize = true;
            this.Text2.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text2.Location = new System.Drawing.Point(18, 38);
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(82, 23);
            this.Text2.TabIndex = 2;
            this.Text2.Text = "label1";
            // 
            // TxtName
            // 
            this.TxtName.AutoSize = true;
            this.TxtName.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(18, 75);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(69, 19);
            this.TxtName.TabIndex = 3;
            this.TxtName.Text = "Nombre";
            this.TxtName.Click += new System.EventHandler(this.TxtName_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TxtNombre.Location = new System.Drawing.Point(17, 97);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(125, 20);
            this.TxtNombre.TabIndex = 4;
            // 
            // TxtEquipo
            // 
            this.TxtEquipo.Location = new System.Drawing.Point(204, 96);
            this.TxtEquipo.Name = "TxtEquipo";
            this.TxtEquipo.Size = new System.Drawing.Size(127, 20);
            this.TxtEquipo.TabIndex = 5;
            // 
            // TxtMarca
            // 
            this.TxtMarca.Location = new System.Drawing.Point(402, 96);
            this.TxtMarca.Name = "TxtMarca";
            this.TxtMarca.Size = new System.Drawing.Size(141, 20);
            this.TxtMarca.TabIndex = 6;
            // 
            // TxtNS
            // 
            this.TxtNS.Location = new System.Drawing.Point(17, 163);
            this.TxtNS.Name = "TxtNS";
            this.TxtNS.Size = new System.Drawing.Size(125, 20);
            this.TxtNS.TabIndex = 7;
            // 
            // TxtEstado
            // 
            this.TxtEstado.Location = new System.Drawing.Point(204, 163);
            this.TxtEstado.Name = "TxtEstado";
            this.TxtEstado.Size = new System.Drawing.Size(127, 20);
            this.TxtEstado.TabIndex = 8;
            // 
            // Equipotxt
            // 
            this.Equipotxt.AutoSize = true;
            this.Equipotxt.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equipotxt.Location = new System.Drawing.Point(214, 74);
            this.Equipotxt.Name = "Equipotxt";
            this.Equipotxt.Size = new System.Drawing.Size(69, 19);
            this.Equipotxt.TabIndex = 10;
            this.Equipotxt.Text = "Equipo";
            // 
            // MarcaTxt
            // 
            this.MarcaTxt.AutoSize = true;
            this.MarcaTxt.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarcaTxt.Location = new System.Drawing.Point(411, 74);
            this.MarcaTxt.Name = "MarcaTxt";
            this.MarcaTxt.Size = new System.Drawing.Size(59, 19);
            this.MarcaTxt.TabIndex = 11;
            this.MarcaTxt.Text = "Marca";
            // 
            // NStxt
            // 
            this.NStxt.AutoSize = true;
            this.NStxt.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NStxt.Location = new System.Drawing.Point(1, 141);
            this.NStxt.Name = "NStxt";
            this.NStxt.Size = new System.Drawing.Size(169, 19);
            this.NStxt.TabIndex = 12;
            this.NStxt.Text = "Número de serie ";
            // 
            // EstadoTxt
            // 
            this.EstadoTxt.AutoSize = true;
            this.EstadoTxt.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstadoTxt.Location = new System.Drawing.Point(214, 141);
            this.EstadoTxt.Name = "EstadoTxt";
            this.EstadoTxt.Size = new System.Drawing.Size(79, 19);
            this.EstadoTxt.TabIndex = 13;
            this.EstadoTxt.Text = "Estado ";
            // 
            // Añadirbtn
            // 
            this.Añadirbtn.BackColor = System.Drawing.SystemColors.Info;
            this.Añadirbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Añadirbtn.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Añadirbtn.Location = new System.Drawing.Point(374, 154);
            this.Añadirbtn.Name = "Añadirbtn";
            this.Añadirbtn.Size = new System.Drawing.Size(113, 36);
            this.Añadirbtn.TabIndex = 14;
            this.Añadirbtn.Text = "Añadir ";
            this.Añadirbtn.UseVisualStyleBackColor = false;
            this.Añadirbtn.Click += new System.EventHandler(this.Añadirbtn_Click);
            // 
            // Mostrar
            // 
            this.Mostrar.BackColor = System.Drawing.SystemColors.Info;
            this.Mostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Mostrar.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mostrar.Location = new System.Drawing.Point(515, 154);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Size = new System.Drawing.Size(102, 36);
            this.Mostrar.TabIndex = 15;
            this.Mostrar.Text = "Actualizar Tabla ";
            this.Mostrar.UseVisualStyleBackColor = false;
            this.Mostrar.Click += new System.EventHandler(this.Mostrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::Multiform.Properties.Resources.inteligencia_artificial_5;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(490, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // HOLA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(644, 440);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Mostrar);
            this.Controls.Add(this.Añadirbtn);
            this.Controls.Add(this.EstadoTxt);
            this.Controls.Add(this.NStxt);
            this.Controls.Add(this.MarcaTxt);
            this.Controls.Add(this.Equipotxt);
            this.Controls.Add(this.TxtEstado);
            this.Controls.Add(this.TxtNS);
            this.Controls.Add(this.TxtMarca);
            this.Controls.Add(this.TxtEquipo);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.Text2);
            this.Controls.Add(this.Inventario);
            this.Controls.Add(this.Text1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HOLA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario del hospital ";
            this.Load += new System.EventHandler(this.HOLA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Text1;
        private System.Windows.Forms.ListView Inventario;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Equipo;
        private System.Windows.Forms.ColumnHeader Marca;
        private System.Windows.Forms.ColumnHeader NS;
        private System.Windows.Forms.ColumnHeader Estado;
        private System.Windows.Forms.Label Text2;
        private System.Windows.Forms.Label TxtName;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtEquipo;
        private System.Windows.Forms.TextBox TxtMarca;
        private System.Windows.Forms.TextBox TxtNS;
        private System.Windows.Forms.TextBox TxtEstado;
        private System.Windows.Forms.Label Equipotxt;
        private System.Windows.Forms.Label MarcaTxt;
        private System.Windows.Forms.Label NStxt;
        private System.Windows.Forms.Label EstadoTxt;
        private System.Windows.Forms.Button Añadirbtn;
        private System.Windows.Forms.Button Mostrar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}