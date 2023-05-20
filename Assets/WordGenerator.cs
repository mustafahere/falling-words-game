using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour {

	private static string[] wordList = { "random", "format", "frozen", "sunset", "wander", "silver", "purple", "castle", "guitar", "melody", "planet", "distant", "shimmer", "whisper", "ocean", "journey", "twinkle", "fluffy", "parrot", "diamond", "vibrant", "tulip", "whistle", "butterfly", "laughter", "safari", "seashell", "echoes", "delight", "blossom", "whimsical", "breeze", "paradise", "serenade", "graceful", "majestic", "rainbow", "serendipity", "magnificent", "chocolate", "fantasy", "mystery", "enchanted", "radiant", "serenity", "glisten", "tranquil", "whimsy", "harmony", "crescent", "luminous", "captivate", "inspire", "delicate", "glimmer", "freedom", "adventure", "brilliant", "glimpse", "sapphire", "emerald", "silhouette", "radiance", "velvet", "dazzle", "sunrise", "cascade", "whispering", "breeze", "whimsical", "melodic", "soaring", "effervescent", "serene", "whisper", "mystical", "lush", "luminosity", "ethereal", "glimpse", "bewitching", "exquisite", "charming", "whisper", "serenade", "twilight", "sparkling", "delightful", "captivating", "enchanting", "serendipitous", "whisper", "serenity", "blissful", "enveloping", "spellbinding" };


    public static string GetRandomWord ()
	{
		int randomIndex = Random.Range(0, wordList.Length);
		string randomWord = wordList[randomIndex];

		return randomWord;
	}

}
