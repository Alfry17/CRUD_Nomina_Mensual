using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Configuration;

namespace NominaMensual
{
    public partial class Empleado : Form
    {
        public Empleado()
        {
            InitializeComponent();
        }


       
        //Variables declarada para el evento click en el Datagriview con fines de que cuando doy click me mande a a la tabla de agregar//
        public static string xcod_empleado;
        public static string xcedula;
        public static string xnombre;
        public static string xapellido;
        public static string xdireccion;
        public static string xsexo;
        public static string xsueldo;
        public static string xfecha_de_necimeinto;
        public static string xfecha_de_ingreso;
        public static string xcod_cargo;
        public static string xnombre_cargo;





        SQLiteConnection cnx = new SQLiteConnection("Data source=C:\\sistema\\nomina.s3db; Version=3;");

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            /*
            //codigo para saltar de un TexBox a otro//
            SendKeys.Send("{TAB}");
            if (e.KeyCode == Keys.Shift)
            {
                e.Handled = true;          
            }
            */
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            /*
            //codigo para saltar de un TexBox a otro//
            SendKeys.Send("{TAB}");
            if (e.KeyCode == Keys.Shift)
            {
                e.Handled = true;          
            }
            */
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            /*
            //codigo para saltar de un TexBox a otro//
            SendKeys.Send("{TAB}");
            if (e.KeyCode == Keys.Shift)
            {
                e.Handled = true;          
            }
            */
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {

            /*
                //codigo para saltar de un TexBox a otro//
                SendKeys.Send("{TAB}");
                if (e.KeyCode == Keys.Shift)
                {
                    e.Handled = true;          
                }
                */
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {

            /*
            //codigo para saltar de un TexBox a otro//
            SendKeys.Send("{TAB}");
            if (e.KeyCode == Keys.Shift)
            {
                e.Handled = true;          
            }
            */
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            /*
                 //codigo para saltar de un TexBox a otro//
                 SendKeys.Send("{TAB}");
                 if (e.KeyCode == Keys.Shift)
                 {
                     e.Handled = true;          
                 }
                 */
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            /*
            //codigo para saltar de un TexBox a otro//
            SendKeys.Send("{TAB}");
            if (e.KeyCode == Keys.Shift)
            {
                e.Handled = true;          
            }
            */

        }

        private void textBox9_KeyDown(object sender, KeyEventArgs e)
        {
            /*
            //codigo para saltar de un TexBox a otro//
            SendKeys.Send("{TAB}");
            if (e.KeyCode == Keys.Shift)
            {
                e.Handled = true;          
            }
            */

        }

        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {
            /*
            //codigo para saltar de un TexBox a otro//
            SendKeys.Send("{TAB}");
            if (e.KeyCode == Keys.Shift)
            {
                e.Handled = true;          
            }
            */

        }

        private void txt7_KeyDown(object sender, KeyEventArgs e)
        {
            /*
            //codigo para saltar de un TexBox a otro//
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }*/
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
                op.ConsultasinResultado("INSERT INTO empleados(cedula, nombre, apellido, direccion, sexo, sueldo, fecha_nacimiento, fecha_ingreso, cod_cargo, nombre_cargo) VALUES('" + txt7.Text + "', '" + txt1.Text + "', '" + txt2.Text + "', '" + txt3.Text + "', '" + txt4.Text + "', '" + txt5.Text + "', '" + dateTimePicker1.Text + "','" + dateTimePicker3.Text + "', '" + txtCalgo.Text + "','" + txtnombre_cargo.Text + "')");

                //*********************************************************************************************************//



                //Calculo de fecha de nacimiento y fecha de ingreso que automaticamente me lo refleja en individuales TexBox cuando agrego un nuevo registro//
                string I = dateTimePicker1.Text;

                DateTime X = Convert.ToDateTime(I);
                int edad = DateTime.Today.AddTicks(-X.Ticks).Year - 1;
                txtNaci.Text = Convert.ToString(edad);
                edad.ToString();


                string t = dateTimePicker3.Text;

                DateTime k = Convert.ToDateTime(t);
                int Antiguedad = DateTime.Today.AddTicks(-k.Ticks).Year - 1;
                textBox10.Text = Convert.ToString(Antiguedad);
                textBox10.ToString();

                //*********************************************************************************************************//
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }


        private void empleado_Load(object sender, EventArgs e)
        {
            try
            {
                //Igualacion de nombre de los TexBox con su mismo nombre//
                txtID.Text = xcod_empleado;
                txt7.Text = xcedula;
                txt1.Text = xnombre;
                txt2.Text = xapellido;
                txt3.Text = xdireccion;
                txt4.Text = xsexo;
                txt5.Text = xsueldo;
                dateTimePicker1.Text = xfecha_de_necimeinto;
                dateTimePicker3.Text = xfecha_de_ingreso;
                txtCalgo.Text = xcod_cargo;
                txtCalgo.Text = xnombre_cargo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

       

        private void button6_Click_1(object sender, EventArgs e)
        {
            //Calculadora algo extra para aprender de logica de negocio
            Form formulario = new Calculadora();    
            formulario.Show();
        }

     

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void btnBus_Click(object sender, EventArgs e)
        {

            Operaciones oper = new Operaciones();

            DataTable dt_empleado = oper.ConsultaconResultado(" SELECT  * FROM empleados where cod_empleado='" + txtID.Text + "' ");
            foreach (DataRow dr in dt_empleado.Rows)
            {

                string cod_empleado, nombre, apellido, cedula, sueldo, sexo, direccion, cod_cargo, nombre_cargo;

                try
                {
                    //Esto me permitira buscar en mi base de dato por ID//
                    cod_empleado = dr["cod_empleado"].ToString();
                    nombre = dr["nombre"].ToString();
                    apellido = dr["apellido"].ToString();
                    cedula = dr["cedula"].ToString();
                    sueldo = dr["sueldo"].ToString();
                    sexo = dr["sexo"].ToString();
                    direccion = dr["direccion"].ToString();
                    cod_cargo = dr["cod_cargo"].ToString();




                    txt1.Text = nombre;
                    txt2.Text = apellido;
                    txt3.Text = direccion;
                    txt4.Text = sexo;
                    txt7.Text = cedula;
                    txt5.Text = sueldo;
                    txtCalgo.Text = cod_cargo;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                           
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                //Borra solo numero por numero//
                txtID.Text = "";
                txt1.Text = "";
                txt2.Text = "";
                txt3.Text = "";
                txt4.Text = "";
                txt5.Text = "";
                dateTimePicker1.Text = "";
                txt7.Text = "";
                txtCalgo.Text = "";
                txtNaci.Text = "";
                textBox10.Text = "";
                txtnombre_cargo.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnCalcu_Click(object sender, EventArgs e)
        {

        }



        private void button2_Click_2(object sender, EventArgs e)
        {


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text != null)
                {
                    //Borra de la base de dato de la tabla empleado//
                    Operaciones op = new Operaciones();
                    op.ConsultasinResultado("DELETE from empleados WHERE cod_empleado = " + txtID.Text);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            try
            {
                //Actualiza los campos de la tabla Cargos//
                Operaciones op = new Operaciones();
                op.ConsultasinResultado("UPDATE empleados SET cedula = '" + txt7.Text + "', nombre = '" + txt1.Text + "', apellido = '" + txt2.Text + "', direccion = '" + txt3.Text + "' sexo = '" + txt4.Text + "' sueldo = '" + txt5.Text + "' fecha_nacimiento = '" + dateTimePicker1.Text + "' fecha_ingreso = '" + dateTimePicker3.Text + "' cod_cargo = '" + txtCalgo.Text + "' nombre_cargo = '" + txtnombre_cargo.Text + ""); //' WHERE cod_empleado LIKE ' %" + txtCodigo.ToString() + "%' ");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

           


        }

       
    }
}
