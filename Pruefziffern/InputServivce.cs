namespace Pruefziffern
{
    public class InputServivce
    {
        public List<int> dataInput()
        {
            List<int> eanCode = new List<int>();
            bool validInput = false;
            do
            {
                try
                {
                    System.Console.WriteLine("Bitte Prüfziffer eintragen:");
                    String eanString = Console.ReadLine();
                    if (eanString.Length < 12)
                    {
                        System.Console.WriteLine("Zu wenig Ziffern eingegeben\n");
                    }
                    else if (eanString.Length > 12)
                    {
                        System.Console.WriteLine("Zu viele Ziffern eingegeben\n");
                    }
                    else
                    {
                        for (int i = 0; i < eanString.Length; i++)
                        {
                            eanCode.Add(Convert.ToInt32(new String(eanString[i], 1)));
                        }
                        validInput = true;
                        System.Console.WriteLine("Prüfziffer gültig.\n");
                    }
                }
                catch (FormatException e)
                {
                    System.Console.WriteLine("Ungültige Eingabe\n");
                    eanCode.Clear();
                }
            } while (!validInput);
            return eanCode;
        }
    }
}
