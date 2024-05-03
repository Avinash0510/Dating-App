using System.Collections;
using System.Reflection.Metadata.Ecma335;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[Controller]
[Route("api/[controller]")] // /api/users
public class UsersController : ControllerBase
{
    private readonly DataContext _context;


    public UsersController(DataContext context)
    {
        _context = context;

    }

    [HttpGet]
    public async Task <ActionResult<IEnumerable<AppUser>>> Getusers()
    {
        var users  = await _context.Users.ToListAsync();
        return users;
    }  

    [HttpGet("{id}")] // /api/users/id
    public async Task<ActionResult<AppUser>> Getusers(int id)
    {
        return await _context.Users.FindAsync(id);
    }

}
