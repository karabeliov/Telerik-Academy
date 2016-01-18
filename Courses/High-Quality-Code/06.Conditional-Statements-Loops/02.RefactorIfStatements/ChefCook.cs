using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassChef;

namespace ClassChef
{
    public class ChefCook
    {
        public static void Main(string[] args)
        {
            Potato potato = new Potato();
            Chef chef = new Chef();

            if (potato == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                if (potato.HasBeenPeeled && !potato.IsRotten)
                {
                    chef.Cook(potato);
                }
            }
        }
    }
}
