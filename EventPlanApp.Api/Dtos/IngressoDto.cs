namespace EventPlanApp.Api.Dtos
{
    public class IngressoDto
    {
        public string NomeEvento { get; set; }
        public decimal Valor { get; set; }
        public bool VIP { get; set; }
        public string QRCode { get; set; }
    }
}
