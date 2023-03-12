using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace _1_ora_0301
{
    public enum Category
    {
        OPINION,
        BUGREPORT,
        FEATUREREQ
    }
    class Program
    {
        static void WriteToConsole(Feedback fb)
        {
            Console.WriteLine("No action was defined for this category" + fb.Category);
        }
        public static void Main(string[] args)
        {
            Feedback opinion1 = new Feedback(Category.OPINION, "This software is not worth the money");
            Feedback bugreport1 = new Feedback(Category.BUGREPORT, "SW freezes when adding new user");
            Feedback featreq1 = new Feedback(Category.FEATUREREQ, "Please add a way to clear the database");
            Feedback opinion2 = new Feedback(Category.OPINION, "The best solution out there");

            FeedbackProcessor fproc = new FeedbackProcessor(fb =>
            {
                Console.WriteLine("No action was defined for this category" + fb.Category);
            }); // parameterkent adjunk at egy
                // default handlert ami kiirja hogy az adott
                // kategoriahoz meg nincs feedback

            fproc.AddAction(Category.BUGREPORT, WriteToConsole, true); // 3. parameter: doOverwrite
            fproc.AddAction(Category.FEATUREREQ, WriteToConsole, true); // ha false akkor ezt az actiont IS meghivja

            fproc.AddFeedback(opinion1);
            fproc.AddFeedback(bugreport1);
            fproc.AddFeedback(featreq1);
            fproc.AddFeedback(opinion2);
        }
    }
}