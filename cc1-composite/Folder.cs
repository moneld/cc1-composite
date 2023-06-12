namespace cc1_composite;

public class Folder : Component
{
    private List<Component> _components = new List<Component>();
    public Folder(string name) : base(name)
    {
    }

    public override void view()
    {
        string tab = indentation();
        Console.WriteLine(tab + "Folder : " + name );
        
        foreach (var component in _components)
        {
           component.view();
        }
    }

    public Component addComponent(Component component)
    {
        component.level = this.level + 1;
        _components.Add(component);

        return component;
    }
}