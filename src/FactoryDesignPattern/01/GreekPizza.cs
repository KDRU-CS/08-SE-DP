﻿namespace FactoryDesignPattern._01;

sealed class GreekPizza : Pizza
{
    public override void Bake()
    {
        Console.WriteLine("Greek pizza Baked");
    }
}