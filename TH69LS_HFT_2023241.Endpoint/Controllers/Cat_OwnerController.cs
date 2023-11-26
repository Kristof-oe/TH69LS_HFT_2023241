using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TH69LS_HFT_2023241.Logic;
using TH69LS_HFT_2023241.Models;

namespace TH69LS_HFT_2023241.Endpoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Cat_OwnerController : ControllerBase
    {
        ICat_OwnerLogic logic;

        public Cat_OwnerController(Cat_OwnerLogic logic)
        {
            this.logic = logic;
        }

        [HttpGet]
        public IEnumerable<Cat_Owner> ReadAll()
        {
            return this.logic.ReadAll();
        }

        [HttpGet("{id}")]
        public Cat_Owner Read(int ID)
        {
            return this.logic.Read(ID);
        }

        [HttpPost]
        public void Create([FromBody] Cat_Owner v)
        {
            this.logic.Create(v);
        }

        [HttpPut("{id}")]
        public void Update([FromBody] Cat_Owner v)
        {
            this.logic.Update(v);
        }

        [HttpDelete("{id}")]
        public void Delete(int ID)
        {
            this.logic.Delete(ID);
        }
    }
}
