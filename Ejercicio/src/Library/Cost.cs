//-------------------------------------------------------------------------------
// <copyright file="Equipment.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

//Usamos el patron Expert y el principio SRP

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class RecipeCost
    {
        public static double GetProductionCost(Recipe recipe)
        {
            double finalPrice = 0;
            foreach (Step step in recipe.Steps)
            {
                //Calculamos el precio por paso haciendo el costo por hora divido 3600 (para pasarlo a segundos) y despues lo multiplicamos por el tiempo utilizado
                double stepCost = (step.Equipment.HourlyCost / 3600 * step.Time) + step.Input.UnitCost;
                finalPrice += stepCost;
            }
            return finalPrice;
        }
    }
}