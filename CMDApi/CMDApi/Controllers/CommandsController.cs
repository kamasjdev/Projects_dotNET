using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CMDApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CMDApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly CommandContext _commandContext;

        public CommandsController(CommandContext context) => _commandContext = context;
        /*public CommandsController(CommandContext context)
        {
            _commandContext = context;
        }*/

        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetCommands()
        {
            return _commandContext.CommandItems;
        }

        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandItem(int id)
        {
            var commandItem = _commandContext.CommandItems.Find(id);

            if (commandItem == null)
            {
                return NotFound();
            }
            else
            {
                return commandItem;
            }
        }


        [HttpPost]
        public ActionResult<Command> PstCmdItem(Command cmd)
        {
            _commandContext.CommandItems.Add(cmd);
            _commandContext.SaveChanges();

            return CreatedAtAction("GetCommandItem", new Command { Id = cmd.Id }, cmd);
        }


        [HttpPut("{id}")]
        public ActionResult PutCmdItem(int id, Command cmd)
        {
            if(id != cmd.Id)
            {
                return BadRequest();
            }
            else
            {
                _commandContext.Entry(cmd).State = EntityState.Modified;
                _commandContext.SaveChanges();

                return NoContent();
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<Command> DeleteCommandItem(int id) 
        {
            var Item = _commandContext.CommandItems.Find(id);
            
            if (Item == null)
            {
                return NotFound();
            }

            _commandContext.CommandItems.Remove(Item);
            _commandContext.SaveChanges();

            return Item;
        }


        /*        [HttpGet]
                public ActionResult<IEnumerable<string>> GetString()
                {
                    return new string[] { "I'm", "using", "MVC." };
                }*/
    }
}