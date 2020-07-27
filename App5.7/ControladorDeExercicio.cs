using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Threading;

namespace App5._7
{
    class ControladorDeExercicio
    {

        private String Letra;
        private String continuar = "";
        private Boolean Condicao = true;

        public ControladorDeExercicio(String letra)
        {

            this.Letra = letra;
            
        }

        

        public void ChamarMetodo()
        {

            switch (this.Letra) { 
                case "a": Exercicio_5_7();
                    break;
                case "b": Exercicio_5_23();
                    break;
                case "c": Exercicio_5_24();
                    break;
                case "d": Exercicio_5_25();
                    break;
                case "e": Exercicio_5_30();
                    break;
                case "f": Exercicio_5_31();
                    break;
                case "g": Exercicio_5_32();
                    break;
                case "h": Exercicio_5_35();
                    break;
                case "i":Exercicio_5_20();
                    break;
               
            }
        }

        private void Tratador()
        {

            ForegroundColor = ConsoleColor.Red;
            Write("\n\n Deseja fazer a operação de novo (S/N)? ");
            
            ForegroundColor = ConsoleColor.Blue;

            for (; ; )
            {
                continuar =(ReadLine());

                if (continuar != "s" && continuar != "n")
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("\nOpcao invalida!");
                    ForegroundColor = ConsoleColor.Blue;
                    Write("\nTente novamente: ");
                }
                else
                if (continuar != "s")
                {
                    this.Condicao = false;
                    break;
                }
                else
                {
                    this.Condicao = true;
                    break;
                }
            }

        }

        public Boolean GetTratador()
        {
            return this.Condicao;
        }


        private void Exercicio_5_7()
        {
                Clear();

                int Limite;

                Write(" Digite ate onde você quer contar : ");

                Limite = int.Parse(ReadLine());

                Contador contador1 = new Contador(1, Limite, 1);
                Somatoria somatoria = new Somatoria();


                while (contador1.Prosseguir())
                {

                    WriteLine();
                    Write(contador1.Valor);
                    somatoria.Somar(contador1.Valor);

               

                }

                WriteLine();

                WriteLine("======================");
                Write(" SOMA =  {0} | MEDIA = {1} ", somatoria.Valor, somatoria.MediaAritmetica());


            Tratador();

        }

        private void Exercicio_5_20()
        {
            Clear();

            DateTime horadehoje;
            horadehoje = DateTime.Now;

            var segundos= new Contador(0, 59, 1);
            var minutos = new Contador(0, 59, 1);
            var horas   = new Contador(0, 23, 1);

            segundos.setvalor(horadehoje.Second);
            minutos.setvalor(horadehoje.Minute);
            horas.setvalor(horadehoje.Hour);

            while(KeyAvailable==false)
            {

                segundos.Contar();

                if(segundos.Valor == 59)
                {
                    segundos.Iniciar();
                    minutos.Contar();

                    if(minutos.Valor == 59)
                    {
                        minutos.Iniciar();
                        horas.Contar();
                    }

                }

                Console.SetCursorPosition(30, 13);
                Write(horas.Valor + ":" + minutos.Valor + ":" + segundos.Valor);

                Thread.Sleep(1000);

            }

            Tratador();

        }

        private void Exercicio_5_23()
        {


            Clear();

            int Limite;

            Write(" Digite ate onde você quer saber a soma dos numeros -> ");

            Limite = int.Parse(ReadLine());

            Contador contador = new Contador(1, Limite, 1);
            Somatoria somatoria = new Somatoria();

            while (contador.Prosseguir())
            {

                WriteLine();

                Write(contador.Valor);

                WriteLine();

                somatoria.Somar(contador.Valor);


            }

            Write("\n\n============================\n\n");

            WriteLine(" SOMA TOTAL = {0} ", somatoria.Valor);

            Tratador();


        }

