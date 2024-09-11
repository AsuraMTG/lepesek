using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lepesek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        static int BinaryToDec(string input)
        {
            char[] array = input.ToCharArray();
            // Reverse since 16-8-4-2-1 not 1-2-4-8-16. 
            Array.Reverse(array);
            /*
             * [0] = 1
             * [1] = 2
             * [2] = 4
             * etc
             */
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '1')
                {
                    // Method uses raising 2 to the power of the index. 
                    if (i == 0)
                    {
                        sum += 1;
                    }
                    else
                    {
                        sum += (int)Math.Pow(2, i);
                    }
                }

            }

            return sum;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //35%
            int lepesMax = 20;
            string lepesSzamol = "";
            int egyesekSzama = 0;
            //int szazalek = 0;

            Random random = new Random();

            for (int i = 0; i < lepesMax; i++)
            {
                int lep = random.Next(0, 2);

                if (lep == 1)
                {
                    lepesSzamol += "1";
                }
                else
                    lepesSzamol += "0";
            }

            for (int i = 0; i < lepesSzamol.Length; i++)
            {
                if (lepesSzamol[i] == '1')
                {
                    egyesekSzama++;
                }
            }



            label1.Text = $"{lepesSzamol}\n{egyesekSzama}\n{BinaryToDec(lepesSzamol)}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";

            //intervallum 0-1005 számjegyek összege 6

            int[] szamok = new int[1006];
            string[] megfelel = new string[1006];
            int kesz = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = i;

                string seged = szamok[i].ToString();


                for (int j = 0; j < seged.Length; j++)
                {

                    label1.Text += $"1";
                    kesz = kesz + Convert.ToInt32(seged[j]);
                    if (kesz == 6)
                    {
                        megfelel[i] = szamok[i].ToString();

                        label1.Text += $"Szia";
                        kesz = 0;
                    }
                }
            }
        }
    }
}
