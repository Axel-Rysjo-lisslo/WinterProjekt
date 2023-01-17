global using System;
global using System.Numerics;
global using Raylib_cs;
global using R = Raylib_cs.Raylib;
// hur strort spelförnstret är 
Raylib.InitWindow(1600,800,"spelFönster");
Raylib.SetTargetFPS(60);

Player p = new Player();
meteor m = new meteor();

while (!R.WindowShouldClose()) {
//börjar rita backgrund, player och meteor
    R.BeginDrawing();
    R.ClearBackground(Color.WHITE);
//ritar ut player och meteror
    R.DrawRectangle((int)p.pos.X, (int)p.pos.Y, p.width, p.heigth, Color.GREEN);
    R.DrawRectangle((int)m.pos.X,(int)m.pos.Y,m.width,m.heigth,Color.BLACK);

p.Update();
    R.EndDrawing();
  


}



    
Console.ReadLine();
