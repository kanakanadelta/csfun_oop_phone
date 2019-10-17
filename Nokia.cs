namespace PhoneAssignment
{
    public class Nokia : Phone, IRingable
    {
        public Nokia(string versionNumber, int batteryPercentage, string carrier, string ringTone) 
        : base(versionNumber, batteryPercentage, carrier, ringTone) {}

        public string VersionNumber{get;set;}
        public int BatteryPercentage{get;set;}
        public string Carrier{get;set;}
        public string RingTone{get;set;}
        public string Ring() 
        {
            string ringStr = "..." + RingTone + "...";
            System.Console.WriteLine(ringStr);
            return ringStr;
        }
        public string Unlock() 
        {
            string unlockMethod = $"Nokia {VersionNumber} unlocked with passcode scanner.";
            System.Console.WriteLine(unlockMethod);
            return unlockMethod;
        }
        public override void DisplayInfo() 
        {
            System.Console.WriteLine($"\n$$$$$$$$$$$$$$$$$$$$\nNokia {VersionNumber}\nBattery: {BatteryPercentage}\nCarrier: {Carrier}\nRing Tone: {RingTone}\n$$$$$$$$$$$$$$$$$$$$");       
        }
    }
}