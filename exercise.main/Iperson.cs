﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public interface Iperson
    {
        public Basket GetBasket();
        public void ChangeBasketCapacity(int capacity);
    }
}
