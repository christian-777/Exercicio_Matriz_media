internal class Program
{
    private static void Main(string[] args)
    {
        double[,] mat = new double[5,3];

        Montar(mat);

        for (int l = 0; l < mat.GetLength(0); l++)
        {
            for (int c = 0; c < mat.GetLength(1); c++)
            {
                Console.Write(mat[l,c]+" | ");
            }
            Console.WriteLine();
        }


        void Montar(double[,] d) 
        { 
            Random n= new Random();

            for(int l=0; l<d.GetLength(0); l++)
            {
                for(int c=0; c<d.GetLength(1); c++)
                {
                    if (c == (d.GetLength(1) - 1))
                    {
                        d[l, c] = (d[l, 0] + d[l, 1]) / 2;
                    }
                    else
                    {
                        d[l,c] = n.Next(100);
                    }
                    
                }
            }
        }
    }
}