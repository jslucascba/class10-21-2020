using System;

namespace class10_21_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dog myDog = new Dog();
            // myDog.SetName("Sofie");
            // myDog.SetBreed("Rat Terrier");
            // myDog.SetWeight(15);
            // myDog.Bark();

            // Exercise(myDog);
            // Console.WriteLine(myDog.GetWeight());

            Dog[] myDogs = GetAllDogs();
            PrintAllDogs(myDogs);
            
        }

        public static void Exercise(Dog localDog) {
            localDog.SetWeight(localDog.GetWeight()-1);
           
        }

        public static Dog[] GetAllDogs() {
            Dog[] myDogs = new Dog[100];
            Dog.SetCount(0);
            string userInput = "";
            Console.WriteLine("Enter dog's name, stop to quit: ");
            userInput=Console.ReadLine();
            while(userInput.ToUpper() != "STOP") {
                Dog temp = new Dog();
                temp.SetName(userInput);
                Console.WriteLine("Enter the breed: ");
                temp.SetBreed(Console.ReadLine());
                Console.WriteLine("Enter the weight: ");

                temp.SetWeight(int.Parse(Console.ReadLine()));
                myDogs[Dog.GetCount()] = temp;
                Dog.IncCount();

                Console.WriteLine("Enter dog's name, stop to quit: ");
                userInput=Console.ReadLine();
            }

            return myDogs;

        }

        public static void PrintAllDogs(Dog[] myDogs) {
            for(int i=0; i < Dog.GetCount(); i++) {
                Console.WriteLine(myDogs[i].ToString());
            }
        }
    }
}
