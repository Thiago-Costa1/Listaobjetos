using System;
using System.Collections.Generic;
using Nova_pasta.classes;

namespace Nova_pasta
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();

            // Array
                Produto[] arrayProdutos = {};

                produtos.Add(new Produto(5, "Apple Watch", 3522.56f));
                produtos.Add(new Produto(7, "Xiaomi Watch", 1522.56f));
                produtos.Add(new Produto(78, "Zenfone ASUS", 4522.56f));
                produtos.Add(new Produto(2, "Samsung", 4522.56f));
                produtos.Add(new Produto(3, "Motorola G8", 6522.56f));
                
                Produto p1 = new Produto();
                p1.Codigo = 67;
                p1.Nome = "Iphone XII ";
                p1.Preco = 8952.56f;

                produtos.Add(p1);
                
                foreach (Produto item in produtos)
                {
                    Console.WriteLine(item.Codigo);
                    Console.WriteLine(item.Nome);
                    Console.WriteLine(item.Preco);
                }
                
                produtos.RemoveAt(3);

                Console.WriteLine("\n Remoção Feita: \n ");
                foreach (Produto item in produtos)
                {
                    Console.WriteLine(item.Nome);                    
                }       

                produtos.RemoveAll(x => x.Nome == "João");

                Console.WriteLine("\n Remoção do ASUS Feita \n");
                foreach (Produto item in produtos)
                {
                    Console.WriteLine(item.Nome);
                }          
                
                produtos.RemoveAt(2);

                Console.WriteLine("\n Remoção do Samsung Feita \n");
                foreach (Produto item in produtos)
                {
                    Console.WriteLine(item.Nome);
                }

                produtos.RemoveAt(3);

                Console.WriteLine("\n  Remoção do Motorola Feita \n");
                foreach (Produto item in produtos)
                {
                    Console.WriteLine(item.Nome);
                }

        }   
    }
}
