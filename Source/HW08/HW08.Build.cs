using UnrealBuildTool;

public class HW08 : ModuleRules
{
	public HW08(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { 
			"Core", 
			"CoreUObject", 
			"Engine", 
			"InputCore", 
			"EnhancedInput", 
			"UMG" 
		});

		PrivateDependencyModuleNames.AddRange(new string[] {  });
	}
}
