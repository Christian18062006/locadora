namespace locadora.Modelos
{
    internal class Veiculos
    {
        public string Marca { get; }
        public int Ano { get; }
        public string Modelo { get; }
        public double ValorLocacao { get; }
        public bool TransmicaoAutomatica { get; }
        public bool Eletrico { get; }
        public string Placa { get; }
        public bool DisponivelLocacao { get; set; }
        public string Status { get; private set; }

        public Veiculos(string marca, string modelo, int ano, double valorLocacao, bool transmicaoAutomatica, bool eletrico, string placa, bool disponivelLocacao)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            ValorLocacao = valorLocacao;
            TransmicaoAutomatica = transmicaoAutomatica;
            Eletrico = eletrico;
            Placa = placa;
            DisponivelLocacao = disponivelLocacao;
            Status = disponivelLocacao ? "disponível" : "alugado";
        }

        public void AtualizarStatus(bool disponivel)
        {
            DisponivelLocacao = disponivel;
            Status = disponivel ? "disponível" : "alugado";
        }

        public virtual string ExibirDetalhes()
        {
            if (TransmicaoAutomatica == false && Eletrico == false && Status == "disponível")
            {
                return $"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}, Valor para locação: {ValorLocacao}. O veículo não é automático, nem elétrico. O veículo está: {Status}";
            }
            else if (TransmicaoAutomatica == true && Eletrico == true && Status == "disponível")
            {
                return $"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}, Valor para locação: {ValorLocacao}. O veículo é automático e elétrico. O veículo está: {Status}";
            }
            else if (TransmicaoAutomatica == true && Eletrico == false && Status == "disponível")
            {
                return $"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}, Valor para locação: {ValorLocacao}. O veículo é automático, mas não é elétrico. O veículo está: {Status}";
            }
            else if (TransmicaoAutomatica == false && Eletrico == true && Status == "disponível")
            {
                return $"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}, Valor para locação: {ValorLocacao}. O veículo é elétrico, mas não é automático. O veículo está: {Status}";
            }
            else if (TransmicaoAutomatica == true && Eletrico == true && Status == "alugado")
            {
                return $"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}, Valor para locação: {ValorLocacao}. O veículo é automático e elétrico. O veículo está: {Status}";
            }
            else if (TransmicaoAutomatica == true && Eletrico == false && Status == "alugado")
            {
                return $"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}, Valor para locação: {ValorLocacao}. O veículo é automático, mas não é elétrico. O veículo está: {Status}";
            }
            else if (TransmicaoAutomatica == false && Eletrico == true && Status == "alugado")
            {
                return $"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}, Valor para locação: {ValorLocacao}. O veículo é elétrico, mas não é automático. O veículo está: {Status}";
            }
            else if (TransmicaoAutomatica == false && Eletrico == false && Status == "alugado")
            {
                return $"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}, Valor para locação: {ValorLocacao}. O veículo não é automático, nem elétrico. O veículo está: {Status}";
            }
            else
            {
                return $"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}, Valor para locação: {ValorLocacao}. O veículo tem características mistas. Verifique as informações! Status: {Status}";
            }
        }
    }
}
