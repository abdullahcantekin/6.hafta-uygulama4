using System;

enum TrafficLight
{
    Red = 1,
    Yellow,
    Green
}

class TrafficLightControl
{
    public string GetAction(TrafficLight light)
    {
        switch (light)
        {
            case TrafficLight.Red:
                return "Stop";
            case TrafficLight.Yellow:
                return "Prepare to stop";
            case TrafficLight.Green:
                return "Go";
            default:
                return "Invalid light";
        }
    }
}

class Program
{
    static void Main()
    {
        TrafficLightControl control = new TrafficLightControl();

        TrafficLight currentLight = TrafficLight.Green;
        Console.WriteLine($"Current light: {currentLight}");
        Console.WriteLine($"Action: {control.GetAction(currentLight)}");
    }
}
