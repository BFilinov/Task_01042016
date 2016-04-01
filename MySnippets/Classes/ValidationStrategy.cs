using System;
using System.Collections.Generic;
using System.Linq;

namespace MySnippets.Classes
{

    public abstract class ValidationStrategy
    {
        protected ParentModel ValidationObj;
        protected abstract Predicate<ParentModel> Predicate { get; }
        public abstract string ErrorMessage { get; }
        public bool IsValid(IEnumerable<ParentModel> collection)
        {
            return collection == null ? Predicate.Invoke(ValidationObj) :
                collection.All(x => Predicate.Invoke(x));
        }

        public void SetValidationObject(ParentModel model)
        {
            ValidationObj = model;
        }
    }
}