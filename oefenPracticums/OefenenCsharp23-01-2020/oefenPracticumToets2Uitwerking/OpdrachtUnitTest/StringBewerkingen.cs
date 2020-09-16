using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpdrachtUnitTest
{
    public static class StringBewerkingen
    {
        public const string ArrayBevatGeenStringsBoodschap = "Geen strings in array";
        public const string ArrayBevatLegeStringsBoodschap = "Lege strings in array";
        public const string ArrayBevatAlleenStringsMetSpatiesBoodschap = "Array bevat alleen strings met spaties";
        public static string MaakZinVanWoorden(string[] stringArray)
        {
            if (stringArray.Count() == 0)
                throw new Exception(ArrayBevatGeenStringsBoodschap);

            foreach (string str in stringArray)
                if (str == String.Empty)
                    throw new Exception(ArrayBevatLegeStringsBoodschap);

            // Zet alle strings in stringArray om naar kleine letters en verwijderd
            // spaties aan het begin en/of eind van de strings
            //foreach (string item in stringArray)
            //{
            //    item.ToLower();
            //    item.Trim();
            //}
            // correctie
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] = stringArray[i].ToLower();
                stringArray[i] = stringArray[i].Trim();
            }


            // Controle toegevoegd. Als er nu empty strings zijn, moet
            // dat komen omdat er strings met alleen spaties waren.
            foreach (string str in stringArray)
                if (str == String.Empty)
                    throw new Exception(ArrayBevatAlleenStringsMetSpatiesBoodschap);

            string returnString = string.Empty;

            // Maak de returnstring op basis van stringArray, waarbij alle
            // strings gescheiden worden door een spatie.
            foreach (string item in stringArray)
            {
                returnString += item + " ";
            }
            returnString = returnString.Trim();     // Verwijder de spatie aan het eind van de string

            // Maak van de eerste letter van de zin een hoofdletter
            returnString = returnString.Substring(0, 1).ToUpper() + returnString.Substring(1, returnString.Length - 1);

            // Sluit de returnString af met een punt.
            return returnString + ".";
        }
    }
}
