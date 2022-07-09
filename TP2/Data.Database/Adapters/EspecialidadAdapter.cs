using Business.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database.Adapters
{
    public class EspecialidadAdapter : Adapter
    {
        public List<Especialidad> GetAll()
        {

            //return new List<Usuario>(Usuarios);
            ///
            // Instanciamos el objeto lista a retornar
            List<Especialidad> Especialidades = new List<Especialidad>();


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

                SqlCommand cmdEspecialidades = new SqlCommand("select * from especialidad", sqlConn);
                // 
                //instanciamos un objeto DataReader que será
                //   el que recuperará los datos de la BD
                //

                SqlDataReader drEspecialidades = cmdEspecialidades.ExecuteReader();

                // Read() lee una fila de las devueltas por el comando sql
                // carga los datos en drUsuarios para poder accederlos,"
                // devuelve verdadero mientras haya podido leer datos
                // y avanza a la fila siguiente para el próximo read
                //
                while (drEspecialidades.Read())
                {
                    /// 
                    //  creamos un objeto Usuario de la capa de entidades para copiar
                    //  los datos de la fila del DataRead er al objeto de entidades
                    //
                    Especialidad esp = new Especialidad();

                    //ahora copiamos los datos de la fila al objeto

                    esp.IdEspecialidad = (int)drEspecialidades["id_especialidad"];
                    esp.NombreEspecialidad = (string)drEspecialidades["nombre_especialidad"];
                    esp.Alta = (bool)drEspecialidades["alta"];

                    //agregarnos el objeto con datos a la lista que devolveremos
                    Especialidades.Add(esp);
                }
                //cerramos la el DataReader y la conexión a la BD

                drEspecialidades.Close();

            }

            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de especialidades", Ex);
                throw ExcepcionManejada;
            }

            finally
            {
                this.CloseConnection();
            }

            //devolvemos el objeto
            return Especialidades;
        }

        public Especialidad GetOneId(int ID)
        {
            //return Usuarios.Find(delegate(Usuario u) { return u.ID == ID; });
            Especialidad esp = new Especialidad();
            try
            {
                OpenConnection();
                SqlCommand cmdEspecialidades = new SqlCommand("SELECT * FROM especialidad WHERE id_especialidad = @id_especialidad", sqlConn);
                cmdEspecialidades.Parameters.Add("@id_especialidad", SqlDbType.Int).Value = ID;
                SqlDataReader drEspecialidades = cmdEspecialidades.ExecuteReader();
                while (drEspecialidades.Read())
                {
                    esp.IdEspecialidad = (int)drEspecialidades["id_especialidad"];
                    esp.NombreEspecialidad = (string)drEspecialidades["nombre_especialidad"];
                    esp.Alta = (bool)drEspecialidades["alta"];
                }
                drEspecialidades.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de especialidad", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
            if (esp.NombreEspecialidad != null)
            {
                return esp;
            }
            else
            {
                Exception Ex = new Exception(" ");
                throw new Exception("La especialidad no existe", Ex);
            }

        }

        //Suponemos que es usuario unico
        public Especialidad GetOneEspecialidad(string nombre_especialidad)
        {
            Especialidad esp = new Especialidad();
            try
            {
                OpenConnection();
                SqlCommand cmdEspecialidades = new SqlCommand("SELECT * FROM especialidad WHERE nombre_especialidad = @nombre_especialidad", sqlConn);
                cmdEspecialidades.Parameters.Add("@nombre_especialidad", SqlDbType.VarChar).Value = nombre_especialidad;
                SqlDataReader drEspecialidades = cmdEspecialidades.ExecuteReader();
                while (drEspecialidades.Read())
                {
                    esp.IdEspecialidad = (int)drEspecialidades["id_especialidad"];
                    esp.NombreEspecialidad = (string)drEspecialidades["nombre_especialidad"];
                    esp.Alta = (bool)drEspecialidades["alta"];
                }
                drEspecialidades.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de especialidad", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
            if (esp.NombreEspecialidad != null)
            {
                return esp;
            }
            else
            {
                Exception Ex = new Exception(" ");
                throw new Exception("La especialidad no existe", Ex);
            }
        }

        public void Delete(int ID)
        {
            ////Usuarios.Remove(this.GetOne(ID));
            try
            {
                OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete especialidad where id_especialidad = @id_especialidad", sqlConn);
                cmdDelete.Parameters.Add("@id_especialidad", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManjeada = new Exception("Error al eliminar especialidad", Ex);
                throw ExcepcionManjeada;
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Save(Especialidad especialidad)
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
            if (especialidad.State == BusinessEntity.States.Deleted)
            {
                Delete(especialidad.IdEspecialidad);
            }

            else if (especialidad.State == BusinessEntity.States.New)
            {
                Insert(especialidad);
            }
            else if (especialidad.State == BusinessEntity.States.Modified)
            {
                Update(especialidad);
            }
            especialidad.State = BusinessEntity.States.Unmodified;
        }

        protected void Insert(Especialidad especialidad)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO especialidad (nombre_especialidad,alta)" +
                    "values(@nombre_especialidad,@alta)" +
                    "select @@identity ", sqlConn);

                cmdSave.Parameters.Add("@nombre_especialidad", SqlDbType.VarChar, 15).Value = especialidad.NombreEspecialidad;
                cmdSave.Parameters.Add("@alta", SqlDbType.Bit).Value = especialidad.Alta;

                especialidad.IdEspecialidad = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
                //cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al crear la especialidad", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }
        }

        protected void Update(Especialidad especialidad)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE especialidad SET nombre_especialidad = @nombre_especialidad, alta = @alta " +
                    "WHERE id_especialidad = @id_especialidad ", sqlConn);

                cmdSave.Parameters.Add("@id_especialidad", SqlDbType.Int).Value = especialidad.IdEspecialidad;
                cmdSave.Parameters.Add("@nombre_especialidad", SqlDbType.VarChar, 15).Value = especialidad.NombreEspecialidad;
                cmdSave.Parameters.Add("@alta", SqlDbType.Bit).Value = especialidad.Alta;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al modificar datos de la especialidad", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }

        }
    }
}