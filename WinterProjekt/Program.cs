global using System;
global using System.Numerics;
global using Raylib_cs;
global using R = Raylib_cs.Raylib;
// 
Raylib.InitWindow(1600,800,"spelFönster");
Raylib.SetTargetFPS(60);

Player p = new Player();
Meteor m = new Meteor();

while (!R.WindowShouldClose()) {
//
    R.BeginDrawing();
    R.ClearBackground(Color.WHITE);
//
    R.DrawRectangle((int)p.Pos.X, (int)p.Pos.Y, p.Width, p.Heigth, Color.GREEN);
    R.DrawRectangle((int)m.pos.X,(int)m.pos.Y,m.Width,m.Heigth,Color.BLACK);

p.Update();
    R.EndDrawing();
  


}



    
Console.ReadLine();
