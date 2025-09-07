namespace MyEcommerce.Domain.Models
{
    public class RetornoValidacao
    {
        public bool status { get; set; } = true;
        public string status_mensagem { get; set; } = string.Empty;
        public List<ErrosValidacao> erros { get; set; } = new List<ErrosValidacao>();
    }

    public class ErrosValidacao
    {
        public string campo { get; set; } = string.Empty;
        public string mensagem { get; set; } = string.Empty;    
    }
}
