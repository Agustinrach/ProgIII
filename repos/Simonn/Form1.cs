using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simonn
{
    public partial class Form1 : Form
    {
        int controlador= 0;
        Random numAleatorio;
        List<int> SimonDice = new List<int>();
        bool Jugando = false;
        public Form1()
        {
            InitializeComponent();
            numAleatorio = new Random();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            string Presionado = ((Button)sender).Name;
            string[] numBtn = Presionado.Split('_');
            btnPresionado(Convert.ToInt32(numBtn[1]));
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            this.timer1.Interval = 500;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SimonDice.Add(numAleatorio.Next(0, 4));
            new Thread(EmpezarJuego).Start();
        }

        private void EmpezarJuego()
        {
            Thread.Sleep(200);
            Jugando = true;
            foreach(int activo in SimonDice)
            {
                switch (activo)
                {
                    case 0: p_0.BackColor = Color.LightGray;
                            Thread.Sleep(300);
                            p_0.BackColor = Color.Lime;
                        break;
                    case 1: p_1.BackColor = Color.LightGray;
                            Thread.Sleep(300);
                            p_1.BackColor = Color.Yellow;
                        break;
                    case 2: p_2.BackColor = Color.LightGray;
                            Thread.Sleep(300);
                            p_2.BackColor = Color.Blue;
                        break;
                    case 3: p_3.BackColor = Color.LightGray;
                            Thread.Sleep(300);
                            p_3.BackColor = Color.Red;
                        break;
                }
                Thread.Sleep(300);
            }
            Jugando = false;
        }
    
        private void btnPresionado(int num)
        {
            if (Jugando || SimonDice.Count == 0) return;
            if (SimonDice[controlador] == num) controlador++;
            else
            {
                MessageBox.Show("PUNTAJE FINAL: " + SimonDice.Count);
                controlador = 0;
                SimonDice = new List<int>();
            }
            if (controlador >= SimonDice.Count)
            {
                controlador = 0;
                SimonDice.Add(numAleatorio.Next(0, 4));
                new Thread(EmpezarJuego).Start();
            }

            label1.Text = SimonDice.Count.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
