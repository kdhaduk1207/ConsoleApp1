using System.Collections.Generic;

namespace MasterDetail
{
    public class UserDetail
    {

        public int Id { get; set; }

        public string Name { get; set; }
    }

    public class QuestionDetail
    {

        public int Id { get; set; }

        public string Question { get; set; }

        public int CorrectAnswerId { get; set; }

        public AnswerDetail CorrectAnswer { get; set; }

        public IList<AnswerDetail> Answers { get; set; }
    }


    public class AnswerDetail
    {

        public int Id { get; set; }

        public string Answer { get; set; }

        public int QuestionId { get; set; }


    }
}
