namespace ApiServico
{
    public class Chamado
    {
        public int Id { get; set; }

        public required string titulo { get; set; }

        public required string Descricao { get; set; }

        public string Status { get; set; } = "Aberto";


    }
}
