using System;
using System.Globalization;

namespace ConstruturesAula51
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        //Criando construtores - conceito de sobre carga:

        //Construtor com 3 parametros
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //Construtor com 2 parametros
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;            
        }

        //Construtur padrao sem parametros
        public Produto()
        {

        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }


        // P/ fazer uma sobreposicao, tem q escrever a palavra "override"
        public override string ToString()
        {
            return Nome
                + ", R$ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: R$ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}