using System;
class Device {
    public int DeviceId { get; set; }
    public string Status { get; set; }

    public Device(int deviceId, string status) {
        DeviceId = deviceId;
        Status = status;
    }
    public virtual void DisplayStatus() {
        Console.WriteLine("Device Information");
        Console.WriteLine("Device ID: " + DeviceId);
        Console.WriteLine("Status: " + Status);
    }
}
class Thermostat : Device {
    public double TemperatureSetting { get; set; }
    public Thermostat(int deviceId, string status, double temperatureSetting) 
        : base(deviceId, status) {
        TemperatureSetting = temperatureSetting;
    }
    public override void DisplayStatus() {
        base.DisplayStatus();
        Console.WriteLine("Temperature Setting: " + TemperatureSetting + "°C");
    }
}

class Program {
    static void Main() {
        Console.Write("Enter Device ID: ");
        int deviceId = int.Parse(Console.ReadLine());
        Console.Write("Enter Device Status (On/Off): ");
        string status = Console.ReadLine();
        Console.Write("Enter Temperature Setting: ");
        double temperature = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Thermostat thermostat = new Thermostat(deviceId, status, temperature);
        thermostat.DisplayStatus();
    }
}
