﻿using System;
using System.Collections.Generic;

public class Person
{
    public Person(string firstName, string lastName, int age, double salary)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
        this.Salary = salary;
    }
    private string firstName;
    private string lastName;
    private int age;
    private double salary;

    public string FirstName
    {
        get
        {
            return this.firstName;
        }

        private set
        {
            this.firstName = value;
        }
    }
    public string LastName
    {
        get
        {
            return this.lastName;
        }

        private set
        {
            this.lastName = value;
        }
    }

    public int Age
    {
        get
        {
            return this.age;
        }

        set
        {
            this.age = value;
        }
    }
    public double Salary
    {
        get
        {
            return this.salary;
        }

        set
        {
            this.salary = value;
        }
    }
    public override string ToString()
    {
        return $"{this.FirstName} {this.LastName} get {this.Salary:f2} leva";
    }
}