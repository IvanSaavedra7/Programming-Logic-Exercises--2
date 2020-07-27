using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace App5._7
{
    class Seletor
    {

        private Boolean Condicao = true;
        private bool PrimeiraRepeticao;
        private bool SegundaRepeticao=false;
        private String Letra;

        public void vitrine()
        {
            Clear();
            ForegroundColor = ConsoleColor.Red;
            Write(" \n\t  EXERCICIO COM CLASSES AUXILIARES CAP 5  ");
            ForegroundColor = ConsoleColor.White;
            Write(" \n\t  ====================================== \n\n ");
            ForegroundColor = ConsoleColor.Blue;
            WriteLine(" [A] EXERCICO - 5.7  ");
            WriteLine(" [B] EXERCICO - 5.23 ");
            WriteLine(" [C] EXERCICO - 5.24 ");
            WriteLine(" [D] EXERCICO - 5.25 ");
            WriteLine(" [E] EXERCICO - 5.30 ");
            WriteLine(" [F] EXERCICO - 5.31 ");
            WriteLine(" [G] EXERCICO - 5.32 ");
            WriteLine(" [h] EXERCICO - 5.35 ");
            WriteLine(" [i] EXERCICO - 5.20 ");
            WriteLine();
            WriteLine();
            WriteLine();
            ForegroundColor = ConsoleColor.Cyan;
            Write(" DIGITE [OK] PRA FINALIZAR O PROGRAMA");
            ForegroundColor = ConsoleColor.Blue;
            WriteLine();
            WriteLine();
            WriteLine();
            Write(" Digite a letra do exercicio que deseja realizar: ");

            this.PrimeiraRepeticao = true;

        }


        public Boolean GetCondicao()
        {

            if (this.PrimeiraRepeticao == true && this.Condicao == false && this.SegundaRepeticao != true)
            {
                this.PrimeiraRepeticao = false;
                this.Condicao = false;
                this.SegundaRepeticao = true;
            }
            else
            {
                this.Condicao = true;
                this.PrimeiraRepeticao = true;
                this.SegundaRepeticao = false;
            }
            return this.Condicao;
        }

        

        public String GetLetra()
        {
            return this.Letra;
        }


        public void tratador()
        {

            for (; ; )
            {

                this.Letra = (ReadLine());

                if (this.Letra != "a" && this.Letra != "b" && this.Letra != "c" && this.Letra != "d" &&
                    this.Letra != "e" && this.Letra != "f" && this.Letra != "g" && this.Letra != "h"&&
                    this.Letra != "i"  && this.Letra != "ok")
                {

                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("\nOPCÃO INVALIDA!");
                    ForegroundColor = ConsoleColor.Blue;
                    Write("\nTente novamente: ");

                }
                else
                {
                    this.Condicao = false;
                    break;
                }
            }

        }
    }
}
