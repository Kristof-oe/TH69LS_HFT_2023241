using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TH69LS_HFT_2023241.Logic;
using TH69LS_HFT_2023241.Models;


namespace TH69LS_HFT_2023241.Endpoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Cat_SitterController : ControllerBase
    {
        ICat_SitterLogic logic;

        public Cat_SitterController(ICat_SitterLogic logic)
        {
            this.logic = logic;
        }

        [HttpGet]
        public IEnumerable<Cat_Sitter> ReadAll()
        {
            return this.logic.ReadAll();
        }

        [HttpGet("{id}")]
        public Cat_Sitter Read(int ID)
        {
            return this.logic.Read(ID);
        }

        [HttpPost]
        public void Create([FromBody] Cat_Sitter v)
        {
            this.logic.Create(v);
        }

        [HttpPut("{id}")]
        public void Update([FromBody] Cat_Sitter v)
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
