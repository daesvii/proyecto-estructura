namespace Gestor_Centro_Educativo
{
    partial class estudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(estudiante));
            this.label3 = new System.Windows.Forms.Label();
            this.TittleBar = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.materia_buscar = new System.Windows.Forms.ComboBox();
            this.listView = new System.Windows.Forms.ListView();
            this.nombre_materia = new System.Windows.Forms.ColumnHeader();
            this.nota1 = new System.Windows.Forms.ColumnHeader();
            this.nota2 = new System.Windows.Forms.ColumnHeader();
            this.nota3 = new System.Windows.Forms.ColumnHeader();
            this.nota_final = new System.Windows.Forms.ColumnHeader();
            this.button2 = new System.Windows.Forms.Button();
            this.nombre_inicio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.TittleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 3;
            // 
            // TittleBar
            // 
            this.TittleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.TittleBar.Controls.Add(this.pictureBox2);
            this.TittleBar.Controls.Add(this.pictureBox3);
            this.TittleBar.Controls.Add(this.pictureBox1);
            this.TittleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TittleBar.Location = new System.Drawing.Point(0, 0);
            this.TittleBar.Name = "TittleBar";
            this.TittleBar.Size = new System.Drawing.Size(646, 50);
            this.TittleBar.TabIndex = 29;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Gestor_Centro_Educativo.Properties.Resources.icons8_macos_minimizar_32__1_;
            this.pictureBox2.Location = new System.Drawing.Point(537, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Gestor_Centro_Educativo.Properties.Resources.icons8_macos_cerrar_32__1_;
            this.pictureBox3.Location = new System.Drawing.Point(566, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 335);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 15);
            this.panel1.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(248, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "SELECCIONE LA MATERIA";
            // 
            // materia_buscar
            // 
            this.materia_buscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.materia_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materia_buscar.FormattingEnabled = true;
            this.materia_buscar.Items.AddRange(new object[] {
            "Matemáticas",
            "Ciencias",
            "Español"});
            this.materia_buscar.Location = new System.Drawing.Point(248, 111);
            this.materia_buscar.Name = "materia_buscar";
            this.materia_buscar.Size = new System.Drawing.Size(121, 23);
            this.materia_buscar.TabIndex = 36;
            // 
            // listView
            // 
            this.listView.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nombre_materia,
            this.nota1,
            this.nota2,
            this.nota3,
            this.nota_final});
            this.listView.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(248, 187);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(386, 96);
            this.listView.TabIndex = 38;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // nombre_materia
            // 
            this.nombre_materia.Text = "MATERIA";
            this.nombre_materia.Width = 110;
            // 
            // nota1
            // 
            this.nota1.Text = "30%";
            this.nota1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nota2
            // 
            this.nota2.Text = "30%";
            this.nota2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nota3
            // 
            this.nota3.Text = "40%";
            this.nota3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nota_final
            // 
            this.nota_final.Text = "Nota Final";
            this.nota_final.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nota_final.Width = 85;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSlateGray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(339, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 25);
            this.button2.TabIndex = 45;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nombre_inicio
            // 
            this.nombre_inicio.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.nombre_inicio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombre_inicio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.nombre_inicio.ForeColor = System.Drawing.Color.Black;
            this.nombre_inicio.Location = new System.Drawing.Point(22, 101);
            this.nombre_inicio.Name = "nombre_inicio";
            this.nombre_inicio.Size = new System.Drawing.Size(182, 19);
            this.nombre_inicio.TabIndex = 47;
            this.nombre_inicio.Text = "NOMBRE DE ESTUDIANTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(22, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 15);
            this.label2.TabIndex = 48;
            this.label2.Text = "_______________________________________";
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txt_nombre.ForeColor = System.Drawing.Color.Black;
            this.txt_nombre.Location = new System.Drawing.Point(22, 76);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(182, 19);
            this.txt_nombre.TabIndex = 49;
            this.txt_nombre.Text = "Estudiante:\r\n";
            // 
            // estudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(646, 350);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.nombre_inicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materia_buscar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TittleBar);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "estudiante";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "estudiante";
            this.Load += new System.EventHandler(this.estudiante_Load);
            this.TittleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label3;
        private Panel TittleBar;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private ComboBox materia_buscar;
        private ListView listView;
        private ColumnHeader nombre_materia;
        private ColumnHeader nota1;
        private ColumnHeader nota2;
        private ColumnHeader nota3;
        private ColumnHeader nota_final;
        private Button button2;
        private TextBox nombre_inicio;
        private Label label2;
        private TextBox txt_nombre;
    }
}