using CongesSociaux_Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CongesSociaux_Application.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<BanqueMaladie> BanqueMaladies { get; set; }
        DbSet<Conge> Conges { get; set; }
        DbSet<Departement> Departements { get; set; }
        DbSet<Enseignant> Enseignants { get; set; }
        DbSet<Periode> Periodes { get; set; }
        DbSet<Soutien> Soutiens { get; set; }
        DbSet<TypeConge> TypeConges { get; set; }
    }
}
