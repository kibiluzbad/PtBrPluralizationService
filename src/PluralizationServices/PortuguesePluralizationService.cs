using System.Collections.Generic;
using System.Data.Entity.Design.PluralizationServices;
using PluralizationServices.Rules;

namespace PluralizationServices
{
    public class PortuguesePluralizationService : PluralizationService
    {
        readonly IList<IPluralizationRule> _pluralizeRules = new IPluralizationRule[]
        {
            new SpecialPluralizationRuleEndedInRZ(),
            new SpecialPluralizationRuleEndedInN(),
            new BasicPluralizationRule()
        };

        readonly IList<IPluralizationRule> _singularizeRules = new IPluralizationRule[]
        {
            new SpecialSingularizeRuleEndedInRZ(),
            new SpecialSingularizeRuleEndedInN(),
            new BasicSingularizeRule()
        };

        public override bool IsPlural(string word)
        {
            foreach (var rule in _pluralizeRules)
            {
                rule.Word = word;
                if (rule.Verify()) return false;
            }

            return true;
        }

        public override bool IsSingular(string word)
        {
            foreach (var rule in _singularizeRules)
            {
                rule.Word = word;
                if (rule.Verify()) return false;
            }

            return true;
        }

        public override string Pluralize(string word)
        {
            foreach (var rule in _pluralizeRules)
            {
                rule.Word = word;
                if (rule.Verify()) return rule.Apply();
            }

            return word;
        }

        public override string Singularize(string word)
        {
            foreach (var rule in _singularizeRules)
            {
                rule.Word = word;
                if (rule.Verify()) return rule.Apply();
            }

            return word;
        }
    }
}
