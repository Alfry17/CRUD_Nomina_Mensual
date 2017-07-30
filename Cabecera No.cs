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
    public partial class Cabecera_No : Form
    {
        public Cabecera_No()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //cerrar formulario//
            this.Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                //Borra solo numero por numero//
                txtnum_nomina.Text = "";
                txtnombre_Empresa.Text = "";
                txttipo_nomina.Text = "";
                dateTimePicker4.Text = "";
                dateTimePicker5.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //INSERT para agregar a la base de dato nuevos registro//
                Operaciones op = new Operaciones();
                op.ConsultasinResultado("INSERT INTO cabecera_nomina (num_nomina, nombre_empresa, tipo_nomina, fecha_inicio, fecha_final) VALUES ('" + txtnum_nomina.Text + "', '" + txtnombre_Empresa.Text + "', '" + txttipo_nomina.Text + "', '" + dateTimePicker4.Text + "', '"  + dateTimePicker5.Text + "')");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
  
    }
}
