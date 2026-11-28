namespace LibraryManagement.Models;

public class TeacherMember : Member
{
    public string Department { get; private set; }
    public override string MemberType => "O‘qituvchi";
    public override int BorrowLimit => 5;

    public TeacherMember(int id, string fullName, string phoneNumber, string department)
        : base(id, fullName, phoneNumber)
    {
        this.Department = department;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()}, Kafedra: {Department}";
    }
}
