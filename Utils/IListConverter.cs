using System.Collections.Generic;

namespace Barros.FinanceControl.Utils {
    
    public static class IListConverter<T> {

        public static List<T> toList(IList<T> iList){
            return (List<T>)iList;
        }
    }
}
