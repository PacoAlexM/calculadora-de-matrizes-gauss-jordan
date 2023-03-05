using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassMatrices;

namespace Matrizes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DosPorDos uno = new DosPorDos();
        TresPorTres dos = new TresPorTres();
        double X1 = 0; double Y1 = 0; double Z1 = 0; double T1 = 0;
        double X2 = 0; double Y2 = 0; double Z2 = 0; double T2 = 0;
        double X3 = 0; double Y3 = 0; double Z3 = 0; double T3 = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void x2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Visible = false;
            groupBox2.Enabled = true;
            groupBox3.Visible = false;
            groupBox3.Enabled = true;
            groupBox4.Visible = false;
            groupBox4.Enabled = true;
            groupBox5.Visible = false;
            X1 = 0; Y1 = 0; Z1 = 0; T1 = 0;
            X2 = 0; Y2 = 0; Z2 = 0; T2 = 0;
            X3 = 0; Y3 = 0; Z3 = 0; T3 = 0;
            //Group 1
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear();
            textBox5.Clear(); textBox6.Clear(); textBox7.Clear(); textBox8.Clear();
            textBox9.Clear(); textBox10.Clear(); textBox11.Clear(); textBox12.Clear();
            //Group 2
            textBox13.Clear(); textBox14.Clear(); textBox15.Clear(); textBox16.Clear();
            textBox17.Clear(); textBox18.Clear(); textBox19.Clear(); textBox20.Clear();
            textBox21.Clear(); textBox22.Clear(); textBox23.Clear(); textBox24.Clear();
            //Group 3
            textBox25.Clear(); textBox26.Clear(); textBox27.Clear(); textBox28.Clear();
            textBox29.Clear(); textBox30.Clear(); textBox31.Clear(); textBox32.Clear();
            textBox33.Clear(); textBox34.Clear(); textBox35.Clear(); textBox36.Clear();
            //Group 4
            textBox37.Clear(); textBox38.Clear(); textBox39.Clear(); textBox40.Clear();
            textBox41.Clear(); textBox42.Clear(); textBox43.Clear(); textBox44.Clear();
            textBox45.Clear(); textBox46.Clear(); textBox47.Clear(); textBox48.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                groupBox1.Enabled = false;
                groupBox2.Visible = true;
                button2.Enabled = true;
                label3.Text = "="; label7.Text = "=";
                textBox4.Visible = false; textBox8.Visible = false;
                textBox9.Visible = false; textBox10.Visible = false; textBox11.Visible = false; textBox12.Visible = false;
                label4.Visible = false; label8.Visible = false;
                label9.Visible = false; label10.Visible = false; label11.Visible = false; label12.Visible = false;
                label22.Text = "="; label18.Text = "=";
                textBox21.Visible = false; textBox17.Visible = false;
                textBox16.Visible = false; textBox15.Visible = false; textBox14.Visible = false; textBox13.Visible = false;
                label21.Visible = false; label17.Visible = false;
                label16.Visible = false; label15.Visible = false; label14.Visible = false; label13.Visible = false;
                label34.Text = "="; label30.Text = "=";
                textBox33.Visible = false; textBox29.Visible = false;
                textBox28.Visible = false; textBox27.Visible = false; textBox26.Visible = false; textBox25.Visible = false;
                label33.Visible = false; label29.Visible = false;
                label28.Visible = false; label27.Visible = false; label26.Visible = false; label25.Visible = false;
            }
            else if (radioButton2.Checked == true)
            {
                groupBox1.Enabled = false;
                groupBox2.Visible = true;
                button2.Enabled = true;
                label3.Text = "Z"; label7.Text = "Z";
                textBox4.Visible = true; textBox8.Visible = true;
                textBox9.Visible = true; textBox10.Visible = true; textBox11.Visible = true; textBox12.Visible = true;
                label4.Visible = true; label8.Visible = true;
                label9.Visible = true; label10.Visible = true; label11.Visible = true; label12.Visible = true;
                label22.Text = "Z"; label18.Text = "Z";
                textBox21.Visible = true; textBox17.Visible = true;
                textBox16.Visible = true; textBox15.Visible = true; textBox14.Visible = true; textBox13.Visible = true;
                label21.Visible = true; label17.Visible = true;
                label16.Visible = true; label15.Visible = true; label14.Visible = true; label13.Visible = true;
                label34.Text = "Z"; label30.Text = "Z";
                textBox33.Visible = true; textBox29.Visible = true;
                textBox28.Visible = true; textBox27.Visible = true; textBox26.Visible = true; textBox25.Visible = true;
                label33.Visible = true; label29.Visible = true;
                label28.Visible = true; label27.Visible = true; label26.Visible = true; label25.Visible = true;
            }
            else
            {
                MessageBox.Show("DEBE TENER UNA OPCION MARCADA", "ERROR.exe");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked == true)
                {
                    X1 = Double.Parse(textBox1.Text); Y1 = Double.Parse(textBox2.Text); T1 = Double.Parse(textBox3.Text);
                    X2 = Double.Parse(textBox5.Text); Y2 = Double.Parse(textBox6.Text); T2 = Double.Parse(textBox7.Text);
                    groupBox2.Enabled = false;
                    groupBox3.Visible = true;
                    //Fila 1
                    Y1 = uno.Fila_1_Igualar_A_Uno_Y(Y1, X1);
                    T1 = uno.Fila_1_Igualar_A_Uno_T(T1, X1);
                    X1 = uno.Fila_1_Igualar_A_Uno_X(X1);
                    //Fila 2
                    Y2 = uno.Fila_2_Igualar_A_Cero_Y(Y1, X2, Y2);
                    T2 = uno.Fila_2_Igualar_A_Cero_T(T1, X2, T2);
                    X2 = uno.Fila_2_Igualar_A_Cero_X(X1, X2);
                    //Group 2
                    textBox24.Text = Convert.ToString(X1); textBox23.Text = Convert.ToString(Y1); textBox22.Text = Convert.ToString(T1);
                    textBox20.Text = Convert.ToString(X2); textBox19.Text = Convert.ToString(Y2); textBox18.Text = Convert.ToString(T2);
                }
                else if (radioButton2.Checked == true)
                {
                    X1 = Double.Parse(textBox1.Text); Y1 = Double.Parse(textBox2.Text); Z1 = Double.Parse(textBox3.Text); T1 = Double.Parse(textBox4.Text);
                    X2 = Double.Parse(textBox5.Text); Y2 = Double.Parse(textBox6.Text); Z2 = Double.Parse(textBox7.Text); T2 = Double.Parse(textBox8.Text);
                    X3 = Double.Parse(textBox9.Text); Y3 = Double.Parse(textBox10.Text); Z3 = Double.Parse(textBox11.Text); T3 = Double.Parse(textBox12.Text);
                    groupBox2.Enabled = false;
                    groupBox3.Visible = true;
                    //Fila 1
                    Y1 = dos.Fila_1_Igualar_A_Uno_Y(Y1, X1);
                    Z1 = dos.Fila_1_Igualar_A_Uno_Z(Z1, X1);
                    T1 = dos.Fila_1_Igualar_A_Uno_T(T1, X1);
                    X1 = dos.Fila_1_Igualar_A_Uno_X(X1);
                    //Fila 2
                    Y2 = dos.Fila_2_Igualar_A_Cero_Y(Y1, X2, Y2);
                    Z2 = dos.Fila_2_Igualar_A_Cero_Z(Z1, X2, Z2);
                    T2 = dos.Fila_2_Igualar_A_Cero_T(T1, X2, T2);
                    X2 = dos.Fila_2_Igualar_A_Cero_X(X1, X2);
                    //Fila 3
                    Y3 = dos.Fila_3_Igualar_A_Cero_Y(Y1, X3, Y3);
                    Z3 = dos.Fila_3_Igualar_A_Cero_Z(Z1, X3, Z3);
                    T3 = dos.Fila_3_Igualar_A_Cero_T(T1, X3, T3);
                    X3 = dos.Fila_3_Igualar_A_Cero_X(X1, X3);
                    //Group
                    textBox24.Text = Convert.ToString(X1); textBox23.Text = Convert.ToString(Y1); textBox22.Text = Convert.ToString(Z1); textBox21.Text = Convert.ToString(T1);
                    textBox20.Text = Convert.ToString(X2); textBox19.Text = Convert.ToString(Y2); textBox18.Text = Convert.ToString(Z2); textBox17.Text = Convert.ToString(T2);
                    textBox16.Text = Convert.ToString(X3); textBox15.Text = Convert.ToString(Y3); textBox14.Text = Convert.ToString(Z3); textBox13.Text = Convert.ToString(T3);
                }
            }
            catch
            {
                MessageBox.Show("ALGUN ERROR EN LOS VALORES", "ERROR.exe",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                //Fila 2
                T2 = uno.Valor_Y(Y2, T2);
                Y2 = uno.Fila_2_Igualar_A_Uno_Y(Y2);
                //Fila 1
                T1 = uno.Valor_X(T2, Y1, T1);
                Y1 = uno.Fila_1_Igualar_A_Cero_Y(Y2, Y1);
                textBox36.Text = Convert.ToString(X1); textBox35.Text = Convert.ToString(Y1); textBox34.Text = "X = " + Convert.ToString(T1);
                textBox32.Text = Convert.ToString(X2); textBox31.Text = Convert.ToString(Y2); textBox30.Text = "Y = " + Convert.ToString(T2);
                groupBox3.Enabled = false;
                groupBox4.Visible = true;
            }
            else if (radioButton2.Checked == true)
            {
                //Fila 2
                Z2 = dos.Fila_2_Igualar_A_Uno_Z(Z2, Y2);
                T2 = dos.Fila_2_Igualar_A_Uno_T(T2, Y2);
                Y2 = dos.Fila_2_Igualar_A_Uno_Y(Y2);
                //Fila 3
                Z3 = dos.Fila_3_Igualar_A_Cero_Z_2do(Z2, Y3, Z3);
                T3 = dos.Fila_3_Igualar_A_Cero_T_2do(T2, Y3, T3);
                Y3 = dos.Fila_3_Igualar_A_Cero_Y_2do(Y2, Y3);
                textBox36.Text = Convert.ToString(X1); textBox35.Text = Convert.ToString(Y1); textBox34.Text = Convert.ToString(Z1); textBox33.Text = Convert.ToString(T1);
                textBox32.Text = Convert.ToString(X2); textBox31.Text = Convert.ToString(Y2); textBox30.Text = Convert.ToString(Z2); textBox29.Text = Convert.ToString(T2);
                textBox28.Text = Convert.ToString(X3); textBox27.Text = Convert.ToString(Y3); textBox26.Text = Convert.ToString(Z3); textBox25.Text = Convert.ToString(T3);
                groupBox3.Enabled = false;
                groupBox4.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
            }
            else if (radioButton2.Checked == true)
            {
                //Fila 3
                T3 = dos.Valor_Z(T3, Z3);
                Z3 = dos.Fila_3_Igualar_A_Uno_Z(Z3);
                //Fila 2
                T2 = dos.Valor_Y(T3, Z2, T2);
                Z2 = dos.Fila_2_Igualar_A_Cero_Z_2do(Z3, Z2);
                //Fila 1
                T1 = dos.Fila_1_Igualar_A_Cero_T(T3, Z1, T1);
                Z1 = dos.Fila_1_Igualar_A_Cero_Z(Z3, Y1, Z1);
                T1 = dos.Valor_X(T2, Y1, T1);
                Y1 = dos.Fila_1_Igualar_A_Cero_Y(Y2, Y1);
                textBox48.Text = Convert.ToString(X1); textBox47.Text = Convert.ToString(Y1); textBox46.Text = Convert.ToString(Z1); textBox45.Text = "X = " + T1;
                textBox44.Text = Convert.ToString(X2); textBox43.Text = Convert.ToString(Y2); textBox42.Text = Convert.ToString(Z2); textBox41.Text = "Y = " + T2;
                textBox40.Text = Convert.ToString(X3); textBox39.Text = Convert.ToString(Y3); textBox38.Text = Convert.ToString(Z3); textBox37.Text = "Z = " + T3;
                groupBox4.Enabled = false;
                groupBox5.Visible = true;
            }
        }
    }
}
