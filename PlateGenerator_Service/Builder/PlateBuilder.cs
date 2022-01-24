using PlateGenerator_Model;
using PlateGenerator_Repository.Repository;
using PlateGenerator_Service.Helper;
using System;

namespace PlateGenerator_Service.Builder
{
    public class PlateBuilder : IPlateBuilder
    {
        private readonly Random _rnd;
        private Plate _plate;
        private PlateRepository _plateRepository;

        public PlateBuilder()
        {
            _plate = new Plate();
            _rnd = new Random();
            _plateRepository = new PlateRepository();
        }

        public IPlateBuilder BuildPlateChar(int count)
        {
            _rnd.NextInit();
            _plate.Chars = _rnd.NextChar(count);

            return this;
        }

        public IPlateBuilder BuildPlateNumber(int count)
        {
            _rnd.NextInit();
            _plate.Number = _rnd.NextNumber(count);

            return this;
        }

        public Plate GetPlate()
        {
            var plate = _plate;

            _plateRepository.Insert(plate);
            _plateRepository.Save();

            Clear();

            return plate;
        }

        private void Clear() => _plate = new Plate();
    }
}
