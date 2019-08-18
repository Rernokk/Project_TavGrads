using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleLoader : MonoBehaviour
{
	private void Start()
	{
		foreach (GAME_ENUM minigame in MinigameDataList.ActiveMinigames.Keys)
		{
			string minigamePrefabName = MinigameDataList.ActiveMinigames[minigame].TavernPrefabName;
			GameObject bottleObject = Instantiate(Resources.Load<GameObject>("Tavern_Hub/MinigamePrefabs/" + minigamePrefabName), Vector3.zero, Quaternion.identity);
			bottleObject.name = minigame.ToString();
		}
	}
}
