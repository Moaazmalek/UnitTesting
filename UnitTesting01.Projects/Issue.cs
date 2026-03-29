

using UnitTesting02.Projects.Exceptions;

namespace UnitTesting02.Projects
{
    public class Issue
    {
        public string Key { get;private set; }
        public string Description { get;private set; }
        public DateTime CreatedAt { get;private set; }
        public Priority Priority { get;private set; }
        public Category Category { get; private set; }
        public Issue(string description, Priority priority,Category category, DateTime? createdAt=null)
        {
            if (string.IsNullOrWhiteSpace(description))
                throw new InvalidIssueDescriptionException();
            Description = description;
            this.Priority = priority;
            this.Category = category;
            this.CreatedAt = createdAt is null ? DateTime.Now : createdAt.Value;
            this.Key = GenerateKey();

        }
        private string GenerateKey()
        {
            var categorySegment = Category switch
            {
                Category.Hardware => "HW",
                Category.Software=> "SW",
                _=> "NA"
            };

            var prioritySegment = Priority switch { 
            Priority.Low => "L",
            Priority.Medium=> "M",
            Priority.High=> "H", 
            _=> "U"};

            var yearSegment = CreatedAt.Year.ToString(); // YYYY

            var uniqueId = Guid.NewGuid().ToString().Substring(0, 8).ToUpper();

            return $"{categorySegment}-{yearSegment}-{prioritySegment}-{uniqueId}";
        }
        public override string ToString()
        {
            return $"[{Key}] {Description}";
        }
    }
}
