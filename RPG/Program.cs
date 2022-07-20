using System;
using RPG.src.Entities;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Knight knight = new Knight("Arus", 50, "Knight"); // Instanciando objeto
            Wizard wizard = new Wizard("Jenica", 50, "White Wizard");
            Ninja ninja = new Ninja("Wedge", 42, "Ninja");
            Wizard blackWizard = new Wizard("Topapa", 42, "Black Wizard");


            // Console.WriteLine(knight.Attack());
            // Console.WriteLine(wizard.Attack(7)); // Posso passar ou não o bonus de ataque
            // Console.WriteLine(ninja.Attack());
            // Console.WriteLine(blackWizard.Attack(1));
            Console.WriteLine(knight.ToString());
            System.Console.WriteLine();
            Console.WriteLine(wizard.ToString());
            System.Console.WriteLine();
            Console.WriteLine(ninja.ToString());
            System.Console.WriteLine();
            Console.WriteLine(blackWizard.ToString());
        }
    }
}