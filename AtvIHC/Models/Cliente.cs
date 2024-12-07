using System.ComponentModel.DataAnnotations;

public class Cliente
{
    public int Id { get; set; } // Código
    [Required, StringLength(100)]
    public string NomeCompleto { get; set; }

    [DataType(DataType.Date)]
    public DateTime DataNascimento { get; set; }

    [StringLength(20)]
    public string RG { get; set; }

    [Required, StringLength(11, MinimumLength = 11)]
    public string CPF { get; set; }

    // Endereço completo
    [Required]
    public string Logradouro { get; set; }
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public string Complemento { get; set; }
    [Required]
    public string UF { get; set; }
    [Required, StringLength(8, MinimumLength = 8)]
    public string CEP { get; set; }

    [Required]
    public string EstadoCivil { get; set; } // Casado, Solteiro, Divorciado, Viúvo

    [StringLength(100)]
    public string NomePai { get; set; }

    [StringLength(100)]
    public string NomeMae { get; set; }
}
