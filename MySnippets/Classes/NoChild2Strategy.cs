using System;

namespace MySnippets.Classes
{
    public class NoChild2Strategy : ValidationStrategy
    {
        protected override Predicate<ParentModel> Predicate
        {
            get { return x => x.Child2.Id != ValidationObj.Child2.Id; }
        }

        public override string ErrorMessage
        {
            get { return "Child2 занят"; }
        }
    }
}