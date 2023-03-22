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
     
        ShouldPlayerDie();
        Movement();
        MeteorSpawn();
        rect.x += movement.X;
        rect.y += movement.Y;
        //Console.WriteLine(movement);
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


        //hämtar en meteor fårn metelåist varje sekund
public void MeteorSpawn()
{

    time++;
    
    if (time/60 > MeteList.Count())
  {
    GlobalProp.TotalMeteorSpawned++;
    MeteList.Add(new());
    

  }


}
  //kollar att när spelare och meteor krockar så stänger den av spelet
  public void ShouldPlayerDie()
  {

    

        for (int i = 0; i < MeteList.Count; i++)
    {
            Meteor m = MeteList[i];
            //Console.WriteLine(m);


            if (R.CheckCollisionRecs(rect, m.rect))
          {
            Environment.Exit(0);    
          }  

    }

  }

}




