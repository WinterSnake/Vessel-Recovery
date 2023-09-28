/*
    Vessel Recovery
	- Settings

    Written By: Ryan Smith
*/
using KSP.Localization;

namespace VesselRecovery;

public class Settings : GameParameters.CustomParameterNode
{
	/* Properties */
	// KSP
	public override string DisplaySection { get { return Localizer.Format("#VR_SETTINGS_DISPLAY"); }}
	public override string Title { get { return Localizer.Format("#VR_SETTINGS_TITLE"); }}
	public override string Section { get { return Localizer.Format("#VR_SETTINGS_SECTION"); }}
	public override GameParameters.GameMode GameMode { get { return GameParameters.GameMode.NOTMISSION; }}  // Career | Science | Sandbox
	public override int SectionOrder { get { return 1; }}
	public override bool HasPresets { get { return false; }}
	// Gameplay
	[GameParameters.CustomParameterUI("#VR_SETTINGS_ENABLED")]
	public new bool Enabled = true;
}
