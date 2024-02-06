using Entities.Concrete;

namespace Business.Abstract;

public interface ISupplierService<T> where T:Person
{
    void GiveMask(T person);
}