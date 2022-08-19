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
    class DomicilioAdapter : Adapter
    {
        public List<Domicilio> GetAll()
        {
            List<Domicilio> domicilios = new List<Domicilio>();
            try
            {
                OpenConnection();

                SqlCommand cmdDomicilio = new SqlCommand("select * from domicilio", sqlConn);


                SqlDataReader drDomicilio = cmdDomicilio.ExecuteReader();

                while (drDomicilio.Read())
                {

                    Domicilio dmc = new Domicilio()
                    {
                        IdDomicilio = (int)drDomicilio["id_domicilio"],
                        Calle = (string)drDomicilio["calle"],
                        Numero = (int)drDomicilio["numero"],
                        EsBis = (bool)drDomicilio["esBis"],
                        Piso = (int)drDomicilio["piso"],
                        Depto = (char)drDomicilio["depto"],
                        Pais = (string)drDomicilio["pais"],
                        Provincia = (string)drDomicilio["provincia"],
                        Localidad = (string)drDomicilio["localidad"],
                        Telefono = (string)drDomicilio["telefono"],
                        Telefono2 = (string)drDomicilio["telefono2"],
                    };

                    domicilios.Add(dmc);
                }

                drDomicilio.Close();

            }

            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de domicilios", Ex);
                throw ExcepcionManejada;
            }

            finally
            {
                CloseConnection();
            }

            //devolvemos el objeto
            return domicilios;

        }

        public Domicilio GetOneById(int id_domicilio)
        {
            Domicilio dmc = new Domicilio();
            try
            {
                OpenConnection();

                SqlCommand cmdDomicilio = new SqlCommand("SELECT * FROM domicilio WHERE id_domicilio = @id_domicilio", sqlConn);

                cmdDomicilio.Parameters.Add("@id_domicilio", SqlDbType.Int).Value = id_domicilio;

                SqlDataReader drDomicilio = cmdDomicilio.ExecuteReader();

                while (drDomicilio.Read())
                {
                    dmc.IdDomicilio = (int)drDomicilio["id_domicilio"];
                    dmc.Calle = (string)drDomicilio["calle"];
                    dmc.Numero = (int)drDomicilio["numero"];
                    dmc.EsBis = (bool)drDomicilio["esBis"];
                    dmc.Piso = (int)drDomicilio["piso"];
                    dmc.Depto = (char)drDomicilio["depto"];
                    dmc.Pais = (string)drDomicilio["pais"];
                    dmc.Provincia = (string)drDomicilio["provincia"];
                    dmc.Localidad = (string)drDomicilio["localidad"];
                    dmc.Telefono = (string)drDomicilio["telefono"];
                    dmc.Telefono2 = (string)drDomicilio["telefono2"];
                }

                drDomicilio.Close();
            }
            catch (Exception Ex)
            {
                throw new Exception("Error al recuperar datos de domicilio", Ex);
            }
            finally
            {
                CloseConnection();
            }
            if (dmc != null)
                return dmc;
            else
                return null;
        }

        public void Delete(int id_domicilio)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("DELETE FROM domicilio WHERE id_domicilio = @id_domicilio", sqlConn);
                cmdDelete.Parameters.Add("@id_domicilio", SqlDbType.Int).Value = id_domicilio;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                throw new Exception("Error al dar de baja el domicilio", Ex);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Save(Domicilio domicilio)
        {
            if (domicilio.State == BusinessEntity.States.Deleted)
            {
                Delete(domicilio.IdDomicilio);
            }

            else if (domicilio.State == BusinessEntity.States.New)
            {
                Insert(domicilio);
            }
            else if (domicilio.State == BusinessEntity.States.Modified)
            {
                Update(domicilio);
            }
            domicilio.State = BusinessEntity.States.Unmodified;
        }

        protected void Insert(Domicilio domicilio)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO domicilio (calle, numero, esBis, piso, depto, pais, provincia, localidad, telefono, telefono2)" +
                    "values(@calle,@numero,@esBis,@piso,@depto,@pais,@provincia,@localidad,@telefono,@telefono2)" +
                    "select @@identity ", sqlConn);

                cmdSave.Parameters.Add("@id_domicilio", SqlDbType.Int).Value = domicilio.IdDomicilio;
                cmdSave.Parameters.Add("@calle", SqlDbType.VarChar, 50).Value = domicilio.Calle;
                cmdSave.Parameters.Add("@numero", SqlDbType.Int).Value = domicilio.Numero;
                cmdSave.Parameters.Add("@esBis", SqlDbType.Bit).Value = domicilio.EsBis;
                cmdSave.Parameters.Add("@piso", SqlDbType.Int).Value = domicilio.Piso;
                cmdSave.Parameters.Add("@depto", SqlDbType.Char).Value = domicilio.Depto;
                cmdSave.Parameters.Add("@pais", SqlDbType.VarChar, 50).Value = domicilio.Pais;
                cmdSave.Parameters.Add("@provincia", SqlDbType.VarChar, 50).Value = domicilio.Provincia;
                cmdSave.Parameters.Add("@localidad", SqlDbType.VarChar, 50).Value = domicilio.Localidad;
                cmdSave.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = domicilio.Telefono;
                cmdSave.Parameters.Add("@telefono2", SqlDbType.VarChar, 50).Value = domicilio.Telefono2;

                domicilio.IdDomicilio = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());

                //cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al crear el domicilio", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }
        }

        protected void Update(Domicilio domicilio)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE domicilio SET calle = @calle, numero = @numero, " +
                    "esBis = @esBis, piso = @piso, depto = @depto, pais = @pais, provincia = @provincia, " +
                    "localidad = @localidad, telefono = @telefono, telefono = @telefono2" +
                    "WHERE id_domicilio = @id_domicilio ", sqlConn);

                cmdSave.Parameters.Add("@id_domicilio", SqlDbType.Int).Value = domicilio.IdDomicilio;
                cmdSave.Parameters.Add("@calle", SqlDbType.VarChar, 50).Value = domicilio.Calle;
                cmdSave.Parameters.Add("@numero", SqlDbType.Int).Value = domicilio.Numero;
                cmdSave.Parameters.Add("@esBis", SqlDbType.Bit).Value = domicilio.EsBis;
                cmdSave.Parameters.Add("@piso", SqlDbType.Int).Value = domicilio.Piso;
                cmdSave.Parameters.Add("@depto", SqlDbType.Char).Value = domicilio.Depto;
                cmdSave.Parameters.Add("@pais", SqlDbType.VarChar, 50).Value = domicilio.Pais;
                cmdSave.Parameters.Add("@provincia", SqlDbType.VarChar, 50).Value = domicilio.Provincia;
                cmdSave.Parameters.Add("@localidad", SqlDbType.VarChar, 50).Value = domicilio.Localidad;
                cmdSave.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = domicilio.Telefono;
                cmdSave.Parameters.Add("@telefono2", SqlDbType.VarChar, 50).Value = domicilio.Telefono2;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al modificar datos del domicilio", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }

        }
    }

}
