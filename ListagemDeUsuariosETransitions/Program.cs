using ProjectBank.Transação;
using ProjectBank.Usuario;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System;
using Microsoft.VisualBasic;
using System.Diagnostics;


public class Listagem
{
    public static void Main(string[] args)
    {
        var listagemDeUsuarios = new List<Usuario>()
 {
                new  Usuario { Id  = 1 , Nome  = " Brayan " , Cpf  =  123456789 , idade  =  27 },
                new  Usuario { Id  = 2 , Nome = " Larissa " , Cpf =  789456123 , idade =  32 },
                new  Usuario { Id =  3 , Nome = " Joao " , Cpf =  456123786 , idade  =  33 },
                new  Usuario { Id = 4 ,  Nome = " Luiza " , Cpf =  963258741 , idade  =  30 }
 };
        var listagemDeTransação = new List<Transação>()
 {
                new  Transação { Id = 2 , Valor = 5000 , Tipo = " TED " , Data = 14/11/2022 , Devedor = " Lariisa " , Credor = " Brayan " } ,
                new  Transação { Id = 1 , Valor = 100 , Tipo = " DOC " , Data = 14/11/2022 , Devedor = " Brayan " , Credor = " João " } ,
                new  Transação { Id = 3 , Valor = 1500 , Tipo = " TED " , Data = 15/11/2022 , Devedor = " Joao " , Credor = " Luiza " } ,

 };

        // CRIAR CONSULTA LINQ

        var resultado = from Id in listagemDeTransação select Id;

        // Executar uma Consulta.  

        foreach (var result in resultado)
        {
            Console.WriteLine($" {result.Id}| {result.Valor} | {result.Devedor} | {result.Credor} ");
        }
    }

}