// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region FormaIncorrecta de hacerlo
interface IAnimal
{
    void Eat();
    void Sleep();
    void Swim();
    void Fly();
}

class Fish : IAnimal
{
    public void Eat() { /* Código para comer */ }
    public void Sleep() { /* Código para dormir */ }
    public void Swim() { /* Código para nadar */ }
    public void Fly() { throw new NotImplementedException(); }
}
#endregion

#region Forma Correcta de Aplicar Principio
interface IEat
{
    void Eat();
}

interface ISleep
{
    void Sleep();
}

interface ISwim
{
    void Swim();
}

interface IFly
{
    void Fly();
}

class Fish2 : IEat, ISleep, ISwim
{
    public void Eat() { /* Código para comer */ }
    public void Sleep() { /* Código para dormir */ }
    public void Swim() { /* Código para nadar */ }
}

class Bird : IEat, ISleep, IFly
{
    public void Eat() { /* Código para comer */ }
    public void Sleep() { /* Código para dormir */ }
    public void Fly() { /* Código para volar */ }
}
#endregion

