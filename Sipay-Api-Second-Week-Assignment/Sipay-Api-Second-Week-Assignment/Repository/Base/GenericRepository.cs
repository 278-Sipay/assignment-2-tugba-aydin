using System.Linq.Expressions;

namespace Sipay_Api_Second_Week_Assignment;

public class GenericRepository<Entity> : IGenericRepository<Entity> where Entity : BaseModel
{
    private readonly SimDbContext dbContext;
    public GenericRepository(SimDbContext _dbContext)
    {
        dbContext = _dbContext;
    }

    public List<Entity> GetByParameter(Expression<Func<Entity, bool>> expression)
    {
        return dbContext.Set<Entity>().Where(expression.Compile()).ToList();
    }
}
