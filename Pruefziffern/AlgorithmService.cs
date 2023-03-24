namespace Pruefziffern
{
    public class AlgorithmService
    {
        private InputServivce inputServivce;
        private EANAlgorithm eanAlgorithm;
        private int controlNumber;
        private List<int> inputNumbers;

        public AlgorithmService()
        {
            this.inputServivce = new InputServivce();
            this.eanAlgorithm = new EANAlgorithm();
            this.inputNumbers = new List<int>();
        }

        public void run()
        {
            bool newInput = true;
            calculateNumbers();
            do
            {
                switch (System.Console.ReadLine().ToLower())
                {
                    case "j":
                        calculateNumbers();
                        break;
                    case "n":
                        System.Console.WriteLine("Programm wird beendet.");
                        newInput = false;
                        break;
                    default:
                        System.Console.WriteLine("Ungültige eingabe");
                        break;
                }
            } while (newInput);
        }

        private void calculateNumbers(){
            this.inputNumbers = this.inputServivce.dataInput();
            this.controlNumber = this.eanAlgorithm.calculateControlNumber(this.inputNumbers);
            System.Console.WriteLine("Prüfzahl: " + this.controlNumber);
            System.Console.Write("Vollständige EAN: ");
            foreach (int number in this.inputNumbers)
            {
                System.Console.Write(number);
            }
            System.Console.Write(this.controlNumber + "\n");
            System.Console.WriteLine("Neue Prüfziffer eingeben? [j]a [n]ein");
        }
    }
}
