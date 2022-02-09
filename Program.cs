using System;

namespace Encontro_Remoto
{

    class Program
    {

        static void Main(string[] args)
        {


            Endereco end = new Endereco();

            end.logradouro = "Rua Dr Manoel Nogueira";
            end.numero = 100;
            end.complemento = "Próximo a Acdemia Movimento";
            end.enderecoComercial = false;

            PessoaFisica Pf = new PessoaFisica();

            Pf.nome = "Décio Santiago dos Santos";
            Pf.cpf = 80170734538;
            Pf.dataDeNascimento = new DateTime(1982, 05, 24);
            Pf.endereco = end;


            PessoaJuridica Pj = new PessoaJuridica();

            Pj.cnpj = 21345762000102;
            Pj.endereco = end;
            Pj.razaoSocial = "DECIO S SANTOS ME";


            PessoaFisica NovaPf = new PessoaFisica();
            NovaPf.ValidarDataNascimento(NovaPf.dataDeNascimento);



            Console.WriteLine("Rua: " + Pf.endereco.logradouro + ", " + Pf.endereco.numero);
            Console.WriteLine("Pessoa Juridica: " + "Cnpj: " + Pj.cnpj + ", " + "Razão social: " + Pj.razaoSocial);
            Console.WriteLine("Pessoa Fisica: " + "Nome: " + Pf.nome + ", " + "Cpf: " + Pf.cpf + ", " + "Data de Nasc: " + Pf.dataDeNascimento);
            Console.WriteLine("Maior de 18 anos? " + NovaPf.ValidarDataNascimento(Pf.dataDeNascimento) );





        }
    }

}
