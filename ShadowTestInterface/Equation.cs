using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuadrilateralTestInterface
{
	internal class Equation
	{
		private double[,] bigDeterminatorMatrix;
		private double[,] smallDeterminatorMatrix;
		private double smallDeterminator;
		private double bigDeterminator;
		public double SmallDiscriminant
        {
            get { return smallDeterminator; }	
        }
		public double BigDiscriminant
		{
			get { return bigDeterminator; }
		}

		public double A { private set; get; }
		public double B { private set; get; }
		public double C { private set; get; }
		public double D { private set; get; }
		public double E { private set; get; }
		public double F { private set; get; }
		public string Type { private set; get; }
		
		public Equation(double a, double b, double c, double d, double e, double f)
		{
			bigDeterminatorMatrix = new double[3, 3];
			smallDeterminatorMatrix = new double[2, 2];
			A = a;
			B = b;
			C = c;
			D = d;
			E = e;
			F = f;
			bigDeterminatorMatrix[0, 0] = A;
			bigDeterminatorMatrix[0, 1] = B;
			bigDeterminatorMatrix[0, 2] = D;
			bigDeterminatorMatrix[1, 0] = B;
			bigDeterminatorMatrix[1, 1] = C;
			bigDeterminatorMatrix[1, 2] = E;
			bigDeterminatorMatrix[2, 0] = D;
			bigDeterminatorMatrix[2, 1] = E;
			bigDeterminatorMatrix[2, 2] = F;
			smallDeterminatorMatrix[0, 0] = A;
			smallDeterminatorMatrix[0, 1] = B;
			smallDeterminatorMatrix[1, 0] = B;
			smallDeterminatorMatrix[1, 1] = C;
			Type = GetEquationType();
		}
		public static double[,] GetMinor(double[,] matrix, int row, int column)
		{
			if (matrix.GetLength(0) != matrix.GetLength(1)) throw new Exception(" Число строк в матрице не совпадает с числом столбцов");
			double[,] buf = new double[matrix.GetLength(0) - 1, matrix.GetLength(0) - 1];
			for (int i = 0; i < matrix.GetLength(0); i++)
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					if ((i != row) || (j != column))
					{
						if (i > row && j < column) buf[i - 1, j] = matrix[i, j];
						if (i < row && j > column) buf[i, j - 1] = matrix[i, j];
						if (i > row && j > column) buf[i - 1, j - 1] = matrix[i, j];
						if (i < row && j < column) buf[i, j] = matrix[i, j];
					}
				}
			return buf;
		}
		private double GetDeterminator(double[,] matrix)
		{
			double det = 0;
			int Rank = matrix.GetLength(0);
			if (Rank == 1) det = matrix[0, 0];
			if (Rank == 2) det = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
			if (Rank > 2)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					det += Math.Pow(-1, 0 + j) * matrix[0, j] * GetDeterminator(GetMinor(matrix, 0, j));
				}
			}
			return det;
		}
		public string GetEquationType()
        {
			smallDeterminator = GetDeterminator(smallDeterminatorMatrix);
			bigDeterminator = GetDeterminator(bigDeterminatorMatrix);
            if (bigDeterminator != 0)
            {
                if (smallDeterminator > 0)
                {
					return "эллипс";
                }
                else if (smallDeterminator == 0)
                {
					return "парабола";
				}
				return "гипербола";
			}
            else
            {
				if (smallDeterminator > 0)
				{
					return "пересекающиеся мнимые прямые (точка)";
				}
				else if (smallDeterminator == 0)
				{
					return "две параллельные прямые";
				}
				return "две пересекающиеся действительные прямые";
			}
		}
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append(A);
			sb.Append("*x^2");

			B *= 2; 
			if (B >= 0)
				sb.Append("+");
			sb.Append(B);
			sb.Append("*xy");

			if (C >= 0)
				sb.Append("+" + C);
			else
				sb.Append(C);
			sb.Append("*y^2");

			D *= 2;
			if (D >= 0)
				sb.Append("+");
			sb.Append(D);
			sb.Append("*x");

			E *= 2;
			if (E >= 0)
				sb.Append("+");
			sb.Append(E);
			sb.Append("*y");

			if (F >= 0)
				sb.Append("+");
			sb.Append(F);

			sb.Append("=0");
			return sb.ToString();
		}

    }
}
