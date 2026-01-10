using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ContractsManager.Core.Domain.Entities;

public class Person
{
    [Key]   //da mettere sempre x convenzione
    public Guid PersonID { get; set; }

    [StringLength(40)] //nvarchar(40)  // [StringLength(40)] -> EF crea nvarchar(40) automaticamente. oggi è usato nvarchar
                       //[Required]
    public string? PersonName { get; set; }

    [StringLength(40)] //nvarchar(40)
    public string? Email { get; set; }

    public DateTime? DateOfBirth { get; set; }

    [StringLength(10)]
    public string? Gender { get; set; }

    //uniqueidentifier
    public Guid? CountryID { get; set; }

    [StringLength(200)]
    public string? Address { get; set; }

    public bool ReceiveNewsLetters { get; set; }

    //[Column("TaxIdentificationNumber", TypeName = "varchar(8)")]
    public string? TIN { get; set; }

    //foreign keys 

    [ForeignKey("CountryID")]
    public virtual Country? Country { get; set; }

    //navigation properties

    //methods
    public override string ToString()
    {
        return $"Person ID: {PersonID}, Person Name: {PersonName}, Email: {Email}, Date of Birth: {DateOfBirth?.ToString("MM/dd/yyyy")}, Gender: {Gender}, Country ID: {CountryID}, Country: {Country?.CountryName}, Address: {Address}, Receive News Letters: {ReceiveNewsLetters}";
    }
}