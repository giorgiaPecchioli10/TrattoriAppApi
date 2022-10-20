using TrattoriAppApi.Dal.DalInterfaces;
using TrattoriAppApi.Models;
using TrattoriAppApi.Service.ServiceInterfaces;

namespace TrattoriAppApi.Service
{
    public class ServiceTrattor : IServiceTrattor
    {
        private readonly IEnumerable<Trattor> _trattors = new List<Trattor>();
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

        public IEnumerable<Trattor> DeleteTrattor(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Trattor> GetTrattorsByColor(ColorType color)
        {
            throw new NotImplementedException();
        }

        public Trattor GetTrattorDetail(int id)
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
