using Barros.FinanceControl.Models.Repository.Daos;
using Barros.FinanceControl.Models.Service;
using System;
using Tecnomotor.InjectorTestPC.Models.Repositories;

namespace Barros.FinanceControl.Models.Entities {
    
    public class UsuarioLogado {

        private static UsuarioLogado usuarioLogado;

        private UsuarioLogado() { }

        private Usuario usuario;

        public void login(Usuario usuario) {
            this.usuario = null;
            try {
                FluentlySessionFactory factory = FluentlySessionFactory.getInstanceFor(usuario);
                this.usuario = usuario;
            } catch (Exception ex) {
                FluentlySessionFactory.setNullInstance();
                FluentlySysSessionFactory factory = FluentlySysSessionFactory.getInstance(usuario);
                
                //ATENÇÂO ISSO É UMA GAMBI
                //Foi necessário essa verificação pois se tentar logar com usuário inválido com privilégio SYSDBA
                //O driver do oracle esta criando a conexão banco, o que não pode, pois o mesmo deveria retornar uma 
                //exception;
                try {
                    UsuarioService service = new UsuarioService(new UsuarioDao(factory.Session));
                    service.getAllUserFinanceControl();
                    service = null;
                    this.usuario = usuario;
                } catch (Exception e) {
                    FluentlySysSessionFactory.setNullInstance();
                    throw e;
                }
            }               
        }

        public void logout() {
            this.usuario = null;
            FluentlySessionFactory.setNullInstance();
            FluentlySysSessionFactory.setNullInstance();
        }

        public Boolean isLogged() {
            return this.usuario != null;           
        }

        public Usuario getUsuario() {
            return this.usuario;
        }

        public static UsuarioLogado getInstance() {
            if (usuarioLogado == null)
                usuarioLogado = new UsuarioLogado();

            return usuarioLogado;
            
        }

    }
}
