using PlateGenerator_Model;
using PlateGenerator_Service.Helper;
using System;

namespace PlateGenerator_Service.Builder
{
    public class PlateBuilder : IPlateBuilder
    {
        private readonly Random _rnd;
        private Plate _plate;

        public PlateBuilder()
        {
            _plate = new Plate();
            _rnd = new Random();
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

            Clear();

            return plate;
        }

        private void Clear() => _plate = new Plate();
    }
}
