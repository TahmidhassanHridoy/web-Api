using DAL.Interface.Moderator;
using DAL.Repos.Moderator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ModeratorDataAccessFactory
    {
        static AskNLearnEntities1 dbObj = new AskNLearnEntities1();

        public static IModerator<Cours, int> GetData()
        {
            return new CourseRepo(dbObj);
        }

        public static IModerator<Post, int> GetPosts()
        {
            return new PostRepo(dbObj);
        }

        
    }
}
