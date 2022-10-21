using TrattoriAppApi.Models;

namespace TrattoriAppApi.Service.ServiceInterfaces
{
    public interface IServiceTrattor
    {
        public Trattor AddTrattor(PostTrattorModel postTrattorModel);
        public IEnumerable<Trattor>? GetTrattorsByColor(string color);
        public Trattor? GetTrattorDetail(int id);
        public Trattor PutTrattor(int id);
        public IEnumerable<Trattor> DeleteTrattor(int id);



    }
}
