public class Pessoa
{
    public int Id { get; set; } // Identificador �nico da pessoa
    public string Nome { get; set; } // Nome completo da pessoa
    public string CPF { get; set; } // CPF �nico para identifica��o da pessoa
    public string CodigoBarras { get; set; } // C�digo de barras �nico para identifica��o da pessoa
    public required string TipoPessoa { get; set; } // "Funcion�rio", "Visitante"
    public List<EntradaRefeitorio> Entradas { get; set; } // Lista de entradas no refeit�rio associadas a esta pessoa
}