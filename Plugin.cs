using BepInEx;
using UnityEngine;

namespace LCOS.LowGravity;

[BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
public class Plugin : BaseUnityPlugin
{
    private void Awake()
    {
        // Ensure the gravity is set at the start
        Physics.gravity = new Vector3(0, -4.9f, 0);  // Reduced gravity
        Logger.LogInfo("Custom Gravity Mod Loaded: Gravity set to " + Physics.gravity);
    }

    private void Update()
    {
        // Continuously check and set the gravity to ensure it remains constant
        if (Physics.gravity.y != -4.9f)
        {
            Physics.gravity = new Vector3(0, -4.9f, 0);
            Logger.LogInfo($"Gravity was reset, now set to: {Physics.gravity}");
        }
    }
}
