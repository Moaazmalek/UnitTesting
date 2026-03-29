
namespace UnitTesting02.Projects.Exceptions
{
    public class InvalidIssueDescriptionException(string message= "Issue description cannot be null or whitespace"): Exception(message)
    {
        
    }
}
