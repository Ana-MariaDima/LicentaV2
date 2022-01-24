using Licenta.Models.DTOs;
using Licenta.Repositories.CategoriiIngredienteRepository;
using Licenta.Repositories.CategoriiReteteRepository;
using Licenta.Repositories.DatabaseRepository;
using Licenta.Repositories.UnitatiRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// in servicii facem operatiile pe care ni le cere clientul, i.e. facem si modificari, nu doar accesari ca in repository

namespace Licenta.Services
{
    public interface IDemoService
    {
        public IIngredienteRepository GetIngredienteRepository();
        public ICategoriiIngredienteRepository GetCategoriiIngredienteRepository();

        public ICategoriiReteteRepository GetCategoriiReteteRepository();
        public IUnitatiRepository GetUnitatiRepository();
        IngredienteDTO GetDataMappedByNume(string nume_ingredient);
    }
}
