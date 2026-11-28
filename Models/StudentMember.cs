namespace LibraryManagement.Models;

public class StudentMember : Member
{
    public string GroupName { get; private set; }
    public override string MemberType => "Talaba";
    public override int BorrowLimit => 3;

    public StudentMember(int id, string fullName, string phoneNumber, string groupName)
        : base(id, fullName, phoneNumber)
    {
        this.GroupName = groupName;
    }

    public override decimal CalculateFine(int lateDays, decimal dailyFine)
    {
        return base.CalculateFine(lateDays, dailyFine) / 2;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()}, Guruh: {GroupName}";
    }
}
