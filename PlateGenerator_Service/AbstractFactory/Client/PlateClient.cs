using PlateGenerator_Model;
using PlateGenerator_Service.AbstractFactory.AbstractProduct;

namespace PlateGenerator_Service.AbstractFactory
{
    public class PlateClient
    {
        private readonly AbstractOldPlate _oldPlate;
        private readonly AbstractNewPlate _newPlate;

        public PlateClient(PlateFactory plateFactory)
        {
            _oldPlate = plateFactory.CreateOldPlate();
            _newPlate = plateFactory.CreateNewPlate();
        }

        public Plate GetHungarianOldPlate()
        {
            return _oldPlate.GetOldPlate();
        }

        public Plate GetHungarianNewPlate()
        {
            return _newPlate.GetNewPlate();
        }
    }
}
