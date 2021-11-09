using PlateGenerator_Model;
using PlateGenerator_Service.AbstractFactory.AbstractProduct;
using PlateGenerator_Service.Builder;
using PlateGenerator_Service.Director;

namespace PlateGenerator_Service.AbstractFactory
{
    public class OldPlate : AbstractOldPlate
    {
        private readonly PlateDirector _plateDirector;
        private readonly PlateBuilder _plateBuilder;

        public OldPlate(PlateDirector plateDirector, PlateBuilder plateBuilder)
        {
            _plateDirector = plateDirector;
            _plateBuilder = plateBuilder;
        }
        public override Plate GetOldPlate()
        {
            _plateDirector.BuildPlate(3, 3);

            return _plateBuilder.GetPlate();
        }
    }
}
