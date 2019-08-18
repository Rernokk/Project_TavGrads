using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GAME_ENUM
{
	MINI_GAME,
}

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
	public static Dictionary<GAME_ENUM, MinigameData> ActiveMinigames = new Dictionary<GAME_ENUM, MinigameData>()
	{
		{GAME_ENUM.MINI_GAME, new MinigameData("MinigameBottle")},
	};
}
