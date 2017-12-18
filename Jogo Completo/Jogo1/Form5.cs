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
    public partial class Form5 : Form
    {
        int p1, p2, nlutas;
        string personagem1, personagem2, armap1, armap2;

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(personagem1, personagem2, p1, p2, comboBox1.Text, comboBox2.Text, nlutas);
            f3.ShowDialog();
            Close();
        }

        public Form5(string a, string b, int person1, int person2, string a1, string a2, int lutas)
        {
            InitializeComponent();
            p1 = person1;
            p2 = person2;
            personagem1 = a;
            personagem2 = b;
            this.armap1 = a1;
            this.armap2 = a2;
            nlutas = lutas;
            label1.Text = "No inicio voces escolheram os personagens " + personagem1 + " e " + personagem2 + " escolha as armas quer eles iram\n                                                            para a proxima luta.";
            label2.Text = "Escolha a nova arma para o " + personagem1;
            label3.Text = "Escolha a nova arma para o " + personagem2;
            troca1();
            troca2();

        }
        public void troca1()
        {
            if (personagem1 == "Militar")
            {

                comboBox1.Items.AddRange(new object[] {"Sniper","Fuzil", "Espingarda","Lança Foguetes"});

            }
            if (personagem1 == "Samurai")
            {
                comboBox1.Items.AddRange(new object[] { "Katana", "Semehada", "Espada do Dragão", "Cutelo" });
            }
            if (personagem1 == "Dragão")
            {
                comboBox1.Items.AddRange(new object[] { "Fogo", "Eletrico", "Trevas", "Gelo" });
               
            }
            if (personagem1 == "Mago")
            {
                comboBox1.Items.AddRange(new object[] { "Trevas", "Gelo", "Fogo", "Água" });
            }
            armap1 = comboBox1.Text;
        }
        public void troca2()
        {
            if (personagem2 == "Militar")
            {

                comboBox2.Items.AddRange(new object[] { "Sniper", "Fuzil", "Espingarda", "Lança Foguetes" });

            }
            if (personagem2 == "Samurai")
            {
                comboBox2.Items.AddRange(new object[] { "Katana", "Semehada", "Espada do Dragão", "Cutelo" });
            }
            if (personagem2 == "Dragão")
            {
                comboBox2.Items.AddRange(new object[] { "Fogo", "Eletrico", "Trevas", "Gelo" });

            }
            if (personagem2 == "Mago")
            {
                comboBox2.Items.AddRange(new object[] { "Trevas", "Gelo", "Fogo", "Água" });
            }
            armap2 = comboBox2.Text;
        }
    }
}
