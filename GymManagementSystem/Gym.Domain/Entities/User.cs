namespace Gym.Domain.Entities;

public class User
{
    public Guid _id { get; private set; }
    public string _firstName { get; private set; }
    public string _lastName { get; private set; }
    public string _email{ get; private set; }
    public string _phoneNumber{ get; private set; }
    public enum _role;
    public string _passwordHash{ get; private set; }
    public bool _isActive{ get; private set; }
    
}