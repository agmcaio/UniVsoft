namespace GuessingGame.src
{
    public class GameQuestion
    {

        public GameQuestion()
        {
           Question = "";
           Response = "";
        }
        public GameQuestion(string question, string response)
        {
            Question= question; 
            Response= response;
        }

        private string question;
        public string Question
        {
            get { return question; }
            set { question = value.ToUpper(); }
        }


        private string response;
        public string Response
        {
            get { return response; }
            set { response = value.ToUpper(); }
        }
    }
}
