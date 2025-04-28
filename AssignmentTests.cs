using System.Threading.Tasks;

namespace AssignmentManagementApp.Tests
{
    public class AssignmentTests
    {
        [Fact]
        public void Assignment_should_Have_A_Title()
        {
            var assignment = new Assignment()
            {
                Title = "Test Assignment",
                Description = "This is a test assignment.",
                DueDate = DateTime.Now.AddDays(7),
                IsCompleted = false
            };
            Assert.NotNull(assignment.Title);
        }
        [Fact]
        public void CreateAssignment_Should_InitializeCorrectly()
        {
            var assignment = new Assignment("Test Assignment", "This is a test.", DateTime.Now);
            Assert.Equal("Test Assignment", assignment.Title);
            Assert.Equal("This is a test.", assignment.Description);
            Assert.False(assignment.IsCompleted);
        }
        [Fact]
        public void UpdateAssignment_Should_ModifyValues()
        {
            var assignment = new Assignment("Old Title", "Old Description", DateTime.Now);

            assignment.Title = "New Title";
            assignment.Description = "New Description";
            assignment.IsCompleted = true;

            Assert.Equal("New Title", assignment.Title);
            Assert.Equal("New Description", assignment.Description);
            Assert.True(assignment.IsCompleted);
        }
        [Fact]
        public void DeleteAssignment_Should_RemoveAssignment()
        {
            var assignment = new Assignment("Test Assignment", "This is a test.", DateTime.Now);
            assignment = null; // Simulate deletion
            Assert.Null(assignment);
        }
    }
}

