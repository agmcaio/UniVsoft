namespace GuessingGame.src
{
    public class NewQuestion : GameQuestion
    {
        public NewQuestion() : base()
        {
            Tip = "";
        }

        public NewQuestion(string question, string response, string tip) : base(question, response)
        {
            Tip = tip;
        }

        private string tip;
        public string Tip
        {
            get { return tip; }
            set { tip = value.ToUpper(); }
        }

    }
}
