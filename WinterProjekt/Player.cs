using System;

public class Player
{
    public Vector2 Spawn { get; set; } = new(100, 100);
    public int Speed { get; set; } = 10;
    
    public Vector2 Pos { get; set; }

    public int Heigth{ get; set; } = 60;
    public int Width  { get; set; } = 60;

    public void Update()
    {
    Pos += Movement();
    }

//movment för gubben 
    public Vector2 Movement()
    {
        Vector2 Temp = new(0, 0);
        if (R.IsKeyDown(KeyboardKey.KEY_D))
        {
            Temp.X = Speed;
        }
        else if(R.IsKeyDown(KeyboardKey.KEY_A))
        {
          Temp.X = -Speed;
        }
        if(R.IsKeyDown(KeyboardKey.KEY_W))
        {
           Temp.Y = -Speed; 
        }
        else if(R.IsKeyDown(KeyboardKey.KEY_S))
        {
           Temp.Y = Speed; 
        }

        return Temp; 
    }
}




