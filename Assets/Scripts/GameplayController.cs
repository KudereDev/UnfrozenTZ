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
        testMap1.mapName = "��������� � ������";
        testMap1.childMap = string.Empty;

        testMap1.mapPositionX = 10;
        testMap1.mapPositionY = 14;

        testMap1.mapPreviewDescription = "� ��������� ���� � ������� ���� �������� ���-�� ��������. ������ ��������� �� ������, ��������� ����� ������� � �� ������������. ����� ������������ ������ ����� ������ ������ ����� ����� ��-���� ����������� � ��������������.\r\n\r\n����� ���������� ������� (��������� ��������) � ��� ����������� ���� � �������.";
        testMap1.mapFinishedDescription = "����� ��� ����� �������� ����� ����� ���������� ������������� � �������� �� �������. ������ ����� ���������. ����������, ���������� ���-�� �������!";

        testMap1.allyForces = "��� ������";
        testMap1.enemyForces = "�����, �����, �������";

        testMap1.unlockHero = new List<MapHeroUnlock>();
        testMap1.mapRewards = new List<MapReward>();

        testMap1.mapRewards.Add(new MapReward("Current", 5));


        testMap2.mapNumber = 2.ToString();
        testMap2.mapName = "������� ����";
        testMap2.childMap = 1.ToString();

        testMap2.mapPositionX = 5;
        testMap2.mapPositionY = 10;

        testMap2.mapPreviewDescription = "�������, ��������� ����� ������� �������� ������ �� ������ � �� ������������. ���� ������� � ��� � ����������� � ������������.";
        testMap2.mapFinishedDescription = "���� �������� ����� ����� �� ����� ������� � ���� ������ � ������� �������� ���������. ��������� ��� �� ��� ����� ���������. �� ��� ������ ��������� �������� ����� ��������� ���������� �������. ��� ���������, ��� �������� ������ ��������� � ����, � ����� ��� �����������. ����� ����� ������ � ���� ����������� � ��������.";

        testMap2.allyForces = "����";
        testMap2.enemyForces = "�����";

        testMap2.unlockHero = new List<MapHeroUnlock>();
        testMap2.mapRewards = new List<MapReward>();

        testMap2.unlockHero.Add(new MapHeroUnlock("����a"));
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