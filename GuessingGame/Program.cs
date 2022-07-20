using GuessingGame.src;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Questions List
            List<NewQuestion> questions;
            questions = CreateQuestions();

            // Question display for user
            Random rnd = new Random();
            int position = rnd.Next(0, questions.Count);
            NewQuestion question = questions[position];

            // Response Logic
            var attempts = 0;
            var flag = false;
            var responseUser = "";

            while(attempts <= 3 && flag == false)
            {
                Console.WriteLine("Pergunta: {0}", question.Question);
                Console.WriteLine("Resposta:");
                responseUser = Console.ReadLine().ToUpper();

                if(responseUser == question.Response)
                {
                    flag = true;
                }
                else
                {
                    Console.WriteLine("Errou!");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Temos uma dica para você: {0}", question.Tip);
                }
            }
            if(flag)
            {
                Console.WriteLine("Ganhou!");
            }
            else
            {
                Console.WriteLine("Perdeu");
            }
            Console.ReadKey();
        }

        static List<NewQuestion> CreateQuestions()
        {
            List<NewQuestion> questionsList = new List<NewQuestion>();
            questionsList.Add(new NewQuestion("Qual a cor do céu?", "Azul", "mar"));
            questionsList.Add(new NewQuestion("Qual o nome do dono do facebook?", "Mark Zuckberg", "Mark ..."));
            questionsList.Add(new NewQuestion("Aplicativo de assistir filmes", "Netflix", "Tudum"));
            return questionsList;
        }
    }
}
