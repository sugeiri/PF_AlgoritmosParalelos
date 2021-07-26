using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaVelocidad
{
    public partial class Form1 : Form
    {
        int[] arreglo = new int[15];
        int[] arreglo_bb = new int[15];
        int[] arreglo_bs = new int[15];
        int[] arreglo_ob = new int[15];
        int[] arreglo_oq = new int[15];
        int[] arreglo_oi = new int[15];
        int num_buscado = 67;
        string encontrado_bb = "";
        string encontrado_bs = "";

        Stopwatch stopwatch_bs = new Stopwatch();
        Stopwatch stopwatch_bb = new Stopwatch();
        Stopwatch stopwatch_ob = new Stopwatch();
        Stopwatch stopwatch_oq = new Stopwatch();
        Stopwatch stopwatch_oi = new Stopwatch();

        List<double> List_stopwatch_bb = new List<double>();
        List<double> List_stopwatch_bs = new List<double>();
        List<double> List_stopwatch_ob = new List<double>();
        List<double> List_stopwatch_oi = new List<double>();
        List<double> List_stopwatch_oq = new List<double>();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            arreglo = new int[15]{ 9, 15, 1, 3, 98, 23, 76, 7, 29, 67, 4, 45, 87, 34, 72 };
            List_stopwatch_bb = new List<double>();
            List_stopwatch_bs = new List<double>();
            List_stopwatch_ob = new List<double>();
            List_stopwatch_oi = new List<double>();
            List_stopwatch_oq = new List<double>();
            this.toolTip1.SetToolTip(this.Start, "Iniciar Carrera");
            this.toolTip1.SetToolTip(this.Restart, "Reiniciar Historial de Carrera");
            this.toolTip1.SetToolTip(this.Average, "Ver Promedio");
            this.toolTip1.SetToolTip(this.bs_bs, "Ver Arreglo con Busqueda Secuencial");
            this.toolTip1.SetToolTip(this.bs_bb, "Ver Arreglo con Busqueda Binaria");
            this.toolTip1.SetToolTip(this.bs_ob, "Ver Arreglo con Ordenamiento Burbuja");
            this.toolTip1.SetToolTip(this.bs_oi, "Ver Arreglo con Ordenamiento por Insersion");
            this.toolTip1.SetToolTip(this.bs_oq, "Ver Arreglo con Ordenamiento QuickSort");
        }

        private void Start_Click(object sender, EventArgs e)
        {
            stopwatch_bs = new Stopwatch();
            stopwatch_bb = new Stopwatch();
            stopwatch_ob = new Stopwatch();
            stopwatch_oq = new Stopwatch();
            stopwatch_oi = new Stopwatch();
            GoAsync();
        }
        public async void GoAsync()
        {
            var sw = new Stopwatch();
            sw.Start();
            Console.WriteLine("Starting");
            int[] result = await Task.WhenAll(Task.Run(() => Busqueda_Secuencial(1, num_buscado)), 
                                              Task.Run(() => Busqueda_Binaria(1, num_buscado)),
                                              Task.Run(() => Ordenamiento_Burbuja(1)),
                                              Task.Run(() => Ordenamiento_QuickSort(1)),
                                              Task.Run(() => Ordenamiento_Insersion(1)));
            BB_MS.Text= stopwatch_bb.Elapsed.TotalMilliseconds.ToString();
            BS_MS.Text = stopwatch_bs.Elapsed.TotalMilliseconds.ToString();
            OB_MS.Text = stopwatch_ob.Elapsed.TotalMilliseconds.ToString();
            OI_MS.Text = stopwatch_oi.Elapsed.TotalMilliseconds.ToString();
            OQS_MS.Text = stopwatch_oq.Elapsed.TotalMilliseconds.ToString();

            List_stopwatch_bb.Add(stopwatch_bb.Elapsed.TotalMilliseconds);
            List_stopwatch_bs.Add(stopwatch_bs.Elapsed.TotalMilliseconds);
            List_stopwatch_ob.Add(stopwatch_ob.Elapsed.TotalMilliseconds);
            List_stopwatch_oi.Add(stopwatch_oi.Elapsed.TotalMilliseconds);
            List_stopwatch_oq.Add(stopwatch_oq.Elapsed.TotalMilliseconds);

        }
        private async Task<int> Sleep(int ms)
        {
            Console.WriteLine("Sleeping for {0} at {1}", ms, Environment.TickCount);
            await Task.Delay(ms);
            Console.WriteLine("Sleeping for {0} finished at {1}", ms, Environment.TickCount);
            return ms;
        }
        private async Task<int> Busqueda_Secuencial(int ms, int num)
        {

            stopwatch_bs.Start();
            int[] ii_arreglo = new int[15] { 9, 15, 1, 3, 98, 23, 76, 7, 29, 67, 4, 45, 87, 34, 72 };
            int Tamaño = ii_arreglo.Length;
            int Posicion = 0;

            while (Posicion < Tamaño)
            {
                if (ii_arreglo[Posicion] == num)
                {
                    encontrado_bs = "Si";
                    stopwatch_bs.Stop();
                    arreglo_bs = ii_arreglo;
                    return ms;
                }
                else
                {
                    Posicion++;
                }
            }
            encontrado_bb = "No";
            return ms;

        }
        private async Task<int> Busqueda_Binaria(int ms, int num)
        {
            stopwatch_bb.Start();
            //await Task.Delay(ms);
            int[] ii_arreglo = new int[15] { 9, 15, 1, 3, 98, 23, 76, 7, 29, 67, 4, 45, 87, 34, 72 };
            int t;
            for (int a = 1; a < ii_arreglo.Length; a++)
                for (int b = ii_arreglo.Length - 1; b >= a; b--)
                {
                    if (ii_arreglo[b - 1] > ii_arreglo[b])
                    {
                        t = ii_arreglo[b - 1];
                        ii_arreglo[b - 1] = ii_arreglo[b];
                        ii_arreglo[b] = t;
                    }
                }

            int l = 0, h = 14;
            int m = 0;
            bool found = false;
            while (l <= h && found == false)
            {
                m = (l + h) / 2;
                if (ii_arreglo[m] == num)
                    found = true;
                if (ii_arreglo[m] > num)
                    h = m - 1;
                else
                    l = m + 1;
            }
            if (found == false)
                encontrado_bb = "No";
            else
                encontrado_bb = "Si";

            arreglo_bb = ii_arreglo;
            stopwatch_bb.Stop();
            return ms;

        }
        private async Task<int> Ordenamiento_Burbuja(int ms)
        {
            stopwatch_ob.Start();
            //await Task.Delay(ms);
            int[] ii_arreglo = new int[15] { 9, 15, 1, 3, 98, 23, 76, 7, 29, 67, 4, 45, 87, 34, 72 };
            int t;
            for (int a = 1; a < ii_arreglo.Length; a++)
                for (int b = ii_arreglo.Length - 1; b >= a; b--)
                {
                    if (ii_arreglo[b - 1] > ii_arreglo[b])
                    {
                        t = ii_arreglo[b - 1];
                        ii_arreglo[b - 1] = ii_arreglo[b];
                        ii_arreglo[b] = t;
                    }
                }
            stopwatch_ob.Stop();
            arreglo_ob = ii_arreglo;
            return ms;

        }
        private async Task<int> Ordenamiento_QuickSort(int ms)
        {
            stopwatch_oq.Start();
            //await Task.Delay(ms);
            int[] ii_arreglo = new int[15] { 9, 15, 1, 3, 98, 23, 76, 7, 29, 67, 4, 45, 87, 34, 72 };
            arreglo_oq = QuickSort(ii_arreglo, 0, 14);
            stopwatch_oq.Stop();
            return ms;

        }
        private int[] QuickSort(int[] ii_arreglo, int primero, int ultimo)
        {
            int i, j, central;
            double pivote;
            central = (primero + ultimo) / 2;
            pivote = ii_arreglo[central];
            i = primero;
            j = ultimo;
            do
            {
                while (ii_arreglo[i] < pivote) i++;
                while (ii_arreglo[j] > pivote) j--;
                if (i <= j)
                {
                    int temp;
                    temp = ii_arreglo[i];
                    ii_arreglo[i] = ii_arreglo[j];
                    ii_arreglo[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (primero < j)
            {
                ii_arreglo= QuickSort(ii_arreglo, primero, j);
            }
            if (i < ultimo)
            {
                ii_arreglo =QuickSort(ii_arreglo, i, ultimo);
            }
            return ii_arreglo;


        }
        private async Task<int> Ordenamiento_Insersion(int ms)
        {
            stopwatch_oi.Start();
            //await Task.Delay(ms);
            int[] ii_arreglo = new int[15] { 9, 15, 1, 3, 98, 23, 76, 7, 29, 67, 4, 45, 87, 34, 72 };
            int auxili;
            int j;
            for (int i = 0; i < ii_arreglo.Length; i++)
            {
                auxili = ii_arreglo[i];
                j = i - 1;
                while (j >= 0 && ii_arreglo[j] > auxili)
                {
                    ii_arreglo[j + 1] = ii_arreglo[j];
                    j--;
                }
                ii_arreglo[j + 1] = auxili;
            }
            stopwatch_oi.Stop();
            arreglo_oi = ii_arreglo;
            return ms;

        }
        
        private void bs_oq_Click(object sender, EventArgs e)
        {
            Ver_Arreglo form = new Ver_Arreglo(arreglo, arreglo_oq, "QuickSort", false, 0, "");
            form.ShowDialog();
        }

        private void bs_ob_Click(object sender, EventArgs e)
        {
            Ver_Arreglo form = new Ver_Arreglo(arreglo, arreglo_ob, "Burbuja", false, 0, "");
            form.ShowDialog();
        }

        private void bs_oi_Click(object sender, EventArgs e)
        {
            Ver_Arreglo form = new Ver_Arreglo(arreglo, arreglo_oi, "Insersion", false, 0, "");
            form.ShowDialog();
        }

        private void bs_bb_Click(object sender, EventArgs e)
        {
            Ver_Arreglo form = new Ver_Arreglo(arreglo, arreglo_bb, "B.Binaria", true, num_buscado, encontrado_bb);
            form.ShowDialog();
        }

        private void bs_bs_Click(object sender, EventArgs e)
        {
            Ver_Arreglo form = new Ver_Arreglo(arreglo, arreglo_bs, "B.Secuencial", true, num_buscado, encontrado_bs);
            form.ShowDialog();
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            BB_MS.Text = "0";
            BS_MS.Text = "0";
            OQS_MS.Text = "0";
            OI_MS.Text = "0";
            OB_MS.Text = "0";

            List_stopwatch_bb = new List<double>();
            List_stopwatch_bs = new List<double>();
            List_stopwatch_ob = new List<double>();
            List_stopwatch_oi = new List<double>();
            List_stopwatch_oq = new List<double>();
        }

        private void Average_Click(object sender, EventArgs e)
        {
            if(List_stopwatch_bb.Count>0)
            {
                Ver_Average form = new Ver_Average(List_stopwatch_bb,
                                                  List_stopwatch_bs,
                                                  List_stopwatch_ob,
                                                  List_stopwatch_oq,
                                                  List_stopwatch_oi);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Aun no se ha realizado ninguna corrida");
            }
        }
    }
}
