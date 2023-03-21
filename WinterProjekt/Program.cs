global using System;
global using System.Numerics;
global using Raylib_cs;
global using R = Raylib_cs.Raylib;
// 
Raylib.InitWindow(1600,800,"spelFönster");
Raylib.SetTargetFPS(60);

Player p = new Player();

while (!R.WindowShouldClose()) {
//
    R.BeginDrawing();
    R.ClearBackground(Color.WHITE);
//
    Character.UpdateAll();
    Character.DrawAll();

    R.EndDrawing();
}