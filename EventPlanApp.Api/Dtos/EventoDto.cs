namespace EventPlanApp.Api.Dtos
{
    public class EventoDto
    {
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string HorarioInicio { get; set; }
        public string HorarioFim { get; set; }
        public int LotacaoMaxima { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
        public string Tipo { get; set; }
        public string Genero { get; set; }
    }
}
