﻿using System;

namespace Inheritance_Exercise_01_Answers
{
    class Program
    {
        #region// TODO: Demonstrate inheritance using a class

        // TODO: Create another child class called EnemyCharacter that inherits from the base class
        // TODO: Give the EnemyCharacter class methods and properties (be creative)
        // TODO: Make all members public

        #endregion

        static void Main(string[] args)
        {
            // TODO: Create an instance of the Character class
            var character = new Character();

            // TODO: Create an instance of your MainCharacter class
            var mainCharacter = new MainCharacter();

            // TODO: Create an instance of your EnemyCharacter class
            var enemyCharacter = new EnemyCharacter();

            // TODO: Call all the methods for the main character and enemy character
            // TODO: Seperate them with the AddSpaces(int numberOfSpaces) function
            mainCharacter.Attack();
            mainCharacter.Defend();
            AddSpaces(1);
            enemyCharacter.Attack();
            enemyCharacter.Defend();


            // TODO: Try calling the methods for the character class
            //character.Attack();
            //character.Defend();

            // Thought Experiment: Why can't you call the methods for the charcter class?
            // Answer here: Because the base class's members are marked as Protected, we can only access them from class's that inherit from the base class
        }
        public static void AddSpaces(int numberOfSpaces)
        {
            while (numberOfSpaces != 0)
            {
                Console.WriteLine();
                numberOfSpaces--;
            }
        }
    }
}
