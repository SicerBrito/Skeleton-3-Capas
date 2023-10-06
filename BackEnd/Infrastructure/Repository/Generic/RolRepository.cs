using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repository;
public class RolRepository : GenericRepository<Rol>, IRol
{
    private readonly DbAppContext _Context;
    public RolRepository(DbAppContext context) : base(context)
    {
        _Context = context;
    }
}
