using NUnit.Framework;
using PlateGenerator_Model;
using PlateGenerator_Service.Builder;
using PlateGenerator_Service.Director;

namespace PlateGenerator_Test
{
    public class PlateBuilderTest
    {
        private PlateBuilder _plateBuilder;
        private PlateDirector _plateDirector;
        private const int _plateNumber = 4, _plateChars = 4;

        [SetUp]
        public void Setup()
        {
            _plateBuilder = new PlateBuilder();
            _plateDirector = new PlateDirector(_plateBuilder);
        }

        [Test]
        public void IsPlateValid()
        {
            _plateDirector.BuildPlate(_plateNumber, _plateChars);

            var plate = _plateBuilder.GetPlate();

            Assert.IsNotNull(plate);
            Assert.AreEqual(plate.Chars.Length, 4);
            Assert.AreEqual(plate.Number.Length, 4);
            Assert.IsNotNull(plate.Id);
        }

        [Test]
        public void IsPlateInvalid()
        {
            var plate = _plateBuilder.GetPlate();

            Assert.IsInstanceOf(typeof(Plate),plate);
            Assert.IsNotNull(plate);
            Assert.IsNull(plate.Chars);
            Assert.IsNull(plate.Number);
        }

        [Test]
        public void IsPlateCharsValidNumberInvalid()
        {
            _plateBuilder.BuildPlateChar(_plateChars);

            var plate = _plateBuilder.GetPlate();

            Assert.IsInstanceOf(typeof(Plate), plate);
            Assert.IsNotNull(plate);
            Assert.AreEqual(plate.Chars.Length, 4);
        }

        [Test]
        public void IsPlateNumbersValidCharsInvalid()
        {
            _plateBuilder.BuildPlateNumber(_plateNumber);

            var plate = _plateBuilder.GetPlate();

            Assert.IsInstanceOf(typeof(Plate), plate);
            Assert.IsNotNull(plate);
            Assert.IsNull(plate.Chars);
        }
    }
}