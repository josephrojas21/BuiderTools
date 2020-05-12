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
    public partial class login : Form
    {
        public SqlConnection cn;
        public login()
        {
            InitializeComponent();
            cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Documents\\BuiderTools\\BuilderTools.mdf;Integrated Security=false;Connect Timeout=30");
            //abre conexion
            cn.Open();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            var sql = $"select * from tblUser where email = '{txtUsuario.Text}'";
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Console.WriteLine(dt);
            
            if (dt.Rows[0][4].ToString() == txtContraseña.Text)
            {
                home form = new home();
                form.Show();
            } else
            {
                MessageBox.Show("contraseña incorrecta");
            }

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            registro formResg = new registro();
            formResg.Show();
        }
    }
}
