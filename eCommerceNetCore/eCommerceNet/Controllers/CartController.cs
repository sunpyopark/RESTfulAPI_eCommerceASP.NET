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

    //Defining the route of the controller file.

    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("eCommerce")]

     //contructor for cart controller class.
    public class CartController : ControllerBase
    {
        private readonly Context _context;

        public CartController(Context context)
        {
            _context = context;
        }

        // GET: api/Cart
        [HttpGet]
        public IEnumerable<Cart> GetCart()
        {
            return _context.cart;

        }

        // GET: api/Cart/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCart([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); 
            }

            var Cart = await _context.cart

              .FirstOrDefaultAsync(i => i.CartId == id);

            if (Cart == null)
            {
                return NotFound();
            }

            return Ok(Cart);
        }

        // PUT: api/Cart/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCart([FromRoute] int id, [FromBody] Cart Cart)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != Cart.CartId)
            {
                return BadRequest();
            }

            _context.Entry(Cart).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CartExists(id))
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

        // POST: api/Cart
        [HttpPost]
        public async Task<IActionResult> PostCart([FromBody] Cart Cart)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.cart.Add(Cart);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCart", new { id = Cart.CartId }, Cart);
        }

        // DELETE: api/Cart/3
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCart([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var Cart = await _context.cart.FindAsync(id);
            if (Cart == null)
            {
                return NotFound();
            }

            _context.cart.Remove(Cart);
            await _context.SaveChangesAsync();

            return Ok(Cart);
        }

        private bool CartExists(int id)
        {
            return _context.cart.Any(e => e.CartId == id);
        }


    }
}