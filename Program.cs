namespace edu.Pr.Ejercicio2._1212
{
    internal class Program
    {
        static void Main(string[] args)
        {



            char[] caracter = new char[5];

            caracter[0] = 'a';
            caracter[1] = 'e';
            caracter[2] = 'i';
            caracter[3] = 'o';
            caracter[4] = 'u';


            char[]caracter2 = new char[5];
            
            caracter2[0] = 'a';
            caracter2[1] = 'e';
            caracter2[2] = 'i';
            caracter2[3] = 'h';
            caracter2[4] = 'u';

            int i;
            for ( i = 0; i < 1 ; i++)
            {
               
               for(int j =0; j < caracter.Length; j++)
                {
                    if (caracter[j] != caracter2[j])
                    {
                        Console.WriteLine(i + j);
                    }
                }
            }













        }  
    }
}