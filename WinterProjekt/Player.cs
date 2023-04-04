using System;

public class Player : Character
{

    //int time;
    public static List<Meteor> MeteList = new();

    public static Texture2D rymdskepp = R.LoadTexture("recorces/rymdskepp-small.png");
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
        //sR.DrawRectangleRec(rect, Color.GREEN);
        
        R.DrawTexture(rymdskepp, (int)rect.x, (int)rect.y, Color.WHITE);
        
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

    float timeBetweenMeteors = 1;
    float timeSinceLastMeteor = 0; 


        //hämtar en meteor från metelist varje sekund
public void MeteorSpawn()
{

    timeSinceLastMeteor += Raylib.GetFrameTime();
    if (timeSinceLastMeteor > timeBetweenMeteors)
    {
        GlobalProp.TotalMeteorSpawned++;
        timeSinceLastMeteor = 0;
        if(timeBetweenMeteors>0.5) {
            timeBetweenMeteors = Convert.ToSingle(timeBetweenMeteors - 0.05);
        }
        MeteList.Add(new());
        
    }



}
  //kollar att när spelare och meteor krockar så stänger programmet
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




