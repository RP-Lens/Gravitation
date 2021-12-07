using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class readStuff : Initialisation
{
    public struct planet
    {
        public string Name; 
        public float mass;
        public float perihelion;
        public string initSpeed;
        public float mvRad;
    };

    planet[] planets = new planet[9];

    public planet[] readInfo()
    {
        var sr = new StreamReader("D:/Programs/Unity/Gravitation/Assets/Scripts/Physics/PlanetInfo.csv");

        var line = sr.ReadLine();
        var info = line.Split(',');

        int i = 0;

        while (info.Length < 2)
        {
            //Get planet info from file
            planets[i].Name = info[0];
            planets[i].mass = (float) Convert.ToDouble(info[1]);
            planets[i].perihelion = (float) Convert.ToDouble(info[2]);
            planets[i].mvRad = (float) Convert.ToDouble(info[4]);
            
            //Read next line
            line = sr.ReadLine();
            info = line.Split(',');
            i++;
        }

        return planets;
    }
}
