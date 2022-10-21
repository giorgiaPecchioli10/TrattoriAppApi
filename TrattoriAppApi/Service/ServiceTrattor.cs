using TrattoriAppApi.Dal.DalInterfaces;
using TrattoriAppApi.Models;
using TrattoriAppApi.Service.ServiceInterfaces;

namespace TrattoriAppApi.Service
{
    public class ServiceTrattor : IServiceTrattor
    {
        private  IEnumerable<Trattor> _trattors = new List<Trattor>();
        private readonly IDal<Trattor> _dalTrattor;

        public ServiceTrattor(IDal<Trattor> dalTrattor)
        {
            _dalTrattor = dalTrattor;
        }
        public Trattor AddTrattor(PostTrattorModel postTrattorModel)
        {
            var trattorMap = new Trattor();
            trattorMap.TrattorId = GetTrattorId();
            trattorMap.Type = postTrattorModel.Type;
            trattorMap.Color = postTrattorModel.Color;

            var trattors = _dalTrattor.Read().ToList();
            trattors.Add(trattorMap);
            _dalTrattor.Write(trattors);
            return trattorMap;

        }

        public Trattor? GetTrattorDetail(int trattorId)
        {
            var trattors = _dalTrattor.Read().ToList();
           var trattorDetail = trattors.FirstOrDefault(trattor => trattor.TrattorId == trattorId);

            return trattorDetail;
        }

        public IEnumerable<Trattor>? GetTrattorsByColor(string color)
        {
            var trattors = _dalTrattor.Read().ToList();
            var trattorsColor = trattors.Where(trattor => trattor.Color.Contains(color));
            return trattorsColor;
        }

        public IEnumerable<Trattor> DeleteTrattor(int id)
        {
            throw new NotImplementedException();
        }




        public Trattor PutTrattor(int id)
        {
            throw new NotImplementedException();
        }

        private int GetTrattorId()
        {
            if (_dalTrattor.Read().Count() == 0)
                return 0;
            return _dalTrattor.Read().Max(trattor => trattor.TrattorId) + 1;
        }
    }
}
