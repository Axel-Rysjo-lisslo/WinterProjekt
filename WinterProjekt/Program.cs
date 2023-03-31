global using System;
global using System.Numerics;
global using Raylib_cs;
global using R = Raylib_cs.Raylib;



Raylib.InitWindow(1600,800,"spelFönster");
Raylib.SetTargetFPS(60);

Image backgroundImage = R.LoadImage("recorces/space.png");

Texture2D backgroundTexture = R.LoadTextureFromImage(backgroundImage);
R.UnloadImage(backgroundImage);

Player p = new Player();


while (!R.WindowShouldClose()) {

    R.BeginDrawing();
    R.ClearBackground(Color.BLACK);
   // Console.WriteLine("test");
    R.DrawTexture(backgroundTexture,0,0, Color.WHITE);


    Character.UpdateAll();
    Character.DrawAll();

    R.EndDrawing();
}