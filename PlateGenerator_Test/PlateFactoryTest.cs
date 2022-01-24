using NUnit.Framework;
using PlateGenerator_Model;
using PlateGenerator_Service.AbstractFactory;
using PlateGenerator_Service.Builder;
using PlateGenerator_Service.Director;

namespace PlateGenerator_Test
{
    public class PlateFactoryTest
    {
        private PlateFactory _plateFactory;
        private PlateClient _plateClient;
        private PlateBuilder _plateBuilder;
        private PlateDirector _plateDirector;

        [SetUp]
        public void Setup()
        {
            _plateBuilder = new PlateBuilder();
            _plateDirector = new PlateDirector(_plateBuilder);
            _plateFactory = new HungarianPlateFactory(_plateDirector, _plateBuilder);
            _plateClient = new PlateClient(_plateFactory);
        }

        [Test]
        public void IsHungarianOldPlateValid()
        {            
            var oldPlate = _plateClient.GetHungarianOldPlate();

            Assert.IsNotNull(oldPlate);
            Assert.IsInstanceOf(typeof(Plate), oldPlate);
            Assert.AreEqual(oldPlate.Chars.Length, 3);
            Assert.AreEqual(oldPlate.Number.Length, 3);
            Assert.IsNotNull(oldPlate.Id);
        }

        [Test]
        public void IsHungarianNewPlateValid()
        {
            var newPlate = _plateClient.GetHungarianNewPlate();

            Assert.IsNotNull(newPlate);
            Assert.IsInstanceOf(typeof(Plate), newPlate);
            Assert.AreEqual(newPlate.Chars.Length, 4);
            Assert.AreEqual(newPlate.Number.Length, 3);
            Assert.IsNotNull(newPlate.Id);
        }

        [Test]
        public void IsHungarianOldPlateInvalid()
        {
            var oldPlate = _plateClient.GetHungarianOldPlate();

            Assert.IsInstanceOf(typeof(Plate), oldPlate);
            Assert.IsNotNull(oldPlate);
            Assert.AreNotEqual(oldPlate.Chars.Length, 4);
            Assert.AreNotEqual(oldPlate.Number.Length, 4);
            Assert.IsNotNull(oldPlate.Id);
        }

        [Test]
        public void IsHungarianNewPlateInvalid()
        {
            var newPlate = _plateClient.GetHungarianNewPlate();

            Assert.IsInstanceOf(typeof(Plate), newPlate);
            Assert.IsNotNull(newPlate);
            Assert.AreNotEqual(newPlate.Chars.Length, 3);
            Assert.AreNotEqual(newPlate.Number.Length, 4);
            Assert.IsNotNull(newPlate.Id);
        }
    }
}
