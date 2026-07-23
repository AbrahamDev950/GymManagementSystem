using Gym.Domain.Enums;

namespace Gym.Domain.Entities;

public class User
{
    public Guid Id { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Email{ get; private set; }
    public string PhoneNumber{ get; private set; }
    public Role Role { get; private set; }
    public string PasswordHash{ get; private set; }
    public bool IsActive{ get; private set; }

    public User(
        string firstName,
        string lastName,
        string email,
        string phoneNumber,
        Role role,
        string passwordHash)
    {
        this.Id = Guid.NewGuid();
        this.FirstName = ValidateFirstName(firstName);
        this.LastName = ValidateLastName(lastName);
        this.Email = ValidateEmail(email);
        this.PhoneNumber = ValidatePhoneNumber(phoneNumber);
        this.Role = ValidateRole(role);
        this.PasswordHash = ValidatePassword(passwordHash);
        this.IsActive = false;
    }

    private static string ValidateEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
        {
            throw new ArgumentException("Email cannot be null or empty");
        }

        if (!email.Contains("@"))
        {
            throw new ArgumentException("Email must contain a @");
        }
        return email;
    }

    private static string ValidatePhoneNumber(string phoneNumber)
    {
        if (string.IsNullOrWhiteSpace(phoneNumber))
        {
            throw new ArgumentException("PhoneNumber cannot be null or empty");
        }

        if (phoneNumber.Length < 10 || phoneNumber.Length > 15)
        {
            throw new ArgumentException("PhoneNumber must be between 10 and 15 characters");
        }
        return phoneNumber;
    }

    private static Role ValidateRole(Role role)
    {
        if (role != Role.Admin && role != Role.Receptionist && role != Role.Trainer)
        {
            throw new ArgumentException("Role must be Admin, Receptionist or Trainer");
        }
        return role;
    }

    private static string ValidatePassword(string password)
    {
        if (string.IsNullOrWhiteSpace(password))
        {
            throw new ArgumentException("Password cannot be null or empty");
        }

        if (password.Length < 8)
        {
            throw new ArgumentException("Password must be at least 8 characters long");
        }
        return password;
    }

    private static string ValidateFirstName(string firstName)
    {
        if (string.IsNullOrWhiteSpace(firstName))
        {
            throw new ArgumentException("FirstName cannot be null or empty");
        }
        return firstName;
    }

    private static string ValidateLastName(string lastName)
    {
        if (string.IsNullOrWhiteSpace(lastName))
        {
            throw new ArgumentException("LastName cannot be null or empty");
        }
        return lastName;
    }
    
    public void SwitchStatus()
    {
        IsActive = !IsActive;
    }
}
