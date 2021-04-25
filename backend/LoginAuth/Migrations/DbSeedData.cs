using System.Collections.Generic;
using LoginAuth.Data;
using System.Data.Entity.Migrations;
using LoginAuth.Models.ClubModels;

namespace LoginAuth.Migrations
{
    public class DbSeedData
    {
        private readonly ApplicationDbContext _db;

        public DbSeedData(ApplicationDbContext db)
        {
            _db = db;
        }

        public void EnsureSeedData()
        {
            //------------------------BOOK CLUB-----------------------------------
            //------------NOVEL--------------
            List<Choice> choice1 = new List<Choice>()
            {
                new() {Text = "0-100"}, 
                new() {Text = "100-200"}, 
                new() {Text = "200-400"}, 
                new() {Text = "400+"}
            };
            
            Question q1 = new Question()
            {
                Text = "On average, how many pages of books do you read in a month?",
                Choices = choice1
            };

            _db.Questions.Add(q1);

            List<Choice> choice2 = new List<Choice>()
            {
                new (){Text ="0-3"},
                new (){Text = "3-6"},
                new (){Text = "6-9"},
                new (){Text = "9+"}
            };
            Question q2 = new Question()
            {
                Text = "How many novel have you read so far?",
                Choices = choice2
            };

            _db.Questions.Add(q2);

            List<Choice> choice3 = new List<Choice>()
            {
                new (){Text ="low"},
                new (){Text = "medium"},
                new (){Text = "high"},
                new (){Text = "extreme"}
            };
            Question q3 = new Question()
            {
                Text = "How much do you like adventure movies?",
                Choices = choice3
            };

            _db.Questions.Add(q3);

            _db.SaveChanges();

            var qList1 = new List<Question> {q1, q2, q3};

            SubClub sub1 = new SubClub()
            {
                Title = "Novel",
                Questions = qList1
            };

            _db.SubClubs.Add(sub1);
            _db.SaveChanges();
            //--------------Action--------------
            List<Choice> choice4 = new List<Choice>()
            {
                new (){Text ="low"},
                new (){Text = "medium"},
                new (){Text = "high"},
                new (){Text = "extreme"}
            };

            Question q4 = new Question()
            {
                Text = "How much do you like action movies?",
                Choices = choice4
            };

            _db.Questions.Add(q4);

            List<Choice> choice5 = new List<Choice>()
            {
                new (){Text ="0-3"},
                new (){Text = "3-6"},
                new (){Text = "6-9"},
                new (){Text = "9+"}
            };
            Question q5 = new Question()
            {
                Text = "How many action books have you read before?",
                Choices = choice5
            };

            _db.Questions.Add(q5);

            _db.SaveChanges();

            var qList2 = new List<Question> {q4, q5};
            
            SubClub sub2 = new SubClub()
            {
                Title = "Action",
                Questions = qList2
            };

            _db.SubClubs.Add(sub2);
            _db.SaveChanges();
            
            var subList1 = new List<SubClub> {sub1, sub2};

            Club club1 = new Club
            {
                Title = "Book",
                SubClubs = subList1
            };

            _db.Clubs.Add(club1);
            _db.SaveChanges();

            //-------------------SPORT CLUB------------------------------
            //------------Tennis-------------
            List<Choice> choice6 = new List<Choice>()
            {
                new (){Text ="None"},
                new (){Text = "Once"},
                new (){Text = "More than once"},
            };
            Question q6 = new Question()
            {
                Text = "Have you ever watched a tennis game?",
                Choices = choice6
            };

            _db.Questions.Add(q6);
            
            List<Choice> choice7 = new List<Choice>()
            {
                new (){Text ="None"},
                new (){Text = "a few times"},
                new (){Text = "often"},
            };

            Question q7 = new Question()
            {
                Text = "Have you ever played tennis?",
                Choices = choice7
            };

            _db.Questions.Add(q7);
            
            List<Choice> choice8 = new List<Choice>()
            {
                new (){Text ="Not much"},
                new (){Text = "Good"},
                new (){Text = "Expert"},
            };

            Question q8 = new Question()
            {
                Text = "How good do you think you know tennis game rules?",
                Choices = choice8
            };

            _db.Questions.Add(q8);
            _db.SaveChanges();
            
            var qList3 = new List<Question> {q6, q7, q8};

            SubClub sub3 = new SubClub()
            {
                Title = "Tennis",
                Questions = qList3
            };

            _db.SubClubs.Add(sub3);
            _db.SaveChanges();
            
            //--------------Basketball---------------------
            List<Choice> choice9 = new List<Choice>()
            {
                new (){Text ="0-30"},
                new (){Text = "30-60"},
                new (){Text = "60-90"},
                new (){Text = "90+"}
            };

            Question q9 = new Question()
            {
                Text = "How many hours have you played basketball so far?",
                Choices = choice9
            };

            _db.Questions.Add(q9);
            
            List<Choice> choice10 = new List<Choice>()
            {
                new (){Text ="0-2"},
                new (){Text = "2-10"},
                new (){Text = "10-50"},
                new (){Text = "50+"}
            };

            Question q10 = new Question()
            {
                Text = "Have many basketball game have you ever watched?",
                Choices = choice10
            };

            _db.Questions.Add(q10);
            _db.SaveChanges();

            var qList4 = new List<Question> {q9, q10};

            SubClub sub4 = new SubClub()
            {
                Title = "Basketball",
                Questions = qList4
            };

            _db.SubClubs.Add(sub4);
            _db.SaveChanges();

            var subList2 = new List<SubClub> {sub3, sub4};

            Club club2 = new Club
            {
                Title = "Sport",
                SubClubs = subList2
            };

            _db.Clubs.Add(club2);
            _db.SaveChanges();

            //---------------------------MUSIC------------------
            //----------Classical Music--------------
            List<Choice> choice11 = new List<Choice>()
            {
                new (){Text ="0-1"},
                new (){Text = "1-2"},
                new (){Text = "2-4"},
                new (){Text = "4+"}
            };

            Question q11 = new Question()
            {
                Text = "How many hours per day do you listen to music?",
                Choices = choice11
            };

            _db.Questions.Add(q11);
            
            List<Choice> choice12 = new List<Choice>()
            {
                new (){Text ="None"},
                new (){Text = "Not much"},
                new (){Text = "Sometimes"},
                new (){Text = "Often"}
            };
            Question q12 = new Question()
            {
                Text = "How much do you like listening different music kinds?",
                Choices = choice12
            };

            _db.Questions.Add(q12);
            
            List<Choice> choice13 = new List<Choice>()
            {
                new (){Text ="None"},
                new (){Text = "Not much"},
                new (){Text = "Sometimes"},
                new (){Text = "Often"}
            };
            Question q13 = new Question()
            {
                Text = "How much do you like talking about music history?",
                Choices = choice13
            };

            _db.Questions.Add(q13);
            
            List<Choice> choice14 = new List<Choice>()
            {
                new (){Text ="0-5"},
                new (){Text = "5-15"},
                new (){Text = "15-30"},
                new (){Text = "30+"}
            };
            Question q14 = new Question()
            {
                Text = "How many classical musics have you ever listened?",
                Choices = choice14
            };

            _db.Questions.Add(q14);

            _db.SaveChanges();
            
            var qList5 = new List<Question> {q11, q12, q13, q14};
            
            SubClub sub5 = new SubClub()
            {
                Title = "Classical Music",
                Questions = qList5
            };

            _db.SubClubs.Add(sub5);
            _db.SaveChanges();

            var subList3 = new List<SubClub> {sub5};
            
            Club club3 = new Club
            {
                Title = "Music",
                SubClubs = subList3
            };

            _db.Clubs.Add(club3);
            _db.SaveChanges();
        }
    }
}