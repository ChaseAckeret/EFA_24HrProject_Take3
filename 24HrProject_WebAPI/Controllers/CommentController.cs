using _24HrProject_Models;
using _24HrProject_Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _24HrProject_WebAPI.Controllers
{
    public class CommentController : ApiController
    {

        public IHttpActionResult Get()
        {
            CommentService CommentService = CreateCommentService();
            var comments = CommentService.GetComments();
            return Ok(comments);
        }

        public IHttpActionResult Post(CommentCreate Comment)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateCommentService();

            if (!service.CreateComment(Comment))
                return InternalServerError();

            return Ok();
        }


        private CommentService CreateCommentService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var CommentService = new CommentService(userId);
            return CommentService;
        }
    }
}
