using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Entidades;
using WebAPIAutores;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/autores")]

    public class AutoresController : ControllerBase
    {
        private readonly ApplicationDBContext context;
        public AutoresController(ApplicationDBContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Autor>>> Get()
        {
            var autores = await context.Autores.ToListAsync();
            return autores;
            // return await context.Autores.ToListAsync();
            // return await context.Autores.Include(x => x.Libros).ToListAsync();
        }

        [HttpGet("nombreautor")]
        public async Task<ActionResult<Autor>> Get(string nombre)
        {
            var autor = await context.Autores.FirstOrDefaultAsync(a => a.nombre.Contains(nombre)); //*Query a la base de datos
            // var autor = await context.Autores.Include(x => x.Libros).FirstOrDefaultAsync(a => a.Nombre.Contains(nombre)); //*Query a la base de datos
            if (autor == null)
            {
                return NotFound();
            }
            return autor;
        }

        [HttpPost]
        public async Task<ActionResult> Post(Autor autor)
        {
            var mismoNombre = await context.Autores.AnyAsync(x => x.nombre == autor.nombre);

            if (mismoNombre)
            {
                return BadRequest($"Ya existe un autor con el nombre:{autor.nombre} ");
            }

            context.Add(autor);
            await context.SaveChangesAsync();
            return Ok(autor);
        }

        [HttpPut("{id:int}")] //? api/autores/1 esta es la URL donde se realizara la accion
        public async Task<ActionResult> Put(Autor autor, int id)
        {
            if (autor.id != id)
            {
                return BadRequest("El id  del autor no coincide con el id de la URL");
            }

            var existe = await context.Autores.AnyAsync(x => x.id == id);
            if (!existe)
            {
                return NotFound();
            }

            context.Update(autor);
            await context.SaveChangesAsync();
            return Ok(autor);
        }

        [HttpDelete("{id:int}")] //? De la misma manera que en actualizacion 
        public async Task<ActionResult> Delete(int id)
        {
            var existe = await context.Autores.AnyAsync(x => x.id == id);
            if (!existe)
            {
                return NotFound();
            }

            context.Remove(new Autor() { id = id });
            await context.SaveChangesAsync();
            return Ok(id);
        }
    }
}
