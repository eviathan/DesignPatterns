using DecoratorPattern.Skills;
using DecoratorPattern.Interfaces;

namespace DecoratorPattern.SkillDecorators
{
    public class OratorDecorator : ISkillDecorator
    {
        public ISkill Skill { get; set; }

        public OratorDecorator(ISkill skill)
        {
            Skill = skill;
        }

        public float GetValue()
        {
            return Skill.GetValue() + 70f; 
        }
    }
}