using MyWheel.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        //[HttpGet]
        //public JsonResult UserAnswers()
        //{
        //    var query = db.UserAnswers.Select(x => new { x.ReviewId, x.Answer.QuestionId });
        //    return Json(query, JsonRequestBehavior.AllowGet);
        //}

        [HttpPut]
        [ActionName("UserAnswer")]
        public JsonResult AddUserAnswer(UserAnswer answer)
        {
            //var query = db.UserAnswers
            //    .Where(x => x.ReviewId == answer.ReviewId && x.Answer.QuestionId == answer.Answer.QuestionId);

            db.UserAnswers.Add(answer);
            db.SaveChanges();
            return Json(answer);
        }

        [HttpPost]
        [ActionName("Review")]
        public JsonResult UpdateRating(int id)
        {
            var review=db.Reviews.Find(id);
            review.Rating = db.UserAnswers.Include(x=>x.Answer).Where(x=>x.ReviewId==id).Select(x => (float)x.Answer.Value).Average();
            db.Entry(review).State = EntityState.Modified;
            db.SaveChanges();
            return Json(review);

        }

        [HttpDelete]
        [ActionName("UserAnswer")]
        public JsonResult DeleteUserAnswerBool(int ReviewId, int QuestionId)
        {
            var ua=db.UserAnswers.Where(x => x.Answer.QuestionId == QuestionId && x.ReviewId == ReviewId).FirstOrDefault();
            var result=false;
            if (ua != null){
                db.UserAnswers.Remove(ua);
                db.SaveChanges();
                result = true;
            }
            return Json(result);
        }

        //[HttpPost]
        //[ActionName("Place")]
        //public JsonResult UpdatePlace(Place Place)
        //{
            
        //}

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