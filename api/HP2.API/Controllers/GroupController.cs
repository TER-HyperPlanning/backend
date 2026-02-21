using HP2.Application.Contracts;
using HP2.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace HP2.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GroupsController : ControllerBase
{
    private readonly IGroupService _groupService;

    public GroupsController(IGroupService groupService)
    {
        _groupService = groupService;
    }

    // POST: api/groups
    [HttpPost]
    public async Task<ActionResult<GroupModel>> Create([FromBody] GroupModel group)
    {
        if (group == null)
            return BadRequest();

        var createdGroup = await _groupService.CreateGroupAsync(group);

        return CreatedAtAction(
            nameof(Get),
            new { id = createdGroup.Id },
            createdGroup
        );
    }

    // GET: api/groups/{id}
    [HttpGet("{id}")]
    public async Task<ActionResult<GroupModel>> Get(string id)
    {
        var group = await _groupService.GetGroupByIdAsync(id);

        if (group == null)
            return NotFound($"Group with ID {id} not found");

        return Ok(group);
    }

    // GET: api/groups
    [HttpGet]
    public async Task<ActionResult<IEnumerable<GroupModel>>> GetAll()
    {
        var groups = await _groupService.GetAllGroupsAsync();
        return Ok(groups);
    }

    // PUT: api/groups/{id}
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(string id, [FromBody] GroupModel group)
    {
        if (group == null)
            return BadRequest();

        if (id != group.Id)
            return BadRequest("ID mismatch");

        var existing = await _groupService.GetGroupByIdAsync(id);
        if (existing == null)
            return NotFound($"Group with ID {id} not found");

        await _groupService.UpdateGroupAsync(group);
        return NoContent();
    }

    // DELETE: api/groups/{id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        var existing = await _groupService.GetGroupByIdAsync(id);
        if (existing == null)
            return NotFound($"Group with ID {id} not found");

        await _groupService.DeleteGroupAsync(id);
        return NoContent();
    }
}