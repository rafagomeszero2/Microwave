using Microwave.Exceptions;

namespace Microwave.Entities
{
    public static class Verifiers
    {
        public static void VerifyName(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new CustomExceptions("É necessário informar um alimento.");
            }
        }

        public static void VerifyTimer(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new CustomExceptions("É necessário informar o tempo de aquecimento.");
            }
            int textToInt = int.Parse(text);
            if (textToInt < DefaultConfiguration.MIN_TIMER || textToInt > DefaultConfiguration.MAX_TIMER)
            {
                throw new CustomExceptions("É necessário informar um valor dentro do limite (1~120).");
            }
        }

        public static int VerifyPower(string text)
        {
            if (text.Trim() == "")
            {
                return DefaultConfiguration.DEFAULT_POWER;
            }
            int textToInt = int.Parse(text);
            if (textToInt < DefaultConfiguration.MIN_POWER || textToInt > DefaultConfiguration.MAX_POWER)
            {
                throw new CustomExceptions("É necessário informar um valor dentro do limite (1~10).");
            }
            return textToInt;
        }

        public static char VerifyChar(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new CustomExceptions("É necessário informar o caractere de aquecimento.");
            }
            char textToChar = char.Parse(text);
            return textToChar;
        }

        public static bool VerifyProgram(string text)
        {
            foreach (DefaultPrograms obj in DefaultPrograms.programsList)
            {
                if (text.ToUpper().Trim() == obj.ProgramName.ToUpper().Trim())
                {
                    return true;
                }
            }
            return false;
        }
    }
}
