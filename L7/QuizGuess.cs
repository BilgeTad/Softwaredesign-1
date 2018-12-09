using System;

namespace L7
{
    class QuizGuess : Quizelement
    {
        public int correct;
        public QuizGuess(String question, int correct)
        {
            this.question = question;
            this.correct = correct;
            this.callToAction = "Schätzen Sie die richtige Zahl:";

        }
        public override void show()
        {
            Console.WriteLine(question);
            Console.WriteLine(callToAction);
        }
        public override bool isAnswerCorrect(string choice)
        {
            int currentChoice = Int32.Parse(choice);
            if (currentChoice == correct)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}