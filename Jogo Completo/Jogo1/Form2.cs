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
    public partial class Form2 : Form
    {
        int p1 = 0, p2 = 0;
        string personagem1, a1, a2;
        public Form2(string c, string arma1)
        {
            InitializeComponent();
            personagem1 = c;
            a1 = arma1;
        }
        bool selecao;
        string personagem2="Militar";
        private void b_select_Militar2_CheckedChanged(object sender, EventArgs e)
        {
            selecao = b_select_Militar2.Checked;
            if (selecao == true)
            {
                personagem2 = "Militar";
            }
        }

        private void b_select_Mago2_CheckedChanged(object sender, EventArgs e)
        {
            selecao = b_select_Mago2.Checked;
            if (selecao == true)
            {
                personagem2 = "Mago";
            }
        }

        private void b_select_Drag2_CheckedChanged(object sender, EventArgs e)
        {
            selecao = b_select_Drag2.Checked;
            if (selecao == true)
            {
                personagem2 = "Dragão";
            }
        }

        private void b_select_Samurai2_CheckedChanged(object sender, EventArgs e)
        {
            selecao = b_select_Samurai2.Checked;
            if (selecao == true)
            {
                personagem2 = "Samurai";
            }
        }

        private void b_Lutar_Click(object sender, EventArgs e)
        {
            if (personagem2 == "Militar")
            {
                Militar mili2 = new Militar();
                if ("Fuzil" == cb_ArmaMilitar2.Text)
                {
                    mili2.setArma(new Fuzil());
                    
                }
                if ("Sniper" == cb_ArmaMilitar2.Text)
                {
                    mili2.setArma(new Sniper());
                }
                if ("Lança Foguetes" == cb_ArmaMilitar2.Text)
                {
                    mili2.setArma(new Lança_Foguetes());
                }
                if ("Espingarda" == cb_ArmaMilitar2.Text)
                {
                    mili2.setArma(new Espingarda());
                }
                a2 = cb_ArmaMilitar2.Text;
            }
            if (personagem2 == "Mago")
            {
                Mago mag2 = new Mago();
                if ("Fogo" == cb_ArmaMago2.Text)
                {
                    mag2.setMagia(new Fogo());
                }
                if ("Trevas" == cb_ArmaMago2.Text)
                {
                    mag2.setMagia(new Trevas());
                }
                if ("Água" == cb_ArmaMago2.Text)
                {
                    mag2.setMagia(new Agua());
                }
                if ("Gelo" == cb_ArmaMago2.Text)
                {
                    mag2.setMagia(new Gelo());
                }
                a2 = cb_ArmaMago2.Text;
            }
            if (personagem2 == "Dragão")
            {
                Dragao drag2 = new Dragao();
                if ("Fogo" == cb_ArmaDragao2.Text)
                {
                    drag2.setMagia(new Fogo());
                }
                if ("Trevas" == cb_ArmaDragao2.Text)
                {
                    drag2.setMagia(new Trevas());
                }
                if ("Eletrico" == cb_ArmaDragao2.Text)
                {
                    drag2.setMagia(new Agua());
                }
                if ("Gelo" == cb_ArmaDragao2.Text)
                {
                    drag2.setMagia(new Gelo());
                }
                a2 = cb_ArmaDragao2.Text;
            }
            if (personagem2 == "Samurai")
            {
                Samurai samu2 = new Samurai();
                if ("Semehada" == cb_ArmaSamurai2.Text)
                {
                    samu2.setArma(new Semehada());
                }
                if ("Cutelo" == cb_ArmaSamurai2.Text)
                {
                    samu2.setArma(new Cutelo());
                }
                if ("Katana" == cb_ArmaSamurai2.Text)
                {
                    samu2.setArma(new Katana());
                }
                if ("Lamina do Dragão" == cb_ArmaSamurai2.Text)
                {
                    samu2.setArma(new Lamina_do_Dragao());
                }
                a2 = cb_ArmaSamurai2.Text;
            }
            Form3 f3 = new Form3(personagem1,personagem2,p1,p2,a1,a2,0);
            f3.ShowDialog();
            Close();
        }
    }
}
