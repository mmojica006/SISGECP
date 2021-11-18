using System;
using System.Collections.Generic;
using Domain.Entities.Models;

namespace Services.Interfaces
{
    public interface ICargoService
    {
        IEnumerable<Cargo> GetAllCargos();
        Cargo GetCargo(int id);
        void InsertCargo(Cargo model);
        void UpdateCargo(Cargo model);
        void DeleteCargo(int id);

    }
}
