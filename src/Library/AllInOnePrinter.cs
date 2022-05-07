//---------------------------------------------------------------------------------
// <copyright file="AllInOnePrinter.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------
using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    public enum Destination
    {
        Console,
        File
    }

    public class AllInOnePrinter
    {
        public void PrintRecipeConsole(Recipe recipe)
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }
        public void PrintRecipeFile(Recipe recipe)
        {
            File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
        }
    }
}

//--------------------------------------------------------------------------------------------------------
// Solución del problema.
// 
// Use polimorfismo.
//--------------------------------------------------------------------------------------------------------