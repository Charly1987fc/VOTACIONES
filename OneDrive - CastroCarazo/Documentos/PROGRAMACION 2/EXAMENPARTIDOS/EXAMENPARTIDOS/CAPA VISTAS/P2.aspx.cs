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
using System.Security.Cryptography;

namespace EXAMENPARTIDOS.CAPA_VISTAS
{
    public partial class P2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LlenarGrid();
                lmensaje.Text="FAVOR PARA AGREGUE LOS VOTANTES" ;
            }
        }
        protected void Ingresar()
        {
            //SE INGRESAN LOS DATOS DE LOS VOTANTES PARA QUE QUEDEN REGISTRADOS EN LA TABLA VOTANTES//
            String s = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand(" INSERT INTO VOTANTES VALUES('" + Tidcedula.Text + "' ,'" + Tnombrecompleto.Text + "' ,'" + Temail.Text + " '  )", conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            LlenarGrid();
        }
        protected void Borrar()
        {
            //SE LOGRA BORRAR UN VOTANTE SOLO CON EL ID CEDULA//
            String s = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand(" Delete VOTANTES where IDCEDULA = '" + Tidcedula.Text + "'  ", conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            LlenarGrid();
        }
        protected void LlenarGrid()
        {
            //SE LLAMA LA TABLA VOTANTES PARA QUE SE REFLEJEN LAS PERSONAS QUE VOTARON, ADEMAS EL ID SERA UNICO//
            string constr = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT *  FROM VOTANTES"))
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