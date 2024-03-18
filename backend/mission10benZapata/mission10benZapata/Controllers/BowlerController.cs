using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mission10benZapata.Data;

namespace mission10benZapata.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private IBowlerRepository _bowlerRepository;
        public BowlerController(IBowlerRepository temp)
        {
            _bowlerRepository = temp;
        }

        [HttpGet]
        public IEnumerable<Bowler> Get()
        {
            {
                // This will filter out the bowlers that are not in teams Sharsks or Marlins
                var bowlerData = _bowlerRepository.Bowlers
                    .Where(b => b.Team?.TeamName == "Sharks" ||  b.Team?.TeamName == "Marlins")
                    .ToArray();
                return bowlerData;
            }
        }
    }
}
