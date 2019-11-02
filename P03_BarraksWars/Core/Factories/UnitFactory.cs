namespace _03BarracksFactory.Core.Factories
{
    using System;
    using Contracts;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            var classType = Type.GetType($"_03BarracksFactory.Models.Units.{unitType}");
            var createdInstance = Activator.CreateInstance(classType);
            return (IUnit)createdInstance;
        }
    }
}
