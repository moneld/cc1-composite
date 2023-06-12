namespace cc1_composite;

public abstract class Component
{
    protected string name;

    public int level;

    protected Component(string name)
    {
        this.name = name;
    }

    public abstract void view();

    public string indentation()
    {
        string str = "";

        for (int i = 0; i < level; i++)
        {
            str += "\t";
        }

        return str;
    }


}