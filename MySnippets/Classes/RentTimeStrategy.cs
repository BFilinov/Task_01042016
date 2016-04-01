using System;

namespace MySnippets.Classes
{
    public class RentTimeStrategy : ValidationStrategy
    {
        protected override Predicate<ParentModel> Predicate
        {
            get { return x => x.Begin <= x.End; }
        }

        public override string ErrorMessage
        {
            get { return "время окончания не может быть меньше времени начала"; }
        }
    }
}