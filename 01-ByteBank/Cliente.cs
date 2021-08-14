
namespace _01_ByteBank
{
    public class Cliente
    {

        private string _cpf;
        public string Nome { get; set; }

        public string Cpf {
            get {
                return _cpf;
            }
            
            set
            {
                //escrevo lógica de validação de cpf
                _cpf = value;
            }

         }

        public string Profissao { get; set; }

       
        public Endereco endereco = new Endereco();


    }
}
