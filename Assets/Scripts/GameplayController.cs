using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayController : MonoBehaviour
{
    //Try to load all points data from streaming assets
    //Load each mission points with needed text data
    //Set points around the map with needed data 
    //Draw line between points 

    //Try load all heroes from hero file(hero name + score)
    //Update main UI to represent all heroes and their score

    //Turn on connection between gameplay controller and UI

    //Add updated data both for heroes and maps
    //Save heroes data to json in streaming assets 
    private void Start()
    {
        //SaveMapForFurtherChanges();
    }

    /*public void SaveMapForFurtherChanges() 
    {
        var mapConfig = new MapConfig();

        var testMap1 = new MapSettings();
        var testMap2 = new MapSettings();

        testMap1.mapNumber = 1.ToString();
        testMap1.mapName = "Переполох в гнезде";
        testMap1.childMap = string.Empty;

        testMap1.mapPositionX = 10;
        testMap1.mapPositionY = 14;

        testMap1.mapPreviewDescription = "В последние годы в птичьем мире творится что-то странное. Птенцы пропадают из гнезда, перелётные птицы улетают и не возвращается. После исчезновения целого клана грачей Птичий Совет решил всё-таки разобраться с исчезновениями.\r\n\r\nСовет отправляет Ястреба (стартовый персонаж) в лес расспросить птиц о деталях.";
        testMap1.mapFinishedDescription = "Птицы как будто потеряли разум — они разучились разговаривать и нападают на Ястреба. Многие гнёзда заброшены. Несомненно, происходит что-то ужасное!";

        testMap1.allyForces = "Нет гнезда";
        testMap1.enemyForces = "Галки, сойки, воробьи";

        testMap1.unlockHero = new List<MapHeroUnlock>();
        testMap1.mapRewards = new List<MapReward>();

        testMap1.mapRewards.Add(new MapReward("Current", 5));


        testMap2.mapNumber = 2.ToString();
        testMap2.mapName = "Дальние дали";
        testMap2.childMap = 1.ToString();

        testMap2.mapPositionX = 5;
        testMap2.mapPositionY = 10;

        testMap2.mapPreviewDescription = "Говорят, некоторые чайки улетают рыбачить далеко от берега и не возвращаются. Надо слетать к ним и расспросить о подробностях.";
        testMap2.mapFinishedDescription = "Даже разумные чайки вовсе не хотят пускать к себе чужака и яростно защищают гнездовья. Верховный Чай не даёт герою аудиенции. Но ему удаётся завоевать уважение Чайки — молодой наследницы племени. Она признаётся, что охотники правда пропадают в море, а племя это замалчивает. Чайка хочет вместе с нами разобраться в причинах.";

        testMap2.allyForces = "Орлы";
        testMap2.enemyForces = "Чайки";

        testMap2.unlockHero = new List<MapHeroUnlock>();
        testMap2.mapRewards = new List<MapReward>();

        testMap2.unlockHero.Add(new MapHeroUnlock("Чайкa"));
        testMap2.mapRewards.Add(new MapReward("Current", 5));

        mapConfig.mapSetting = new List<MapSettings>();
        mapConfig.mapSetting.Add(testMap1);
        mapConfig.mapSetting.Add(testMap2);


        var jsonString = JsonUtility.ToJson(mapConfig, true);
        System.IO.File.WriteAllText(Application.streamingAssetsPath + "/MapConfig.json", jsonString);
    }
    */
}


[System.Serializable]
public class MapConfig 
{
    public List<MapSettings> mapSetting;
}

[System.Serializable]
public class MapSettings 
{
    public string mapNumber;
    public string mapName;
    public string childMap;

    public int mapPositionX;
    public int mapPositionY;

    public string mapPreviewDescription;
    public string mapFinishedDescription;

    public string allyForces;
    public string enemyForces;

    public List<MapHeroUnlock> unlockHero;
    public List<MapReward> mapRewards;
}

[System.Serializable]
public class MapHeroUnlock 
{
    public string heroName;

    public MapHeroUnlock(string heroName)
    {
        this.heroName = heroName;
    }
}

[System.Serializable]
public class MapReward 
{
    public string rewardTarget;
    public int rewardAmount;

    public MapReward(string rewardTarget, int rewardAmount) 
    {
        this.rewardTarget = rewardTarget;
        this.rewardAmount = rewardAmount;
    }
}

[System.Serializable]
public class HeroSettings 
{
    List<HeroData> heroes;
}

[System.Serializable]
public class HeroData 
{
    public string heroName;
    public string heroScore;
    public int heroStatus;
}