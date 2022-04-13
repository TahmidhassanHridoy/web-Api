using AutoMapper;
using BLL.Entities;
using BLL.Entities.Moderator;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace BLL.Services
{
    public class ModeratorServices
    {
            AskNLearnEntities1 dbObj = new AskNLearnEntities1();
            
            public static string Get(int uid)
            {
                var u = ModeratorDataAccessFactory.GetData().LearnersList(uid);
                return u;
            }
            public static string Get()
            {

                var config = new MapperConfiguration(cfg => cfg.CreateMap<User, UsersModel>());
                var mapper = new Mapper(config);
                var u = AdminDataAccessFactory.GetUser().LearnersList();
                //var Data = mapper.Map<List<UsersModel>>(u);
                //var s = new JavaScriptSerializer.serialize(u);
                return u;
            }



        public static string AddNewPost(string post)
        {
            var d = new JavaScriptSerializer().Deserialize<AddPostModel>(post);
            Post p = new Post();

            p.uid = d.uid;
            p.title = d.title;
            p.details = d.details;
            p.upVote = d.upVote;
            p.downVote = d.downVote;
            p.dateTime = DateTime.Now;


            var  k= ModeratorDataAccessFactory.GetPosts().AddPost(p);
            return "New Post Posted !!!";
        }


        public static string Instructors()
            {
                var u = ModeratorDataAccessFactory.GetData().InstructorsList();
                return u;
            }

            public static string Moderators()
            {
                var u = ModeratorDataAccessFactory.GetData().ModeratorsList();
                return u;
            }

            public static string Learners()
            {
                var u = ModeratorDataAccessFactory.GetData().LearnersList();
                return u;
            }

        public static string GetPost()
        {
            var p = ModeratorDataAccessFactory.GetPosts().PostList();
            return p;
        }


        public static string GetCourselist()
            {
                var p = ModeratorDataAccessFactory.GetData().CourseList();
                return p;
            }

            public static string DeletePost(int id)
            {
                var data = ModeratorDataAccessFactory.GetData().DeletePost(id);
                return data;
            }
            //public static string UpdatePost(string U)
            //{

            //    var d = new JavaScriptSerializer().Deserialize<AddPostModel>(U);
            //    User u = new User();
            //    UsersInfo ui = new UsersInfo();
            //    DateTime localDate = DateTime.Now;

            //    u.uid = d.uid;
            //    u.title = d.title;
            //    u.details = d.details;
            //    u.upvote = d.upVote;
            //    u.downvote = d.downVote;
            //    u.userType = d.userType;
            //    u.dateTime = localDate;


            //    var UU = ModeratorDataAccessFactory.GetData().UpdatePost(u);

            //    ui.eduInfo = d.eduInfo;
            //    ui.currentPosition = d.currentPosition;
            //    ui.reputation = d.reputation;

            //    var AddUI = ModeratorDataAccessFactory.AddUserInfo().UpdateUser(ui);
            //    return "Updated Success";

            //}

        }
    }
