namespace Candor.Core.Mod;

public class Mod
{
    // Human readable name
    public string modName { get; set; }
    // Relative path to mod file from the "ModStore" e.g. ModStore is C:\Mods\<game>, filePath would be "someFile.mod"
    public string filePath { get; set; }
    // The state the mod is currently in
    public State modState { get; set; }
    // Extra info the mod can store, such as associated files to ease disabling/uninstalling
    public ModInfo ModInfo { get; set; }

    public enum State
    {
        // The order of which the mod will be enabled, starting from uninstalled, to disabled, then finally enabled.
        Uninstalled,
        Disabled,
        Enabled
    }
}