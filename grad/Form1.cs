using System.Windows.Forms;
using System;

namespace grad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double[] x = { 1, 1 };
        double[] y = { 1, 1 };


        private void button1_Click(object sender, EventArgs e)
        {
            int N = x.Length;
            Random rnd = new Random();

            double close_a = rnd.Next(-100, 100);
            double close_b = rnd.Next(-100, 100);





            double szd_before;
            double szd_after;
            double temp1;
            double temp2;
            double sum;
            double navch = 0.0001;
            int count = 0;
            richTextBox1.Text = "";

            do
            {
                count += 1;

                sum = 0;
                for (int i = 0; i < N; i++)
                {
                    sum += Math.Pow((close_a + close_b * x[i] - y[i]), 2);
                }
                szd_before =sum / N;


                sum = 0;
                for (int i = 0; i < N; i++)
                {
                    sum += close_a + close_b * x[i] - y[i];
                }
                temp1 = close_a - navch * 0.25 * sum;


                sum = 0;
                for (int i = 0; i < N; i++)
                {
                    sum += (close_a + close_b * x[i] - y[i]) * x[i];
                }
                temp2 = close_b - navch * 0.25 * sum;


                close_a = temp1;
                close_b = temp2;


                sum = 0;
                for (int i = 0; i < N; i++)
                {
                    sum += Math.Pow((close_a + close_b * x[i] - y[i]), 2);
                }
                szd_after = sum/N;

                if (count % 500 == 0)
                {
                    richTextBox1.Text += ($"{count}]    a:{close_a}      b:{close_b}  cзд:{szd_after}\n");
                }

            } while (szd_after <= szd_before && count < 50000 && Math.Abs(szd_after - szd_before) > navch / 1000);
            richTextBox1.Text += ($"{count}]    a:{close_a}      b:{close_b}  cзд:{szd_after}\n");
        }
        double[] NormModelling(double m, double s, int N)
        {
            Random R = new Random();
            double[] mas = new double[0];
            int i = 0;
            while (i <= N - 2)
            {
                double x = R.NextDouble();
                double y = R.NextDouble();

                x = -1 + x * 2;
                y = -1 + y * 2;
                double se = Math.Pow(x, 2) + Math.Pow(y, 2);
                if ((se > 0) && (se <= 1))
                {
                    double z0 = x * Math.Sqrt(-2 * Math.Log(se) / se);
                    double z1 = y * Math.Sqrt(-2 * Math.Log(se) / se);
                    double eps = m + s * z0;
                    Array.Resize(ref mas, mas.Length + 1);
                    mas[mas.Length - 1] = eps;
                    eps = m + s * z1;
                    Array.Resize(ref mas, mas.Length + 1);
                    mas[mas.Length - 1] = eps;
                    i += 2;
                }
            }
            return mas;
        }
        private void generate_regression_click(object sender, EventArgs e)
        {
            Random R = new Random();
            
            var splittedtb1 = textBox1.Text.Split();
            var a_Parab = Convert.ToDouble(splittedtb1[1]);
            var b_Parab = Convert.ToDouble(splittedtb1[0]);
            richTextBox1.Text += $"Лінійну регресію з параметрами {a_Parab} та {a_Parab} та нормально розподіленим зашумленням згенеровано.";
            int N = 1000;
            double eps = 1;
            double Xmin = -1;
            double Xmax = 1;
            double[] XXXX = new double[N];
            double[] esheY = new double[N];
            for (int i = 0; i < N; i++)
            {
                double esheodinX = R.NextDouble();
                esheodinX = Xmin + esheodinX * (Xmax - Xmin);
                XXXX[i] = esheodinX;
            }
            var epsilon = NormModelling(0, eps, N);

            for (int i = 0; i < epsilon.Length; i++)
                esheY[i] = a_Parab * XXXX[i] + b_Parab + epsilon[i];

            x = new double[XXXX.Length]; XXXX.CopyTo(x, 0);
            y = new double[esheY.Length]; esheY.CopyTo(y, 0);

        }
    }
}