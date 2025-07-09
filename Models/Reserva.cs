namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            
           // Implementado
            if (Suite.Capacidade >= hospedes.Count())
            {
                Hospedes = hospedes;
            }
            else
            {
                // Implementado

                throw new ArgumentException("O número de hospedes passou da capacidade permitida");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
           // Implementado

            int quantidade = Hospedes.Count();
            return quantidade;
        }

        public decimal CalcularValorDiaria()
        {
            // Implementado

            decimal valor = DiasReservados * Suite.ValorDiaria;
            
            // Implementado
            if (DiasReservados >= 10)
            {
                decimal desconto = (DiasReservados * Suite.ValorDiaria) * 0.10M;
                valor = DiasReservados * Suite.ValorDiaria - desconto;
            }

            return valor;
        }
    }
}