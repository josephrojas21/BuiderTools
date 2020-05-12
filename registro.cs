using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BuilderTools
{
    public partial class registro : Form
    {


        public SqlConnection cn;
        public registro()
        {
            InitializeComponent();
            cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Documents\\BuiderTools\\BuilderTools.mdf;Integrated Security=false;Connect Timeout=30");
            //abre conexion
            cn.Open();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var sql = $"insert into dbo.[tblUser] ( name, lastname, email, password) values('{txtNombre.Text}','{txtApellido.Text}','{ txtE_mail.Text }','{ txtContraseña.Text}')";
            SqlCommand comando = new SqlCommand(sql, cn);
            comando.ExecuteNonQuery();
            MessageBox.Show("Empleado ingresado con exito");
            home form = new home();
            form.Show();


        }
    }
}
