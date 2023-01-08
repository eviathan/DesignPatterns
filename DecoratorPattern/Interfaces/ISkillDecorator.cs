using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DecoratorPattern.Interfaces
{
    public interface ISkillDecorator : ISkill
    {
        ISkill Skill { get; set; }
    }
}