using Microsoft.AspNetCore.Mvc;
using ClassLibTeam10.Business;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace WebApiTeam10.Controllers
{
    //WebApi -> Add -> Project reference

    [ApiController]
    [Route("api/[controller]")]

    public class FactionController : ControllerBase
    {
        [HttpPost]
        [Route("AddFaction")]

        public void Addcard(int factionId, string race, string factionName, string factionLeader, string factionStronghold)
        {
            //voeg dependincy van lib toe
            Factions.Add(factionId, race, factionName, factionLeader, factionStronghold);
        }
<<<<<<< HEAD
        [HttpGet]
        [Route("GetFactions")]
=======

        [HttpGet]
>>>>>>> 9b87c11dd85911cb45969249849f446ad8c93423
        public ActionResult GetAllFactions()
        {
            var result = Factions.GetFactions();
            if (result.Succeeded)
            {
                var factions = result.DataTable;
                string JSONresult = JsonConvert.SerializeObject(factions);
                return Ok(JSONresult);
            }
            return NotFound();
        }
    }

}
