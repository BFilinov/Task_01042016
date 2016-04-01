using System.Collections.Generic;
using System.Linq;

namespace MySnippets.Classes
{
    public class ModelValidator
    {
        private readonly ICollection<ValidationStrategy> _strategies;
        private readonly ParentModel _valObject;

        public ModelValidator(ParentModel valObject, params ValidationStrategy[] strategies)
        {
            _valObject = valObject;
            _strategies = strategies.ToList();
        }

        public ModelValidator AddStrategy(ValidationStrategy strategy)
        {
            _strategies.Add(strategy);
            return this;
        }

        public string Validate(IEnumerable<ParentModel> collection = null)
        {
            foreach (var strategy in _strategies)
                strategy.SetValidationObject(_valObject);
            return _strategies.All(x => x.IsValid(collection)) ?
                string.Empty :
                string.Join("; ", _strategies.Select(x => x.ErrorMessage));
        }
    }
}