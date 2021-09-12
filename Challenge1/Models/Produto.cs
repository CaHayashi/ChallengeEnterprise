using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge1.Models
{
    public class Produto
    {

        private int Id { get; set;}
        private string Nome { get; set; }
        private string Peso { get; set; }
        private int Quantidade { get; set; }
        private DateTime DataValidade { get; set; }
        private DateTime DataCompra { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Nome: {Nome}, Peso: {Peso}, Quantidade: {Quantidade}, Data de Validade: {DataValidade}, Data da Compra: {DataCompra}";
        }

        public Produto (int id, string nome, string peso, int quantidade, DateTime dataValidade, DateTime dataCompra)
        {
            Id = id;
            Nome = nome;
            Peso = peso;
            Quantidade = quantidade;
            DataValidade = dataValidade;
            DataCompra = dataCompra;
        }
    }
}
