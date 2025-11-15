using Xunit;

public class TodoTest
{
    [Fact]
    public void GetName()
    {
        // Given
        var todo = new Todo("Finish homework");
        // When
    
        // Then
        Assert.Equal(todo.GetName(),"Finish homework");
        Assert.NotEqual(todo.GetName(),"Finish homeworkk");
    }

    [Fact]
    public void IsDoneTest()
    {
        // Given
        var todo = new Todo("Finish homework");
        Assert.Equal(todo.IsDone(),false);
        // When
        todo.Done();
        // Then
        Assert.Equal(todo.IsDone(),true);
    }
}