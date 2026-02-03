using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using HP2.Application;
using HP2.Domain.Models;
using System.Globalization;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;

namespace HP2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatiereTestController : ControllerBase
    {
        private readonly IMatiereTestService MatiereTestService;
        private readonly IConfiguration Configuration;

        public MatiereTestController(IMatiereTestService MatiereTestService, IConfiguration configuration)
        {
            this.MatiereTestService = MatiereTestService;
            this.Configuration = configuration;
        }

        // GET: api/<MatiereTestController>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<MatiereTestModel>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IList<MatiereTestModel>>> GetAll()
        {
            var list = await this.MatiereTestService.GetAll();
            return Ok(list);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(MatiereTestModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<ActionResult<MatiereTestModel>> GetById(int id)
        {
            var MatiereTest = await this.MatiereTestService.GetById(id);
            if (MatiereTest == null)
            {
                return NotFound();
            }
            return Ok(MatiereTest);
        }

    }
}
