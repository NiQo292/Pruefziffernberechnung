namespace Pruefziffern
{
    public class EANAlgorithm
    {
        public int calculateControlNumber(List<int> inputNumbers)
        {
            int controlNumber = 0;
            int subtotal = 0;

            for (int i = 0; i < inputNumbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    subtotal += inputNumbers[i] * 1;
                }
                else
                {
                    subtotal += inputNumbers[i] * 3;
                }
            }

            int modulo = subtotal % 10;

            if (modulo != 0)
            {
                controlNumber = 10 - modulo;
            }

            return controlNumber;
        }
    }
}
