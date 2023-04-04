public  class Meteor : Character
{

    //public static int TotalMeteorSpawned { get; set; } = 0;
    public int dirX { get; set; }
    public int dirXSpeed { get; set; }

    
   public static Texture2D meteorit = R.LoadTexture("recorces/meteor-small.png");

    
    //Säger åt meteor att öka med 0,5 varje gång det spawnar en ny och så att den inte går över 20 i hastighet
    public Meteor()
    {
        GetSpawn();
        if(GlobalProp.BaseSpeed < 20) {
            GlobalProp.BaseSpeed = Convert.ToSingle(10 + (GlobalProp.TotalMeteorSpawned * 0.2));
            Console.WriteLine(GlobalProp.BaseSpeed);
        } else {
            GlobalProp.BaseSpeed = 20;
        }
        Console.WriteLine(GlobalProp.BaseSpeed);
        rect = new(spawn.X, spawn.Y, Heigth, Width);
        // Console.WriteLine(GlobalProp.TotalMeteorSpawned);
    }

    public override void Update()
    {

        Movement();

        rect.x += movement.X;
        rect.y += movement.Y;


    }

    public override void Draw()
    {
        
       // R.DrawRectangleRec(rect, Color.BLACK);
        R.DrawTexture(meteorit, (int)rect.x, (int)rect.y, Color.WHITE);
        
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

//kollar så att hastigheten på meteoriten ökar 
    public override void Movement()
    { 

        movement.X = GlobalProp.BaseSpeed*dirXSpeed;

        
    }

    
    
}





