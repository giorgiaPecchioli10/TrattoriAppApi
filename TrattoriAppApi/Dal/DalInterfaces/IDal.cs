using TrattoriAppApi.Models;

namespace TrattoriAppApi.Dal.DalInterfaces
{
    public interface IDal<T>
    {
        public IEnumerable<T> Read();
        public void Write(IEnumerable<T> values);
    }
}
