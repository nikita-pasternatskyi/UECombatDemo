// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class UECombatDemo : ModuleRules
{
	public UECombatDemo(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });
	}
}
