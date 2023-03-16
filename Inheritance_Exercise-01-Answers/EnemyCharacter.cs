using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Exercise_01_Answers
{
    // TODO: Create another child class called EnemyCharacter that inherits from the base class
    public class EnemyCharacter : Character
    {
        // TODO: Give the EnemyCharacter class methods and properties (be creative)
        // TODO: Make all members public
        public new void Attack()
        {
            Console.WriteLine("Enemy Character's attack method");
        }
        public new void Defend()
        {
            Console.WriteLine("Enemy Character's defense method");
        }
    }
}
