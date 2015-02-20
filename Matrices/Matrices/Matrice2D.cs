using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    class Matrice2D
    {

        public int[,] Random(int Taille){

            Random rnd = new Random();
            int i, j;
            int[,] Mat2D = new Int32[Taille,Taille];
            for (i = 0; i < Taille; i++)
            {

                for (j = 0; j < Taille; j++)
                {
                    Mat2D[i, j] = rnd.Next(-9,9);

                }

            }
            return Mat2D;
        }
        public int[,] NewMatrice(int[,] Mat, int t1, int iCase)
        {
            int i, j, iNew = 0, jNew = 0;
            int[,] NewMat = new int[t1,t1];

            for (i = 0; i < t1 + 1; i++)
            {
                if (i != iCase)
                {
                    for (j = 1; j < t1 + 1; j++)
                    {


                        NewMat[jNew,iNew] = Mat[j,i];



                        jNew++;

                    }
                    iNew++;
                    jNew = 0;
                }
            }
            return NewMat;
        }
        public int CalcDeterminant(int[,] Matrice, int Taille)
        {

            int[,] newMatrice = {};
            int det = 0;
            int i, j;
            int signe = 1;

            if (Taille > 2)
            {

                i = Taille - 1;
                for (j = 0; j < Taille; j++)
                {

                    newMatrice= NewMatrice(Matrice,  i, j);

                    if (signe < 0)
                    {
                        det -= Matrice[0,j] * CalcDeterminant(newMatrice, Taille - 1);
                    }
                    else
                    {
                        det += Matrice[0,j] * CalcDeterminant(newMatrice, Taille - 1);
                    }
                    signe = -signe;
                }


            }
            else
            {
                det = Matrice[0,0] * Matrice[1,1] - Matrice[1,0] * Matrice[0,1];
            }
            return det;
        }
        public string AfficheMat(int[,] Mat, int Taille)
        {

            int i, j;
            string strMat = "";
            for (i = 0; i < Taille; i++)
            {

                for (j = 0; j < Taille; j++)
                {
                    if (Mat[i, j]<0)
                        strMat += "    " + Mat[i,j] ;
                    else
                        strMat += "     " +Mat[i, j] ;

                }

                strMat += "\n\n";

            }
            return strMat;
        }
    }
}
