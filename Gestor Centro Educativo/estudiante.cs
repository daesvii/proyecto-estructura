using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_Centro_Educativo
{
    public partial class estudiante : Form
    {
        public estudiante()
        {
            InitializeComponent();
        }

        private void ver_notas_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new tittleBar2();
            this.Hide();
            form.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form form = new tittleBar2();
            this.Hide();
            form.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (materia_buscar.Text == "Matemáticas")
            {
                listView.Items.Clear();
                foreach (materia.matematicas u in materia.variables_globales.estudiante_matematicas)
                {
                    if(u.estudiante == nombre_inicio.Text)
                    {
                        ListViewItem lista = new ListViewItem("Matematicas");
                        lista.SubItems.Add(u.primernota);
                        lista.SubItems.Add(u.segundanota);
                        lista.SubItems.Add(u.tercernota);
                        double primera = (double.Parse(u.primernota) * 0.30);
                        double segunda = (double.Parse(u.segundanota) * 0.30);
                        double tercera = (double.Parse(u.tercernota) * 0.40);
                        double total = primera + segunda + tercera;
                        total = Math.Round(total, 1);
                        lista.SubItems.Add(Convert.ToString(total));
                        listView.Items.Add(lista);
                    }
                 
                }
            }else if(materia_buscar.Text == "Ciencias")
            {
                listView.Items.Clear();
                foreach (materia.ciencias u in materia.variables_globales.estudiante_ciencias)
                {
                    if(u.estudiante== nombre_inicio.Text)
                    {
                        ListViewItem lista = new ListViewItem("Ciencias");
                        lista.SubItems.Add(u.primernota);
                        lista.SubItems.Add(u.segundanota);
                        lista.SubItems.Add(u.tercernota);
                        double primera = (double.Parse(u.primernota) * 0.30);
                        double segunda = (double.Parse(u.segundanota) * 0.30);
                        double tercera = (double.Parse(u.tercernota) * 0.40);
                        double total = primera + segunda + tercera;
                        total = Math.Round(total, 1);
                        lista.SubItems.Add(Convert.ToString(total));
                        listView.Items.Add(lista);
                    }
                    

                }
            }else if (materia_buscar.Text == "Español")
            {
                listView.Items.Clear();
                foreach (materia.español u in materia.variables_globales.estudiante_español)
                {
                    if (u.estudiante == nombre_inicio.Text)
                    {
                        ListViewItem lista = new ListViewItem("Español");
                        lista.SubItems.Add(u.primernota);
                        lista.SubItems.Add(u.segundanota);
                        lista.SubItems.Add(u.tercernota);
                        double primera = (double.Parse(u.primernota) * 0.30);
                        double segunda = (double.Parse(u.segundanota) * 0.30);
                        double tercera = (double.Parse(u.tercernota) * 0.40);
                        double total = primera + segunda + tercera;
                        total = Math.Round(total, 1);
                        lista.SubItems.Add(Convert.ToString(total));
                        listView.Items.Add(lista);
                    }
                    
                }
            }
        }

        private void nombre_inicio_Click(object sender, EventArgs e)
        {
            
        }

        private void estudiante_Load(object sender, EventArgs e)
        {
            nombre_inicio.Text = Form2.variables_globales.nombre_sesion;
        }
    }
}
