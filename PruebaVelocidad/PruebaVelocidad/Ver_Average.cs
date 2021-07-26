using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaVelocidad
{
    public partial class Ver_Average : Form
    {
        List<double> List_stopwatch_bb = new List<double>();
        List<double> List_stopwatch_bs = new List<double>();
        List<double> List_stopwatch_ob = new List<double>();
        List<double> List_stopwatch_oi = new List<double>();
        List<double> List_stopwatch_oq = new List<double>();
        public Ver_Average(List<Double> ii_bb,
                           List<Double> ii_bs,
                           List<Double> ii_ob,
                           List<Double> ii_oqs,
                           List<Double> ii_oi)
        {
            InitializeComponent();
            List_stopwatch_bb = ii_bb;
            List_stopwatch_bs = ii_bs;
            List_stopwatch_ob = ii_ob;
            List_stopwatch_oi = ii_oi;
            List_stopwatch_oq = ii_oqs;
            Llena_Tabla_Tiempos();
            Llena_Tabla_Average();
            
        }
        void Llena_Tabla_Tiempos()
        {
            int n = List_stopwatch_bb.Count;
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(DG_Tiempos);
            for (int ii=0;ii< n;ii++)
            {
                row = new DataGridViewRow();
                row.CreateCells(DG_Tiempos);
                row.Cells[0].Value = List_stopwatch_bb[ii];
                row.Cells[1].Value = List_stopwatch_bs[ii];
                row.Cells[2].Value = List_stopwatch_ob[ii];
                row.Cells[3].Value = List_stopwatch_oq[ii];
                row.Cells[4].Value = List_stopwatch_oi[ii];
                DG_Tiempos.Rows.Add(row);
            }
            
        }
        void Llena_Tabla_Average()
        {

            DG_Average.Rows[0].Cells[0].Value = (List_stopwatch_bb.Sum()/ List_stopwatch_bb.Count).ToString("N4");
            DG_Average.Rows[0].Cells[1].Value = (List_stopwatch_bs.Sum() / List_stopwatch_bs.Count).ToString("N4");
            DG_Average.Rows[0].Cells[2].Value = (List_stopwatch_ob.Sum() / List_stopwatch_ob.Count).ToString("N4");
            DG_Average.Rows[0].Cells[3].Value = (List_stopwatch_oq.Sum() / List_stopwatch_oq.Count).ToString("N4");
            DG_Average.Rows[0].Cells[4].Value = (List_stopwatch_oi.Sum() / List_stopwatch_oi.Count).ToString("N4");
            
        }
        
    }
}
