using System;
using System.Collections.Generic;
using Domain.Entities.Models;
using Infraestructure.RepositoryPattern.Interface;
using Services.Interfaces;

namespace Services
{
    public class CargoService : ICargoService
    {
        #region Property
        private IRepository<Cargo> _repository;
        #endregion

        #region Constructor
        public CargoService(IRepository<Cargo> repository)
        {
            _repository = repository;
        }
        #endregion
        public void DeleteCargo(int id)
        {
            Cargo customer = GetCargo(id);
            _repository.Remove(customer);
            _repository.SaveChanges();
        }

        public IEnumerable<Cargo> GetAllCargos()
        {
            return _repository.GetAll();
        }

        public Cargo GetCargo(int id)
        {
            return _repository.Get(id);
        }

        public void InsertCargo(Cargo model)
        {
            _repository.Insert(model);
        }

        public void UpdateCargo(Cargo model)
        {
            _repository.Update(model);
        }
    }
}
