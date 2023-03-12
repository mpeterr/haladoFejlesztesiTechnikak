using System.ComponentModel;

namespace _1_ora_0301
{
    class Feedback
    {
        public Category Category { get; } 
        public string Description { get; }

        public Feedback(Category category, string description)
        {
            Category = category;
            Description = description; 
        }
    }
}