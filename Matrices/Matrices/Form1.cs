using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] Matrice;
            int iTaille = 0;
            int iDet;
            try
            {
                iTaille = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                
            }
            if (iTaille > 0)
            {
                Matrice2D mMatrice = new Matrice2D();
                Matrice = mMatrice.Random(iTaille);
                label3.Text = mMatrice.AfficheMat(Matrice, iTaille);
                iDet = mMatrice.CalcDeterminant(Matrice, iTaille);

                label2.Text = Convert.ToString(iDet);
            }
            else
            {
                MessageBox.Show("Entrez un nombre supérieur à zéro");
            }
        }


    }    
}
