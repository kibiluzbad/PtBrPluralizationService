namespace PluralizationServices.Rules
{
    public interface IPluralizationRule
    {
        string Word { get; set; }
        bool Verify();
        string Apply();
    }
}
