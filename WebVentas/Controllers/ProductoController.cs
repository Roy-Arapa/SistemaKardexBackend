﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DatosVentas;
using EntidadesVentas.Producto;
using WebVentas.Modelos.Producto;

namespace WebVentas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : Controller
    {
        private readonly DbContextVentas _context;

        public ProductoController(DbContextVentas context)
        {
            _context = context;
        }

        // GET: Api/Producto/Listar
        [HttpGet("[action]")]
        public async Task<IEnumerable<ProductoListarVM>> Listar()
        {
            var objResultado = from producto in _context.producto
                               select new
                               {
                                   producto.idProducto,
                                   producto.cProducto,
                                   producto.cPrecioProd,
                                   producto.nCantidadProd,
                                   producto.cDescripcion,
                                   producto.lVigente
                               };

            var objProducto = await objResultado.ToListAsync();
            return objProducto.Select(c => new ProductoListarVM
            {
                idProducto = c.idProducto,
                cProducto = c.cProducto,
                cPrecioProd = c.cPrecioProd,
                nCantidadProd = c.nCantidadProd,
                cDescripcion = c.cDescripcion,
                lVigente = c.lVigente
            });
        }

        // POST: Api/Producto/Crear
        [HttpPost("[action]")]
        public async Task<IActionResult> Crear([FromBody] ProductoCrearVM model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            DT_Producto objProducto = new DT_Producto
            {
                cProducto = model.cProducto,
                cPrecioProd = model.cPrecioProd,
                nCantidadProd = model.nCantidadProd,
                cDescripcion = model.cDescripcion,
                idUsuReg = 0,
                dFechaReg = DateTime.Now,
                lVigente = true
            };
            _context.producto.Add(objProducto);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

            return Ok();
        }

        // PUT: Api/Producto/Actualizar
        [HttpPut("[action]")]
        public async Task<IActionResult> Actualizar([FromBody] ProductoActualizarVM model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (model.idProducto <= 0)
            {
                return BadRequest();
            }

            var objProducto = await _context.producto.FirstOrDefaultAsync(c => c.idProducto == model.idProducto);

            if (objProducto == null)
            {
                return NotFound();
            }

            objProducto.cProducto = model.cProducto;
            objProducto.cPrecioProd = model.cPrecioProd;
            objProducto.nCantidadProd = model.nCantidadProd;
            objProducto.cDescripcion = model.cDescripcion;
            objProducto.idUsuMod = 0;
            objProducto.dFechaMod = DateTime.Now;
            objProducto.lVigente = model.lVigente;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

            return Ok();
        }

        // PUT: Api/Producto/Activar/1
        [HttpPut("[action]/{idProducto}")]
        public async Task<IActionResult> Activar([FromRoute] int idProducto)
        {
            if (idProducto <= 0)
            {
                return BadRequest();
            }

            var _producto = await _context.producto.FirstOrDefaultAsync(a => a.idProducto == idProducto);

            if (_producto == null)
            {
                return NotFound();
            }

            _producto.lVigente = true;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                // Guardar Excepción
                return BadRequest();
            }

            return Ok();
        }

        // PUT: Api/Cliente/Desactivar/1
        [HttpPut("[action]/{idProducto}")]
        public async Task<IActionResult> Desactivar([FromRoute] int idProducto)
        {
            if (idProducto <= 0)
            {
                return BadRequest();
            }

            var _producto = await _context.producto.FirstOrDefaultAsync(a => a.idProducto == idProducto);

            if (_producto == null)
            {
                return NotFound();
            }

            _producto.lVigente = false;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                // Guardar Excepción
                return BadRequest();
            }

            return Ok();
        }
    }
}