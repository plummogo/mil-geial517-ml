using PlateGenerator_Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlateGenerator_Repository.Repository
{
    internal interface IPlateRepository
    {
        IEnumerable<Plate> GetAll();
        Plate GetById(int id);
        void Insert(Plate plateToInsert);
        void Update(Plate plateToUpdate);
        void Delete(int id);
        void Save();
    }
}
