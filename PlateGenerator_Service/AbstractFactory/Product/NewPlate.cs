using PlateGenerator_Model;
using PlateGenerator_Service.AbstractFactory.AbstractProduct;
using PlateGenerator_Service.Builder;
using PlateGenerator_Service.Director;

namespace PlateGenerator_Service.AbstractFactory
{
    public class NewPlate : AbstractNewPlate
    {
        private readonly PlateDirector _plateDirector;
        private readonly PlateBuilder _plateBuilder;

        public NewPlate(PlateDirector plateDirector, PlateBuilder plateBuilder)
        {
            _plateDirector = plateDirector;
            _plateBuilder = plateBuilder;
        }

        public override Plate GetNewPlate()
        {
            _plateDirector.BuildPlate(4, 3);

            return _plateBuilder.GetPlate();
        }
    }
}
