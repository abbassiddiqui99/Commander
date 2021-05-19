using System.Collections.Generic;
using Data;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo _commanderRepo;
        public CommandsController(ICommanderRepo commanderRepo)
        {
            _commanderRepo = commanderRepo;

        }

        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands(){
            var commandItems = _commanderRepo.GetAllCommands();
            return Ok(commandItems);
        }

        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandById(int id){
            var commandItem = _commanderRepo.GetCommandById(id);
            return Ok(commandItem);
        }
    }
}