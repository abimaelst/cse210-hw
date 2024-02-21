public class ReceptionEvent : Event
{
    public string EmailForRSVP { get; set; }

    public ReceptionEvent(string title, string description, DateTime date, string time, Address address, string emailForRSVP)
        : base(title, description, date, time, address)
    {
        EmailForRSVP = emailForRSVP;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nRSVP at: {EmailForRSVP}";
    }
}
