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
    public partial class Form1 : Form
    {
        bool selecao;
        string personagem="Militar", a;
        public Form1()
        {
            InitializeComponent();
        }

        private void b_select_Militar_CheckedChanged(object sender, EventArgs e)
        {            
            selecao = b_select_Militar.Checked;
            if(selecao == true)
            {
                personagem = "Militar";
            }
        }

        private void b_select_Mago_CheckedChanged(object sender, EventArgs e)
        {
            selecao = b_select_Mago.Checked;
            if (selecao == true)
            {
                personagem = "Mago";
            }
        }

        private void b_select_Drag_CheckedChanged(object sender, EventArgs e)
        {
            selecao = b_select_Drag.Checked;
            if (selecao == true)
            {
                personagem = "Dragão";
            }
        }

        private void b_select_Samurai_CheckedChanged(object sender, EventArgs e)
        {
            selecao = b_select_Samurai.Checked;
            if (selecao == true)
            {
                personagem = "Samurai";
            }
        }

        private void b_confPerson1_Click(object sender, EventArgs e)
        {
            if(personagem == "Militar")
            {
                Militar mili = new Militar();
                if ("Fuzil" == cb_ArmaMilitar.Text)
                {
                    mili.setArma(new Fuzil());
                }
                if ("Sniper" == cb_ArmaMilitar.Text)
                {
                    mili.setArma(new Sniper());
                }
                if ("Lança Foguetes" == cb_ArmaMilitar.Text)
                {
                    mili.setArma(new Lança_Foguetes());
                }
                if ("Espingarda" == cb_ArmaMilitar.Text)
                {
                    mili.setArma(new Espingarda());
                }
                a = cb_ArmaMilitar.Text;
            }
            if (personagem == "Mago")
            {
               Mago mag = new Mago();
                if ("Fogo" == cb_ArmaMago.Text)
                {
                    mag.setMagia(new Fogo());
                }
                if ("Trevas" == cb_ArmaMago.Text)
                {
                     mag.setMagia(new Trevas());
                }
                if ("Água" == cb_ArmaMago.Text)
                {
                     mag.setMagia(new Agua());
                }
                if ("Gelo" == cb_ArmaMago.Text)
                {
                     mag.setMagia(new Gelo());
                }
                a = cb_ArmaMago.Text;
            }
            if (personagem == "Dragão")
            {
                Dragao drag = new Dragao();
                
                if ("Fogo" == cb_ArmaDragao.Text)
                {
                    drag.setMagia(new Fogo());
                }
                if ("Trevas" == cb_ArmaDragao.Text)
                {
                    drag.setMagia(new Trevas());
                }
                if ("Eletrico" == cb_ArmaDragao.Text)
                {
                     drag.setMagia(new Agua());
                }
                if ("Gelo" == cb_ArmaDragao.Text)
                {
                     drag.setMagia(new Gelo());
                }
                a = cb_ArmaDragao.Text;
            }
            if (personagem == "Samurai")
            {
                Samurai samu = new Samurai();
                if ("Semehada" == cb_ArmaSamurai.Text)
                {
                    samu.setArma(new Semehada());
                }
                if ("Cutelo" == cb_ArmaSamurai.Text)
                {
                     samu.setArma(new Cutelo());
                }
                if ("Katana" == cb_ArmaSamurai.Text)
                {
                     samu.setArma(new Katana());
                }
                if ("Lamina do Dragão" == cb_ArmaSamurai.Text)
                {
                     samu.setArma(new Lamina_do_Dragao());
                }
                a = cb_ArmaSamurai.Text;
            }
            
            Form2 f2 = new Form2(personagem,a);
            f2.ShowDialog();

        }
    }
}
