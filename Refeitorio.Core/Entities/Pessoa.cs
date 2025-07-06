public class Pessoa
{
    public int Id { get; set; } // Identificador único da pessoa
    public string Nome { get; set; } // Nome completo da pessoa
    public string CPF { get; set; } // CPF único para identificação da pessoa
    public string CodigoBarras { get; set; } // Código de barras único para identificação da pessoa
    public required string TipoPessoa { get; set; } // "Funcionário", "Visitante"
    public List<EntradaRefeitorio> Entradas { get; set; } // Lista de entradas no refeitório associadas a esta pessoa
}