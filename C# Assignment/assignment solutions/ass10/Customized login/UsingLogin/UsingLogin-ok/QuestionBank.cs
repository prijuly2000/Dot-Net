using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsingLogin_ok
{
    class QuestionBank
    {
        Question[] q;
        public QuestionBank()
        {
            q = new Question[5];
            Question q1 = new Question("Que1", "Q1OP1", "Q1OP2", "Q1OP3", "Q1OP4", "Q1OP1");
            Question q2 = new Question("Que2", "Q2OP1", "Q2OP2", "Q2OP3", "Q2OP4", "Q2OP2");
            Question q3 = new Question("Que3", "Q3OP1", "Q3OP2", "Q3OP3", "Q3OP4", "Q3OP3");
            Question q4 = new Question("Que4", "Q4OP1", "Q4OP2", "Q4OP3", "Q4OP4", "Q4OP4");
            Question q5 = new Question("Que5", "Q5OP1", "Q5OP2", "Q5OP3", "Q5OP4", "Q5OP1");

            q[0] = q1;
            q[1] = q2;
            q[2] = q3;
            q[3] = q4;
            q[4] = q5;
        }
                

        public Question this[int index]
        {
            get { return q[index]; }
            set { q[index] = value; }
        }


    }
}
