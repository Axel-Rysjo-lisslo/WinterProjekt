public  class Meteor : Character
{

    //public static int TotalMeteorSpawned { get; set; } = 0;


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

        spawn.X = -100;
    }


    public override void Movement()
    { 

        movement.X = Speed;
        
    }

    
    
}





