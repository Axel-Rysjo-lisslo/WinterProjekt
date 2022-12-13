using System;


public class Player
{
    public Vector2 spawn { get; set; } = new(100, 100);
    public int speed { get; set; } = 10;
    
    public Vector2 pos { get; set; }

    public int heigth{ get; set; } = 60;
    public int width  { get; set; } = 60;

    public void Update()
    {
    pos += Movement();
    }


    public Vector2 Movement()
    {
        Vector2 temp = new(0, 0);
        if (R.IsKeyDown(KeyboardKey.KEY_D))
        {
            temp.X = speed;
        }
        else if(R.IsKeyDown(KeyboardKey.KEY_A))
        {
          temp.X = -speed;
        }
        if(R.IsKeyDown(KeyboardKey.KEY_W))
        {
           temp.Y = -speed; 
        }
        else if(R.IsKeyDown(KeyboardKey.KEY_S))
        {
           temp.Y = speed; 
        }

        return temp; 
    }


}