        private void Exercicio_5_24()
        {


            Clear();

            int Limite;

            Write(" Digite ate onde você quer saber a soma dos numeros -> ");

            Limite = int.Parse(ReadLine());

            Contador contador = new Contador(1, Limite, 1);
            Produtorio produtorio = new Produtorio();

            while (contador.Prosseguir())
            {

                WriteLine();

                Write(contador.Valor);

                WriteLine();

                produtorio.Multiplicar(contador.Valor);

            }

            Write("\n\n============================\n\n");

            WriteLine(" PRODUTO TOTAL = {0} ", produtorio.Valor);

            Tratador();


        }


        /// <summary>
        /// ////////////////////////////////////////////////////////
        /// </summary>
        /// 


        private void Exercicio_5_25()
        {


            Clear();

            int Limite;
            int numeroAtual;


            Write(" Digite quantos numeros você vai escrever -> ");

            Limite = int.Parse(ReadLine());

            Write("\n=============================================\n");


            Contador contador = new Contador(1, Limite, 1);
            Contador Tipo1 = new Contador(0, int.MaxValue, 1);
            Contador Tipo2 = new Contador(0, int.MaxValue, 1);
            Contador Tipo3 = new Contador(0, int.MaxValue, 1);
            Contador Tipo4 = new Contador(0, int.MaxValue, 1);
            Contador Tipo5 = new Contador(0, int.MaxValue, 1);
            Contador Tipo6 = new Contador(0, int.MaxValue, 1);

            Somatoria somatoria1 = new Somatoria();
            Somatoria somatoria2 = new Somatoria();
            Somatoria somatoria3 = new Somatoria();
            Somatoria somatoria4 = new Somatoria();
            Somatoria somatoria5 = new Somatoria();
            Somatoria somatoria6 = new Somatoria();


            while (contador.Prosseguir())
            {

                Write(" Digite o seu {0}° a Comparar -> ", contador.Valor);



                numeroAtual = int.Parse(ReadLine());

                if (numeroAtual <= 0)
                {
                    Tipo1.Contar();
                    somatoria1.Somar(numeroAtual);
                }

                if (numeroAtual >= 0 && numeroAtual <= 25)
                {
                    Tipo2.Contar();
                    somatoria2.Somar(numeroAtual);
                }

                if (numeroAtual >= 26 && numeroAtual <= 50)
                {
                    Tipo3.Contar();
                    somatoria3.Somar(numeroAtual);
                }

                if (numeroAtual >= 51 && numeroAtual <= 75)
                {
                    Tipo4.Contar();
                    somatoria4.Somar(numeroAtual);
                }

                if (numeroAtual >= 76 && numeroAtual <= 100)
                {
                    Tipo5.Contar();
                    somatoria5.Somar(numeroAtual);
                }

                if (numeroAtual >= 100)
                {
                    Tipo6.Contar();
                    somatoria6.Somar(numeroAtual);
                }

            }

            Write(" \n------------------------------------------------------------- \n");
            if (Tipo1.Valor > 0)
            {
                WriteLine(" [ -infinito, 0 ] = {0}     MEDIA = {1} ", Tipo1.Valor, somatoria1.MediaAritmetica());
            }

            if (Tipo2.Valor > 0)
            {
                WriteLine(" [0, 25] = {0}              MEDIA = {1} ", Tipo2.Valor, somatoria2.MediaAritmetica());
            }

            if (Tipo3.Valor > 0)
            {
                WriteLine(" [26,50] = {0}              MEDIA = {1} ", Tipo3.Valor, somatoria3.MediaAritmetica());
            }

            if (Tipo4.Valor > 0)
            {
                WriteLine(" [51,75] = {0}              MEDIA = {1} ", Tipo4.Valor, somatoria4.MediaAritmetica());
            }

            if (Tipo5.Valor > 0)
            {
                WriteLine(" [76,100] = {0}             MEDIA = {1} ", Tipo5.Valor, somatoria5.MediaAritmetica());
            }

            if (Tipo6.Valor > 0)
            {
                WriteLine(" [100,+infinito] = {0}      MEDIA = {1} ", Tipo6.Valor, somatoria6.MediaAritmetica());
            }

            Tratador();



        }

