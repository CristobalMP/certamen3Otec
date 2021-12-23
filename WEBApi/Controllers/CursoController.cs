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
    public class CursoController : ApiController
    {
        [HttpGet]
        [Route("api/v2/ListarCurso")]
        public Retorno buscar()
        {

            Retorno ret = new Retorno();
            try
            {
                List<curso> listado = new List<curso>();
                CursoEntity datos = new CursoEntity();
                listado = datos.listado();


                ret.error = false;
                ret.mensaje = "ok";
                if (listado.Count > 0)
                    ret.data = listado;
                else
                    ret.data = "No existe el Curso";
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
        [Route("api/v2/BuscarCurso")]
        public Retorno buscar(int id_curso = 0)
        {

            Retorno ret = new Retorno();
            try
            {
                List<curso> listado = new List<curso>();
                CursoEntity datos = new CursoEntity();
                listado = id_curso == 0 ? datos.listado() : datos.listado(id_curso);


                ret.error = false;
                ret.mensaje = "ok";
                if (listado.Count > 0)
                    ret.data = listado;
                else
                    ret.data = "No existe el Curso";
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
        [Route("api/v2/GuardarCurso")]
        public Retorno guardar(curso curso)
        {
            Retorno ret = new Retorno();
            try
            {
                CursoEntity datos = new CursoEntity();

                int estado = datos.guardar(curso);

                if (estado == 1)
                {
                    ret.error = false;
                    ret.mensaje = "Curso Guardado";
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
        [Route("api/v2/EditarCurso")]
        public Retorno editar(curso curso)
        {
            Retorno ret = new Retorno();
            try
            {
                CursoEntity datos = new CursoEntity();

                int estado = datos.editar(curso);

                if (estado == 1)
                {
                    ret.error = false;
                    ret.mensaje = "Se edito el Curso";
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
        [Route("api/v2/EliminarCurso")]
        public Retorno eliminar(int id_curso)
        {
            Retorno ret = new Retorno();

            try
            {

                CursoEntity datos = new CursoEntity();
                int estado = datos.eliminar(id_curso);

                if (estado == 1)
                {
                    ret.error = false;
                    ret.mensaje = "Se elimino el Curso";
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
