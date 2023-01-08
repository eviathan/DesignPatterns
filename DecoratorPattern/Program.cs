using DecoratorPattern.SkillDecorators;
using DecoratorPattern.Skills;

var speechSkill = new Speech();
Console.WriteLine($"Speech without decorators: {speechSkill.GetValue()}");

var giftOfTheGab = new GiftOfTheGabDecorator(speechSkill);
Console.WriteLine($"Speech with gift of gab (+20) decorator: {giftOfTheGab.GetValue()}");

var orator = new OratorDecorator(giftOfTheGab);
Console.WriteLine($"Speech with orator (+70) decorator: {orator.GetValue()}");

var goldenTongue = new GoldenTongueDecorator(orator);
Console.WriteLine($"Speech with golden tongue (+20%) decorator: {goldenTongue.GetValue()}");