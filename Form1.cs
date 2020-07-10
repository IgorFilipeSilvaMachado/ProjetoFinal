using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Semafore
{
    public partial class Form1 : Form
    {
        int Atual = 0;
        Jogadores[] jogadores = new Jogadores[2];
        Jogo jogo = new Jogo();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            jogadores[0] = new Jogadores("Joaquin", 0 );
            jogadores[1] = new Jogadores("Vera", 0);
            label2.Text = jogadores[Atual].getNome();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (jogo.getM(0, 0) == ' ')
            {
                jogo.setM(0, 0, 'v');
                button1.BackColor = Color.Green;
                if (jogo.verifica() == true)
                {
                    MessageBox.Show("O " + jogadores[Atual].getNome() + " Ganhou ");
                }
                

                if (Atual == 0)
                {

                    Atual = 1;
                }
                else
                {

                    Atual = 0;
                }

                
                label2.Text = jogadores[Atual].getNome();
              
            }
            else
            {
                if (jogo.getM(0, 0) == 'v')
                {
                    jogo.setM(0, 0, 'a');
                    button1.BackColor = Color.Yellow;

                    if (jogo.verifica() == true)
                    {
                        MessageBox.Show("O " + jogadores[Atual].getNome() + " Ganhou ");
                    }

                    if (Atual == 0)
                    {

                        Atual = 1;
                    }
                    else
                    {

                        Atual = 0;
                    }

                    label2.Text = jogadores[Atual].getNome();

                }

                else
                {
                    if (jogo.getM(0, 0) == 'a')
                    {
                        jogo.setM(0, 0, 'e');
                        button1.BackColor = Color.Red;

                        if (jogo.verifica() == true)
                        {
                            MessageBox.Show("O " + jogadores[Atual].getNome() + " Ganhou ");
                        }

                        if (Atual == 0)
                        {

                            Atual = 1;
                        }
                        else
                        {

                            Atual = 0;
                        }

                        label2.Text = jogadores[Atual].getNome();

                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (jogo.getM(0, 1) == ' ')
            {
                jogo.setM(0, 1, 'v');
                button2.BackColor = Color.Green;

                if (jogo.verifica() == true)
                {
                    MessageBox.Show("O " + jogadores[Atual].getNome() + " Ganhou");
                }
               

                if (Atual == 0)
                {

                    Atual = 1;
                }
                else
                {

                    Atual = 0;
                }

                label2.Text = jogadores[Atual].getNome();
            }
            else
            {
                if (jogo.getM(0, 1) == 'v')
                {
                    jogo.setM(0, 1, 'a');
                    button2.BackColor = Color.Yellow;

                    if (jogo.verifica() == true)
                    {
                        MessageBox.Show("O " + jogadores[Atual].getNome() + " Ganhou");
                    }

                    if (Atual == 0)
                    {

                        Atual = 1;
                    }
                    else
                    {

                        Atual = 0;
                    }

                    label2.Text = jogadores[Atual].getNome();
                }

                else
                {
                    if (jogo.getM(0, 1) == 'a')
                    {
                        jogo.setM(0, 1, 'e');
                        button2.BackColor = Color.Red;

                        if (jogo.verifica() == true)
                        {
                            MessageBox.Show("O " + jogadores[Atual].getNome() + " Ganhou");
                        }

                        if (Atual == 0)
                        {

                            Atual = 1;
                        }
                        else
                        {

                            Atual = 0;
                        }

                        label2.Text = jogadores[Atual].getNome();


                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (jogo.getM(0, 2) == ' ')
            {
                jogo.setM(0, 2, 'v');
                button3.BackColor = Color.Green;

                if (jogo.verifica() == true)
                {
                    MessageBox.Show("O " + jogadores[Atual].getNome() + " Ganhou");
                }

                if (Atual == 0)
                {

                    Atual = 1;
                }
                else
                {

                    Atual = 0;
                }

                label2.Text = jogadores[Atual].getNome();
            }
            else
            {
                if (jogo.getM(0, 2) == 'v')
                {
                    jogo.setM(0, 2, 'a');
                    button3.BackColor = Color.Yellow;

                    if (jogo.verifica() == true)
                    {
                        MessageBox.Show("O " + jogadores[Atual].getNome() + " Ganhou");
                    }

                    if (Atual == 0)
                    {

                        Atual = 1;
                    }
                    else
                    {

                        Atual = 0;
                    }

                    label2.Text = jogadores[Atual].getNome();
                }

                else
                {
                    if (jogo.getM(0, 2) == 'a')
                    {
                        jogo.setM(0, 2, 'e');
                        button3.BackColor = Color.Red;

                        if (jogo.verifica() == true)
                        {
                            MessageBox.Show("O " + jogadores[Atual].getNome() + " Ganhou");
                        }

                        if (Atual == 0)
                        {

                            Atual = 1;
                        }
                        else
                        {

                            Atual = 0;
                        }

                        label2.Text = jogadores[Atual].getNome();


                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (jogo.getM(0, 3) == ' ')
            {
                jogo.setM(0, 3, 'v');
                button4.BackColor = Color.Green;

                if (jogo.verifica() == true)
                {
                    MessageBox.Show("O " + jogadores[Atual].getNome() + " Ganhou");
                }

                if (Atual == 0)
                {

                    Atual = 1;
                }
                else
                {

                    Atual = 0;
                }

                label2.Text = jogadores[Atual].getNome();
            }
            else
            {
                if (jogo.getM(0, 3) == 'v')
                {
                    jogo.setM(0, 3, 'a');
                    button4.BackColor = Color.Yellow;

                    if (jogo.verifica() == true)
                    {
                        MessageBox.Show("O " + jogadores[Atual].getNome() + " Ganhou");
                    }

                    if (Atual == 0)
                    {

                        Atual = 1;
                    }
                    else
                    {

                        Atual = 0;
                    }

                    label2.Text = jogadores[Atual].getNome();
                }

                else
                {
                    if (jogo.getM(0, 3) == 'a')
                    {
                        jogo.setM(0, 3, 'e');
                        button4.BackColor = Color.Red;

                        if (jogo.verifica() == true)
                        {
                            MessageBox.Show("O " + jogadores[Atual].getNome() + " Ganhou");
                        }

                        if (Atual == 0)
                        {

                            Atual = 1;
                        }
                        else
                        {

                            Atual = 0;
                        }

                        label2.Text = jogadores[Atual].getNome();


                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (jogo.getM(1, 0) == ' ')
            {
                jogo.setM(1, 0, 'v');
                button5.BackColor = Color.Green;

                if (jogo.verifica() == true)
                {
                    MessageBox.Show("O " + jogadores[Atual].getNome() + " Ganhou");
                }

                if (Atual == 0)
                {

                    Atual = 1;
                }
                else
                {

                    Atual = 0;
                }

                label2.Text = jogadores[Atual].getNome();
            }
            else
            {
                if (jogo.getM(1, 0) == 'v')
                {
                    jogo.setM(1, 0, 'a');
                    button5.BackColor = Color.Yellow;

                    if (jogo.verifica() == true)
                    {
                        MessageBox.Show("O " + jogadores[Atual].getNome() + " Ganhou");
                    }

                    if (Atual == 0)
                    {

                        Atual = 1;
                    }
                    else
                    {

                        Atual = 0;
                    }

                    label2.Text = jogadores[Atual].getNome();
                }

                else
                {
                    if (jogo.getM(1, 0) == 'a')
                    {
                        jogo.setM(1, 0, 'e');
                        button5.BackColor = Color.Red;

                        if (jogo.verifica() == true)
                        {
                            MessageBox.Show("O " + jogadores[Atual].getNome() + " Ganhou");
                        }

                        if (Atual == 0)
                        {

                            Atual = 1;
                        }
                        else
                        {

                            Atual = 0;
                        }

                        label2.Text = jogadores[Atual].getNome();


                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (jogo.getM(1, 1) == ' ')
            {
                jogo.setM(1, 1, 'v');
                button6.BackColor = Color.Green;

                if (jogo.verifica() == true)
                {
                    MessageBox.Show("O " + jogadores[Atual].getNome() + " Ganhou");
                }

                if (Atual == 0)
                {

                    Atual = 1;
                }
                else
                {

                    Atual = 0;
                }

                label2.Text = jogadores[Atual].getNome();
            }
            else
            {
                if (jogo.getM(1, 1) == 'v')
                {
                    jogo.setM(1, 1, 'a');
                    button6.BackColor = Color.Yellow;

                    if (jogo.verifica() == true)
                    {
                        MessageBox.Show("O " + jogadores[Atual].getNome() + " Ganhou");
                    }

                    if (Atual == 0)
                    {

                        Atual = 1;
                    }
                    else
                    {

                        Atual = 0;
                    }

                    label2.Text = jogadores[Atual].getNome();
                }

                else
                {
                    if (jogo.getM(1, 1) == 'a')
                    {
                        jogo.setM(1, 1, 'e');
                        button6.BackColor = Color.Red;

                        if (jogo.verifica() == true)
                        {
                            MessageBox.Show("O " + jogadores[Atual].getNome() + " Ganhou");
                        }

                        if (Atual == 0)
                        {

                            Atual = 1;
                        }
                        else
                        {

                            Atual = 0;
                        }

                        label2.Text = jogadores[Atual].getNome();


                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (jogo.getM(1, 2) == ' ')
            {
                jogo.setM(1, 2, 'v');
                button7.BackColor = Color.Green;

                if (jogo.verifica() == true)
                {
                    MessageBox.Show("O " + jogadores[Atual].getNome() + " Ganhou");
                }

                if (Atual == 0)
                {

                    Atual = 1;
                }
                else
                {

                    Atual = 0;
                }

                label2.Text = jogadores[Atual].getNome();
            }
            else
            {
                if (jogo.getM(1, 2) == 'v')
                {
                    jogo.setM(1, 2, 'a');
                    button7.BackColor = Color.Yellow;

                    if (jogo.verifica() == true)
                    {
                        MessageBox.Show("O " + jogadores[Atual].getNome() + " Ganhou");
                    }

                    if (Atual == 0)
                    {

                        Atual = 1;
                    }
                    else
                    {

                        Atual = 0;
                    }

                    label2.Text = jogadores[Atual].getNome();
                }

                else
                {
                    if (jogo.getM(1, 2) == 'a')
                    {
                        jogo.setM(1, 2, 'e');
                        button7.BackColor = Color.Red;

                        if (jogo.verifica() == true)
                        {
                            MessageBox.Show("O " + jogadores[Atual].getNome() + " Ganhou");
                        }

                        if (Atual == 0)
                        {

                            Atual = 1;
                        }
                        else
                        {

                            Atual = 0;
                        }

                        label2.Text = jogadores[Atual].getNome();


                    }
                }
            }
        }
        
        private void button8_Click(object sender, EventArgs e)
        {
            if (jogo.getM(1, 3) == ' ')
            {
                jogo.setM(1, 3, 'v');
                button8.BackColor = Color.Green;

                if (jogo.verifica() == true)
                {
                    MessageBox.Show("O " + jogadores[Atual].getNome() + " Ganhou");
                }

                if (Atual == 0)
                {

                    Atual = 1;
                }
                else
                {

                    Atual = 0;
                }

                label2.Text = jogadores[Atual].getNome();
            }
            else
            {
                if (jogo.getM(1, 3) == 'v')
                {
                    jogo.setM(1, 3, 'a');
                    button8.BackColor = Color.Yellow;

                    if (jogo.verifica() == true)
                    {
                        MessageBox.Show("O " + jogadores[Atual].getNome() + " Ganhou");
                    }

                    if (Atual == 0)
                    {

                        Atual = 1;
                    }
                    else
                    {

                        Atual = 0;
                    }

                    label2.Text = jogadores[Atual].getNome();
                }

                else
                {
                    if (jogo.getM(1, 3) == 'a')
                    {
                        jogo.setM(1, 3, 'e');
                        button8.BackColor = Color.Red;

                        if (jogo.verifica() == true)
                        {
                            MessageBox.Show("O " + jogadores[Atual].getNome() + " Ganhou");
                        }

                        if (Atual == 0)
                        {

                            Atual = 1;
                        }
                        else
                        {

                            Atual = 0;
                        }

                        label2.Text = jogadores[Atual].getNome();


                    }
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (jogo.getM(2, 0) == ' ')
            {
                jogo.setM(2, 0, 'v');
                button9.BackColor = Color.Green;

                if (jogo.verifica() == true)
                {
                    MessageBox.Show("O " + jogadores[Atual].getNome() + " Ganhou");
                }

                if (Atual == 0)
                {

                    Atual = 1;
                }
                else
                {

                    Atual = 0;
                }

                label2.Text = jogadores[Atual].getNome();
            }
            else
            {
                if (jogo.getM(2, 0) == 'v')
                {
                    jogo.setM(2, 0, 'a');
                    button9.BackColor = Color.Yellow;

                    if (jogo.verifica() == true)
                    {
                        MessageBox.Show("O " + jogadores[Atual].getNome() + " Ganhou");
                    }

                    if (Atual == 0)
                    {

                        Atual = 1;
                    }
                    else
                    {

                        Atual = 0;
                    }

                    label2.Text = jogadores[Atual].getNome();
                }

                else
                {
                    if (jogo.getM(2, 0) == 'a')
                    {
                        jogo.setM(2, 0, 'e');
                        button9.BackColor = Color.Red;

                        if (jogo.verifica() == true)
                        {
                            MessageBox.Show("O " + jogadores[Atual].getNome() + " Ganhou");
                        }

                        if (Atual == 0)
                        {

                            Atual = 1;
                        }
                        else
                        {

                            Atual = 0;
                        }

                        label2.Text = jogadores[Atual].getNome();


                    }
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (jogo.getM(2, 1) == ' ')
            {
                jogo.setM(2, 1, 'v');
                button10.BackColor = Color.Green;

                if (jogo.verifica() == true)
                {
                    MessageBox.Show("O " + jogadores[Atual].getNome() + " Ganhou");
                }

                if (Atual == 0)
                {

                    Atual = 1;
                }
                else
                {

                    Atual = 0;
                }

                label2.Text = jogadores[Atual].getNome();
            }
            else
            {
                if (jogo.getM(2, 1) == 'v')
                {
                    jogo.setM(2, 1, 'a');
                    button10.BackColor = Color.Yellow;

                    if (jogo.verifica() == true)
                    {
                        MessageBox.Show("O " + jogadores[Atual].getNome() + " Ganhou");
                    }

                    if (Atual == 0)
                    {

                        Atual = 1;
                    }
                    else
                    {

                        Atual = 0;
                    }

                    label2.Text = jogadores[Atual].getNome();
                }

                else
                {
                    if (jogo.getM(2, 1) == 'a')
                    {
                        jogo.setM(2, 1, 'e');
                        button10.BackColor = Color.Red;

                        if (jogo.verifica() == true)
                        {
                            MessageBox.Show("O " + jogadores[Atual].getNome() + " Ganhou");
                        }

                        if (Atual == 0)
                        {

                            Atual = 1;
                        }
                        else
                        {

                            Atual = 0;
                        }

                        label2.Text = jogadores[Atual].getNome();


                    }
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (jogo.getM(2, 2) == ' ')
            {
                jogo.setM(2, 2, 'v');
                button11.BackColor = Color.Green;

                if (jogo.verifica() == true)
                {
                    MessageBox.Show("O " + jogadores[Atual].getNome() + " Ganhou");
                }

                if (Atual == 0)
                {

                    Atual = 1;
                }
                else
                {

                    Atual = 0;
                }

                label2.Text = jogadores[Atual].getNome();
            }
            else
            {
                if (jogo.getM(2, 2) == 'v')
                {
                    jogo.setM(2, 2, 'a');
                    button11.BackColor = Color.Yellow;

                    if (jogo.verifica() == true)
                    {
                        MessageBox.Show("O " + jogadores[Atual].getNome() + " Ganhou");
                    }

                    if (Atual == 0)
                    {

                        Atual = 1;
                    }
                    else
                    {

                        Atual = 0;
                    }

                    label2.Text = jogadores[Atual].getNome();
                }

                else
                {
                    if (jogo.getM(2, 2) == 'a')
                    {
                        jogo.setM(2, 2, 'e');
                        button11.BackColor = Color.Red;

                        if (jogo.verifica() == true)
                        {
                            MessageBox.Show("O " + jogadores[Atual].getNome() + " Ganhou");
                        }

                        if (Atual == 0)
                        {

                            Atual = 1;
                        }
                        else
                        {

                            Atual = 0;
                        }

                        label2.Text = jogadores[Atual].getNome();


                    }
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (jogo.getM(2, 3) == ' ')
            {
                jogo.setM(2, 3, 'v');
                button12.BackColor = Color.Green;

                if (jogo.verifica() == true)
                {
                    MessageBox.Show("O " + jogadores[Atual].getNome() + " Ganhou");
                }

                if (Atual == 0)
                {

                    Atual = 1;
                }
                else
                {

                    Atual = 0;
                }

                label2.Text = jogadores[Atual].getNome();
            }
            else
            {
                if (jogo.getM(2, 3) == 'v')
                {
                    jogo.setM(2, 3, 'a');
                    button12.BackColor = Color.Yellow;

                    if (jogo.verifica() == true)
                    {
                        MessageBox.Show("O " + jogadores[Atual].getNome() + " Ganhou");
                    }

                    if (Atual == 0)
                    {

                        Atual = 1;
                    }
                    else
                    {

                        Atual = 0;
                    }

                    label2.Text = jogadores[Atual].getNome();
                }

                else
                {
                    if (jogo.getM(2, 3) == 'a')
                    {
                        jogo.setM(2, 3, 'e');
                        button12.BackColor = Color.Red;

                        if (jogo.verifica() == true)
                        {
                            MessageBox.Show("O " + jogadores[Atual].getNome() + " Ganhou");
                        }

                        if (Atual == 0)
                        {

                            Atual = 1;
                        }
                        else
                        {

                            Atual = 0;
                        }

                        label2.Text = jogadores[Atual].getNome();

                    }
                }
            }
        }
    }
}
