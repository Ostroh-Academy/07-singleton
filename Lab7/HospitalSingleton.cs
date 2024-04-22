using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    public class HospitalSingleton
    {
        private static HospitalSingleton instance;
        private string[] medicalData;
        private HospitalSingleton()
        {
            medicalData = new string[100];
        }

        public static HospitalSingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new HospitalSingleton();
            }
            return instance;
        }

        public void AddMedicalData(string data)
        {
            for (int i = 0; i < medicalData.Length; i++)
            {
                if (medicalData[i] == null)
                {
                    medicalData[i] = data;
                    return;
                }
            }
            Console.WriteLine("Medical data storage is full.");
        }

        public string GetMedicalData(int index)
        {
            if (index >= 0 && index < medicalData.Length)
            {
                return medicalData[index];
            }
            else
            {
                return "Invalid index.";
            }
        }
    }
}
