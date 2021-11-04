using PlateGenerator_Service.Builder;

namespace PlateGenerator_Service.Director
{
    public class PlateDirector
    {
        private readonly IPlateBuilder _plateBuilder;

        public PlateDirector(IPlateBuilder plateBuilder)
        {
            _plateBuilder = plateBuilder;
        }

        public void BuildPlate(int charCount, int numberCount)
        {
            _plateBuilder
                .BuildPlateChar(charCount)
                .BuildPlateNumber(numberCount);
        }
    }
}
