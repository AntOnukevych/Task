using System.Collections.Generic;
using System.Linq;

namespace Most_popular_pizza_configurations
{
    /// <summary>Represents class for extension methods.</summary>
    static class Extensions
    {
        #region Extension Methods
        /// <summary>
        /// Counts ordered pizzas by toppings.
        /// </summary>
        /// <param name="pizzas">The list of ordered pizzas.</param>
        /// <returns>
        /// Returns the list of uniq pizzas with number of orders.
        /// </returns>       
        public static List<PizzaCounter> CountPizzas(this List<Pizza> pizzas)
        {
            List<PizzaCounter> pizzaCounter = new List<PizzaCounter>();

            pizzas.ForEach(p =>
            {
                p.Identifier = string.Join("", p.toppings.OrderBy(s => s))
                    .Trim();

                PizzaCounter counter = pizzaCounter
                    .SingleOrDefault(c => c.Pizza.Identifier == p.Identifier);

                if (counter == null)
                {
                    pizzaCounter.Add(new PizzaCounter() { Pizza = p, Count = 1 });
                }
                else
                {
                    counter.Count++;
                }
            });

            return pizzaCounter;
        }
        #endregion
    }
}