using System;

namespace MySnippets.Classes
{
    public class NoChild1Strategy : ValidationStrategy
    {
        protected override Predicate<ParentModel> Predicate
        {
            get { return x => x.Child1.Id != ValidationObj.Child1.Id; }
        }

        public override string ErrorMessage
        {
            get { return "Child1 занят"; }
        }
    }
}