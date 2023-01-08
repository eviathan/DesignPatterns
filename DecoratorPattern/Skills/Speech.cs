using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Skills
{
    public class Speech : ISkill
    {
        private float value { get; set; } = 10f;

        public string GetDescription()
        {
            throw new NotImplementedException();
        }

        public float GetValue()
        {
            return value;
        }
    }
}