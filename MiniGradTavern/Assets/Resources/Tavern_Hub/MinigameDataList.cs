using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Shannon: Enum References for the game names
public enum GAME_ENUM
{
	VALIANT_KNIGHT,
}

// Shannon: Object Struct for storing necessary data regarding Minigames. This could be specific variable values or file paths for saving/loading, etc..
public struct MinigameData
{
	public string TavernPrefabName;

	public MinigameData(string TavernPrefabName)
	{
		this.TavernPrefabName = TavernPrefabName;
	}
}

public static class MinigameDataList
{
	// Shannon: Static loader that provides access as necessary to all minigame data sets. Should persist between gameplay sessions and games to allow for cross-game interaction.
	public static Dictionary<GAME_ENUM, MinigameData> ActiveMinigames = new Dictionary<GAME_ENUM, MinigameData>()
	{
		{GAME_ENUM.VALIANT_KNIGHT, new MinigameData("ValiantKnightBottle")},
	};
}
