using LibraryManagement.Common;

namespace LibraryManagement.Models;

public abstract class Member : IDisplayable
{
    public int Id { get; }
    public string FullName { get; private set; }
    public string PhoneNumber { get; private set; }
    public int ActiveLoanCount { get; private set; }
    public abstract string MemberType { get; }
    public abstract int BorrowLimit { get; }

    protected Member(int id, string fullName, string phoneNumber)
    {
        if (id <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(id), "Id musbat bo'lishi kerak.");
        }

        this.Id = id;
        this.UpdateContact(fullName, phoneNumber);
    }

    public bool CanBorrow()
    {
        return ActiveLoanCount < BorrowLimit;
    }

    public virtual decimal CalculateFine(int lateDays, decimal dailyFine)
    {
        return lateDays <= 0 ? 0 : lateDays * dailyFine;
    }

    public virtual string GetSummary()
    {
        return $"Id: {Id}, F.I.Sh.: {FullName}, Telefon: {PhoneNumber}, " +
               $"A'zo turi: {MemberType}, Olingan materiallar: {ActiveLoanCount}/{BorrowLimit}";
    }

    public void UpdateContact(string fullName, string phoneNumber)
    {
        if (string.IsNullOrWhiteSpace(fullName))
        {
            throw new ArgumentException("To'liq ism bo'sh bo'lmasligi kerak.", nameof(fullName));
        }

        if (string.IsNullOrWhiteSpace(phoneNumber))
        {
            throw new ArgumentException("Telefon raqami bo'sh bo'lmasligi kerak.", nameof(phoneNumber));
        }

        this.FullName = fullName;
        this.PhoneNumber = phoneNumber;
    }

    public void IncreaseActiveLoans()
    {
        this.ActiveLoanCount++;
    }

    public void DecreaseActiveLoans()
    {
        if (ActiveLoanCount > 0)
        {
            this.ActiveLoanCount--;
        }
    }
}
