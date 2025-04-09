namespace AssignmentManagementApp.Tests
{
    public class AssignmentTests
    {
        [Fact]
        public void Assignment_should_Have_A_Title()
        {
            var assignment = new Assignment();
            Assert.NotNull(assignment.Title);
        }
    }
}
