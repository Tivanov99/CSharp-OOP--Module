using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
        private double whiteflour = 1.5;
        private double wholegrainFlour = 1;
        private double crispyTechnique = 0.9;
        private double chewyTechnique = 1.1;
        private double homeMadeTechnique = 1.0;
        private string flourType;
        private string technique;
        private double weight;
        public Dough(string flourType, string technique, double weight)
        {
            FlourType = flourType;
            Technique = technique;
            Weight = weight;
        }
        public string FlourType
        {
            get => this.flourType;
            private set
            {
                try
                {
                    Validations.ChekForInvalidFlourType(value.ToLower());
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
                this.flourType = value;
            }
        }
        public string Technique
        {
            get => this.technique;
            private set
            {
                try
                {
                    Validations.ChekForInvalidTechnique(value.ToLower());
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);

                }
                this.technique = value;
            }
        }
        public double Weight
        {
            get => this.weight;
            private set
            {
                try
                {
                    Validations.CheckWeightOFDough(value);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);

                }
                this.weight = value;
            }
        }


        public double CalloriesPerGram()
        {
            return (weight * 2) * CheckFlour() * ChekTechnique();
        }
        private double CheckFlour()
        {
            if (this.flourType.ToLower() == "white")
            {
                return this.whiteflour;
            }
            else if (this.flourType.ToLower() == "wholegrain")
            {
                return this.wholegrainFlour;
            }
            return 0;
        }
        private double ChekTechnique()
        {
            if (this.technique.ToLower() == "crispy")
            {
                return this.crispyTechnique;
            }
            else if (this.technique.ToLower() == "chewy")
            {
                return this.chewyTechnique;
            }
            else if (this.technique.ToLower() == "homemade")
            {
                return this.homeMadeTechnique;
            }
            return 0;
        }
    }
}
