using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azeri_Chat_Task
{
    class AIServer
    {
        static List<string> salam = new List<string> {
            "Salam","Salam necesen?","Aleykum salam","Hello qardash"
            };
        static List<string> necesen = new List<string> {
            "Yaxshiyam sen?","Ela , sen necesen?","Bele de","Shukur, esas sen neceesen?"
            };
        static List<string> neVarNeYox = new List<string> {
            "Salamatchiliqdi","Yaxshiliq shukur","Hech, boshluq"
            };
        static List<string> hardasan = new List<string> {
            "Evde hemisheki kimi, sen hardasan?","Dincelirem","Novxanida cimirem","Kurdemirdeyem","Yiyib ichmekdeyem"
            };
        static List<string> randomWords = new List<string> {
            "Basha dushmedim","Hansisa sohbeti bashla","...","Bro..."
            };
        static public string GetResponseSalam()
        {
            Random random = new Random();
            int index = random.Next(salam.Count);
            return salam[index];
        }
        static public string GetResponseNecesen()
        {
            Random random = new Random();
            int index = random.Next(necesen.Count);
            return necesen[index];
        }
        static public string GetResponseNeVarNeYox()
        {
            Random random = new Random();
            int index = random.Next(neVarNeYox.Count);
            return neVarNeYox[index];
        }
        static public string GetResponseHardasan()
        {
            Random random = new Random();
            int index = random.Next(hardasan.Count);
            return hardasan[index];
        }
        static public string GetResponse()
        {
            Random random = new Random();
            int index = random.Next(randomWords.Count);
            return randomWords[index];
        }
    }
}
