using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace TraversalCoreProje.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());
        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult AddComment(Comment comment)
        {
            commentManager.TAdd(comment);
            comment.CommentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            comment.CommentStatus = true;
            return PartialView();
        }

    }
}
