using PlateGenerator_Service.AbstractFactory.AbstractProduct;
using PlateGenerator_Service.Builder;
using PlateGenerator_Service.Director;

namespace PlateGenerator_Service.AbstractFactory
{
    public class HungarianPlateFactory : PlateFactory
    {
        private readonly PlateDirector _plateDirector;
        private readonly PlateBuilder _plateBuilder;
        public HungarianPlateFactory(PlateDirector plateDirector, PlateBuilder plateBuilder)
        {
            _plateDirector = plateDirector;
            _plateBuilder = plateBuilder;
        }

        public override AbstractNewPlate CreateNewPlate()
        {
            return new NewPlate(_plateDirector, _plateBuilder);
        }

        public override AbstractOldPlate CreateOldPlate()
        {
            return new OldPlate(_plateDirector, _plateBuilder);
        }
    }
}
