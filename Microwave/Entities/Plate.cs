using System.IO;

namespace Microwave.Entities
{
    public class Plate
    {
        public int Timer { get; private set; }
        public int Power { get; private set; }
        public string Food { get; set; }
        public char FoodId { get; private set; }

        public Plate(string food, int timer, int power, char foodId)
        {
            Food = food;
            Timer = timer;
            Power = power;
            FoodId = foodId;
        }

        public Plate(string food, char foodId)
        {
            Food = food;
            Timer = DefaultConfiguration.FAST_TIMER;
            Power = DefaultConfiguration.FAST_POWER;
            FoodId = foodId;
        }


        public void StartCook()
        {
            for (int indexTimer = 0; indexTimer < Timer; indexTimer++)
            {
                for (int indexPower = 0; indexPower < Power; indexPower++)
                {
                    Food += FoodId;
                }
            }
        }

        public void StartCook(string path)
        {
            try
            {
                for (int indexTimer = 0; indexTimer < Timer; indexTimer++)
                {
                    for (int indexPower = 0; indexPower < Power; indexPower++)
                    {
                        using (StreamWriter sw = File.CreateText(path))
                        {
                            Food += FoodId;
                            sw.WriteLine(Food);
                        }
                    }
                }
            }
            catch (IOException)
            {
                throw new IOException("Arquivo não encontrado.");
            }

        }



        

        public override string ToString()
        {
            return $"Prato: {Food} \nTempo: {Timer} \nPotência: {Power}";
        }
    }
}
