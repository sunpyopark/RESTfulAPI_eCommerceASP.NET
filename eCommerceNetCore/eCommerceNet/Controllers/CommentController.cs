using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using eCommerceNet.Data;
using eCommerceNet.Models;
using Microsoft.AspNetCore.Cors;

namespace eCommerceNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
  
    [EnableCors("eCommerce")]

    //constructor method for the commentcontroler class.

    public class CommentController : ControllerBase
    {
        private readonly Context _context;

        public CommentController(Context context)
        {
            _context = context;
        }

        // GET: api/Comment
        [HttpGet]
        public IEnumerable<Comment> GetComment()
        {
            return _context.comment;

        }

        // GET: api/Comment/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetComment([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var Comment = await _context.comment

              .FirstOrDefaultAsync(i => i.CommentId == id);

            if (Comment == null)
            {
                return NotFound();
            }

            return Ok(Comment);
        }

        // PUT: api/Comment/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutComment([FromRoute] int id, [FromBody] Comment Comment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != Comment.CommentId)
            {
                return BadRequest();
            }

            _context.Entry(Comment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CommentExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Comment
        [HttpPost]
        public async Task<IActionResult> PostComment([FromBody] Comment Comment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.comment.Add(Comment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetComment", new { id = Comment.CommentId }, Comment);
        }

        // DELETE: api/Comment/3
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComment([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var Comment = await _context.comment.FindAsync(id);
            if (Comment == null)
            {
                return NotFound();
            }

            _context.comment.Remove(Comment);
            await _context.SaveChangesAsync();

            return Ok(Comment);
        }

        private bool CommentExists(int id)
        {
            return _context.comment.Any(e => e.CommentId == id);
        }


    }
}