using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

public class MainClass
{
    public static void Main()
    {
        Developer dev1 = new PanelDeveloper();
        Developer dev2 = new WoodDeveloper();

        House house1 = dev1.Create();
        House house2 = dev2.Create();
    }
}

public abstract class Developer
{
    public abstract House Create();
}

public abstract class House
{
}

public class PanelDeveloper : Developer
{
    public override House Create()
    {
        return new PanelHouse();
    }
}

public class WoodDeveloper : Developer
{
    public override House Create()
    {
        return new WoodHouse();
    }
}


public class WoodHouse : House
{
}

public class PanelHouse : House
{
}