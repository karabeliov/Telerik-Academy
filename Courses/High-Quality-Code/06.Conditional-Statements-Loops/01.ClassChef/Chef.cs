using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassChef
{
    public class Chef
    {
        private Bowl GetBowl()
        {
            Bowl bowl = new Bowl();
            return bowl;
        }

        private Carrot GetCarrot()
        {
            Carrot carrot = new Carrot();
            return carrot;
        }

        private Potato GetPotato()
        {
            Potato potato = new Potato();
            return potato;
        }

        private void Cut(Vegetable vegetable)
        {
            throw new NotImplementedException();
        }

        private void Peel(Vegetable vegetable)
        {
            throw new NotImplementedException();
        }

        public void Cook(Vegetable vegetable)
        {
            Potato potato = GetPotato();
            Carrot carrot = GetCarrot();
            Bowl bowl;

            Peel(potato);
            Peel(carrot);

            bowl = GetBowl();

            Cut(potato);
            Cut(carrot);

            bowl.Add(carrot);
            bowl.Add(potato);
        } 
    }
}
