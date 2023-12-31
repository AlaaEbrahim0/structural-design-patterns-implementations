﻿namespace Bridge.ShapesRenderer.Implementors;

public class PaperRenderer : IRenderer
{
    public void RenderCircle(float radius)
    {
        Console.WriteLine($"Printing a circle on paper with radius {radius}.");
    }

    public void RenderSquare(float side)
    {
        Console.WriteLine($"Printing a square on paper with side {side}.");
    }

    public void RenderTriangle(float side)
    {
        Console.WriteLine($"Printing a triangle on paper with side {side}.");

    }
}