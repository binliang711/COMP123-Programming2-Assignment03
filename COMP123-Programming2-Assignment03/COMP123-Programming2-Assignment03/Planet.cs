﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Programming2_Assignment03
{
    abstract class Planet
    {
        // private instance variables ++++++++++++++++++++++++++++++++++++
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        //public properties +++++++++++++++++++++++++++++++++++++++++++
        public double Diameter
        {
            get
            {
                return this._diameter; //Read-only
            }
        }

        public double Mass
        {
            get
            {
                return this._mass; //Read-only
            }
        }

        public string Name
        {
            get
            {
                return this._name; //Read-only
            }
        }
        public int MoonCount
        {
            get
            {
                return this._moonCount;
            }
            set
            {
                this._moonCount = value;
            }
        }

        public double OrbitalPeriod
        {
            get
            {
                return this._orbitalPeriod;
            }
            set
            {
                this._orbitalPeriod = value;
            }
        }

        public int RingCount
        {
            get
            {
                return this._ringCount;
            }
            set
            {
                this._ringCount = value;
            }
        }

        public double RotationPeriod
        {
            get
            {
                return this._rotationPeriod;
            }
            set
            {
                this._rotationPeriod = value;
            }
        }

        // CONSTRUCTORS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public Planet(string name, double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
        }

        //Override method+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public override string ToString()
        {
            return this.Name + "'s diameter and mass are:" + this.Diameter + " and " + this.Mass;
        }
    }
}
