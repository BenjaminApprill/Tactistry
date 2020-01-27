public static class InitPaths
{
    const string SObjPath = "Assets/Editor/ProjectWindow/ScriptableObject/";

    public static string Project_Window_Init(string name)
    {
        return SObjPath + name + ".asset";
    }
}
