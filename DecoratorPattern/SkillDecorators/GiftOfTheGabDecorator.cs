using DecoratorPattern.Skills;
using DecoratorPattern.Interfaces;

namespace DecoratorPattern.SkillDecorators
{
    public class GiftOfTheGabDecorator : ISkillDecorator
    {
        public ISkill Skill { get; set; }

        public GiftOfTheGabDecorator(ISkill skill)
        {
            Skill = skill;
        }

        public float GetValue()
        {
            return Skill.GetValue() + 20f; 
        }
    }
}