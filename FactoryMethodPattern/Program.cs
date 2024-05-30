using FactoryMethodPattern.Enums;
using FactoryMethodPattern.Factories;
using FactoryMethodPattern.Interfaces;

ICakeFactory cakeFactory = new CakeFactory();


var carrotCake1 = cakeFactory.Bake(CakeType.CarrotCake);
var carrotCake2 = cakeFactory.Bake(CakeType.CarrotCake);

var battenberg1 = cakeFactory.Bake(CakeType.Battenberg);
var battenberg2 = cakeFactory.Bake(CakeType.Battenberg);
var battenberg3 = cakeFactory.Bake(CakeType.Battenberg);

// This will thro an exception
// var carrotCake3 = cakeFactory.Bake(CakeType.CarrotCake);