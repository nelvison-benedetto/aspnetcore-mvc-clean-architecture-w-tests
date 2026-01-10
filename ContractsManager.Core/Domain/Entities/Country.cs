using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ContractsManager.Core.Domain.Entities;

public class Country
{
    [Key]  //primary key della tab, da specificare per convenzione SEMPRE (anche se ef cmnq lo puo capire ...Id/id/ID )
    public Guid CountryID { get; set; }

    public string? CountryName { get; set; }

    //foreign keys

    //navigation properties
    public virtual ICollection<Person>? Persons { get; set; }  //icollection better than e.g.list xk è uninterfaccia, questa è best practice EF

    //methods
}