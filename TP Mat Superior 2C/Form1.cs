using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Mat_Superior_2C
{
    public partial class Form1 : Form
    {
        string varx;
        string vary;
        double[] X;
        double[] Y;
        List<double> Progre = new List<double>();
        List<double> Regre = new List<double>();
        List<double> ProgreEqui = new List<double>();
        List<double> RegreEqui = new List<double>();
        bool esProgre = false;
        bool esLaGrange = false;
        bool esRegre = false;
        bool equidista = false;
        double K;
        int ordenX = 0;
        double ResulK = 0;
        double NuevoResul = 0;
        int a = 0;
        bool modificado = false;
        List<double> NuevoX = new List<double>();
        List<double> NuevoY = new List<double>();
        bool mayor = false;




        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            NuevoX.Clear();
            NuevoY.Clear();


            Regre.Clear();
            RegreEqui.Clear();
            esRegre = true;
            esProgre = false;
            esLaGrange = false;
            lblXY.Text = "";
            X = ObtenerVariables1();
            Y = ObtenerVariables2();
            ordenX = X.Length;
            equidista = EsEquidistante();
            string polinomio = "";
            string elevados = "";
            CalcElementsRegre(Y, ordenX, 1, equidista);


            if (equidista == true)
            {
                for (int i = 0; i < RegreEqui.Count; i++)
                {
                    if (i == 0)
                    {
                        polinomio = polinomio + RegreEqui[i];
                    }
                    else
                    {
                        elevados = elevados + "(X - " + X[ordenX - i] + ")";
                        polinomio = polinomio + " + " + RegreEqui[i] + elevados;
                    }

                }
            }
            else
            {

                for (int i = 0; i < Regre.Count; i++)
                {
                    if (i == 0)
                    {
                        polinomio = polinomio + Regre[i];
                    }
                    else
                    {
                        elevados = elevados + "(X - " + X[ordenX - i] + ")";
                        polinomio = polinomio + " + " + Regre[i] + elevados;
                    }

                }
            }
            lblPolinomio.Text = polinomio;
            a = 0;
            MostrarCoordenadas();
            lblResulK.Text = "";
            txtK.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public double[] ObtenerVariables1()
        {
            string entrada = txtX.Text;
            int largo = entrada.Length - 1;
            if (entrada[0] == '(' & entrada[largo] == ')')
            {

                entrada = entrada.TrimStart('(').TrimEnd(')');

            }
            else
            {

                MessageBox.Show("Por favor ingrese los numeros en el formato correcto", "Error en formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }
            //string[] entradasplit = entrada.Split(';');
            double[] entradasplit = Array.ConvertAll(entrada.Split(';'), new Converter<string, double>(Double.Parse));

            return entradasplit;

        }

        public double[] ObtenerVariables2()
        {
            string entrada2 = txtY.Text;
            int largo = entrada2.Length - 1;
            if (entrada2[0] == '(' & entrada2[largo] == ')')
            {

                entrada2 = entrada2.TrimStart('(').TrimEnd(')');

            }
            else
            {

                MessageBox.Show("Por favor ingrese los numeros en el formato correcto", "Error en formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }

            //string[] entradasplit2 = entrada2.Split(';');
            double[] entradasplit2 = Array.ConvertAll(entrada2.Split(';'), new Converter<string, double>(Double.Parse));

            return entradasplit2;

        }

        private void TxtX_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblLaGrange_Click(object sender, EventArgs e)
        {
            NuevoX.Clear();
            NuevoY.Clear();

            lblXY.Text = "";
            esRegre = false;
            esProgre = false;
            esLaGrange = true;
            X = ObtenerVariables1();
            Y = ObtenerVariables2();
            ordenX = X.Length;
            string polinomio = "";
            string div = "";
            string elevados = "";
            double divposta = 1;

            for (int i = 0; i < ordenX; i++)
            {

                for (int k = 0; k < ordenX; k++)
                {
                    if (k != i)
                    {

                        elevados = elevados + "(X - " + X[k] + ")";
                        div = div + "( " + X[i] + " - " + X[k] + " )";
                        divposta = divposta * (X[i] - X[k]);

                    }

                }

                lblXY.Text = lblXY.Text + "L" + i + "(x) = " + elevados + " / " + div + Environment.NewLine;
                polinomio = polinomio + " ( " + elevados + " / " + divposta + " ) " + Y[i] + " + ";
                elevados = "";
                div = "";
                divposta = 1;
                MostrarCoordenadas();
                lblEquidistante.Text = "";
                lblResulK.Text = "";
                txtK.Text = "";



            }
            lblPolinomio.Text = polinomio;

        }

        private void LblNGProg_Click(object sender, EventArgs e)
        {
            NuevoX.Clear();
            NuevoY.Clear();

            Progre.Clear();
            ProgreEqui.Clear();
            esRegre = false;
            esProgre = true;
            esLaGrange = false;
            lblXY.Text = "";
            X = ObtenerVariables1();
            Y = ObtenerVariables2();
            ordenX = X.Length;
            equidista = EsEquidistante();
            string polinomio = "";
            string elevados = "";
            CalcElements(Y, ordenX, 1, equidista);

            if (equidista == true)
            {
                for (int i = 0; i < ProgreEqui.Count; i++)
                {
                    if (i == 0)
                    {
                        polinomio = polinomio + ProgreEqui[i];
                    }
                    else
                    {
                        elevados = elevados + "(X - " + X[i - 1] + ")";
                        polinomio = polinomio + " + " + ProgreEqui[i] + elevados;
                    }

                }
            }
            else
            {
                for (int i = 0; i < Progre.Count; i++)
                {
                    if (i == 0)
                    {
                        polinomio = polinomio + Progre[i];
                    }
                    else
                    {
                        elevados = elevados + "(X - " + X[i - 1] + ")";
                        polinomio = polinomio + " + " + Progre[i] + elevados;
                    }

                }
            }


            lblPolinomio.Text = polinomio;

            a = 0;
            MostrarCoordenadas();
            lblResulK.Text = "";
            txtK.Text = "";








        }

        void CalcElements(double[] y, int order, int step, bool equidista)
        {
            int i;
            double[] xx;

            double h = 0;
            double abajo = 0;
            double equiResul = 0;


            if (equidista == true)
            {
                h = X[1] - X[0];
            }


            if (order >= 1)
            {
                xx = new double[order];
                for (i = 0; i < order - 1; i++)
                {
                    if (equidista == true)
                    {

                        //abajo = factorial * elevado;
                        xx[i] = (y[i + 1] - y[i]);
                    }
                    else
                    {
                        xx[i] = (y[i + 1] - y[i]) / (X[i + step] - X[i]);
                    }

                    if (equidista == true)
                    {

                        lblXY.Text = lblXY.Text + "( " + y[i + 1] + " - " + y[i] + " )  = " + xx[i] + Environment.NewLine;

                    }
                    else
                    {
                        lblXY.Text = lblXY.Text + "( " + y[i + 1] + " - " + y[i] + " ) / ( " + X[i + step] + " - " + X[i] + ")  = " + xx[i] + Environment.NewLine;
                    }
                }

                double elevado = Math.Pow(h, a);
                double factorial = factorial_Recursion(a);

                equiResul = y[0] / (factorial * elevado);
                ProgreEqui.Add(equiResul);
                a = a + 1;
                Progre.Add(y[0]);


                CalcElements(xx, order - 1, step + 1, equidista);

            }
        }

        void CalcElementsRegre(double[] y, int order, int step, bool equidista)
        {


            int i;
            double[] xx;
            double h = 0;
            double abajo = 0;
            double equiResul = 0;


            if (equidista == true)
            {
                h = X[1] - X[0];
            }

            if (order >= 1)
            {
                xx = new double[order];
                for (i = 0; i < order - 1; i++)
                {
                    if (equidista == true)
                    {

                        //abajo = factorial * elevado;
                        xx[i] = (y[i + 1] - y[i]);
                    }
                    else
                    {
                        xx[i] = (y[i + 1] - y[i]) / (X[i + step] - X[i]);
                    }
                    if (equidista == true)
                    {

                        lblXY.Text = lblXY.Text + "( " + y[i + 1] + " - " + y[i] + " )  = " + xx[i] + Environment.NewLine;

                    }
                    else
                    {
                        lblXY.Text = lblXY.Text + "( " + y[i + 1] + " - " + y[i] + " ) / ( " + X[i + step] + " - " + X[i] + ")  = " + xx[i] + Environment.NewLine;
                    }
                }

                // Add items using Add method   
                double elevado = Math.Pow(h, a);
                double factorial = factorial_Recursion(a);

                equiResul = y[order - 1] / (factorial * elevado);
                RegreEqui.Add(equiResul);
                a = a + 1;
                Regre.Add(y[order - 1]);


                CalcElementsRegre(xx, order - 1, step + 1, equidista);

            }
        }

        private void BtbK_Click(object sender, EventArgs e)
        {

            ResulK = 0;
            if (esLaGrange == true)
            {
                K = Convert.ToDouble(txtK.Text);
                resolverLaGrange(K);
                lblResulK.Text = "P(" + K + " ) = " + ResulK.ToString();
            }
            else if (esProgre == true)
            {
                K = Convert.ToDouble(txtK.Text);
                resolverProgre(K);
                lblResulK.Text = "P(" + K + " ) = " + ResulK.ToString();

            }
            else if (esRegre == true)
            {
                K = Convert.ToDouble(txtK.Text);
                resolverRegre(K);
                lblResulK.Text = "P(" + K + " ) = " + ResulK.ToString();
            }
            else if (esRegre == false && esLaGrange == false && esProgre == false)
            {
                MessageBox.Show("Por favor ingrese primero los valores X e Y", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }



        }
        void resolverLaGrange(double T)
        {



            double elevados = 1;
            double divposta = 1;

            for (int i = 0; i < ordenX; i++)
            {

                for (int k = 0; k < ordenX; k++)
                {
                    if (k != i)
                    {

                        elevados = elevados * (T - X[k]);
                        divposta = divposta * (X[i] - X[k]);

                    }

                }

                ResulK = ResulK + (elevados / divposta) * Y[i];
                elevados = 1;
                divposta = 1;




            }
        }
        void resolverProgre(double T)
        {
            double elevados = 1;
            if (equidista == true)
            {
                for (int i = 0; i < ProgreEqui.Count; i++)
                {
                    if (i == 0)
                    {
                        ResulK = ResulK + ProgreEqui[i];
                    }
                    else
                    {
                        elevados = elevados * (T - X[i - 1]);
                        ResulK = ResulK + (ProgreEqui[i] * elevados);
                    }

                }
            }
            else
            {
                for (int i = 0; i < Progre.Count; i++)
                {
                    if (i == 0)
                    {
                        ResulK = ResulK + Progre[i];
                    }
                    else
                    {
                        elevados = elevados * (T - X[i - 1]);
                        ResulK = ResulK + (Progre[i] * elevados);
                    }

                }
            }

        }
        void resolverRegre(double T)
        {
            double elevados = 1;
            if (equidista == true)
            {
                for (int i = 0; i < RegreEqui.Count; i++)
                {
                    if (i == 0)
                    {
                        ResulK = ResulK + RegreEqui[i];
                    }
                    else
                    {
                        elevados = elevados * (T - X[ordenX - i]);
                        ResulK = ResulK + (RegreEqui[i] * elevados);
                    }

                }
            }
            else
            {
                for (int i = 0; i < Regre.Count; i++)
                {
                    if (i == 0)
                    {
                        ResulK = ResulK + Regre[i];
                    }
                    else
                    {

                        elevados = elevados * (T - X[ordenX - i]);
                        ResulK = ResulK + (Regre[i] * elevados);
                    }

                }
            }


        }

        bool EsEquidistante()
        {
            double actual = 0;
            double anterior = 0;
            for (int i = 1; i < ordenX; i++)
            {
                if (i == 1)
                {
                    anterior = X[i] - X[i - 1];

                }
                else
                {
                    actual = X[i] - X[i - 1];

                    if (anterior != actual)
                    {
                        lblEquidistante.Text = "No es equidistante!";
                        return false;
                    }
                    anterior = actual;
                }

            }
            lblEquidistante.Text = "Es equidistante!";
            return true;
        }

        private void LblEquidistante_Click(object sender, EventArgs e)
        {

        }

        public double factorial_Recursion(double number)
        {
            if (number == 1 || number == 0)
                return 1;
            else
                return number * factorial_Recursion(number - 1);
        }

        private void BtbAgregar_Click(object sender, EventArgs e)
        {

            
            obtenerVariables1();
            agregarVariables();
            if (mayor == false)
            {
                compararVariables();
            }
            mayor = false;

        }
        public void obtenerVariables1()
        {
            string entrada = txtAgregar.Text;
            int largo = entrada.Length - 1;
            if (entrada[0] == '(' & entrada[largo] == ')')
            {

                entrada = entrada.TrimStart('(').TrimEnd(')');

            }
            else
            {

                MessageBox.Show("Por favor ingrese el numero en el formato (X;Y)", "Error en formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mayor = true;

            }

            string[] entradasplit = entrada.Split(';');
            varx = entradasplit[0];
            vary = entradasplit[1];

        }
        public void agregarVariables()
        {
            if (modificado == false)
            {
                ordenX = X.Length;
                for (int i = 0; i < ordenX; i++)
                {

                    NuevoX.Add(X[i]);
                    NuevoY.Add(Y[i]);

                }
                if (Double.Parse(varx) < X[ordenX - 1] && Double.Parse(vary) < Y[ordenX - 1])
                {
                    MessageBox.Show("Por favor ingrese 2 numero (X;Y) mayor a la ultima tupla de la lista ", "Error en formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    mayor = true;
                    NuevoX.Clear();
                    NuevoY.Clear();
                    
                }
                else
                {

                    NuevoX.Add(Double.Parse(varx));
                    NuevoY.Add(Double.Parse(vary));
                    modificado = true;
                }
            }
            else
            {
                if (Double.Parse(varx) < NuevoX[NuevoX.Count - 1] && Double.Parse(vary) < NuevoY[NuevoY.Count - 1])
                {
                    MessageBox.Show("Por favor ingrese 2 numero (X;Y) mayor a la ultima tupla de la lista ", "Error en formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    mayor = true;
                }
                else
                {

                    NuevoX.Add(Double.Parse(varx));
                    NuevoY.Add(Double.Parse(vary));
                }
            }

        }
        public void compararVariables()
        {
            double elevados = 1;
            double divposta = 1;

            for (int i = 0; i < NuevoX.Count; i++)
            {

                for (int k = 0; k < NuevoX.Count; k++)
                {
                    if (k != i)
                    {

                        elevados = elevados * (2 - NuevoX[k]);
                        divposta = divposta * (NuevoX[i] - NuevoX[k]);

                    }

                }

                NuevoResul = NuevoResul + (elevados / divposta) * NuevoY[i];
                elevados = 1;
                divposta = 1;

            }
            resolverLaGrange(2);

            if (ResulK == NuevoResul)
            {
                MessageBox.Show("El polinomio obtenido es igual al original!", "FINTER", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else

            {
                string polinomio = "";
                string div = "";
                string eleva3 = "";
                divposta = 1;

                for (int t = 0; t < NuevoX.Count; t++)
                {

                    for (int k = 0; k < NuevoX.Count; k++)
                    {
                        if (k != t)
                        {

                            eleva3 = eleva3 + "(X - " + NuevoX[k] + ")";
                            div = div + "( " + NuevoX[t] + " - " + NuevoX[k] + " )";
                            divposta = divposta * (NuevoX[t] - NuevoX[k]);

                        }

                    }


                    polinomio = polinomio + " ( " + eleva3 + " / " + divposta + " ) " + NuevoY[t] + " + ";
                    eleva3 = "";
                    div = "";
                    divposta = 1;

                }
                MessageBox.Show("El polinomio obtenido NO es igual al original! El nuevo polinomio es:" + polinomio, "FINTER", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            MostrarNuevasCoordenadas();

        }
        void MostrarNuevasCoordenadas()
        {
            lblCoordenadas.Text = "i | X | Y" + Environment.NewLine;
            for (int i = 0; i < NuevoX.Count; i++)
            {
                lblCoordenadas.Text = lblCoordenadas.Text + i + " | " + NuevoX[i] + " | " + NuevoY[i] + Environment.NewLine;
            }

        }
        void MostrarCoordenadas()
        {
            lblCoordenadas.Text = "i | X | Y" + Environment.NewLine;
            for (int i = 0; i < ordenX; i++)
            {
                lblCoordenadas.Text = lblCoordenadas.Text + i + " | " + X[i] + " | " + Y[i] + Environment.NewLine;
            }

        }

        private void BtbEliminar_Click(object sender, EventArgs e)
        {
            
            eliminarVariables();
            compararVariables();
        }

        public void eliminarVariables()
        {
            int coord = int.Parse(txtEliminar.Text);
            if (modificado == false)
            {
                ordenX = X.Length;
                for (int i = 0; i < ordenX; i++)
                {
                    NuevoX.Add(X[i]);
                    NuevoY.Add(Y[i]);

                }
                NuevoX.RemoveAt(coord);           
                modificado = true;
            }
            else
            {
                NuevoX.RemoveAt(coord);
            }
        }
    }
    
    }
