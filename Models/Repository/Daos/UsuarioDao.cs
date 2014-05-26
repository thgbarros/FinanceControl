using Barros.FinanceControl.Models.Entities;
using NHibernate;
using System;
using System.Windows.Forms;

namespace Barros.FinanceControl.Models.Repository.Daos {
    
    public class UsuarioDao : BaseCrudDao<Usuario, int>{

        public UsuarioDao(ISession session) : base(session) { }

        public override int getKey(Usuario entity) {
            return entity.Id;
        }

        public override void insert(Usuario usuario) {            
            using (var command = Session.Connection.CreateCommand()) {                
                command.CommandText = "Create user "+usuario.Login+" identified by "+usuario.Senha+
                    " default tablespace users quota unlimited on users";                
                command.ExecuteNonQuery();        
            }

            setGrant(usuario);
            createTableFor(usuario);
        }

        public void lockUser(Usuario usuario){
            using (var command = Session.Connection.CreateCommand()) {                                   
                command.CommandText = "alter user " + usuario.Login + " account lock";
                command.ExecuteNonQuery();                
            }
        }

        public void unLockUser(Usuario usuario) {            
            using (var command = Session.Connection.CreateCommand()) {                
                command.CommandText = "alter user " + usuario.Login + " account unlock";
                command.ExecuteNonQuery();                
            }
        }

        private void setGrant(Usuario usuario) {
            using (var command = Session.Connection.CreateCommand()) {
                command.CommandText = "Grant create session, create table, " +
//                        (usuario.CriaUsuario ? "create user, drop user, " : "") +
                        "create sequence to " + usuario.Login;
                command.ExecuteNonQuery();                
                    
                //O tablespace e o limite já está sendo aplicado no insert do usuário";
                //command.CommandText = "alter user " + usuario.Login + " quota unlimited on users";
                //command.ExecuteNonQuery();
            }
        }

        private void createTableFor(Usuario usuario) {
            using (var command = Session.Connection.CreateCommand()) { 
                command.CommandText = getTabelaCategoriaFor(usuario);
                command.ExecuteNonQuery();
                command.CommandText = getSequenceCategoriaFor(usuario);
                command.ExecuteNonQuery();
                //command.CommandText = getTriggerCategoriaFor(usuario);
                //command.ExecuteNonQuery();

                command.CommandText = getTabelaContaFor(usuario);
                command.ExecuteNonQuery();
                command.CommandText = getSequenceContaFor(usuario);
                command.ExecuteNonQuery();
                //command.CommandText = getTriggerContaFor(usuario);
                //command.ExecuteNonQuery();

                command.CommandText = getTabelaTransacaoFor(usuario);
                command.ExecuteNonQuery();
                command.CommandText = getSequenceTransacaoFor(usuario);
                command.ExecuteNonQuery();
                //command.CommandText = getTriggerTransacaoFor(usuario);
                //command.ExecuteNonQuery();

                command.CommandText = getTabelaOrcamentoFor(usuario);
                command.ExecuteNonQuery();
                command.CommandText = getSequenceOrcamentoFor(usuario);
                command.ExecuteNonQuery();
            }
        }

        private string getTabelaCategoriaFor(Usuario usuario){
            return "create table " + usuario.Login + ".categoria(" +
                        "id number not null," +
                        "descricao varchar2(100) not null," +
                        "categoria_pai number," +
                        "tipo_categoria number not null," +
                        "constraint pk_categoria_id primary key(id)," +
                        "constraint fk_categoria_pai foreign key(categoria_pai) references " + usuario.Login + ".categoria(id))";

        }

        private string getSequenceCategoriaFor(Usuario usuario) {
            return "create sequence " + usuario.Login + ".seq_cat_id " +
                        "increment by 1 start with 1 nocache";
        }

        //private string getTriggerCategoriaFor(Usuario usuario) { 
        //    return "create trigger "+usuario.Login+".trg_cat_seq "+
        //               "before insert on "+usuario.Login+".categoria "+
        //               "for each row "+
        //               "begin "+
        //                    "select "+usuario.Login+".seq_cat_id.nextVal into :new.id from dual; "+
        //                "end;";
        //}

        private string getTabelaContaFor(Usuario usuario) {
            return "create table " + usuario.Login + ".conta(" +
                "id number not null," +
                "descricao varchar2(100) not null," +
                "saldoInicial number(9,2) default 0.0," +
                "dataSaldoInicial date default sysdate,"+
                "constraint pk_conta_id primary key(id))";
        }

        private string getSequenceContaFor(Usuario usuario) {
            return "create sequence " + usuario.Login + ".seq_conta_id " +
                        "increment by 1 start with 1 nocache";
        }

        //private string getTriggerContaFor(Usuario usuario) {
        //    return "create trigger " + usuario.Login + ".trg_conta_seq " +
        //               "before insert on " + usuario.Login + ".conta " +
        //               "for each row " +
        //               "begin " +
        //                    "select " + usuario.Login + ".seq_conta_id.nextVal into :new.id from dual; " +
        //                "end;";
        //}

        private string getTabelaTransacaoFor(Usuario usuario) {
            return "create table " + usuario.Login + ".transacao(" +
                "id number not null," +
                "data_transacao date default sysdate," +
                "descricao varchar2(300)," +
                "categoria_id number not null," +
                "conta_id number not null," +
                "valor number(9,2) not null,"+
                "constraint pk_transacao_id primary key(id)," +
                "constraint fk_categoria_id foreign key(categoria_id) references " + usuario.Login + ".categoria(id)," +
                "constraint fk_conta_id foreign key(conta_id) references " + usuario.Login + ".conta(id))";
        }

        private string getSequenceTransacaoFor(Usuario usuario) {
            return "create sequence " + usuario.Login + ".seq_trans_id " +
                        "increment by 1 start with 1 nocache";
        }

        //private string getTriggerTransacaoFor(Usuario usuario) {
        //    return "create trigger " + usuario.Login + ".trg_trans_seq " +
        //               "before insert on " + usuario.Login + ".transacao " +
        //               "for each row " +
        //               "begin " +
        //                    "select " + usuario.Login + ".seq_trans_id.nextVal into :new.id from dual; " +
        //                "end;";
        //}

        private string getTabelaOrcamentoFor(Usuario usuario) {
            return "create table "+usuario.Login+"orcamento(" +
                        "id number not null," +
                        "descricao varchar2(60) not null," +
                        "tipo_orcamento number default 0," +
                        "valor number(8,2) default 0," +
                        "mes number," +
                        "ano number," +
                        "categoria_id number not null," +
                        "constraint pk_orcamento_id primary key(id)," +
                        "constraint fk_orc_categoria_id foreign key(categoria_id) references "+
                                usuario.Login+"categoria(id))";
        }


        private string getSequenceOrcamentoFor(Usuario usuario) {
            return "create sequence " + usuario.Login + ".seq_orc_id " +
                        "increment by 1 start with 1 nocache";
        }      
   
    }
}
