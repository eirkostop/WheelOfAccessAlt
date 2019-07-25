using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

using MyWheel.Models;

namespace MyWheel.Managers
{
    public class AppManager
    {
        public ICollection<Question> GetQuestions()
        {
            List<Question> result;
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                var query = db.Questions.AsQueryable();

                result = query.ToList();
            }
            return result;
        }

        public ICollection<int> GetUserAnswers(int questionId, string userId)
        {
            ICollection<int> result;
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                // Not a good implementation. Can throw null exception.
                result = db.Users.Include(x => x.Reviews)
                                 .Where(x => x.Id == userId)
                                 .FirstOrDefault()
                                 .Reviews
                                 .Select(x => x.Id)
                                 .ToList();
            }
            return result;
        }

    //    public bool ToggleFavoriteMovie(int movieId, string userId)
    //    {
    //        bool result;
    //        using (ApplicationDbContext db = new ApplicationDbContext())
    //        {
    //            ApplicationUser user = db.Users.Include(x => x.FavoriteMovies)
    //                                           .Where(x => x.Id == userId)
    //                                           .FirstOrDefault();
    //            Movie movie = user.FavoriteMovies.Where(x => x.Id == movieId)
    //                                             .FirstOrDefault();
    //            if (movie == null)
    //            {
    //                movie = db.Movies.Find(movieId);
    //                user.FavoriteMovies.Add(movie);
    //                db.SaveChanges();
    //                result = true;
    //            }
    //            else
    //            {
    //                user.FavoriteMovies.Remove(movie);
    //                db.SaveChanges();
    //                result = false;
    //            }
    //        }
    //        return result;
    //    }
    }
}