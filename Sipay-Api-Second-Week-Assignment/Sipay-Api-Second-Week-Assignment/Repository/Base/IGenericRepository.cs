using System.Linq.Expressions;

namespace Sipay_Api_Second_Week_Assignment;

public interface IGenericRepository<Entity> where Entity : class
{
    IQueryable<Entity> GetByParameter(Expression<Func<Entity, bool>> expression);
}
