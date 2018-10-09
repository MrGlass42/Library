/* Programa que calcula o lado de um quadrado a ser retirado de uma folha quadrada, de modo a possibilitar que uma caixa
 * que será construida com base nessa folha tem um volume máximo.
 * FATEC - MC - PGRG - 09/11/2017 - Versão 0.3
 * --> Adicionada a possibilidade de se calcular os valores, pressionando a tecla Enter além de pressionar o botão: "Calcular".
 * --> Alterado as fontes dos Texts Box, e também o tamanho das mesmas.
 * --> Acrecentado sistema de conversão de medidas: cm -> m.
 * --> Acrecentado a imagem e os labels variavies para informar os valores na imagem.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjCalc1
{
    public partial class Form1 : Form
    {
        double pc = 0,
                sd = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculo(object sender, EventArgs e)
        {
            string String;
            double d = 0,
            v1 = 0,
            v2 = 0,
            y = 0,
            sd = 0,
            num1 = 12, 
            num2 = 8,  
            num3 = 1,  
            nums1 = 24,
            nums2 = -8;
            String = Txb1.Text;
            y = Double.Parse(String);
            if (y < 2)
            {
                MessageBox.Show("Digite um número váido!!!", "FATEC - MC");
                Txb1.Text = "";
            }
            else
            {
                num2 = num2 * y;
                num3 = num3 * (y * y);
                d = (num2 * num2) - 4 * num1 * num3;
                v1 = (num2 + Math.Sqrt(d)) / (2 * num1);
                v2 = (num2 - Math.Sqrt(d)) / (2 * num1);
                if (v1 != 0 && v1 > 0 && v1 < (y / 2))
                {
                    sd = 24 * v1 - 8 * y;
                    if (sd < 0 && sd != 0)
                        pc = v1;
                }
                if (v2 != 0 && v2 > 0 && v2 < (y / 2))
                {
                    sd = 24 * v2 - 8 * y;
                    if (sd < 0 && sd != 0)
                        pc = v2;
                }
                sd = 4 * (pc * pc * pc) - 4 * (pc * pc) * y + (y * y) * pc;
                if (MessageBox.Show("Deseja que os valores sejam mostrados em Metros?", "FATEC - MC", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    pc = pc / 100;
                    sd = sd / 100;
                    Txb2.Text = $"O valor do lado do quadrado pequeno é: {pc}m e o volume máximo para esse lado é: {sd}m";
                    l5.Text = Convert.ToString(pc);
                    l6.Text = "m";
                    l7.Text = Convert.ToString(pc);
                    l8.Text = "m";
                }
                else
                {
                    Txb2.Text = $"O valor do lado do quadrado pequeno é: {pc}cm e o volume máximo para esse lado é: {sd}cm";
                    l5.Text = Convert.ToString(pc);
                    l7.Text = Convert.ToString(pc);
                }
                d = 0;
                v1 = 0;
                v2 = 0;
                y = 0;
                pc = 0;
                sd = 0;
                num1 = 12;
                num2 = 8;
                num3 = 1;
                nums1 = 24;
                nums2 = -8;
            }
        }
        private void Limpar(object sender, EventArgs e)
        {
            Txb1.Text = "";
            Txb2.Text = "";
        }
        public void Txb1_TextChanged(object sender, EventArgs e)
        {  
        }
        public void Txb2_TextChanged(object sender, EventArgs e)
        {   
        }
        private void Calculo2(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string String;
                double d = 0,
                    v1 = 0,
                    v2 = 0,
                    y = 0,
                    pc = 0,
                    sd = 0,
                    num1 = 12,
                    num2 = 8,
                    num3 = 1,
                    nums1 = 24,
                    nums2 = -8;
                String = Txb1.Text;
                y = Double.Parse(String);
                if (y < 2)
                {
                    MessageBox.Show("Digite um número váido!!!", "FATEC - MC");
                    Txb1.Text = "";
                }
                else
                {
                    num2 = num2 * y;
                    num3 = num3 * (y * y);
                    d = (num2 * num2) - 4 * num1 * num3;
                    v1 = (num2 + Math.Sqrt(d)) / (2 * num1);
                    v2 = (num2 - Math.Sqrt(d)) / (2 * num1);
                    if (v1 != 0 && v1 > 0 && v1 < (y / 2))
                    {
                        sd = 24 * v1 - 8 * y;
                        if (sd < 0 && sd != 0)
                            pc = v1;
                    }
                    if (v2 != 0 && v2 > 0 && v2 < (y / 2))
                    {
                        sd = 24 * v2 - 8 * y;
                        if (sd < 0 && sd != 0)
                            pc = v2;
                    }
                    sd = 4 * (pc * pc * pc) - 4 * (pc * pc) * y + (y * y) * pc;
                    if (MessageBox.Show("Deseja que os valores sejam mostrados em Metros?", "FATEC - MC", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        pc = pc / 100;
                        sd = sd / 100;
                        Txb2.Text = $"O valor do lado do quadrado pequeno é: {pc}m e o volume máximo para esse lado é: {sd}m";
                        l5.Text = Convert.ToString(pc);
                        l6.Text = "m";
                        l7.Text = Convert.ToString(pc);
                        l8.Text = "m";
                    }
                    else
                    {
                        Txb2.Text = $"O valor do lado do quadrado pequeno é: {pc}cm e o volume máximo para esse lado é: {sd}cm";
                        l5.Text = Convert.ToString(pc);
                        l7.Text = Convert.ToString(pc);
                    }
                    d = 0;
                    v1 = 0;
                    v2 = 0;
                    y = 0;
                    pc = 0;
                    sd = 0;
                    num1 = 12;
                    num2 = 8;
                    num3 = 1;
                    nums1 = 24;
                    nums2 = -8;
                }
            }
        }
    }
}
