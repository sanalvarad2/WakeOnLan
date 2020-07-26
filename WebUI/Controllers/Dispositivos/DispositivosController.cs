﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers.Dispositivos
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DispositivosController : ControllerBase
    {
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            DAL.Models.Dispositivos retVal = DAL.Methods.DispositivosBC.GetByID(id);
            return Ok(retVal);     
        }

        [HttpGet]
        [Route("{nombre}")]
        public IActionResult GetByNombre(string nombre)
        {
            List<DAL.Models.Dispositivos> retVal = DAL.Methods.DispositivosBC.GetByNombre(nombre);
            return Ok(retVal);
        }

        [HttpGet]
        [Route("{hostname}")]
        public IActionResult GetByHostName(string hostname)
        {
            DAL.Models.Dispositivos retVal = DAL.Methods.DispositivosBC.GetByHostName(hostname);
            return Ok(retVal);
        }

        [HttpGet]
        [Route("{macaddress}")]
        public IActionResult GetByMacAddress(string macaddress)
        {
            DAL.Models.Dispositivos retVal = DAL.Methods.DispositivosBC.GetByMacAddress(macaddress);
            return Ok(retVal);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<DAL.Models.Dispositivos> retVal = DAL.Methods.DispositivosBC.GetAll();
            return Ok(retVal);
        }

        [HttpPost]
        public IActionResult Guardar(DAL.Models.Dispositivos Obj)
        {
            int retVal;
            retVal = DAL.Methods.DispositivosBC.Guardar(Obj);
            return Ok(retVal);
        }

        [HttpDelete]
        public IActionResult Borrar(int id)
        {
            DAL.Methods.DispositivosBC.Borrar(id);
            return Ok();
        }
    }
}
