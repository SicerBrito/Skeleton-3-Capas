using Infrastructure.Repository;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.UnitOfWork;
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly DbAppContext ? _Context;
        public UnitOfWork(DbAppContext context){
            _Context = context;
        }



        private RolRepository ? _Rol;
        private UsuarioRepository ? _Usuario;
        private UsuariosRolesRepository ? _UsuariosRoles;



        
        public IRol ? Roles => _Rol ??= new RolRepository(_Context!);
        public IUsuario ? Usuarios => _Usuario ??= new UsuarioRepository(_Context!);
        public IUsuarioRoles UsuariosRoles => _UsuariosRoles ??= new UsuariosRolesRepository(_Context!);



        public void Dispose(){
            _Context!.Dispose();
            GC.SuppressFinalize(this); 
        }

        public Task<int> SaveAsync(){
            return _Context!.SaveChangesAsync();
        }
    }
