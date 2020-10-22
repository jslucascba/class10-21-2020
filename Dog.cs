using System;

namespace class10_21_2020
{
    public class Dog
    {
        private string name;
        private string breed;
        private int weight;
        private static int count;


        public void SetName(string name) {
            this.name = name;
        }

        public string GetName() {
            return name;
        }
         public void SetBreed(string breed) {
            this.breed = breed;
        }

        public string GetBreed() {
            return breed;
        }
         public void SetWeight(int weight) {
            this.weight = weight;
        }

        public int GetWeight() {
            return weight;
        }
         public static void SetCount(int value) {
            value = count;
        }

        public static int GetCount() {
            return count;
        }

        public static void IncCount() {
            count++;
        }

        public void Bark() {
            Console.WriteLine("Woof woof!");
        }

        public override string ToString() {
            return name + "\t" + breed + "\t" + weight;
        }
    }
}