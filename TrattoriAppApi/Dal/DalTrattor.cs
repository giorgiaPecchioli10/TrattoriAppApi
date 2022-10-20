using TrattoriAppApi.Dal.DalInterfaces;
using TrattoriAppApi.Models;

namespace TrattoriAppApi.Dal
{
    public class DalTrattor : IDal<Trattor>
    {
        private static IEnumerable<Trattor> _trattorsList = new List<Trattor>();
        public IEnumerable<Trattor> Read()
        {
            return _trattorsList;
        }

        public void Write(IEnumerable<Trattor> trattors)
        {
            if (trattors != null)
                _trattorsList = trattors;
            
        }
    }
}
