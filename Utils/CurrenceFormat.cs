using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barros.FinanceControl.Utils {
    
    public static class CurrencyFormat  {

        public static String doubleToString(double saldo)   {            
            try {
                return String.Format("{0:n}", saldo); 
            }  catch (FormatException fe) {                
                return "0,00";
            }
        }
    }
}
