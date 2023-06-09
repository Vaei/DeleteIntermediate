string ProjectDir = Directory.GetCurrentDirectory();
string PluginsDir = ProjectDir + "\\Plugins";

if (Directory.Exists(ProjectDir))
{
    string[] ProjectIntermediate = Directory.GetDirectories(ProjectDir, "Intermediate", SearchOption.AllDirectories);
    string[] PluginIntermediate = Directory.GetDirectories(PluginsDir, "Intermediate", SearchOption.AllDirectories);

    List<string> Intermediate = new List<string>();
    foreach (string d in ProjectIntermediate)
    {
        Intermediate.Add(d);
    }
    foreach (string d in PluginIntermediate)
    {
        Intermediate.Add(d);
    }

    foreach (string d in Intermediate)
    {
        Directory.Delete(d, true);
    }
}