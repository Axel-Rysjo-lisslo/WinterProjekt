public  class Meteor : Character
{

    //public static int TotalMeteorSpawned { get; set; } = 0;
    public int dirX { get; set; }
    public int dirXSpeed { get; set; }

    //Säger åt meteor att öka med 0,5 varje gång det spawnar en ny
    public Meteor()
    {
        GetSpawn();
        Speed = Convert.ToSingle(10 + (GlobalProp.TotalMeteorSpawned * 0.5));
        rect = new(spawn.X, spawn.Y, Heigth, Width);
        Console.WriteLine(GlobalProp.TotalMeteorSpawned);
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
    
    //Spawnar en meteor random på y axel mellan 100 och 700 
    public void GetSpawn()
    {
        Random rnd = new Random();

        spawn = new();

        spawn.Y = rnd.Next(100,700);

        Random rndX = new Random();

        dirX = rndX.Next(0,10);

    Console.WriteLine(dirX);

        if (dirX > 5) 
        {
            spawn.X = -100;
            dirXSpeed = 1;
        } else {
            spawn.X = 1700;
            dirXSpeed = -1;
        }

        
    }


    public override void Movement()
    { 

        movement.X = Speed*dirXSpeed;
        
    }

    
    
}





