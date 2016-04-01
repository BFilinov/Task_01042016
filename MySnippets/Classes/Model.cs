using System;

namespace MySnippets.Classes
{
    public class ParentModel
    {
        public ChildModel1 Child1 { get; set; }
        public ChildModel2 Child2 { get; set; }

        public DateTime Begin { get; set; }
        public DateTime End { get; set; }
    }

    public class ChildModel1
    {
        public int Id { get; set; }
    }

    public class ChildModel2
    {
        public int Id { get; set; }
    }
}
