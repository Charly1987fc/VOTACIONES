using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.WebControls;

namespace EXAMENPARTIDOS.CAPA_VISTAS
{
    public partial class Grafica : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ConfigurarGrafica();
            }
        }

        private void ConfigurarGrafica()
        {
            Chart1.Series.Clear();
            Chart1.ChartAreas.Clear();

            
            ChartArea area = new ChartArea();
            Series series = new Series();
            series.Name = "Votos";
            series.ChartType = SeriesChartType.Pie;

           
            series.Points.Add(new DataPoint(0, 45) { LegendText = "CANDIDATOS" });
            series.Points.Add(new DataPoint(0, 30) { LegendText = "Candidato 2" });
            series.Points.Add(new DataPoint(0, 25) { LegendText = "Candidato 3" });

            Chart1.Series.Add(series);
            Chart1.ChartAreas.Add(area);
        }
    }
}