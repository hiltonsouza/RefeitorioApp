public class EntradaRefeitorio
{
    public int Id { get; set; } // Identificador único da entrada no refeitório
    public int PessoaId { get; set; } // Chave estrangeira para a entidade Pessoa
    public Pessoa Pessoa { get; set; } // Pessoa que fez a entrada
    public DateTime? EntradaDataHora { get; set; } // hora que a pessoa entrou no refeitório
    public string TipoRefeicao { get; set; } // "Almoço", "Jantar", "Café"
}