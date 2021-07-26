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
    public partial class Ver_Arreglo : Form
    {
        public Ver_Arreglo(int[]arreglo_original,
                           int[]arreglo_res,
                           string modelo,
                           bool es_buscada,
                           int numero_buscado,
                           string fue_encontrado)
        {
            InitializeComponent();
            label3.Text = modelo.ToUpper();
            if(es_buscada)
                label3.Text = modelo.ToUpper() + " Numero Buscado: "+ numero_buscado+" Encontrado: "+ fue_encontrado.ToUpper();
            Llena_Tabla_Original(arreglo_original);
            Llena_Tabla_Ordenada(arreglo_res);
            if (es_buscada && fue_encontrado.Substring(0, 1).ToUpper() == "S")
                MarcaNum(numero_buscado);



        }
        void Llena_Tabla_Original(int[] arreglo)
        {
            DG_Original.Rows[0].Cells[0].Value = arreglo[0];
            DG_Original.Rows[0].Cells[1].Value = arreglo[1];
            DG_Original.Rows[0].Cells[2].Value = arreglo[2];
            DG_Original.Rows[0].Cells[3].Value = arreglo[3];
            DG_Original.Rows[0].Cells[4].Value = arreglo[4];
            DG_Original.Rows[0].Cells[5].Value = arreglo[5];
            DG_Original.Rows[0].Cells[6].Value = arreglo[6];
            DG_Original.Rows[0].Cells[7].Value = arreglo[7];
            DG_Original.Rows[0].Cells[8].Value = arreglo[8];
            DG_Original.Rows[0].Cells[9].Value = arreglo[9];
            DG_Original.Rows[0].Cells[10].Value = arreglo[10];
            DG_Original.Rows[0].Cells[11].Value = arreglo[11];
            DG_Original.Rows[0].Cells[12].Value = arreglo[12];
            DG_Original.Rows[0].Cells[13].Value = arreglo[13];
            DG_Original.Rows[0].Cells[14].Value = arreglo[14];
        }
        void Llena_Tabla_Ordenada(int[] arreglo)
        {

            DG_Ordenado.Rows[0].Cells[0].Value = arreglo[0];
            DG_Ordenado.Rows[0].Cells[1].Value = arreglo[1];
            DG_Ordenado.Rows[0].Cells[2].Value = arreglo[2];
            DG_Ordenado.Rows[0].Cells[3].Value = arreglo[3];
            DG_Ordenado.Rows[0].Cells[4].Value = arreglo[4];
            DG_Ordenado.Rows[0].Cells[5].Value = arreglo[5];
            DG_Ordenado.Rows[0].Cells[6].Value = arreglo[6];
            DG_Ordenado.Rows[0].Cells[7].Value = arreglo[7];
            DG_Ordenado.Rows[0].Cells[8].Value = arreglo[8];
            DG_Ordenado.Rows[0].Cells[9].Value = arreglo[9];
            DG_Ordenado.Rows[0].Cells[10].Value = arreglo[10];
            DG_Ordenado.Rows[0].Cells[11].Value = arreglo[11];
            DG_Ordenado.Rows[0].Cells[12].Value = arreglo[12];
            DG_Ordenado.Rows[0].Cells[13].Value = arreglo[13];
            DG_Ordenado.Rows[0].Cells[14].Value = arreglo[14];
        }
        void MarcaNum(int num)
        {
            for(int ii=0;ii< 15;ii++)
            {
                if (int.Parse(DG_Ordenado.Rows[0].Cells[ii].Value.ToString()) == num)
                    DG_Ordenado.Rows[0].Cells[ii].Style.BackColor = Color.Green;
            }
            
        }
    }
}
