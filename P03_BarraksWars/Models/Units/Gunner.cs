﻿namespace _03BarracksFactory.Models.Units
{
    public class Gunner : Unit
    {
        private const int DefaultHealth = 20;
        private const int DefaultDemage = 20;
        public Gunner() : base(DefaultHealth, DefaultDemage)
        {
        }
    }
}
