public class EntradaRefeitorio
{
    public int Id { get; set; } // Identificador �nico da entrada no refeit�rio
    public int PessoaId { get; set; } // Chave estrangeira para a entidade Pessoa
    public Pessoa Pessoa { get; set; } // Pessoa que fez a entrada
    public DateTime? EntradaDataHora { get; set; } // hora que a pessoa entrou no refeit�rio
    public string TipoRefeicao { get; set; } // "Almo�o", "Jantar", "Caf�"
}