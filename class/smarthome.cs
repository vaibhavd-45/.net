using System;
using System.Collections.Generic;

public class Device
{
    public string Name { get; set; }
    public bool IsOn { get; private set; }

    public Device(string name)
    {
        Name = name;
        IsOn = false;
    }

    public void TurnOn() => IsOn = true;
    public void TurnOff() => IsOn = false;
}

public class SmartHomeSystem
{
    private List<Device> devices;

    public SmartHomeSystem()
    {
        devices = new List<Device>();
    }

    public void AddDevice(string deviceName)
    {
        devices.Add(new Device(deviceName));
    }

    public void RemoveDevice(string deviceName)
    {
        devices.RemoveAll(d => d.Name == deviceName);
    }

    public void TurnOnAllDevices()
    {
        foreach (var device in devices)
        {
            device.TurnOn();
        }
    }

    public void TurnOffAllDevices()
    {
        foreach (var device in devices)
        {
            device.TurnOff();
        }
    }

    public void DisplayDevices()
    {
        foreach (var device in devices)
        {
            Console.WriteLine($"{device.Name}: {(device.IsOn ? "On" : "Off")}");
        }
    }
}

public class Program
{
    public static void Main()
    {
        var smartHome = new SmartHomeSystem();
        smartHome.AddDevice("Living Room Light");
        smartHome.AddDevice("Kitchen Fan");

        smartHome.DisplayDevices();
        smartHome.TurnOnAllDevices();
        smartHome.DisplayDevices();
        smartHome.RemoveDevice("Kitchen Fan");
        smartHome.DisplayDevices();
    }
}
