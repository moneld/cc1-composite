namespace cc1_composite;

public class File : Component
{
    public File(string name) : base(name)
    {
    }

    public override void view()
    { 
        string tab = indentation();
        
       Console.WriteLine(tab + "File : " + name);
    }
}