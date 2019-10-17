namespace PhoneAssignment
{
    public class Galaxy : Phone, IRingable 
    {
        public string VersionNumber{get;set;}
        public int BatteryPercentage{get;set;}
        public string Carrier{get;set;}
        public string RingTone{get;set;}
        public Galaxy(string versionNumber, int batteryPercentage, string carrier, string ringTone) 
            : base(versionNumber, batteryPercentage, carrier, ringTone) {}
        public string Ring() 
        {   
            string ringStr = "..." + RingTone + "...";
            System.Console.WriteLine(ringStr);
            return ringStr;
        }
                    
        public string Unlock() 
        {
            string unlockMethod = $"Galaxy {VersionNumber} unlocked with fingerprint scanner.";
            System.Console.WriteLine(unlockMethod);
            return unlockMethod;
        }
        public override void DisplayInfo() 
        {
            System.Console.WriteLine($"\n####################\nGalaxy {VersionNumber}\nBattery: {BatteryPercentage}\nCarrier: {Carrier}\nRing Tone: {RingTone}\n####################");           
        }
    }
}