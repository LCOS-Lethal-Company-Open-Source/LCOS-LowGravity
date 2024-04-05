using BepInEx;
using UnityEngine;

namespace LCOS.LowGravity;

[BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
public class Plugin : BaseUnityPlugin
{
    private void Awake()
    {
        Logger.LogInfo("Custom Gravity Mod Loaded");

        // Set a low gravity value at startup
        Physics.gravity = new Vector3(0, -4.9f, 0);
    }

    private void Update()
    {
        Logger.LogInfo($"Current Gravity: {Physics.gravity}");
    }
}
