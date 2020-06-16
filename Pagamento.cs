namespace Encapsulamento_07
{
    public class Pagamento
    {
        public string Cartao = "sim";
        public string escolha = "sim";
        public bool Token;
        public string NomeDoTitular = "Gabriel Carvalho";
        public string NumeroDoCartao = "550986789786";
        public string DatadeVencimento = "07/27";
        protected string CodigoDeSeguranca = "897";


        public string rscolha(string Cartao, string escolha){
            if(escolha == Cartao){
                Token = true;
                return "ok";
            }else{
                Token = false;
                return "not ok";
            }
        }

        public bool Validar(string NomeDoTitular, string NumeroDoCartao, string DatadeVencimento, string CodigoDeSeguranca){
            if(this.NomeDoTitular == NomeDoTitular && this.NumeroDoCartao == NumeroDoCartao && this.DatadeVencimento == DatadeVencimento && this.CodigoDeSeguranca == CodigoDeSeguranca){
                return true;
                
            }else{
                return false;
            }
        }




        


            }
        }
       