class Reception : Event
{
    private string _rsvpContact;

    public Reception(string eventTitle, string description, string date, string time, Address address, string rsvpContact) : base(eventTitle, description, date, time, address)
    {
        _rsvpContact= rsvpContact;
    }

    public string GetRsvpContact()
    {
        return _rsvpContact;
    }
}