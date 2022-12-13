using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternPractice.Singleton
{
    public class OrderManagementService
    {
        #region SINGLETON PATTERN

        // Construteur doit etre private
        private static OrderManagementService _instance;
        public OrderManagementService()
        {

        }

        // Accessor du singleton quand on a besoin
        // Doit etre publique
        public static OrderManagementService getInstance()
        {
            if (_instance == null)
                _instance = new OrderManagementService(); // Lazy initialisation, on demande, not at program start
            return _instance;
        }
        #endregion


        #region Class business logic


        //Placeholder
        public void PlaceOrder()
        {
            System.Console.WriteLine("An order has been placed");
        }

        #endregion
    }

}
