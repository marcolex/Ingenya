using Ingenya.ApiCore;
using Ingenya.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApp.Controllers
{

    //[Route("Clientes")]
    [RoutePrefix("api/Cliente")]
    public class ClienteController : ApiController
    {
        ClienteManagement clienteManagement;
        Cliente cliente;
        HttpResponseMessage response;
        /// <summary>
        /// Obtener todos los clientes.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     GET api/TodosLosClientes
        ///     {        
        ///     "IdCliente": 0,
        ///     "Nombre": "Prueba Cliente",
        ///     "Site": "site.com",
        ///     "Telefono": "88888888",
        ///     "Direccion": "San Jose",
        ///     "CorreoContacto": "test@gmail.com"      
        ///     }
        /// </remarks>
        /// <response code="200">Carga de clientes, exitosa</response>  
        /// <response code="500">Hubo un error en la carga de los clientes</response>  
        [HttpGet]
        [Route("TodosLosClientes")]
        public HttpResponseMessage TodosLosClientes()
        {
            try
            {
                clienteManagement = new ClienteManagement();
                response = Request.CreateResponse(HttpStatusCode.OK, (IEnumerable<Cliente>)clienteManagement.RetrieveAllCliente());
                return response;
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error en la carga de los clientes");
            }

        }

        /// <summary>
        /// Insertar un cliente nuevo.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST api/InsertarCliente
        ///       {
        ///        "IdCliente": 0,
        ///        "Nombre": "string",
        ///        "Site": "string",
        ///        "Telefono": "string",
        ///        "Direccion": "string",
        ///        "CorreoContacto": "string"
        ///       }
        /// 
        /// </remarks>
        /// <response code="201">El nuevo cliente se ingreso correctamente</response> 
        /// <response code="500">Hubo un error error al crear el nuevo cliente</response> 
        // POST api/values
        [HttpPost]
        [Route("InsertarCliente")]
        public HttpResponseMessage InsertarCliente([FromBody] Cliente cliente)
        {
            try
            {
                clienteManagement = new ClienteManagement();
                try
                {
                    clienteManagement.CreateCliente(cliente);
                    return Request.CreateResponse(HttpStatusCode.Created , "El cliente se inserto correctamente");
                }
                catch (Exception)
                {

                    return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error error al crear el nuevo cliente");
                }

                // return response;
            }
            catch (Exception)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error error al crear el nuevo cliente");
            }

        }


        /// <summary>
        /// Modificar un cliente.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     PUT api/ModificarCliente
        ///       {
        ///        "IdCliente": 0,
        ///        "Nombre": "string",
        ///        "Site": "string",
        ///        "Telefono": "string",
        ///        "Direccion": "string",
        ///        "CorreoContacto": "string"
        ///     }
        /// </remarks>
        /// <response code="200">El cliente se modifico correctamente</response> 
        /// <response code="500">Hubo un error error al modificar el cliente</response> 
        // POST api/values
        [HttpPut]
        [Route("ModificarCliente")]
        public HttpResponseMessage ModificarCliente([FromBody] Cliente cliente)
        {
            try
            {
                clienteManagement = new ClienteManagement();
                try
                {
                    clienteManagement.UpdateCliente(cliente);
                    return Request.CreateResponse(HttpStatusCode.OK, "El cliente se modifico correctamente");
                }
                catch (Exception)
                {

                    return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error error al modificar el cliente");
                }

                // return response;
            }
            catch (Exception)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error error al modificar el cliente");
            }

        }


        /// <summary>
        /// Eliminar un cliente.
        /// </summary>
        /// <param name="id">Id Cliente</param>
        /// <response code="200">El cliente se elimino correctamente</response>  
        /// <response code="400">No se puede eliminar este cliente por tener proyectos asociados</response>  
        /// <response code="500">Hubo un error error al eliminar el cliente</response>  
        [HttpDelete()]
        [Route("EliminarCliente/{id}")]
        public HttpResponseMessage EliminarCliente(string id)
        {
            try
            {
                cliente = new Cliente
                {
                    IdCliente = Int32.Parse(id)
                };
                clienteManagement = new ClienteManagement();
                clienteManagement.DeleteCliente(cliente);
                return Request.CreateResponse(HttpStatusCode.OK, "El cliente se elimino correctamente");
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FOREIGN KEY"))
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "No se puede eliminar este cliente por tener proyectos asociados");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "No se puede eliminar este cliente por tener proyectos asociados");
                }
                
            }

        }

        /// <summary>
        /// Obtener un cliente por Id.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     GET api/ObtenerCliente
        ///     {        
        ///     "IdCliente": 0,
        ///     "Nombre": "Prueba Cliente",
        ///     "Site": "site.com",
        ///     "Telefono": "88888888",
        ///     "Direccion": "San Jose",
        ///     "CorreoContacto": "test@gmail.com"      
        ///     }
        /// </remarks>
        /// <param name="idCliente">Cliente</param>
        /// <response code="200">Carga de cliente, exitosa</response>  
        /// <response code="404">No se encontro el cliente por id</response>  
        /// <response code="500">Hubo un error en la carga del cliente por id</response>  
        [HttpPut]
        [Route("ObtenerCliente/{id}")]
        public HttpResponseMessage ObtenerCliente(string idCliente)
        {
            try
            {
                cliente = new Cliente
                {
                    IdCliente = Int32.Parse(idCliente)
                };
                clienteManagement = new ClienteManagement();
                cliente = clienteManagement.RetrieveClientebyId(cliente);
                if (cliente is null)
                {
                    response = Request.CreateResponse(HttpStatusCode.NotFound, cliente);
                }
                else
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, cliente);
                }

                return response;
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error en la carga del cliente por id");
            }

        }

    }
}
