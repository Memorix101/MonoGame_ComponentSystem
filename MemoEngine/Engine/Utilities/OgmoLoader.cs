using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using System.Xml.Linq;

namespace MemoEngine
{
    public class OgmoLoader
    {

        StringBuilder output = new StringBuilder();

        public void xmlLoader(string name)
        {

            String path = "Content/OgmoLevel/" + name + ".oel";

            XDocument xdoc = XDocument.Load(path);
            StringBuilder result = new StringBuilder();

            var lvl = xdoc.Descendants("level");

            foreach(var o in lvl)
            {
                foreach(var p in o.Descendants("LevelObjects"))
                {
                    foreach(var t in p.Descendants("tile"))
                    {
                        //result.AppendLine("LO " + t.Attribute("x").Value);
                        GameObject tile = new GameObject();
                        tile.AddComponent(new Tile(float.Parse(t.Attribute("x").Value) * 32, float.Parse(t.Attribute("y").Value) * 32, int.Parse(t.Attribute("tx").Value) * 32, int.Parse(t.Attribute("ty").Value) * 32));
                        Scene._AddedGO.Add(tile);
                    }
                }

                foreach (var p in o.Descendants("Obstacle"))
                {
                    foreach (var t in p.Descendants("tile"))
                    {
                        //result.AppendLine("OB " + t.Attribute("x").Value);
                        GameObject block = new GameObject();
                        block.AddComponent(new Block(float.Parse(t.Attribute("x").Value) * 32, float.Parse(t.Attribute("y").Value) * 32, int.Parse(t.Attribute("tx").Value) * 32, int.Parse(t.Attribute("ty").Value) * 32));
                        Scene._AddedGO.Add(block);
                    }
                }                
            }
            
            Console.WriteLine(result.ToString());

        }
    }
}
    


    

