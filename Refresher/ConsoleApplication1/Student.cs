﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Student
    {
        public string name;
        public string major;
        public double gpa;

        public Student(string aName, string aMajor, double aGpa) 
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;
        }

        public bool isHonor() 
        {
            if(gpa >= 3.5){
                return true;
            }
            return false;
        }
    }
}
