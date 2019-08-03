using System;
using System.Collections.Generic;
using System.Text;

namespace LessonPlayground
{
    public static class Lesson1
    {
        public static void Run()
        {
            #region Encapsulation
            // OOP is POO. (programming fOr Others)
            // With encapsulation we can achieve that.

            // private vs protected:
            // private for limiting access
            // protected for limiting access but let inheritance
            var person1 = new Person("Tom", "Mathias", "Jenkins");
            Console.WriteLine(person1.FullName);
            #endregion

            #region Polymorphism
            #region Through inheritance
            // Inheritance:
            PoliceOfficer officer1 = new TrafficPoliceOfficer("Mat", "Tim", "Jenkins");
            PoliceOfficer officer2 = new HomocidePoliceOfficer("John", "Billy", "Jenkins");
            PoliceOfficer officer3 = new ChiefPoliceOfficer("Christie", "Maria", "Jenkins");

            var policeOfficers = new[] { officer1, officer2, officer3 };
            foreach (var officer in policeOfficers)
            {
                officer.DoPoliceWork();
                officer.PatrolArea();
            }
            #endregion

            #region Through interfaces
            var cow = new Cow();
            var liveables = new ILife[] { cow, officer1, person1 };
            foreach (var liveable in liveables)
            {
                Damage(liveable, 15);
            }
            #endregion
            #endregion
        }

        private static void Damage(ILife liveable, int hp)
        {
            Console.WriteLine($"Before: {liveable.HP}");
            liveable.HP -= hp;
            Console.WriteLine($"After: {liveable.HP}");
        }
    }

    #region Interface
    // Interface: classes which are unrelated
    // in any other way than their behavior which is shared (by definition)
    // can be unified by implementing the same interface
    // Interfaces should be the most common way to unify different classes and expose their behavior
    interface ILife
    {
        int HP { get; set; }
    }

    interface ITalker
    {
        void Talk(string message);
    }

    public class Cow : ITalker, ILife
    {
        public int HP { get; set; }

        public void Talk(string message)
        {
            var lenght = message.Length;
            var cowMessage = "M";
            for (var i = 0; i < lenght; i++)
            {
                cowMessage += "o";
            }
            Console.WriteLine(cowMessage);
        }
    }

    #endregion

    #region Inheritance
    public class Person : ITalker, ILife
    {
        // Encapsualtion:
        // 1: Budling variables and functions into one class.
        // 2: Aceess restriction- hiding what you don't have to know about.

        public string FullName => $"{_firstName} {_middleName} {_lastName}";

        public int HP { get; set; }

        private readonly string _firstName;
        private readonly string _middleName;
        private readonly string _lastName;

        public Person(string firstName, string middleName, string lastName)
        {
            _firstName = firstName;
            _middleName = middleName;
            _lastName = lastName;
        }

        protected void ThinkBadThoughts()
        {

        }

        public void Talk(string message)
        {
            Console.WriteLine($"{FullName}: {message}");
        }
    }

    // Inheritance: 
    // It's an "is a" relation between a parent and a child.
    // Why do we need it?
    // 1) Generalisation- ability to do and be the same as parent
    // 2) Code reuse

    // Abstract class vs interface:
    // Abstract class = class + interface.

    // Rules of inheritance:
    // 1) Has to form a logical relation (don't fake logic). Do not inherit semantic relation
    // 2) Child should not use a parent. Child should be purely additive.
    // 3) Not more than 2 levels deep
    // 4) Things won't change.

    public class Team
    {
        private List<Person> _people;

        public Team()
        {
            _people = new List<Person>();
        }

        public void Add(Person person)
        {
            _people.Add(person);
        }

        public void Remove(Person person)
        {
            _people.Remove(person);
        }
    }

    public class BadTeam : List<Team>
    {

    }

    public abstract class PoliceOfficer : Person
    {
        public PoliceOfficer(string firstName, string middleName, string lastName) : base(firstName, middleName, lastName)
        {
        }

        protected void LiveLife()
        {
            ThinkBadThoughts();
        }

        public abstract void DoPoliceWork();

        #region Bad Inehritance- methods which might not be used in children
        public virtual void Shoot(Person person)
        {
            Console.WriteLine($"Shooting {person}");
        }

        public void Drive()
        {
            Console.WriteLine("Driving a car");
        }

        public virtual void PatrolArea()
        {
            Console.WriteLine("Patrolling area");
        }
        #endregion
    }

    public class TrafficPoliceOfficer : PoliceOfficer
    {
        public TrafficPoliceOfficer(string firstName, string middleName, string lastName) : base(firstName, middleName, lastName)
        {
        }



        public override void DoPoliceWork()
        {
            Console.WriteLine("Catching speeding up cars");
        }
    }

    public class HomocidePoliceOfficer : PoliceOfficer
    {
        public HomocidePoliceOfficer(string firstName, string middleName, string lastName) : base(firstName, middleName, lastName)
        {
        }

        public override void DoPoliceWork()
        {
            Console.WriteLine("Inspecting crime scene..");
        }
    }

    public class ChiefPoliceOfficer : PoliceOfficer
    {
        public ChiefPoliceOfficer(string firstName, string middleName, string lastName) : base(firstName, middleName, lastName)
        {
        }

        public override void DoPoliceWork()
        {
            Console.WriteLine("Commanding other police officers");
        }

        public override void PatrolArea()
        {
        }
    }

    public class PatrolPoliceOfficer : PoliceOfficer
    {
        public PatrolPoliceOfficer(string firstName, string middleName, string lastName) : base(firstName, middleName, lastName)
        {
        }

        public override void DoPoliceWork()
        {
            PatrolArea();
        }
    }
    #endregion

    #region Prefer composition over inheritance
    #region Bad
    public class BadTile
    {

    }
    public class BadMovingTile : Tile
    {

    }
    public class BadMovingTileWithTxt : BadMovingTile
    {

    }
    public class BadTileWithText : Tile
    {

    }
    public class BadTileWithColor : Tile
    {

    }
    #endregion
    #region Good:
    // Prefer composition over inheritance.
    public class Tile
    { }
    public class Motor
    {
        public void Move()
        {

        }
    }
    public class Renderer
    {

    }
    public class Text
    {

    }
    // Tile + Motor
    // Composition is way to reuse code
    // We have private components with public methods
    // And we expose their public methods through composition public methods.
    public class MovingTile
    {
        private Tile _tile;
        private Motor _motor;

        public MovingTile(Tile tile, Motor motor)
        {
            _tile = tile;
            _motor = motor;
        }

        public void Move()
        {
            _motor.Move();
        }

    }
    public class MovingTileWithTxt : BadMovingTile
    {
        Tile _tile;
        Text _text;
        Motor _motor;
    }
    #endregion
    #endregion
}
