﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Information_System
{
    class CreatorManufacter : Cold_Storage
    {
       
        public override IProduct_information FactoryMethod()
        {
            return new Manufacturer_implementer();
        }
        public override Interface_Calculate FactoryMehodCalculate()
        {
            return new Calculate_implementer();
        }


    }
}