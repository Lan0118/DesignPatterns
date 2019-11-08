using System;
namespace FacadePattern
{
    public class Tuner
    {
        string description;
        Amplifer amplifer;
        double frequency;

        public Tuner(string description, Amplifer amplifer)
        {
            this.description = description;
        }

        public void on()
        {
            Console.WriteLine(description + " On");
        }

        public void off()
        {
            Console.WriteLine(description + " Off");
        }

        public void setFrequency(double frequency)
        {
            Console.WriteLine(description + " setting frequency to " + frequency);
            this.frequency = frequency;
        }

        public void setFM()
        {
            Console.WriteLine(description + " setting FM mode");
        }

        public string getDescription()
        {
            return description;
        }
    }
}