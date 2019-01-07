using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeIt.Photography.Libraries.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CodeIt.Photography.Presenter.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogPostController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetBlogPost(int id)
        {
            JsonResult json = null;

            try
            {
                BlogPostEntity blogPost = new BlogPostEntity();

                json = new JsonResult(JsonConvert.SerializeObject(blogPost));
                json.StatusCode = 200;
            }
            catch (Exception ex)
            {

            }

            return json;
        }
    }
}