namespace Pruefziffern
{
    public interface DriverIDInput : IInputService
    {
        public List<int> dataInput()
        {
            List<int> driverIDCode = new List<int>();
            bool validInput = false;
            do
            {
                try
                {
                    System.Console.WriteLine("Bitte die ersten 9 Zeichen der Führerscheinnummer eintragen:");
                    String driverIDString = Console.ReadLine().ToLower();
                    if (driverIDString.Length < 9)
                    {
                        System.Console.WriteLine("Zu wenig Ziffern eingegeben\n");
                    }
                    else if (driverIDString.Length > 9)
                    {
                        System.Console.WriteLine("Zu viele Ziffern eingegeben\n");
                    }
                    else
                    {
                        for (int i = 0; i < driverIDString.Length; i++)
                        {
                            driverIDCode.Add(getNumber(driverIDString, i));
                        }
                        validInput = true;
                        System.Console.WriteLine("Prüfziffer gültig.\n");
                    }
                }
                catch (FormatException e)
                {
                    System.Console.WriteLine("Ungültige Eingabe\n");
                    driverIDCode.Clear();
                }
            } while (!validInput);
            return driverIDCode;
        }


        private int getNumber(String driverIDString, int i){
            int idNumber = 9;
            switch (driverIDString[i]){
                case 'a':
                    idNumber = idNumber+1;
                    break;
                case 'b':
                    idNumber = idNumber+2;
                    break;
                case 'c':
                    idNumber = idNumber+3;
                    break;
                case 'd':
                    idNumber = idNumber+4;
                    break;    
                case 'e':
                    idNumber = idNumber+5;
                    break;
                case 'f':
                    idNumber = idNumber+6;
                    break;
                case 'g':
                    idNumber = idNumber+7;
                    break;
                case 'h':
                    idNumber = idNumber+8;
                    break;      
                case 'i':
                    idNumber = idNumber+9;
                    break;
                case 'j':
                    idNumber = idNumber+10;
                    break;
                case 'k':
                    idNumber = idNumber+11;
                    break;
                case 'l':
                    idNumber = idNumber+12;
                    break;    
                case 'm':
                    idNumber = idNumber+13;
                    break;
                case 'n':
                    idNumber = idNumber+14;
                    break;
                case 'o':
                    idNumber = idNumber+15;
                    break;
                case 'p':
                    idNumber = idNumber+16;
                    break;   
                case 'q':
                    idNumber = idNumber+17;
                    break;
                case 'r':
                    idNumber = idNumber+18;
                    break;
                case 's':
                    idNumber = idNumber+19;
                    break;
                case 't':
                    idNumber = idNumber+20;
                    break;    
                case 'u':
                    idNumber = idNumber+21;
                    break;
                case 'v':
                    idNumber = idNumber+22;
                    break;
                case 'w':
                    idNumber = idNumber+23;
                    break;
                case 'x':
                    idNumber = idNumber+24;
                    break;  
                case 'y':
                    idNumber = idNumber+25;
                    break;  
                case 'z':
                    idNumber = idNumber+26;
                    break;           
                default:
                    idNumber = Convert.ToInt32(new String(driverIDString[i], 1));
                    break;    
            }

            return idNumber;
        }
    }
}