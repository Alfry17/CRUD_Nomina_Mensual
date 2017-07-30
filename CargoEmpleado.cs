using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NominaMensual
{
    public partial class CargoEmpleado : Form
    {
        public CargoEmpleado()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                //Actualiza nuevas ediciones de registro de la tabla cargos//
                Operaciones op = new Operaciones();
                op.ConsultasinResultado("UPDATE cargo SET cod_cargo = '" + txtCa.Text + "', nombre_cargo = '" + txtCarg.Text + "')");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            txtCa.Text = "";
            txtCarg.Text = "";
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                //Insertar nuevos cargos en la base de datos//
                Operaciones op = new Operaciones();
                op.ConsultasinResultado("INSERT INTO cargo (cod_cargo, nombre_cargo) VALUES('" + txtCa.Text + "', '" + txtCarg.Text + "')");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //cerrar formulario//
            this.Close();
        }
    }
}
