using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNameConsoleApp1 { 
    enum Models {AUDI, VOLVO, VW, OPEL, FORD}

    class Cars
    {
        public float speed;
        public int wheel = 4;
        protected bool isWorking = true;
        public static int test = 13;
        public Models model;

        public Cars(float speed, int wheel, bool isWorking)
        {
            this.speed = speed;
            this.wheel = wheel;
            this.isWorking = isWorking;
        }

        public void setWheel(int wheel)
        {
            this.wheel = wheel;
        }

        public void setSpeed(float speed)
        {
            this.speed = speed;
        }

        public virtual void getValues()
        {
            Console.WriteLine("For " + this.model + " : speed is " + this.speed + " , wheel is   " + this.wheel + " , is Working is " + this.isWorking);
        }

    }

    class Trucks : Cars
    {
        int passengers;
        public Trucks (int passengers, int wheel, float speed, bool isWorking) : base (speed, wheel, isWorking)
        {
            this.passengers = passengers;
        }

        public override void getValues()
        {
            //base.getValues();
            Console.WriteLine("For " + this.model + " : speed is " + this.speed + " , wheel is   " + this.wheel + " , is Working is " + this.isWorking + " , passenger is " + this.passengers);
        }

    }

    class Program
    {
        public static void Main(string[] args)
        {
            Cars audi = new Cars (150f, 4, false);
            Trucks volvo = new Trucks (2, 20, 89.9f, true);
            audi.model = Models.AUDI;
            volvo.model = Models.VOLVO;

            audi.getValues();

            volvo.getValues();

            Console.ReadKey();
        } 
    }
}

