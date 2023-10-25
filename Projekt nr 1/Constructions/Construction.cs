using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2.Constructions
{
    class Construction
    {
        public Construction()
        {
        }

        public Construction(float height, float width, int entrances, int humanCapacity, string buildMaterial)
        {
            Height = height;
            Width = width;
            Entrances = entrances;
            HumanCapacity = humanCapacity;
            BuildMaterial = buildMaterial;
        }
        public float Height { get; set; }
        public float Width { get; set; }
        public int Entrances { get; set; }
        public int HumanCapacity { get; set; }
        public string BuildMaterial { get; set; }
    }
}




//1.Stwórz nowy projekt konsolowy z wykorzystanie Visual Studio
//2. Dodaj Folder Construction i w nim zdefiniuj klasę o takiej samej nazwie
//3. Zdefiniuj obiekt, który będzie posiadał właściwości:
//1.Height typu zmiennoprzecinkowego
//2. Width typu zmiennoprzecinkowego
//3. Entrances typu liczba całkowita
//4. HumanCapacity typu liczba całkowita
//5. BuildMaterial typu tekstowego
//4. Zdefiniuj publiczny konstruktor, który zainicjalizuje poszczególne właściwości.
//5. W pliku Program.cs stwórz obiekt typu Construction i wypisz wszystkie
//właściwości obiektu.
//6. Do obiektu Contruction dodaj pole prywatne _buildMaterial , które będzie
//ustawiane i odczytywane za pomocą get oraz set zmiennej BuildMaterial
//7. Przy ustawianiu _buildMaterial sprawdzaj czy nie podano pusty string. Jeżeli tak
//rzuć wyjątek ArgumentNullException
//8. Kod umieść na repozytorium.