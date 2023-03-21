using System;

public class Player : Character
{

    int time;
    public static List<Meteor> MeteList = new();
    public Player() 
    {
        Speed = 10;

        rect = new(800,400, Width, Heigth);
    }


    public override void Update()
    {
        Movement();
        MeteorSpawn();
        rect.x += movement.X;
        rect.y += movement.Y;
        Console.WriteLine(movement);
    }

    public override void Draw()
    {
        R.DrawRectangleRec(rect, Color.GREEN);
    }

//movment för gubben 
    public override void Movement()
    {
        if (R.IsKeyDown(KeyboardKey.KEY_D))
        {
            movement.X = Speed;
        }
        else if(R.IsKeyDown(KeyboardKey.KEY_A))
        {
          movement.X = -Speed;
        } 
        else
        {
            movement.X = 0;
        }


        if(R.IsKeyDown(KeyboardKey.KEY_W))
        {
           movement.Y = -Speed; 
        }
        else if(R.IsKeyDown(KeyboardKey.KEY_S))
        {
           movement.Y = Speed; 
        }
        else
        {
            movement.Y = 0;
        }
    }
  
public void MeteorSpawn()
{

    time++;
    
    if (time/120 > MeteList.Count())
  {
    
    MeteList.Add(new());

  }


}
  
  public void ShouldPlayerDie()
  {

    foreach (Meteor m in MeteList)
    {
        
            

    }

  }

}