        /// <summary>
        /// //////////////////////////////////////////////////////////////
        /// </summary>
        /// <param name="args"></param>
        /// 


        private void Exercicio_5_30()
        {

            Clear();

            string numero;

            Write("DIGITE O NUMERO ENTRE 999 E 99999, QUE VC DESEJA TRABALHRA:");

            for (; ; )
            {
                numero = ReadLine();
                WriteLine();

                int teste1;

                bool isInteiro = int.TryParse(numero, out teste1);

                if (!isInteiro)
                    Write("não é um numero\nDigite dnv: ");
                else
                {
                    int teste2 = int.Parse(numero);
                    if (teste2 < 999 || teste2 > 99999)
                        Write("seu numero nao esta conforme pedido\nDigite dnv: ");
                    else
                        break;
                }
            }

            for (int i = 0; i < numero.Length; i++)
            {
                int pedaço = int.Parse(numero.Substring(i, 1));


                String fila = "{";

                Contador cont = new Contador(1, pedaço, 1);

                while (cont.Prosseguir())
                {
                    if (cont.Valor != pedaço)
                        fila = fila + cont.Valor + ",";
                    else
                        fila = fila + cont.Valor;
                }

                ForegroundColor = ConsoleColor.Red;
                Write(pedaço + " - ");
                ForegroundColor = ConsoleColor.Blue;
                Write(fila + "}\n\n");

            }

            //Write(pedaço);

            Tratador();


        }


        /// <summary>
        /// ///////////////////
        /// </summary>



        private void Exercicio_5_31()
        {

            Clear();

            int Numero, Resto;

            var somatoria = new Somatoria();

            var conta = new Contador(1, 5, 1);

            Write(" DIGITE UM NUMERO DE 5 DIGITES PARA SOMALOS : ");

            Numero = int.Parse(ReadLine());

            if (Numero < 10000 || Numero > 99999)
            {

                WriteLine("\n SEU NUMERO NÃO TEM 5 DIGITOS !!!");
                Tratador();

            }
            else
            {
                while (conta.Prosseguir())
                {

                    Resto = Numero % 10;

                    Numero = Numero / 10;

                    somatoria.Somar(Resto);

                }


                WriteLine($" \n A SOMA DOS DIGITOS É { somatoria.Valor } ");


                Tratador();



            }

             

        }


        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <param name="args"></param>
        /// 

        private void Exercicio_5_32()
        {

            Clear();

            Write("Digite a base ->");

            double numero1 = double.Parse(ReadLine());

            WriteLine();
            Write("Digite o esxpoente ->");

            int numero2 = int.Parse(ReadLine());

            if (numero2 == 0)
            {

                WriteLine($" \n\n {numero1} ELVADO A {numero2} = {numero1} ");

            }



            if (numero2 > 1)
            {

                var Mat = new Matematica(numero2);

                double resultado = Mat.Elevado(numero1);

                WriteLine($" \n\n {numero1} ELEVADO A {numero2} = {resultado} ");

                Tratador();
            }


        }


        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////
        /// </summary>



        private void Exercicio_5_35()
        {

            Clear();

            Write("DIGITE ATE ONDE VOCÊ QUER VER OS NUMEROS PERFEITOS->");

            int Limite = int.Parse(ReadLine());

            var Contador = new Contador(1, Limite, 1);



            while (Contador.Prosseguir())
            {

                var Mat = new Matematica(Contador.Valor);

                int Soma = Mat.SomaDivisore();

                if (Soma == Contador.Valor)
                {

                    WriteLine("\n\n" + Contador.Valor);

                }


            }


            Tratador();
        }






    }

}
