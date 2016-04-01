using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySnippets.Classes;

namespace MySnippets
{
    class ValidationCallExample
    {
        public static void Run()
        {
            ParentModel p1 = new ParentModel
            {
                Child1 = new ChildModel1 { Id = 1 },
                Child2 = new ChildModel2 { Id = 2 },
                Begin = DateTime.Now,
                End = DateTime.Now.AddDays(1)
            };
            ModelValidator validator = new ModelValidator(p1);
            //var collection = DbContext.Model....
            var collection = new List<ParentModel>();
            string validationErrorMessage = validator
                .AddStrategy(new NoChild1Strategy())
                .AddStrategy(new NoChild2Strategy())
                .AddStrategy(new RentTimeStrategy())
                .Validate(collection);
        }
    }
}
