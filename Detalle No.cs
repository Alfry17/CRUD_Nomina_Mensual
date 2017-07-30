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
    public partial class Detalle_No : Form
    {
        public Detalle_No()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //cerrar formulario//
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //INSERT para agregar a la base de dato nuevos registro//
                Operaciones op = new Operaciones();
                op.ConsultasinResultado("INSERT INTO detalle_nomina (cod_det_nom, sueldo_bruto, isr, ss, otros, total_deducciones, sueldo_neto, cod_empleado, num_nomina) VALUES('" + txtcod.Text + "', '" + txtsueldo.Text + "', '" + txtISR.Text + "', '" + txtSS.Text + "', '"  + txtOTROS.Text + "', '" + txttotal.Text + "', '" + txtsueldoNeto.Text + "', '"  + txtCodEmple.Text + "', '" + txtNunNomi.Text + "')");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                //Borra solo numero por numero//
                txtcod.Text = "";
                txtsueldo.Text = "";
                txtISR.Text = "";
                txtSS.Text = "";
                txtOTROS.Text = "";
                txttotal.Text = "";
                txtsueldo.Text = "";
                txtCodEmple.Text = "";
                txtNunNomi.Text = "";
                txtsueldoNeto.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }

 }

