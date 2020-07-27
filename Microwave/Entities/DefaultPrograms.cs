using Microwave.Exceptions;
using System.Collections.Generic;

namespace Microwave.Entities
{
    public class DefaultPrograms
    {
        public string ProgramName { get; private set; }
        public string ProgramInstruction { get; private set; }
        public char ProgramCharacter { get; private set; }
        public int ProgramPower { get; private set; }
        public int ProgramTimer { get; private set; }

        public static List<DefaultPrograms> programsList = new List<DefaultPrograms>();

        private DefaultPrograms(string programName, string programInstruction, char programCharacter, int programPower, int programTimer)
        {
            ProgramName = programName;
            ProgramInstruction = programInstruction;
            ProgramCharacter = programCharacter;
            ProgramPower = programPower;
            ProgramTimer = programTimer;
        }

        public static void WritePrograms()
        {
            DefaultPrograms temp;
            temp = new DefaultPrograms("Arroz", "Aquece arroz pré cozido", '@', 5, 30);
            programsList.Add(temp);
            temp = new DefaultPrograms("Pipoca", "Prepara pipocas com embalagens para microondas", '$', 8, 35);
            programsList.Add(temp);
            temp = new DefaultPrograms("Carne", "Descongela carnes", '%', 1, 50);
            programsList.Add(temp);
            temp = new DefaultPrograms("Ovo", "Cozinha ovos", '#', 7, 45);
            programsList.Add(temp);
            temp = new DefaultPrograms("Bolo", "Assar massas", '&', 6, 100);
            programsList.Add(temp);
        }

        public static void AddCustomProgram(string name, string instruction, char character, int power, int timer)
        {
            DefaultPrograms customProgram = new DefaultPrograms(name, instruction, character, power, timer);
            DefaultPrograms.programsList.Add(customProgram);
        }


    }
}
