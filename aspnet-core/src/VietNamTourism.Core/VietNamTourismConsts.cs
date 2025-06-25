using VietNamTourism.Debugging;

namespace VietNamTourism;

public class VietNamTourismConsts
{
	public const string LocalizationSourceName = "VietNamTourism";

	public const string ConnectionStringName = "Default";

	public const bool MultiTenancyEnabled = true;

	public const string DefaultSchema = "TourismDB";

	public const string AppAdminMenuName = "Administrations";


	// Entity

	public const int MaxNameLength = 256;
	public const int MinNameLength = 2;


	/// <summary>
	/// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
	/// </summary>
	public static readonly string DefaultPassPhrase =
				DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "f33584ece9da42b8bd79931d1b0413df";
}
