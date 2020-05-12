using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReportGeneration.Web.Models;

namespace ReportGeneration.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetPosts()
        {
            var tableModel = new DataTableModel(Request);
            var model = Startup.AutofacContainer.Resolve<PostModel>();
            var data = model.GetPosts(tableModel);
            return Ok(data);
        }

        [HttpPost]
        public IActionResult CreatePost([FromBody] CreatePost post)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new FailedResponse
                {
                    Errors = ModelState.Values.SelectMany(x => x.Errors.Select(e => e.ErrorMessage))
                });
            }
            try
            {
                post.Create();
                return Ok("Post Created");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Operation Failed. Please Try agin !!");
            }
        }
    }
}