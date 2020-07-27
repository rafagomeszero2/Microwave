using System;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microwave.Entities;
using Microwave.Exceptions;
using Microwave.IO;

namespace MicrowaveTest
{
    [TestClass]
    public class VerifiersTest
    {



        [TestMethod]
        [ExpectedException(typeof(CustomExceptions))]

        public void EmptyString()
        {
            string text = "";

            Verifiers.VerifyName(text);
            Verifiers.VerifyTimer(text);
            Verifiers.VerifyChar(text);
        }



        [TestMethod]
        [ExpectedException(typeof(CustomExceptions))]

        public void OutOfRange()
        {
            string minValue = "0";
            string maxValue = "121";

            Verifiers.VerifyTimer(minValue);
            Verifiers.VerifyTimer(maxValue);
            Verifiers.VerifyPower(minValue);
            Verifiers.VerifyPower(maxValue);
        }



        [TestMethod]

        public void ListContains()
        {
            DefaultPrograms.WritePrograms();
            DefaultPrograms obj = DefaultPrograms.programsList[0];

            string text = obj.ProgramName;

            Assert.IsTrue(Verifiers.VerifyProgram(text));
        }



        [TestMethod]

        public void FileNotExist()
        {
            string text = "BrokenPath";

            try
            {
                FileIO.IsFile(text);
                FileIO.ReadFile(text);
            }
            catch (FileNotFoundException)
            {
                return;
            }
        }



        [TestMethod]

        public void FileExist()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\teste.txt";

            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(".");
            }

            bool result = FileIO.IsFile(path);

            File.Delete(path);

            Assert.IsTrue(result);

        }


    }
}
