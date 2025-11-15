namespace Model;

public class Todo
{
    string name ="";
    bool done = false;

    public Todo(string name)
    {
        this.name = name;
        done = false;
    }

    public string GetName()
    {
        return this.name;
    }

    public bool IsDone()
    {
        return this.done;
    }

    public void Done()
    {
        this.done = true;        
    }
}