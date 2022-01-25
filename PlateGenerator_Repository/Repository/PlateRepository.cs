using PlateGenerator_Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PlateGenerator_Repository.Repository
{
    public class PlateRepository : IPlateRepository
    {
        private readonly PlateContext _plate;
        public PlateRepository() => _plate = new PlateContext();

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Plate> GetAll()
        {
            return _plate.Plates.ToList();
        }

        public Plate GetById(int id)
        {
            return _plate.Plates.Find(id);
        }

        public void Insert(Plate plateToInsert)
        {
            _plate.Plates.Add(plateToInsert);
        }

        public void Save()
        {
            _plate.SaveChanges();
        }

        public void Update(Plate plateToUpdate)
        {
            _plate.Plates.Update(plateToUpdate);
        }
    }
}
