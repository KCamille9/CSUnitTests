﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMExample.Model
{
    public class Person
    {
        public String Name { get; set; }
        public int Age { get; set; }
        public String Proffesions { get; set; }
        public int ID { get; set; }
        public String sleeeeep { get; set; }



        public Person(int id, String name, int numOfPlanes, String proffesion)
        {
            this.ID = id;
            this.Name = name;
            this.Age = numOfPlanes;
            this.Proffesions = proffesion;
        }

        //quiero dormir



        public String Sentence
        {
            get
            {
                return "ID #" + ID +
              "\nName: " + Name + "\nAge: " + Age + "\nProfession: " + Proffesions + "\n";
            }

        }
    }

}
