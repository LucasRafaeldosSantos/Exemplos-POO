using System;
using ExemploPOO.Models;
using ExemploPOO.Interfaces;
using ExemploPOO.Helper;
using System.IO;
using System.Collections.Generic;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "D:\\Trabalhando com Arquivos";
            var caminhoPathCombine = Path.Combine(caminho, "Pasta Teste 1");
            var caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");
            var caminhoArquivoTeste = Path.Combine(caminho, "arquivo-teste.txt");
            var caminhoArquivoTesteCopia = Path.Combine(caminho, "arquivo-teste-backup.txt");
            var novoCaminhoArquivo = Path.Combine(caminho, "Pasta Teste 2", "arquivo-teste-stream.txt");
            
            var listaString = new List<string> {"Linha 1", "Linha 2", "Linha 3"};
            var listaStringContinuacao = new List<string> {"Linha 4", "Linha 5", "Linha 6"};

            FileHelper helper = new FileHelper();
            //helper.ListarDiretorios(caminho);
            //helper.ListarArquivosDiretorios(caminho);
            //helper.CriarDiretorio(caminhoPathCombine);
            //helper.ApagarDiretorio(caminhoPathCombine, true);
            //helper.CriarArquivoTexto(caminhoArquivo, "Olá! Teste de escrita de arquivo");
            //helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
            //helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao);
            //helper.LerArquivoStream(caminhoArquivo);
            //helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo, false);
            //helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);
            helper.DeletarArquivo(caminhoArquivoTesteCopia);
        }
    }
}


//    ICalculadora calc = new Calculadora();
//    System.Console.WriteLine(calc.Somar(10, 20));
//    System.Console.WriteLine(calc.Subtrair(10, 20));
//    System.Console.WriteLine(calc.Multiplicar(10, 20));
//    System.Console.WriteLine(calc.Dividir(10, 20));




// Computador comp = new Computador();
// System.Console.WriteLine(comp.ToString());



// Corrente c = new Corrente();
// c.Creditar(100);

// c.ExibirSaldo();
    
//Calculadora calc = new Calculadora();
// System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(10, 10));
// System.Console.WriteLine("Resultado da segunda soma: " + calc.Somar(10, 10, 10));
 
// Aluno p1 = new Aluno();
// p1.Nome = "Lucas";
// p1.Idade = 23;
// p1.Documento = "15.856.321-5";
 // p1.Nota = 10;
 // p1.Apresentar();

// Professor p2 = new Professor();
// p2.Nome = "Carlos";
// p2.Idade = 20;
// p2.Documento = "979.280.857-5";
// p2.Salario = 3000;
// p2.Apresentar();  






// //Valores válidos
// Retangulo r = new Retangulo();
// r.DefinirMedidas(30, 30);

// System.Console.WriteLine($"Área: : {r.ObterArea()}");

// //Valores inválidos
// Retangulo r2 = new Retangulo();
// r2.DefinirMedidas(0, 0);

// System.Console.WriteLine($"Área: : {r2.ObterArea()}");



// Pessoa p1 = new Pessoa();
// p1.Nome = "Bob";
// p1.Idade = 20;
// p1.Apresentar();