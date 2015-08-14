using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsingLogin_ok
{
    class Question
    {
        string que_id, option1, option2, option3, option4, ans;int marks;
        public Question()
        {
            ans=que_id = option1 = option2 = option3 = option4 = "";
            marks = 1;
        }

        public Question(string que_id, string option1, string option2, string option3, string option4, string ans)
        {
            this.ans = ans;
            this.marks = 1;
            this.que_id = que_id;
            this.option1 = option1;
            this.option2 = option2;
            this.option3 = option3;
            this.option4 =option4;
            marks = 1;

        }

        public string ID
        {
            get { return que_id; }
            set { que_id = value; }
        }

        public string OPTION1
        {
            get { return option1; }
            set { option1 = value; }
        }

        public string OPTION2
        {
            get { return option2; }
            set { option2 = value; }
        }

        public string OPTION3
        {
            get { return option3; }
            set { option3 = value; }
        }

        public string OPTION4
        {
            get { return option4; }
            set { option4 = value; }
        }

        public string ANS
        {
            get { return ans; }
            set { ans = value; }
        }

        public int MARKS
        {
            get { return marks; }
            set { marks = value; }
        }
    }
}
