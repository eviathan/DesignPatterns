using DecoratorPattern.Skills;
using DecoratorPattern.Interfaces;

namespace DecoratorPattern.SkillDecorators
{
    public class GoldenTongueDecorator : ISkillDecorator
    {
        public ISkill Skill { get; set; }

        public GoldenTongueDecorator(ISkill skill)
        {
            Skill = skill;
        }

        public float GetValue()
        {
            var currentValue = Skill.GetValue();
            return currentValue + currentValue * 0.2f; 
        }
    }
}