namespace Pruefziffern
{
    public class DriverIDAlgorithm : IAlgorithm
    {
        public int calculateControlNumber(List<int> inputNumbers)
        {
            int controlNumber = 0;
            int subtotal = 0;
            int multiplier = 9;
            for (int i = 0; i < inputNumbers.Count; i++){
                subtotal += inputNumbers[i] * multiplier;
                multiplier -= 1;
            }
            controlNumber = subtotal % 11;
            return controlNumber;
        }
    }
}