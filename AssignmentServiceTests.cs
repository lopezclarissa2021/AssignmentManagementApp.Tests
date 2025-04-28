using AssignmentManagementApp.Services;


namespace AssignmentManagementApp.Tests
{
    public class AssignmentServiceTests
    {
        [Fact]
        public void AddAssignment_IsNull_ThrowsError()
        {
            var service = new AssignmentService();
            Assert.Throws<ArgumentNullException>(() => service.AddAssignment(null));
        }
        [Fact]
        public void AddAssignment_ValidAssignment_AddSuccessfully()
        {
            // Arrange

            var service = new AssignmentService();
            var assignment = new Assignment("Test Assignment", "Test Description", DateTime.Now.AddDays(7));
            // Act
            service.AddAssignment(assignment);
            // Assert
            Assert.Equal(new List<Assignment> {assignment}, service.GetAllAssignments());
        }
    }
}

