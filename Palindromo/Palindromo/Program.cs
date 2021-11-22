namespace projeto_txt
{
    class Program
    {
        static void Main(string[] args)
        {
            var Texto = new StreamReader(@"C:\Users\Giovana Duarte\Videos\Código\Projeto Palindromo\Palindromo\Texto.txt");
            StreamWriter sw = new StreamWriter(@"C:\Users\Giovana Duarte\Videos\Código\Projeto Palindromo\Palindromo\Resultado.txt");
            string Resultado;

            using (Texto)
            {
                while (!Texto.EndOfStream)
                {
                    var LinhaTexto = Texto.ReadLine().ToUpper();
                    var Reverso = InverterPalavra(LinhaTexto).Replace(" ", "");
                    Console.WriteLine(LinhaTexto);


                    if (LinhaTexto.Replace(" ", "").Equals(Reverso))
                    {
                        Resultado = $"A  frase {LinhaTexto} é um palindromo";
                        sw.WriteLine(Resultado);
                    }
                    else
                    {
                        Resultado = $"A  frase {LinhaTexto} não é um palindromo";
                        sw.WriteLine(Resultado);
                    }

                }
                sw.Close();
            }
        }
        public static string InverterPalavra(string LinhaTexto)
        {
            char[] ArrayChar = LinhaTexto.ToCharArray();
            Array.Reverse(ArrayChar);
            return new string(ArrayChar);
        }
    }
}
