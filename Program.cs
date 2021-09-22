using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodGame
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("name: ");
            Console.ReadKey(true);
            string firstName;
            string lastName;
            string fullName;
            firstName = "Chris";
            lastName = "Chiasson";
            fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            Console.WriteLine("---------Hud---------");
            int life; // create an interger variable named, "score"
            life = 3;
            
            Console.WriteLine("life"); // NOT accessing a variable
            life = life + 0; //stomped an enemy for 100 points 
            Console.WriteLine(life); // accessing a variable


            int score; // create an interger variable named, "score"
            score = 0;

           
            Console.WriteLine("score"); // NOT accessing a variable

            score = score + 0; //stomped an enemy for 100 points
            Console.WriteLine(score); // accessing a variable

            Console.ReadKey(true);
            Console.WriteLine("---------Action---------");
            Console.WriteLine("You got a kill");
            Console.ReadKey(true);
            Console.WriteLine("---------Hud---------");
            Console.WriteLine("life"); // NOT accessing a variable
            life = life + 0; //stomped an enemy for 100 points 
            Console.WriteLine(life); // accessing a variable
            Console.WriteLine("score");
            score = score + 100; //stomped an enemy for 100 points
            Console.WriteLine(score);
            Console.WriteLine("---------Action---------");
            Console.ReadKey(true);
            Console.WriteLine("You got 5 kills");
            Console.ReadKey(true);
            Console.WriteLine("---------Hud---------");
            Console.WriteLine("life"); // NOT accessing a variable
            life = life + 0; //stomped an enemy for 100 points 
            Console.WriteLine(life); // accessing a variable
            Console.WriteLine("score");
            score = score + 500; //stomped an enemy for 100 points
            Console.WriteLine(score);
            Console.ReadKey(true);
            Console.WriteLine("---------Action---------");
            Console.WriteLine("You were hit by a bus");
            Console.ReadKey(true);
            Console.WriteLine("---------Hud---------");
            Console.WriteLine("life");
            life = life - 1; //stomped an enemy for 100 points
            Console.WriteLine(life);
            Console.WriteLine("score");
            score = score - 126; //stomped an enemy for 100 points
            Console.WriteLine(score);
            Console.ReadKey(true);
            Console.WriteLine("---------Action---------");
            Console.WriteLine("You then get up off the dirt and make for home in your car");
            Console.ReadKey(true);

            Console.WriteLine("you look down at your Speeddometer and odometer it reads");
            Console.ReadKey(true);
            float speed;
            float distanceTravelled;
            speed = 90;
            speed = 100.0f;
            distanceTravelled = 2345.35f;

            Console.WriteLine("Speeddometer: " + speed);
            Console.WriteLine("odometer: " + distanceTravelled);
            Console.ReadKey(true);
            Console.WriteLine("you get home and go to bed");
            Console.ReadKey(true);

            Console.WriteLine("ZZzzz....");
            Console.ReadKey(true);
        }
    }
}
