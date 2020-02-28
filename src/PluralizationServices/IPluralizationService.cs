namespace PluralizationServices
{
    public interface IPluralizationService
    {
        bool IsPlural(string word);

        bool IsSingular(string word);

        string Pluralize(string word);

        string Singularize(string word);
    }
}
