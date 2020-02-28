namespace PluralizationServices
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using PluralizationServices.Rules;
    using PluralizationServices.Rules.RuleEndedInL;

    public sealed class PortuguesePluralizationService : IPluralizationService
    {
        private static readonly IReadOnlyList<Func<string, PluralizationRule>> PluralizeRules = new List<Func<string, PluralizationRule>>
        {
            world => new SpecialPluralizationRuleEndedInRZ(world),
            world => new SpecialPluralizationRuleEndedInN(world),
            world => new SpecialPluralizationRuleEndedInAl(world),
            world => new SpecialPluralizationRuleEndedInEl(world),
            world => new SpecialPluralizationRuleEndedInIl(world),
            world => new SpecialPluralizationRuleEndedInOl(world),
            world => new SpecialPluralizationRuleEndedInUl(world),
            world => new BasicPluralizationRule(world),
        };

        private static readonly IReadOnlyList<Func<string, PluralizationRule>> SingularizeRules = new List<Func<string, PluralizationRule>>
        {
            world => new SpecialSingularizeRuleEndedInRZ(world),
            world => new SpecialSingularizeRuleEndedInN(world),
            world => new BasicSingularizeRule(world),
        };

        public bool IsPlural(string word) => PluralizeRules.All(newRule => !newRule(word).Verify());

        public bool IsSingular(string word) => SingularizeRules.All(newRule => !newRule(word).Verify());

        public string Pluralize(string word)
        {
            foreach (var newRule in PluralizeRules)
            {
                var rule = newRule(word);

                if (rule.Verify())
                {
                    return rule.Apply();
                }
            }

            return word;
        }

        public string Singularize(string word)
        {
            foreach (var newRule in SingularizeRules)
            {
                var rule = newRule(word);

                if (rule.Verify())
                {
                    return rule.Apply();
                }
            }

            return word;
        }
    }
}
