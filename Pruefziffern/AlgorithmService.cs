namespace Pruefziffern
{
    public class AlgorithmService
    {
        private IInputService inputService;
        private EANInput eanInput;
        private DriverIDInput driverIDInput;

        private IAlgorithm algorithm;
        private EANAlgorithm eanAlgorithm;
        private DriverIDAlgorithm driverIDAlgorithm;
        private int controlNumber;
        private List<int> inputNumbers;

        public AlgorithmService()
        {
            this.eanInput = new EANInput();
            this.driverIDInput = new DriverIDInput();
            this.eanAlgorithm = new EANAlgorithm();
            this.driverIDAlgorithm = new DriverIDAlgorithm();
            this.inputNumbers = new List<int>();
        }

        public void run()
        {
            bool newInput = true;
            if(selectAlogorithm() == "1"){
                this.inputService = this.eanInput;
                this.algorithm = eanAlgorithm;
                do
                {
                    calculateNumbers();
                    System.Console.WriteLine("Prüfzahl: " + this.controlNumber);
                    System.Console.Write("Vollständige EAN: ");
                    foreach (int number in this.inputNumbers)
                    {
                        System.Console.Write(number);
                    }
                    System.Console.Write(this.controlNumber + "\n");
                    System.Console.WriteLine("Neue Prüfziffer eingeben? [j]a [n]ein");
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
            }else{
                this.inputService = this.driverIDInput;
                this.algorithm = this.driverIDAlgorithm;
                do
                {
                    calculateNumbers();
                    System.Console.WriteLine("Prüfzahl: " + this.controlNumber);
                    System.Console.Write("Vollständige FührerscheinID: ");
                    System.Console.WriteLine("Neue Prüfziffer eingeben? [j]a [n]ein");
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
        }

        private String selectAlogorithm(){
            bool validInput = false;
            String input = "";
            System.Console.WriteLine("[1]EAN-Algorithmus\n[2]Führerschein-Algorithmus");

            do{
                try
                {
                    input = System.Console.ReadLine();
                    switch (input)
                {
                    case "1":
                        validInput = true;
                        break;
                    case "2":
                        validInput = true;
                        break;    
                    default:
                        System.Console.WriteLine("Ungültige Eingabe");
                        break;
                }
                }
                catch (FormatException e)
                {
                    System.Console.WriteLine("Ungültige Eingabe\n");
                }

            }while(!validInput);

            return input;

        }

        private void calculateNumbers(){
            this.inputNumbers = this.inputService.dataInput();
            this.controlNumber = this.algorithm.calculateControlNumber(this.inputNumbers);
        
        }
    }
}
