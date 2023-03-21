public class Meteor : Character
{

    public int TotalMeteorSpawned { get; set; } = 0;



    public Meteor()
    {
        GetSpawn();
        Speed = Convert.ToSingle(10 + (TotalMeteorSpawned * 0.1));
        rect = new(spawn.X, spawn.Y, Heigth, Width);
    }

    public override void Update()
    {

        Movement();

        rect.x += movement.X;
        rect.y += movement.Y;


    }

    public override void Draw()
    {
        R.DrawRectangleRec(rect, Color.BLACK);
    }

    public void GetSpawn()
    {
        Random rnd = new Random();

        spawn = new();


        spawn.Y = rnd.Next(100,700);

        spawn.X = -100;
    }


    public override void Movement()
    { 

        movement.X = Speed;
        
    }

    
    
}





