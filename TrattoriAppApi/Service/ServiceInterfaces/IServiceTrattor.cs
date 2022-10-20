using TrattoriAppApi.Models;

namespace TrattoriAppApi.Service.ServiceInterfaces
{
    public interface IServiceTrattor
    {
        public Trattor Create(IEnumerable<Trattor> trattors);
        public IEnumerable<Trattor> GetAllByFilter(ColorType color);
        public Trattor GetDetail(int id);
        public Trattor Put(int id);
        public IEnumerable<Trattor> Delete(int id);



    }
}
