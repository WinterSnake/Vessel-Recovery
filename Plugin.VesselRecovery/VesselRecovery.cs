﻿/*
    Vessel Recovery

    Written By: Ryan Smith
*/
using System;
using UnityEngine;

namespace VesselRecovery;

[KSPAddon(KSPAddon.Startup.Flight, false)]
public class VesselRecovery : MonoBehaviour
{
    /* Instance Methods */
	public void Start()
	{
		Debug.Log($"[VesselRecovery]Time started: {Time.realtimeSinceStartup}");
		GameEvents.onVesselCreate.Add(HandleVessel);
	}
	public void HandleVessel(Vessel vessel)
	{
		if (!Settings.Enable)
			return;
	}
	/* Properties */
	public static Settings Settings { get { return HighLogic.CurrentGame.Parameters.CustomParams<Settings>(); }}
}
