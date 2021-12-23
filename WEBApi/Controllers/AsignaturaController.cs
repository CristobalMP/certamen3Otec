using OtecLibrary;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WEBApi.Models;

namespace WEBApi.Controllers
{
    public class AsignaturaController : ApiController
    {
        [HttpGet]
        [Route("api/v1/ListarAsignatura")]
        public Retorno buscar()
        {

            Retorno ret = new Retorno();
            try
            {
                List<asignatura> listado = new List<asignatura>();
                AsignaturaEntity datos = new AsignaturaEntity();
                listado = datos.listado();


                ret.error = false;
                ret.mensaje = "ok";
                if (listado.Count > 0)
                    ret.data = listado;
                else
                    ret.data = "No existe la Asignatura";
                return ret;
            }
            catch (Exception e)
            {
                ret.error = true;
                ret.mensaje = "Error:" + e.Message;
                ret.data = null;
                return ret;
            }
        }

        [HttpGet]
        [Route("api/v1/BuscarAsignatura")]
        public Retorno buscar(int id_asignatura = 0)
        {

            Retorno ret = new Retorno();
            try
            {
                List<asignatura> listado = new List<asignatura>();
                AsignaturaEntity datos = new AsignaturaEntity();
                listado = id_asignatura == 0 ? datos.listado() : datos.listado(id_asignatura);


                ret.error = false;
                ret.mensaje = "ok";
                if (listado.Count > 0)
                    ret.data = listado;
                else
                    ret.data = "No existe la Asignatura";
                return ret;
            }
            catch (Exception e)
            {
                ret.error = true;
                ret.mensaje = "Error:" + e.Message;
                ret.data = null;
                return ret;
            }
        }

        [HttpPost]
        [Route("api/v1/GuardarAsignatura")]
        public Retorno guardar(asignatura asignatura)
        {
            Retorno ret = new Retorno();
            try
            {
                AsignaturaEntity datos = new AsignaturaEntity();

                int estado = datos.guardar(asignatura);

                if (estado == 1)
                {
                    ret.error = false;
                    ret.mensaje = "Asignatura Guardada";
                    ret.data = null;
                }
                else
                {
                    ret.error = true;
                    ret.mensaje = "No se Guardo";
                    ret.data = null;
                }
                return ret;
            }
            catch (Exception e)
            {
                ret.error = true;
                ret.mensaje = "Error:" + e.Message;
                ret.data = null;
                return ret;
            }
        }


        [HttpPut]
        [Route("api/v1/EditarAsignatura")]
        public Retorno editar(asignatura asignatura)
        {
            Retorno ret = new Retorno();
            try
            {
                AsignaturaEntity datos = new AsignaturaEntity();

                int estado = datos.editar(asignatura);

                if (estado == 1)
                {
                    ret.error = false;
                    ret.mensaje = "Se edito la Asignatura";
                    ret.data = null;
                }
                else
                {
                    ret.error = true;
                    ret.mensaje = "Fracaso la edición";
                    ret.data = null;
                }
                return ret;
            }
            catch (Exception e)
            {
                ret.error = true;
                ret.mensaje = "Error:" + e.Message;
                ret.data = null;
                return ret;
            }
        }

        [HttpDelete]
        [Route("api/v1/EliminarAsignatura")]
        public Retorno eliminar(int id_asignatura)
        {
            Retorno ret = new Retorno();

            try
            {

                AsignaturaEntity datos = new AsignaturaEntity();
                int estado = datos.eliminar(id_asignatura);

                if (estado == 1)
                {
                    ret.error = false;
                    ret.mensaje = "Se elimino la Asignatura";
                    ret.data = null;
                }
                else
                {
                    ret.error = true;
                    ret.mensaje = "Fracaso la eliminacion";
                    ret.data = null;
                }
                return ret;
            }
            catch (Exception e)
            {
                ret.error = true;
                ret.mensaje = "Error:" + e.Message;
                ret.data = null;
                return ret;
            }
        }
    }
}
