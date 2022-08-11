using System;
using System.Reflection.Emit;
using System.Reflection;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class ProdutoClass
    {
        public ProdutoClass(int id = 0, string name = "", double price = 0)
        {
            Id = id;
            Name = name;
            Price = price;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; }
    }
    struct ProdutoStruct
    {
        public ProdutoStruct(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}