using System.Collections.Generic;

namespace Most_popular_pizza_configurations
{
    /// <summary>Represents the pizza object.</summary>
    class Pizza
    {
        #region Properties
        /// <summary>The list of toppings.</summary>              
        public List<string> toppings { get; set; }

        /// <summary>The identifier.</summary>
        public string Identifier { get; set; }
        #endregion
    }
}
