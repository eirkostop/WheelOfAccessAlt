using MyWheel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWheel.Controllers
{
    public class RestController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        //[HttpGet]
        //public JsonResult Actors()
        //{
        //    var actors = db.GetActors();
        //    var result = actors.Select(x => new
        //    {
        //        Id = x.Id,
        //        Name = x.Name,
        //        Age = x.Age
        //    });
        //    return Json(result, JsonRequestBehavior.AllowGet);
        //}

        //[HttpGet]
        //public JsonResult UserAnswer(int id)
        //{
            
        //    UserAnswer answer = db.UserAnswers.Find(id);
        //    var result = new
        //    {
        //        Id = UserAnswer.Id,
        //        Name = actor.Name,
        //        Age = actor.Age
        //    };
        //    return Json(result, JsonRequestBehavior.AllowGet);
        //}

        //[HttpPost]
        //public JsonResult Actor(Actor actor)
        //{
        //    db.UpdateActor(actor);
        //    return Json(actor);
        //}

        [HttpPut]
        [ActionName("UserAnswer")]
        public JsonResult AddUserAnswer(UserAnswer answer)
        {
            db.UserAnswers.Add(answer);
            db.SaveChanges();
            return Json(answer);
        }

        //[HttpDelete]
        //[ActionName("Actor")]
        //public JsonResult DeleteActor(int id)
        //{
        //    bool result = db.DeleteActorBool(id);
        //    return Json(result);
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}