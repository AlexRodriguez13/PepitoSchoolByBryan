using Domain.Entities;
using PepitoschoolApp.Interfaces;
using PepitoSchoolForm.Forms;
using System;
using System.Windows.Forms;

namespace PepitoSchool.Forms.Forms
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

        

        private void porCarnetToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            seleccion = 0;
            btnbuscar.Visible = true;
            txtbuscar.Visible = true;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (seleccion == 0)
            {
               dataGridView1.DataSource = estudiantesServices.FindByCarnet(txtbuscar.Text);
            }
            else if (seleccion == 1)
            {
                dataGridView1.DataSource = estudiantesServices.FindByNames(txtbuscar.Text);
            }
            else
            {
                dataGridView1.DataSource = estudiantesServices.FindByLastnames(txtbuscar.Text);
            }
            button1.Visible = true;
            btnbuscar.Visible = false;
            txtbuscar.Visible = false;
        }

        private void porNombresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seleccion = 1;
            btnbuscar.Visible = true;
            txtbuscar.Visible = true;
        }

        private void porApellidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seleccion = 2;
            btnbuscar.Visible = true;
            txtbuscar.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = estudiantesServices.GetAll();
            dataGridView1.ClearSelection();
            button1.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void cmsDataGridView_Click(object sender, EventArgs e)
        {
            try
            {
                if(dataGridView1.CurrentCell.RowIndex == -1)
                {
                    cmsDataGridView.Dispose();
                }
            }
            catch (Exception)
            {
                cmsDataGridView.Dispose();
            }
        }
    }
}