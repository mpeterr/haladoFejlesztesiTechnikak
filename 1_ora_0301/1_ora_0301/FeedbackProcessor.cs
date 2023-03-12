namespace _1_ora_0301
{
    class FeedbackProcessor
    {

        private Dictionary<Category,Action<Feedback>> Actions;
        private List<Feedback> Feedbacks;

        public FeedbackProcessor(Action<Feedback> DefaultAction)
        {
            Actions = new Dictionary<Category, Action<Feedback>>();
            Feedbacks = new List<Feedback>();

            foreach (Category category in Enum.GetValues(typeof(Category)))
            {
                Actions[category] = DefaultAction;
            }
            Feedbacks = new List<Feedback>();
        }

        public void AddFeedback(Feedback fb)
        {
            Feedbacks.Add(fb);
            if (Feedbacks.Count == 3)
            {

            }
        }

        public void AddAction(Category category, Action<Feedback> action, bool dooverwrite)
        {
            if (dooverwrite) Actions(category) += action;
            else Actions(category) = action;
        }
    }
}