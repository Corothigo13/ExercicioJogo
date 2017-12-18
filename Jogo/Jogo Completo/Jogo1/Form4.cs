using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo1
{
    public partial class Form4 : Form
    {
        int p1, p2, nlutas;
        string personagem1, personagem2, armap1, armap2;

        public Form4(string a, string b, int person1, int person2, string a1, string a2)
        {
            InitializeComponent();
            p1 = person1;
            p2 = person2;
            personagem1 = a;
            personagem2 = b;
            this.armap1 = a1;
            this.armap2 = a2;
            label3.Text = "Arma/Magia: " + armap1;
            label5.Text = "Arma/Magia: " + armap2;
            ataqueperson1();
            ataqueperson2();
            danos();

        }
        int dano1, dano2, segundos = 5;

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundos--;
            //tava aq os if            
            if (segundos == 0)
            {
                pictureBox5.Visible = false;
                timer1.Stop();
                if (p1 > p2)
                {
                    MessageBox.Show("Já foram realizadas três lutas e o vencedor foi " + personagem1 + " com " + p1 + " lutas ganhas.");
                }
                if (p2 > p1)
                {
                    MessageBox.Show("Já foram realizadas três lutas e o vencedor foi " + personagem2 + " com " + p2 + " lutas ganhas.");
                }
                Close();
            }

        }

        private void resultadoJogo_Click(object sender, EventArgs e)
        {
            if (p1 - p2 > 0)
            {
                if (personagem1 == "Dragão")
                {
                    pictureBox5.Image = new Bitmap(@"C:\Users\Thiago\Desktop\Jogo Completo\Jogo1\bin\Debug\Drogon.gif");
                    pictureBox5.Visible = true;

                }
                if (personagem1 == "Samurai")
                {
                    pictureBox5.Image = new Bitmap(@"C:\Users\Thiago\Desktop\Jogo Completo\Jogo1\bin\Debug\kirito2.gif");
                    pictureBox5.Visible = true;

                }
                if (personagem1 == "Militar")
                {
                    pictureBox5.Image = new Bitmap(@"C:\Users\Thiago\Desktop\Jogo Completo\Jogo1\bin\Debug\sniper.gif");
                    pictureBox5.Visible = true;

                }
                if (personagem1 == "Mago")
                {
                    pictureBox5.Image = new Bitmap(@"C:\Users\Thiago\Desktop\Jogo Completo\Jogo1\bin\Debug\mago.gif");
                    pictureBox5.Visible = true;

                }
            }
            if (p1 - p2 < 0)
            {
                if (personagem2 == "Dragão")
                {
                    pictureBox5.Image = new Bitmap(@"C:\Users\Thiago\Desktop\Jogo Completo\Jogo1\bin\Debug\Drogon.gif");
                    pictureBox5.Visible = true;

                }
                if (personagem2 == "Samurai")
                {
                    pictureBox5.Image = new Bitmap(@"C:\Users\Thiago\Desktop\Jogo Completo\Jogo1\bin\Debug\kirito2.gif");
                    pictureBox5.Visible = true;

                }
                if (personagem2 == "Militar")
                {
                    pictureBox5.Image = new Bitmap(@"C:\Users\Thiago\Desktop\Jogo Completo\Jogo1\bin\Debug\sniper.gif");
                    pictureBox5.Visible = true;

                }
                if (personagem2 == "Mago")
                {
                    pictureBox5.Image = new Bitmap(@"C:\Users\Thiago\Desktop\Jogo Completo\Jogo1\bin\Debug\mago.gif");
                    pictureBox5.Visible = true;

                }
            }
            timer1.Enabled = true;
            timer1.Start();
        }

        Random rand = new Random();


        public void ataqueperson2()
        {
            if (personagem2 == "Militar")
            {
                Militar mili2 = new Militar();
                if ("Fuzil" == armap2)
                {
                    mili2.setArma(new Fuzil());
                    ataquep2.Text = mili2.Arma();
                }
                if ("Sniper" == armap2)
                {
                    mili2.setArma(new Sniper());
                    ataquep2.Text = mili2.Arma();

                }
                if ("Lança Foguetes" == armap2)
                {
                    mili2.setArma(new Lança_Foguetes());
                    ataquep2.Text = mili2.Arma();

                }
                if ("Espingarda" == armap2)
                {
                    mili2.setArma(new Espingarda());
                    ataquep2.Text = mili2.Arma();

                }
            }
            if (personagem2 == "Mago")
            {
                Mago mag2 = new Mago();
                if ("Fogo" == armap2)
                {
                    mag2.setMagia(new Fogo());
                    ataquep2.Text = mag2.Magia();
                }
                if ("Trevas" == armap2)
                {
                    mag2.setMagia(new Trevas());
                    ataquep2.Text = mag2.Magia();
                }
                if ("Água" == armap2)
                {
                    mag2.setMagia(new Agua());
                    ataquep2.Text = mag2.Magia();
                }
                if ("Gelo" == armap2)
                {
                    mag2.setMagia(new Gelo());
                    ataquep2.Text = mag2.Magia();
                }
            }
            if (personagem2 == "Dragão")
            {
                Dragao drag2 = new Dragao();

                if ("Fogo" == armap2)
                {
                    drag2.setMagia(new Fogo());
                    ataquep2.Text = drag2.Magia();
                }
                if ("Trevas" == armap2)
                {
                    drag2.setMagia(new Trevas());
                    ataquep2.Text = drag2.Magia();
                }
                if ("Eletrico" == armap2)
                {
                    drag2.setMagia(new Agua());
                    ataquep2.Text = drag2.Magia();
                }
                if ("Gelo" == armap2)
                {
                    drag2.setMagia(new Gelo());
                    ataquep2.Text = drag2.Magia();
                }
            }
            if (personagem2 == "Samurai")
            {
                Samurai samu2 = new Samurai();
                if ("Semehada" == armap2)
                {
                    samu2.setArma(new Semehada());
                    ataquep2.Text = samu2.Arma();
                }
                if ("Cutelo" == armap2)
                {
                    samu2.setArma(new Cutelo());
                    ataquep2.Text = samu2.Arma();
                }
                if ("Katana" == armap2)
                {
                    samu2.setArma(new Katana());
                    ataquep2.Text = samu2.Arma();
                }
                if ("Lamina do Dragão" == armap2)
                {
                    samu2.setArma(new Lamina_do_Dragao());
                    ataquep2.Text = samu2.Arma();
                }
            }
        }

        public void ataqueperson1()
        {
            if (personagem1 == "Militar")
            {
                Militar mili = new Militar();
                if ("Fuzil" == armap1)
                {
                    mili.setArma(new Fuzil());
                    ataquep1.Text = mili.Arma();
                }
                if ("Sniper" == armap1)
                {
                    mili.setArma(new Sniper());
                    ataquep1.Text = mili.Arma();

                }
                if ("Lança Foguetes" == armap1)
                {
                    mili.setArma(new Lança_Foguetes());
                    ataquep1.Text = mili.Arma();

                }
                if ("Espingarda" == armap1)
                {
                    mili.setArma(new Espingarda());
                    ataquep1.Text = mili.Arma();

                }
            }
            if (personagem1 == "Mago")
            {
                Mago mag = new Mago();
                if ("Fogo" == armap1)
                {
                    mag.setMagia(new Fogo());
                    ataquep1.Text = mag.Magia();
                }
                if ("Trevas" == armap1)
                {
                    mag.setMagia(new Trevas());
                    ataquep1.Text = mag.Magia();
                }
                if ("Água" == armap1)
                {
                    mag.setMagia(new Agua());
                    ataquep1.Text = mag.Magia();
                }
                if ("Gelo" == armap1)
                {
                    mag.setMagia(new Gelo());
                    ataquep1.Text = mag.Magia();
                }
            }
            if (personagem1 == "Dragão")
            {
                Dragao drag = new Dragao();

                if ("Fogo" == armap1)
                {
                    drag.setMagia(new Fogo());
                    ataquep1.Text = drag.Magia();
                }
                if ("Trevas" == armap1)
                {
                    drag.setMagia(new Trevas());
                    ataquep1.Text = drag.Magia();
                }
                if ("Eletrico" == armap1)
                {
                    drag.setMagia(new Agua());
                    ataquep1.Text = drag.Magia();
                }
                if ("Gelo" == armap1)
                {
                    drag.setMagia(new Gelo());
                    ataquep1.Text = drag.Magia();
                }
            }
            if (personagem1 == "Samurai")
            {
                Samurai samu = new Samurai();
                if ("Semehada" == armap1)
                {
                    samu.setArma(new Semehada());
                    ataquep1.Text = samu.Arma();
                }
                if ("Cutelo" == armap1)
                {
                    samu.setArma(new Cutelo());
                    ataquep1.Text = samu.Arma();
                }
                if ("Katana" == armap1)
                {
                    samu.setArma(new Katana());
                    ataquep1.Text = samu.Arma();
                }
                if ("Lamina do Dragão" == armap1)
                {
                    samu.setArma(new Lamina_do_Dragao());
                    ataquep1.Text = samu.Arma();
                }
            }
        }

        public void danos()
        {

            l_personagem1.Text = personagem1;
            l_personagem2.Text = personagem2;
            dano1 = rand.Next(0, 13);
            dano2 = rand.Next(0, 13);
            label6.Text = Convert.ToString(dano1);
            label7.Text = Convert.ToString(dano2);
            if (Convert.ToInt32(label6.Text) > Convert.ToInt32(label7.Text))
            {
                label8.Text = personagem1 + " ganhou a luta.";
                p1++;
            }
            if (Convert.ToInt32(label6.Text) < Convert.ToInt32(label7.Text))
            {
                label8.Text = personagem2 + " ganhou a luta.";
                p2++;
            }
            if (Convert.ToInt32(label6.Text) == Convert.ToInt32(label7.Text))
            {
                label8.Text = "A luta terminou em empate.";
            }
            nlutas = p1 + p2;
            npartidas.Text = "Numeros de Lutas realizadas: " + nlutas;
            placar.Text = personagem1 + " : " + Convert.ToString(p1) + " | " + personagem2 + " : " + Convert.ToString(p2);

        }

    }
}
