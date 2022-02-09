namespace Encontro_Remoto
{
    public class PessoaJuridica : Pessoa
    {

        public double? cnpj { get; set; }

        public string? razaoSocial { get; set; }

        public override void PagarImposto(float salario)
        {

        }

    }
}




