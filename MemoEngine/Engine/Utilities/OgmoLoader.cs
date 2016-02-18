﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace MemoEngine
{
    public class OgmoLoader
    {
        public void xmlLoader(string name)
        {
            XmlTextReader reader = new XmlTextReader("Content/OgmoLevel/" + name +".oel");
            while (reader.Read())
            {
                switch (reader.Name)
                {
                    case "level": 
                        Console.Write("<" + reader.Name);
                        Console.WriteLine(">");
                        break;
                    case "LevelObjects": //Display the text in each element.
                        Console.WriteLine(reader.Value);
                        break;
                    case "tile": //Display the end of the element.
                        Console.WriteLine(reader.GetAttribute("x")  + " - " + reader.GetAttribute("y"));
                        GameObject tile = new GameObject();
                        tile.AddComponent(new Tile(float.Parse(reader.GetAttribute("x"))*32, float.Parse(reader.GetAttribute("y"))*32, int.Parse(reader.GetAttribute("tx")) * 32, int.Parse(reader.GetAttribute("ty"))*32));
                        Scene._AddedGO.Add(tile);
                        break;
                }          

                Console.ReadLine();
            }
        }
    }
}

    

