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

    public partial class FrmEstudiante : Form
    {
        public IEstudianteServices estudiantesServices { get; set; }
        int index;
        Estudiante est;
        public FrmEstudiante(int index)
        {
            this.index = index;
            InitializeComponent();
        }
        private void FrmEstudiante_Load(object sender, EventArgs e)
        {
            if (index != -50)
            {
                est = estudiantesServices.GetAll()[index];
                txtnombres.Text = est.Nombres;
                txtapellidos.Text = est.Apellidos;
                txtcarnet.Text = est.Carnet;
                txttelefono.Text = est.Phone;
                txtdireccion.Text = est.Direccion;
                txtcorreo.Text = est.Correo;
                numMatematicas.Value = est.Matematica;
                numEstadistica.Value = est.Estadistica;
                numProgramacion.Value = est.Programacion;
                numContabilidad.Value = est.Contabilidad;
                btnaceptar.Enabled = false;
                btnmodificar.Enabled = true;
            }
            else
            {
                btnaceptar.Enabled = true;
                btnmodificar.Enabled = false;
            }
        }
        public FrmEstudiante()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (verificar())
            {
                Estudiante estudiante = new Estudiante()
                {
                    Nombres = txtnombres.Text,
                    Apellidos = txtapellidos.Text,
                    Carnet = txtcarnet.Text,
                    Phone = txttelefono.Text,
                    Direccion = txtdireccion.Text,
                    Correo = txtcorreo.Text,
                    Matematica = (int)numMatematicas.Value,
                    Estadistica = (int)numEstadistica.Value,
                    Programacion = (int)numProgramacion.Value,
                    Contabilidad = (int)numContabilidad.Value,

                };
                estudiantesServices.Create(estudiante);
                Dispose();
            }
            else
            {
                MessageBox.Show("Tienes que llenar todos los formularios.");
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (verificar())
            {
                Estudiante estudiante = new Estudiante()
                {
                    Id = est.Id,
                    Nombres = txtnombres.Text,
                    Apellidos = txtapellidos.Text,
                    Carnet = txtcarnet.Text,
                    Phone = txttelefono.Text,
                    Direccion = txtdireccion.Text,
                    Correo = txtcorreo.Text,
                    Matematica = (int)numMatematicas.Value,
                    Estadistica = (int)numEstadistica.Value,
                    Programacion = (int)numProgramacion.Value,
                    Contabilidad = (int)numContabilidad.Value,

                };
                estudiantesServices.Update(estudiante);
                Dispose();
            }
            else
            {
                MessageBox.Show("Tienes que llenar todos los formularios.");
            }


        }
        public bool verificar()
        {
            if (String.IsNullOrEmpty(txtnombres.Text) || String.IsNullOrEmpty(txtapellidos.Text) || String.IsNullOrEmpty(txtcarnet.Text) || String.IsNullOrEmpty(txttelefono.Text)
                || String.IsNullOrEmpty(txtdireccion.Text) || String.IsNullOrEmpty(txtcorreo.Text))
            {
                return false;
            }
            return true;
        }
    }
}
