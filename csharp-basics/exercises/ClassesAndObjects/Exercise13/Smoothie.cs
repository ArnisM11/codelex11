using System;

public class Smoothie
{
	string[] _ingredients = new string[0];
	public Smoothie(string[] ingredients)
	{
		this._ingredients = ingredients;
	}
	public void Ingredients()
	{
		foreach(string ingredient in _ingredients)
		{
			Console.WriteLine(ingredient+ " ");
		}
	}
	public double GetCost()
	{
		double totalCost = 0;
		foreach (string ingredient in _ingredients)
		{
			switch (ingredient)
			{
				case ("Strawberries"):
					{
						totalCost += 1.50;
						break;
					}
				case ("Banana"):
					{
						totalCost += 0.5;
						break;
					}
				case ("Mango"):
					{
						totalCost += 2.50;
						break;
					}
				case ("Blueberries"):
					{
						totalCost += 1.00;
						break;
					}
				case ("Raspberries"):
					{
						totalCost += 1.00;
						break;
					}
				case ("Apple"):
					{
						totalCost += 1.70;
						break;
					}
				case ("Pineapple"):
					{
						totalCost += 3.50;
						break;
					}
				default:
					break;
			}
		}
        return totalCost;
    }
		public double GetPrice()
		{
			return GetCost() * 1.5 + GetCost();
		}
		public string GetName()
		{
			List<string> res = _ingredients.ToList();
			res.Sort();
			for (int i = 0;i<res.Count;i++)
			{
				if (_ingredients[i].Contains("berries"))
				{
				_ingredients[i] = _ingredients[i].Replace("berries", "berry");
				}
			}
			if (res.Count() > 1)
			{
				res.Add("Fusion");
			}
			else res.Add("Smoothie");
			return string.Join(" ", res.ToArray());
		}
		
	
}
