using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TH69LS_HFT_2023241.Logic;
using TH69LS_HFT_2023241.Models;

namespace TH69LS_HFT_2023241.Endpoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatController : ControllerBase
    {
        ICatLogic logic;

        public CatController(ICatLogic logic)
        {
            this.logic = logic;
        }

        [HttpGet]
        public IEnumerable<Cat> ReadAll()
        {
            return this.logic.ReadAll();
        }

        [HttpGet("{id}")]
        public Cat Read(int ID)
        {
            return this.logic.Read(ID);
        }

        [HttpPost]
        public void Create([FromBody] Cat v)
        {
            this.logic.Create(v);
        }

        [HttpPut("{id}")]
        public void Update( [FromBody] Cat v)
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
