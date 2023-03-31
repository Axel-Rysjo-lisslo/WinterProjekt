using System;



public class Character
{
    public Rectangle rect;
    public Vector2 spawn ;
    public float Speed { get; set; } 

    
    
    public Vector2 Pos { get; set; }
    public Vector2 movement;
    public int Heigth{ get; set; } = 46;
    public int Width  { get; set; } = 60;

    private static List<Character> allCharacters = new();


    public Character() 
    {
        allCharacters.Add(this);
    }

    public virtual void Update()
    {
    

    }

    public virtual void Draw()
    {
    
    }


    public static void UpdateAll() 
    {
        for (int i = 0; i < allCharacters.Count; i++)
        {
            Character c = allCharacters[i];
            c.Update();
        }

        
        
    }

    public  static void DrawAll()
    {

        for (int i = 0; i < allCharacters.Count; i++)
        {
            Character c = allCharacters[i];
            c.Draw();
            
        }


    }
    public virtual void Movement()
    {
        
    }
}

