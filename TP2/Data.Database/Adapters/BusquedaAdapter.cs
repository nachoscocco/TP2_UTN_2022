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
    public class BusquedaAdapter : Adapter
    {
        public List<Busqueda> GetAll()
        {
            List<Busqueda> busquedas = new List<Busqueda>();
            try
            { 
                OpenConnection();

                SqlCommand cmdBusqueda = new SqlCommand("select * from busqueda", sqlConn);


                SqlDataReader drBusqueda = cmdBusqueda.ExecuteReader();

                while (drBusqueda.Read())
                {
                 
                    Busqueda bsq = new Busqueda()
                    {
                        NroBusqueda = (int)drBusqueda["nro_busqueda"],
                        DetalleAmpliado = (string)drBusqueda["detalle_ampliado"],
                        Tipo = (bool)drBusqueda["tipo"],
                        Habilitado = (bool)drBusqueda["habilitado"],
                        Nombre = (string)drBusqueda["nombre"],
                        FechaDesde = (DateTime)drBusqueda["fecha_desde"],
                        FechaHasta = (DateTime)drBusqueda["fecha_hasta"],
                    };

                    busquedas.Add(bsq);
                }
     
                drBusqueda.Close();

            }

            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de busquedas", Ex);
                throw ExcepcionManejada;
            }

            finally
            {
                CloseConnection();
            }

            //devolvemos el objeto
            return busquedas;

        }

        public Busqueda GetOneById(int nro_busqueda)
        {
            Busqueda bsq = new Busqueda(); 
            try
            {
                OpenConnection();
                
                SqlCommand cmdBusqueda = new SqlCommand("SELECT * FROM busqueda WHERE nro_busqueda = @nro_busqueda", sqlConn);
                
                cmdBusqueda.Parameters.Add("@nro_busqueda", SqlDbType.Int).Value = nro_busqueda;

                SqlDataReader drBusqueda = cmdBusqueda.ExecuteReader();
                
                while (drBusqueda.Read())
                {
                    bsq.NroBusqueda = (int)drBusqueda["nro_busqueda"];
                    bsq.DetalleAmpliado = (string)drBusqueda["detalle_ampliado"];
                    bsq.Tipo = (bool)drBusqueda["tipo"];
                    bsq.Nombre = (string)drBusqueda["nombre"];
                    bsq.FechaDesde = (DateTime)drBusqueda["fecha_desde"];
                    bsq.FechaHasta = (DateTime)drBusqueda["fecha_hasta"];
                    bsq.Habilitado = (bool)drBusqueda["habilitado"];
                }

                drBusqueda.Close();
            }
            catch (Exception Ex)
            {  
                throw new Exception("Error al recuperar datos de busqueda", Ex);
            }
            finally
            {
                CloseConnection();
            }
            if (bsq != null)
                return bsq;
            else
                return null;
        }

        //Suponemos que es busqueda unico
        public Busqueda GetOneByNombre(string nombre)
        {
            Busqueda bsq = new Busqueda();
            try
            {
                OpenConnection();
                
                SqlCommand cmdBusqueda = new SqlCommand("SELECT * FROM busqueda WHERE nombre = @nombre", sqlConn);
                
                cmdBusqueda.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;
                
                SqlDataReader drBusqueda = cmdBusqueda.ExecuteReader();
                
                while (drBusqueda.Read())
                {
                    bsq.NroBusqueda = (int)drBusqueda["nro_busqueda"];
                    bsq.DetalleAmpliado = (string)drBusqueda["detalle_ampliado"];
                    bsq.Tipo = (bool)drBusqueda["tipo"];
                    bsq.Nombre = (string)drBusqueda["nombre"];
                    bsq.FechaDesde = (DateTime)drBusqueda["fecha_desde"];
                    bsq.FechaHasta = (DateTime)drBusqueda["fecha_hasta"];
                    bsq.Habilitado = (bool)drBusqueda["habilitado"];
                }
                drBusqueda.Close();
            }
            catch (Exception Ex)
            {
                throw new Exception("Error al recuperar datos de busqueda", Ex);
            } 
            finally
            {
                CloseConnection();
            }
            if (bsq != null)
                return bsq;
            else
                return null;
        }


        public void Delete(int nro_busqueda)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("UPDATE busqueda SET habilitado = 0" +
                                                      "WHERE nro_busqueda = @nro_busqueda", sqlConn);
                cmdDelete.Parameters.Add("@nro_busqueda", SqlDbType.Int).Value = nro_busqueda;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                throw new Exception("Error al dar de baja al busqueda", Ex);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Save(Busqueda busqueda)        
        {
            if (busqueda.State == BusinessEntity.States.Deleted)
            {
                Delete(busqueda.NroBusqueda);
            }

            else if (busqueda.State == BusinessEntity.States.New)
            {
                Insert(busqueda);
            }
            else if (busqueda.State == BusinessEntity.States.Modified)
            {
                Update(busqueda);
            }
            busqueda.State = BusinessEntity.States.Unmodified;
        }

        protected void Insert(Busqueda busqueda)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO busqueda (tipo,nombre,habilitado,detalle_ampliado,fecha_desde,fecha_hasta)" +
                    "values(@tipo,@nombre,@habilitado,@detalle_ampliado,@fecha_desde,@fecha_hasta)" +
                    "select @@identity ", sqlConn);

                cmdSave.Parameters.Add("@tipo", SqlDbType.Bit).Value = busqueda.Tipo;
                cmdSave.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = busqueda.Nombre;
                cmdSave.Parameters.Add("@habilitado", SqlDbType.Bit).Value = busqueda.Habilitado;
                cmdSave.Parameters.Add("@detalle_ampliado", SqlDbType.VarChar, int.MaxValue).Value = busqueda.DetalleAmpliado;
                cmdSave.Parameters.Add("@fecha_desde", SqlDbType.DateTime).Value = busqueda.FechaDesde;
                cmdSave.Parameters.Add("@fecha_hasta", SqlDbType.DateTime).Value = busqueda.FechaHasta;

                busqueda.NroBusqueda = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());

                //cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al crear busqueda", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }
        }

        protected void Update(Busqueda busqueda)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE busqueda SET tipo = @tipo, nombre = @nombre, " +
                    "habilitado = @habilitado, detalle_ampliado = @detalle_ampliado " +   //fecha_desde = @fecha_desde, fecha_hasta = @fecha_hasta
                    "WHERE nro_busqueda = @nro_busqueda ", sqlConn);

               cmdSave.Parameters.Add("@nro_busqueda", SqlDbType.Int).Value = busqueda.NroBusqueda;
                cmdSave.Parameters.Add("@tipo", SqlDbType.Bit).Value = busqueda.Tipo;
                cmdSave.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = busqueda.Nombre;
                cmdSave.Parameters.Add("@habilitado", SqlDbType.Bit).Value = busqueda.Habilitado;
                cmdSave.Parameters.Add("@detalle_ampliado", SqlDbType.VarChar, int.MaxValue).Value = busqueda.DetalleAmpliado;
               // cmdSave.Parameters.Add("@fecha_desde", SqlDbType.DateTime).Value = busqueda.FechaDesde;
             //   cmdSave.Parameters.Add("@fecha_hasta", SqlDbType.DateTime).Value = busqueda.FechaHasta;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al modificar datos del busqueda", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }

        }
    }
}
