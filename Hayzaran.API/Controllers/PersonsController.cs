using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hayzaran.Core.Entities;
using Hayzaran.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hayzaran.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        /// <summary>
        /// Ayrı bir service yazmadan, direk IService kullanılarakta yapılabileceğini göstermek için bir örnektir.
        /// Bir entity kendine özel bir işlem bulundurmuyorsa yani sadece kendine has CRUD işlemleri varsa, bu şekilde kullanılabilir.
        /// </summary>

        private readonly IService<Person> personService;
        public PersonsController(IService<Person> personService)
        {
            this.personService = personService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var persons = await personService.GetAllAsync();
            return Ok(persons);
        }

        [HttpPost]
        public async Task<IActionResult> Save(Person person)
        {
            var newPerson = await personService.AddAsync(person);
            return Created(string.Empty, newPerson);
        }
    }
}