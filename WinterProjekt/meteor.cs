using System;



public class Meteor
{
 
    public Vector2 Spawn { get; set; } = new(100, 100);
    public int Speed { get; set; } = 10;
    
    public Vector2 pos { get; set; }

    public int Heigth{ get; set; } = 60;
    public int Width  { get; set; } = 60;

    List<Rectangle> listNamn = new List<Rectangle>();
    

}






