namespace LHPet.Models
{

  public class Cliente
  {

    public int Id {get;set;}
    public string? Nome {get; set;}
    public string? Email {get; set;}
    public string? Cpf {get; set;} 
    public string? Paciente {get; set;}

    public Cliente(int id ,String nome, String email, String cpf, String paciente)
    {
      this.Id = id;
      this.Nome = nome;
      this.Email = email;
      this.Cpf = cpf;
      this.Paciente = paciente;
    }


  }

}