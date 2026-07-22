using HarmonyLib;
using System;

namespace GlobalPickup
{
    class PickupHook
    {
        [HarmonyPatch(typeof(DropManager), "AutoPickUpUpdate")]
        [HarmonyPrefix]
        static void AutoPickUpUpdatePrefix()
        {
            DropManager.StartGlobalPickUp = true;
        }
    }
}