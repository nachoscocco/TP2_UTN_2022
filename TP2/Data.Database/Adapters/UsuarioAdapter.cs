using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using System.Data.SqlClient;
using System.Data;

namespace Data.Database
{
    public class UsuarioAdapter : Adapter
    {
        public List<Usuario> GetAll()
        {

            //return new List<Usuario>(Usuarios);
            ///
            // Instanciamos el objeto lista a retornar
            List<Usuario> Usuarios = new List<Usuario>();


            try
            {
                // abrimos la conexión a la base de datos con el método que creamos antes 
                this.OpenConnection();

                /* 
                 * creamos un objeto SqlCommand que será la sentencia SQL 
                 * que vamos a ejecutar contra la base de datos 
                 * (los datos de la BD usaurio,contraseñam servidor,etc.
                 * están en el connection string)
                 */

                SqlCommand cmdUsuarios = new SqlCommand("select * from usuarios", sqlConn);
                // 
                //instanciamos un objeto DataReader que será
                //   el que recuperará los datos de la BD
                //

                SqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();

                // Read() lee una fila de las devueltas por el comando sql
                // carga los datos en drUsuarios para poder accederlos,"
                // devuelve verdadero mientras haya podido leer datos
                // y avanza a la fila siguiente para el próximo read
                //
                while (drUsuarios.Read())
                {
                    /// 
                    //  creamos un objeto Usuario de la capa de entidades para copiar
                    //  los datos de la fila del DataRead er al objeto de entidades
                    //
                    Usuario usr = new Usuario();

                    //ahora copiamos los datos de la fila al objeto

                    usr.ID = (int)drUsuarios["id"];
                    usr.NombreUsuario = (string)drUsuarios["usuario"];
                    usr.Clave = (string)drUsuarios["clave"];
                    usr.Habilitado = (bool)drUsuarios["habilitado"];
                    usr.Nombre = (string)drUsuarios["nombre"];
                    usr.Apellido = (string)drUsuarios["apellido"];
                    usr.Email = (string)drUsuarios["email"];




                    //agregarnos el objeto con datos a la lista que devolveremos
                    Usuarios.Add(usr);
                }
                //cerramos la el DataReader y la conexión a la BD

                drUsuarios.Close();

            }

            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de usuarios", Ex);
                throw ExcepcionManejada;
            }

            finally
            {
                this.CloseConnection();
            }

            //devolvemos el objeto
            return Usuarios;




        }

