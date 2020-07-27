using System;



class Matematica
{
    int numeroInteiro; // armazenará o valor a ser usado como base nos cálculos

    // construtor da classe Matematica, que recebe como parâmetro o valor que
    // será usado como base nos cálculos e o armazena no atributo numeroInteiro

    public Matematica(int numeroDesejado)
    {
        numeroInteiro = numeroDesejado;
    }

    // Esta função calcula o fatorial do valor armazenado no atributo numeroInteiro
    public int Fatorial()
    {
        var fat = new Produtorio(); // cria na memória um objeto da classe Produtorio

        // abaixo criamos o gerador de inteiros de 1 a numeroInteiro (Contador)
        var parcela = new Contador(1, numeroInteiro, 1);

        while (parcela.Prosseguir()) // gera números e vê se prossegue a contagem
        {
            fat.Multiplicar(parcela.Valor);  // acumula o número gerado (parcela.Valor)
        }
        return (int)fat.Valor;  // (int) ---> Type Cast ou conversão de tipo
    }

    public int FatorialSemObjetos()
    {
        int fat = 1; // valor inicial de qualquer Produtorio
                     // iniciamos com 1 o gerador de inteiros 
        int parcela = 1;
        while (parcela <= numeroInteiro) // vê se prossegue a contagem
        {
            fat = fat * parcela;  // acumula o número gerado (parcela.Valor)
            parcela = parcela + 1;      // gera próximo números inteiro da sequência
        }
        return fat;
    }

    public string ListaDosDivisores()
    {
        string resultado = " 1";
        var possivelDivisor = new Contador(2, numeroInteiro / 2, 1);
        while (possivelDivisor.Prosseguir())
        {
            int resto = numeroInteiro % possivelDivisor.Valor;
            if (resto == 0)
                resultado = resultado + ", " + possivelDivisor.Valor;
        }
        resultado += ", " + numeroInteiro;
        return resultado;
    }

    public int SomaDivisore()
    {
        double resultado;

        var possivelDivisor = new Contador(1, numeroInteiro / 2, 1);

        var Soma = new Somatoria();

        while (possivelDivisor.Prosseguir())
        {
            int resto = numeroInteiro % possivelDivisor.Valor;
            if (resto == 0)
            {

                resultado = possivelDivisor.Valor ;

                Soma.Somar(resultado);
                
            }
                
        }


        resultado = Soma.Valor;

        return (int)resultado;

    }

    public int MDC(int outroValor)
    {
        int dividendo = numeroInteiro;
        int divisor = outroValor;
        int resto = 0;
        do
        {
            resto = dividendo % divisor;
            if (resto != 0)
            {
                dividendo = divisor;
                divisor = resto;
            }
        }
        while (resto != 0);

        return divisor;
    }

    public bool EhPalindromo()
    {
        int aoContrario = 0;
        int numero = numeroInteiro;
        while (numero > 0)
        {
            int quociente = numero / 10;
            int resto = numero - 10 * quociente;  // separo o dígito mais à direita do número
            aoContrario = aoContrario * 10 + resto; // 
            numero = quociente;
        }

        if (aoContrario == numeroInteiro)
            return true;  // é palíndromo
        else
            return false; // não é palíndromo
    }


    public double Elevado(double a)
    {

        int expoente = numeroInteiro;

        double Base = a;

        var Conta = new Contador(1,expoente,1);

        var Produtorio = new Produtorio();

        while(Conta.Prosseguir())
        {

            Produtorio.Multiplicar(Base);


        }

        return Produtorio.Valor;

    }
        


}
        

