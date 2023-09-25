namespace portal_roadtrip.Domain.Entities;

public class Usuario
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Rg { get; set; }
    public string OrgaoEmissor { get; set; }
    public string DataNascimento { get; set; }
    public string DataCadastro { get; set; }
    public string Celular { get; set; }
}