using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using System.Data.SqlClient;
using System.Data;


namespace Data.Database.Adapters
{
    public class ConocimientoAdapter : Adapter
    {
        public List<Conocimiento> GetAll()
        {

            //return new List<Conocimiento>(Conocimientos);
            ///
            // Instanciamos el objeto lista a retornar
            List<Conocimiento> Conocimientos = new List<Conocimiento>();


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

                SqlCommand cmdConocimientos = new SqlCommand("select * from conocimientos", sqlConn);
                // 
                //instanciamos un objeto DataReader que será
                //   el que recuperará los datos de la BD
                //

                SqlDataReader drConocimientos = cmdConocimientos.ExecuteReader();

                // Read() lee una fila de las devueltas por el comando sql
                // carga los datos en drConocimientos para poder accederlos,"
                // devuelve verdadero mientras haya podido leer datos
                // y avanza a la fila siguiente para el próximo read
                //
                while (drConocimientos.Read())
                {
                    /// 
                    //  creamos un objeto Conocimiento de la capa de entidades para copiar
                    //  los datos de la fila del DataRead er al objeto de entidades
                    //
                    Conocimiento cno = new Conocimiento();

                    //ahora copiamos los datos de la fila al objeto

                    cno.IdConocimiento = (int)drConocimientos["id_conocimiento"];
                    cno.Nombre = (string)drConocimientos["nombre"];
                    cno.Alta = (bool)drConocimientos["alta"];
                    
                    //agregarnos el objeto con datos a la lista que devolveremos
                    Conocimientos.Add(cno);
                }
                //cerramos la el DataReader y la conexión a la BD

                drConocimientos.Close();

            }

            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de Conocimientos", Ex);
                throw ExcepcionManejada;
            }

            finally
            {
                this.CloseConnection();
            }

            //devolvemos el objeto
            return Conocimientos;




        }

        public Business.Entities.Conocimiento GetOneId(int ID)
        {
            //return Conocimientos.Find(delegate(Conocimiento u) { return u.ID == ID; });
            Conocimiento cno = new Conocimiento();
            try
            {
                OpenConnection();
                SqlCommand cmdConocimientos = new SqlCommand("SELECT * FROM conocimientos WHERE id_conocimiento = @id_conocimiento", sqlConn);
                cmdConocimientos.Parameters.Add("@id_conocimiento", SqlDbType.Int).Value = ID;
                SqlDataReader drConocimientos = cmdConocimientos.ExecuteReader();
                while (drConocimientos.Read())
                {
                    cno.IdConocimiento = (int)drConocimientos["id_conocimiento"];
                    cno.Nombre = (string)drConocimientos["nombre"];
                    cno.Alta = (bool)drConocimientos["alta"];
                }
                drConocimientos.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de Conocimiento", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
            if (cno.Nombre != null)
            {
                return cno;
            }
            else
            {
                Exception Ex = new Exception(" ");
                throw new Exception("El Conocimiento no existe", Ex);
            }

        }

        //Suponemos que es Conocimiento unico
        public Business.Entities.Conocimiento GetOneConocimiento(string nombreConocimiento)
        {
            Conocimiento cno = new Conocimiento();
            try
            {
                OpenConnection();
                SqlCommand cmdConocimientos = new SqlCommand("SELECT * FROM conocimientos WHERE nombre = @nombre", sqlConn);
                cmdConocimientos.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombreConocimiento;
                SqlDataReader drConocimientos = cmdConocimientos.ExecuteReader();
                while (drConocimientos.Read())
                {
                    cno.IdConocimiento = (int)drConocimientos["id_conocimiento"];
                    cno.Nombre = (string)drConocimientos["nombre"];
                    cno.Alta = (bool)drConocimientos["alta"];
                }
                drConocimientos.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de Conocimiento", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
            if (cno.Nombre != null)
            {
                return cno;
            }
            else
            {
                Exception Ex = new Exception(" ");
                throw new Exception("El Conocimiento no existe", Ex);
            }
        }


        public void Delete(int ID)
        {
            ////Conocimientos.Remove(this.GetOne(ID));
            try
            {
                OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete conocimientos where id_conocimiento = @id_conocimiento", sqlConn);
                cmdDelete.Parameters.Add("@id_conocimiento", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManjeada = new Exception("Error al eliminar Conocimiento", Ex);
                throw ExcepcionManjeada;
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Save(Conocimiento Conocimiento)
        //{
        //    if (Conocimiento.State == BusinessEntity.States.New)
        //    {
        //        int NextID = 0;
        //        foreach (Conocimiento cno in Conocimientos)
        //        {
        //            if (cno.ID > NextID)
        //            {
        //                NextID = cno.ID;
        //            }
        //        }
        //        Conocimiento.ID = NextID + 1;
        //        Conocimientos.Add(Conocimiento);
        //    }
        //    else if (Conocimiento.State == BusinessEntity.States.Deleted)
        //    {
        //        this.Delete(Conocimiento.ID);
        //    }
        //    else if (Conocimiento.State == BusinessEntity.States.Modified)
        //    {
        //        Conocimientos[Conocimientos.FindIndex(delegate(Conocimiento u) { return u.ID == Conocimiento.ID; })]=Conocimiento;
        //    }
        //    Conocimiento.State = BusinessEntity.States.Unmodified;            
        {
            if (Conocimiento.State == BusinessEntity.States.Deleted)
            {
                Delete(Conocimiento.IdConocimiento);
            }

            else if (Conocimiento.State == BusinessEntity.States.New)
            {
                Insert(Conocimiento);
            }
            else if (Conocimiento.State == BusinessEntity.States.Modified)
            {
                Update(Conocimiento);
            }
            Conocimiento.State = BusinessEntity.States.Unmodified;
        }

        protected void Insert(Conocimiento Conocimiento)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO Conocimientos (nombre,alta)" +
                    "values(@nombre,@alta)" +
                    "select @@identity ", sqlConn);

                cmdSave.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = Conocimiento.Nombre;
                
                cmdSave.Parameters.Add("@alta", SqlDbType.Bit).Value = Conocimiento.Alta;
                

                Conocimiento.IdConocimiento = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());

                //cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al crear Conocimiento", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }
        }

        protected void Update(Conocimiento Conocimiento)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE conocimientos SET nombre = @nombre, alta = @alta" +                
                    "WHERE id_conocimiento = @id ", sqlConn);

                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = Conocimiento.IdConocimiento;
                cmdSave.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = Conocimiento.Nombre;
                cmdSave.Parameters.Add("@alta", SqlDbType.Bit).Value = Conocimiento.Alta;
               
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al modificar datos del Conocimiento", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }

        }
    }
}
