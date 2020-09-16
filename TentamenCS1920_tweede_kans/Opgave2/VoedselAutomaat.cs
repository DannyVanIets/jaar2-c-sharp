using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Opgave2
{
    public class VoedselAutomaat<T> where T : IProduct
    {
        public int HuidigeTemperatuur { get; set; }

        private List<T> _producten = new List<T>();

        public void Toevoegen(T product)
        {
            _producten.Add(product);
        }

        public int ControleerTemperatuur()
        {
            int temperatuurAfwijking = 0;

            foreach (T product in _producten)
            {
                if (product is IKoeling)
                {
                    var pk = (IKoeling)product;
                    if (HuidigeTemperatuur > pk.Temperatuur && temperatuurAfwijking > (HuidigeTemperatuur - pk.Temperatuur) * -1)
                    {
                        temperatuurAfwijking = (HuidigeTemperatuur - pk.Temperatuur) * -1;
                    }
                }
            }

            return temperatuurAfwijking;
        }

        public bool ZwaarEnKoel(T product)
        {
            if (product.Gewicht > 200)
            {
                if(product is IKoeling)
                {
                    var pk = (IKoeling)product;

                    if (pk.Temperatuur < 6)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public List<T> Selecteer(Func<T, bool> predicaat)
        {
            List<T> productenDieVoldaan = new List<T>();

            foreach (T product in _producten)
            {
                if (predicaat(product))
                {
                    productenDieVoldaan.Add(product);
                }
            }

            return productenDieVoldaan;
        }
    }
}
