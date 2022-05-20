using Domain.Entities;
using PepitoschoolApp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PepitoSchoolForm.Forms
{
    public partial class Principal : Form
    {
        IEstudianteServices estudiantesServices;
        int seleccion;
        public Principal(IEstudianteServices estudiantesServices)
        {
            this.estudiantesServices = estudiantesServices;
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = estudiantesServices.GetAll();
            dataGridView1.ClearSelection();
        }
        public Principal()
        {
            InitializeComponent();
        }

        private void agregarEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstudiante frmEstudiante = new FrmEstudiante(-50);
            frmEstudiante.estudiantesServices = estudiantesServices;
            frmEstudiante.ShowDialog();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = estudiantesServices.GetAll();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            if (index >= 0)
            {
                Estudiante a = estudiantesServices.GetAll()[index];
                estudiantesServices.Delete(a);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = estudiantesServices.GetAll();
            }
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seleccione toda la fila del estudiante con la flechita de la izquierda (parece boton de play) y de click derecho para ver más opciones");
        }

        private void promedioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            if (index >= 0)
            {
                Estudiante a = estudiantesServices.GetAll()[index];
                int suma = a.Matematica + a.Estadistica + a.Programacion + a.Contabilidad;
                int promedio = suma / 4;
                MessageBox.Show($"El promedio de notas del alumno {a.Nombres} {a.Apellidos} es de: {promedio} ");
            }
        }
        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            if (index >= 0)
            {
                FrmEstudiante frmEstudiante = new FrmEstudiante(index);
                frmEstudiante.estudiantesServices = estudiantesServices;
                frmEstudiante.ShowDialog();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = estudiantesServices.GetAll();
            }
        }
    }
}
