using Core.Entities;

namespace Core.Interfaces;
    public interface IUsuario : IGenericRepository<Usuario>{

        Task<Usuario> GetByUsernameAsync(string username);
        Task<Usuario> GetByRefreshTokenAsync(string username);
        
    }
