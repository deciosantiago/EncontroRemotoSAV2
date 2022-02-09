namespace Encontro_Remoto
{
    public class PessoaFisica : Pessoa
    {
        public Int64? cpf { get; set; }

        public DateTime dataDeNascimento { get; set; }

        public override void PagarImposto(float salario)
        {
        }

        public bool ValidarDataNascimento(DateTime dataNasc)
        {
            DateTime dataAtual = DateTime.Today;

            double anos = (dataAtual - dataNasc).TotalDays / 365;

            if (anos >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