        public Business.Entities.Usuario GetOneId(int ID)
        {
            //return Usuarios.Find(delegate(Usuario u) { return u.ID == ID; });
            Usuario usr = new Usuario();
            try
            {
                OpenConnection();
                SqlCommand cmdUsuarios = new SqlCommand("SELECT * FROM usuarios WHERE id_usuario = @id_usuario", sqlConn);
                cmdUsuarios.Parameters.Add("@id_usuario", SqlDbType.Int).Value = ID;
                SqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();
                while (drUsuarios.Read())
                {
                    usr.ID = (int)drUsuarios["id_usuario"];
                    usr.NombreUsuario = (string)drUsuarios["nombre_usuario"];
                    usr.Clave = (string)drUsuarios["clave"];
                    usr.Habilitado = (bool)drUsuarios["habilitado"];
                    usr.Nombre = (string)drUsuarios["nombre"];
                    usr.Apellido = (string)drUsuarios["apellido"];
                    usr.Email = (string)drUsuarios["email"];
                }
                drUsuarios.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de usuario", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
            if (usr.NombreUsuario != null)
            {
                return usr;
            }
            else
            {
                Exception Ex = new Exception(" ");
                throw new Exception("El usuario no existe", Ex);
            }

        }

        //Suponemos que es usuario unico
        public Business.Entities.Usuario GetOneUsuario(string nombreUsuario)
        {
            Usuario usr = new Usuario();
            try
            {
                OpenConnection();
                SqlCommand cmdUsuarios = new SqlCommand("SELECT * FROM usuarios WHERE nombre_usuario = @nombre_usuario", sqlConn);
                cmdUsuarios.Parameters.Add("@nombre_usuario", SqlDbType.VarChar).Value = nombreUsuario;
                SqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();
                while (drUsuarios.Read())
                {
                    usr.ID = (int)drUsuarios["id_usuario"];
                    usr.NombreUsuario = (string)drUsuarios["nombre_usuario"];
                    usr.Clave = (string)drUsuarios["clave"];
                    usr.Habilitado = (bool)drUsuarios["habilitado"];
                    usr.Nombre = (string)drUsuarios["nombre"];
                    usr.Apellido = (string)drUsuarios["apellido"];
                    usr.Email = (string)drUsuarios["email"];
                }
                drUsuarios.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de usuario", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
            if (usr.NombreUsuario != null)
            {
                return usr;
            }
            else
            {
                Exception Ex = new Exception(" ");
                throw new Exception("El usuario no existe", Ex);
            }
        }


        public void Delete(int ID)
        {
            ////Usuarios.Remove(this.GetOne(ID));
            try
            {
                OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete usuarios where id_usuario = @id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManjeada = new Exception("Error al eliminar usuario", Ex);
                throw ExcepcionManjeada;
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Save(Usuario usuario)
        //{
        //    if (usuario.State == BusinessEntity.States.New)
        //    {
        //        int NextID = 0;
        //        foreach (Usuario usr in Usuarios)
        //        {
        //            if (usr.ID > NextID)
        //            {
        //                NextID = usr.ID;
        //            }
        //        }
        //        usuario.ID = NextID + 1;
        //        Usuarios.Add(usuario);
        //    }
        //    else if (usuario.State == BusinessEntity.States.Deleted)
        //    {
        //        this.Delete(usuario.ID);
        //    }
        //    else if (usuario.State == BusinessEntity.States.Modified)
        //    {
        //        Usuarios[Usuarios.FindIndex(delegate(Usuario u) { return u.ID == usuario.ID; })]=usuario;
        //    }
        //    usuario.State = BusinessEntity.States.Unmodified;            
        {
            if (usuario.State == BusinessEntity.States.Deleted)
            {
                Delete(usuario.ID);
            }

            else if (usuario.State == BusinessEntity.States.New)
            {
                Insert(usuario);
            }
            else if (usuario.State == BusinessEntity.States.Modified)
            {
                Update(usuario);
            }
            usuario.State = BusinessEntity.States.Unmodified;
        }

        protected void Insert(Usuario usuario)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO usuarios (nombre_usuario,clave,habilitado,nombre,apellido,email)" +
                    "values(@nombre_usuario,@clave,@habilitado,@nombre,@apellido,@email)" +
                    "select @@identity ", sqlConn);

                cmdSave.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = usuario.NombreUsuario;
                cmdSave.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = usuario.Clave;
                cmdSave.Parameters.Add("@habilitado", SqlDbType.Bit).Value = usuario.Habilitado;
                cmdSave.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = usuario.Nombre;
                cmdSave.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = usuario.Apellido;
                cmdSave.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = usuario.Email;

                usuario.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());

                //cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al crear usuario", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }
        }

        protected void Update(Usuario usuario)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE usuarios SET nombre_usuario = @nombre_usuario, clave = @clave, " +
                    "habilitado = @habilitado, nombre = @nombre, apellido = @apellido, email = @email " +
                    "WHERE id_usuario = @id ", sqlConn);

                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = usuario.ID;
                cmdSave.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = usuario.NombreUsuario;
                cmdSave.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = usuario.Clave;
                cmdSave.Parameters.Add("@habilitado", SqlDbType.Bit).Value = usuario.Habilitado;
                cmdSave.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = usuario.Nombre;
                cmdSave.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = usuario.Apellido;
                cmdSave.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = usuario.Email;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al modificar datos del usuario", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }

        }
    }
}
