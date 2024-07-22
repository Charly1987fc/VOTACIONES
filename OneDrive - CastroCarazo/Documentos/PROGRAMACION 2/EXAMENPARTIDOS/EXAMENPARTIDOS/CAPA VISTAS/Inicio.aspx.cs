using EXAMENPARTIDOS.CAPA_DATOS;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EXAMENPARTIDOS.CAPA_VISTAS
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //SE ASIGNA UN MENSAJE PARA EL USUARIO DEL SISTEMA//
            if (!IsPostBack)
            {
                LlenarGrid();
                lmensaje.Text="FAVOR NO ASIGNE NUMERO DE ID EL SISTEMA LO HACE AUTOMATICO";
            }
        }
        protected void Ingresar()
        {
            // SE AGREGAN CANDIDATOS//
            String s = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand(" INSERT INTO CANDIDATOS VALUES ('" + TNOMBRECOMPLETO.Text + "' ,'" + TNOMBREPARTIDO.Text + "' )", conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            LlenarGrid();
        }
        protected void Borrar()
        {
            //SE PUEDE ELIMINAR UN CANDIDATO A LA VEZ CON SOLO EL ID DE CANDIDATO//
            String s = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand(" Delete CANDIDATOS where ID = '" + TID.Text + "'  " ,conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            LlenarGrid();
        }
        protected void LlenarGrid()
        {
            //SE LLAMA A LA TABLA CANDIDATOS PARA QUE APAREZCA EN EL GRID//
            string constr = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT *  FROM CANDIDATOS"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            GridView1.DataSource = dt;
                            GridView1.DataBind();
                        }
                    }
                }
            }
        }

        protected void BAGREGAR_Click(object sender, EventArgs e)
        {
            Ingresar();
        }

        protected void BELIMINAR_Click(object sender, EventArgs e)
        {
            Borrar();
        }
    }
}