using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Config
{

    public static Config _instance;
    public static Config Instance
    {
        get
        {
            if (_instance == null)
                _instance = new Config();
            return _instance;
        }
    }

    public List<LevelData> levelConfig = new List<LevelData>()
    {
    };

    public Config()
    {
        LevelData level1 = new LevelData(1);
        level1.blockList.Add(new BlockData(2, 0, 0, 2));
        level1.blockList.Add(new BlockData(1, 2, 0, 2));
        level1.blockList.Add(new BlockData(5, 3, 0, 3));
        level1.blockList.Add(new BlockData(2, 1, 3, 2));
        level1.blockList.Add(new BlockData(4, 2, 4, 2));
        level1.blockList.Add(new BlockData(2, 3, 2, 2));
        level1.blockList.Add(new BlockData(3, 4, 3, 3));
        level1.blockList.Add(new BlockData(2, 5, 2, 2));

        LevelData level2 = new LevelData(2);
        level2.blockList.Add(new BlockData(2, 1, 0, 2));
        level2.blockList.Add(new BlockData(1, 2, 0, 2));
        level2.blockList.Add(new BlockData(4, 1, 2, 2));
        level2.blockList.Add(new BlockData(4, 1, 3, 2));
        level2.blockList.Add(new BlockData(4, 1, 4, 2));
        level2.blockList.Add(new BlockData(4, 1, 5, 2));
        level2.blockList.Add(new BlockData(4, 3, 0, 2));
        level2.blockList.Add(new BlockData(5, 3, 1, 3));
        level2.blockList.Add(new BlockData(2, 3, 2, 2));
        level2.blockList.Add(new BlockData(2, 5, 2, 2));
        level2.blockList.Add(new BlockData(2, 5, 4, 2));

        LevelData level3 = new LevelData(3);
        level3.blockList.Add(new BlockData(5, 0, 0, 3));
        level3.blockList.Add(new BlockData(2, 0, 1, 2));
        level3.blockList.Add(new BlockData(4, 0, 3, 2));
        level3.blockList.Add(new BlockData(1, 2, 1, 2));
        level3.blockList.Add(new BlockData(4, 2, 3, 2));
        level3.blockList.Add(new BlockData(4, 1, 4, 2));
        level3.blockList.Add(new BlockData(4, 1, 5, 2));
        level3.blockList.Add(new BlockData(3, 3, 0, 3));
        level3.blockList.Add(new BlockData(3, 4, 1, 3));
        level3.blockList.Add(new BlockData(3, 5, 0, 3));

        LevelData level4 = new LevelData(4);
        level4.blockList.Add(new BlockData(2, 0, 1, 2));
        level4.blockList.Add(new BlockData(1, 2, 0, 2));
        level4.blockList.Add(new BlockData(2, 3, 0, 2));
        level4.blockList.Add(new BlockData(4, 4, 0, 2));
        level4.blockList.Add(new BlockData(3, 4, 1, 3));
        level4.blockList.Add(new BlockData(2, 5, 2, 2));
        level4.blockList.Add(new BlockData(5, 0, 3, 3));
        level4.blockList.Add(new BlockData(2, 1, 4, 2));
        level4.blockList.Add(new BlockData(4, 2, 4, 2));

        LevelData level5 = new LevelData(5);
        level5.blockList.Add(new BlockData(2, 1, 0, 2));
        level5.blockList.Add(new BlockData(1, 2, 0, 2));
        level5.blockList.Add(new BlockData(4, 3, 0, 2));
        level5.blockList.Add(new BlockData(4, 3, 1, 2));
        level5.blockList.Add(new BlockData(5, 0, 4, 3));
        level5.blockList.Add(new BlockData(5, 0, 5, 3));
        level5.blockList.Add(new BlockData(2, 4, 3, 2));
        level5.blockList.Add(new BlockData(2, 5, 3, 2));

        LevelData level6 = new LevelData(6);
        level6.blockList.Add(new BlockData(2, 1, 0, 2));
        level6.blockList.Add(new BlockData(1, 2, 0, 2));
        level6.blockList.Add(new BlockData(4, 3, 0, 2));
        level6.blockList.Add(new BlockData(4, 4, 1, 2));
        level6.blockList.Add(new BlockData(3, 3, 1, 3));
        level6.blockList.Add(new BlockData(5, 0, 2, 3));
        level6.blockList.Add(new BlockData(2, 0, 3, 2));
        level6.blockList.Add(new BlockData(4, 1, 3, 2));
        level6.blockList.Add(new BlockData(2, 1, 4, 2));
        level6.blockList.Add(new BlockData(4, 2, 5, 2));

        LevelData level7 = new LevelData(7);
        level7.blockList.Add(new BlockData(2, 0, 0, 2));
        level7.blockList.Add(new BlockData(4, 1, 0, 2));
        level7.blockList.Add(new BlockData(5, 2, 1, 3));
        level7.blockList.Add(new BlockData(3, 5, 0, 3));
        level7.blockList.Add(new BlockData(5, 0, 2, 3));
        level7.blockList.Add(new BlockData(4, 0, 3, 2));
        level7.blockList.Add(new BlockData(4, 0, 4, 2));
        level7.blockList.Add(new BlockData(4, 0, 5, 2));
        level7.blockList.Add(new BlockData(1, 2, 3, 2));
        level7.blockList.Add(new BlockData(4, 2, 5, 2));
        level7.blockList.Add(new BlockData(2, 3, 2, 2));
        level7.blockList.Add(new BlockData(2, 4, 2, 2));
        level7.blockList.Add(new BlockData(2, 4, 4, 2));

        LevelData level8 = new LevelData(8);
        level8.blockList.Add(new BlockData(4, 0, 0, 2));
        level8.blockList.Add(new BlockData(4, 0, 1, 2));
        level8.blockList.Add(new BlockData(1, 2, 0, 2));
        level8.blockList.Add(new BlockData(2, 3, 0, 2));
        level8.blockList.Add(new BlockData(4, 4, 0, 2));
        level8.blockList.Add(new BlockData(4, 4, 1, 2));
        level8.blockList.Add(new BlockData(2, 0, 2, 2));
        level8.blockList.Add(new BlockData(2, 0, 4, 2));
        level8.blockList.Add(new BlockData(4, 1, 5, 2));
        level8.blockList.Add(new BlockData(2, 4, 2, 2));
        level8.blockList.Add(new BlockData(2, 5, 2, 2));
        level8.blockList.Add(new BlockData(2, 4, 4, 2));

        LevelData level9 = new LevelData(9);
        level9.blockList.Add(new BlockData(2, 1, 1, 2));
        level9.blockList.Add(new BlockData(2, 3, 0, 2));
        level9.blockList.Add(new BlockData(4, 4, 0, 2));
        level9.blockList.Add(new BlockData(5, 2, 2, 3));
        level9.blockList.Add(new BlockData(2, 5, 2, 2));
        level9.blockList.Add(new BlockData(2, 5, 4, 2));
        level9.blockList.Add(new BlockData(3, 4, 3, 3));
        level9.blockList.Add(new BlockData(2, 3, 4, 2));
        level9.blockList.Add(new BlockData(1, 2, 3, 2));
        level9.blockList.Add(new BlockData(4, 0, 3, 2));
        level9.blockList.Add(new BlockData(4, 0, 4, 2));
        level9.blockList.Add(new BlockData(5, 0, 5, 3));

        LevelData level10 = new LevelData(10);
        level10.blockList.Add(new BlockData(4, 0, 0, 2));
        level10.blockList.Add(new BlockData(1, 2, 0, 2));
        level10.blockList.Add(new BlockData(4, 3, 0, 2));
        level10.blockList.Add(new BlockData(2, 0, 1, 2));
        level10.blockList.Add(new BlockData(3, 1, 1, 3));
        level10.blockList.Add(new BlockData(4, 2, 2, 2));
        level10.blockList.Add(new BlockData(5, 2, 3, 3));
        level10.blockList.Add(new BlockData(2, 4, 1, 2));
        level10.blockList.Add(new BlockData(4, 0, 4, 2));
        level10.blockList.Add(new BlockData(5, 0, 5, 3));

        LevelData level11 = new LevelData(11);
        level11.blockList.Add(new BlockData(2, 1, 0, 2));
        level11.blockList.Add(new BlockData(4, 2, 0, 2));
        level11.blockList.Add(new BlockData(4, 4, 0, 2));
        level11.blockList.Add(new BlockData(1, 2, 1, 2));
        level11.blockList.Add(new BlockData(2, 0, 2, 2));
        level11.blockList.Add(new BlockData(4, 1, 3, 2));
        level11.blockList.Add(new BlockData(4, 1, 4, 2));
        level11.blockList.Add(new BlockData(5, 0, 5, 3));
        level11.blockList.Add(new BlockData(3, 3, 3, 3));
        level11.blockList.Add(new BlockData(3, 4, 3, 3));
        level11.blockList.Add(new BlockData(2, 5, 2, 2));
        level11.blockList.Add(new BlockData(2, 5, 4, 2));

        LevelData level12 = new LevelData(12);
        level12.blockList.Add(new BlockData(4, 0, 0, 2));
        level12.blockList.Add(new BlockData(4, 0, 1, 2));
        level12.blockList.Add(new BlockData(1, 2, 0, 2));
        level12.blockList.Add(new BlockData(2, 3, 0, 2));
        level12.blockList.Add(new BlockData(4, 4, 0, 2));
        level12.blockList.Add(new BlockData(4, 4, 1, 2));
        level12.blockList.Add(new BlockData(3, 0, 2, 3));
        level12.blockList.Add(new BlockData(3, 1, 2, 3));
        level12.blockList.Add(new BlockData(4, 2, 2, 2));
        level12.blockList.Add(new BlockData(4, 4, 2, 2));
        level12.blockList.Add(new BlockData(5, 0, 5, 3));
        level12.blockList.Add(new BlockData(2, 3, 4, 2));
        level12.blockList.Add(new BlockData(2, 5, 4, 2));

        LevelData level13 = new LevelData(13);
        level13.blockList.Add(new BlockData(4, 0, 0, 2));
        level13.blockList.Add(new BlockData(1, 2, 0, 2));
        level13.blockList.Add(new BlockData(2, 3, 0, 2));
        level13.blockList.Add(new BlockData(4, 4, 1, 2));
        level13.blockList.Add(new BlockData(3, 0, 1, 3));
        level13.blockList.Add(new BlockData(2, 1, 2, 2));
        level13.blockList.Add(new BlockData(4, 2, 3, 2));
        level13.blockList.Add(new BlockData(4, 4, 3, 2));
        level13.blockList.Add(new BlockData(2, 3, 4, 2));
        level13.blockList.Add(new BlockData(2, 4, 4, 2));
        level13.blockList.Add(new BlockData(2, 5, 4, 2));

        LevelData level14 = new LevelData(14);
        level14.blockList.Add(new BlockData(2, 0, 3, 2));
        level14.blockList.Add(new BlockData(5, 0, 5, 3));
        level14.blockList.Add(new BlockData(2, 1, 0, 2));
        level14.blockList.Add(new BlockData(2, 1, 2, 2));
        level14.blockList.Add(new BlockData(4, 1, 4, 2));
        level14.blockList.Add(new BlockData(4, 2, 0, 2));
        level14.blockList.Add(new BlockData(4, 4, 0, 2));
        level14.blockList.Add(new BlockData(1, 2, 1, 2));
        level14.blockList.Add(new BlockData(4, 3, 1, 2));
        level14.blockList.Add(new BlockData(2, 3, 2, 2));
        level14.blockList.Add(new BlockData(2, 3, 4, 2));
        level14.blockList.Add(new BlockData(4, 4, 2, 2));
        level14.blockList.Add(new BlockData(4, 4, 4, 2));

        LevelData level15 = new LevelData(15);
        level15.blockList.Add(new BlockData(2, 0, 0, 2));
        level15.blockList.Add(new BlockData(4, 1, 0, 2));
        level15.blockList.Add(new BlockData(4, 1, 1, 2));
        level15.blockList.Add(new BlockData(2, 3, 0, 2));
        level15.blockList.Add(new BlockData(2, 4, 0, 2));
        level15.blockList.Add(new BlockData(2, 5, 1, 2));
        level15.blockList.Add(new BlockData(4, 0, 2, 2));
        level15.blockList.Add(new BlockData(1, 2, 2, 2));
        level15.blockList.Add(new BlockData(4, 3, 2, 2));
        level15.blockList.Add(new BlockData(5, 3, 3, 3));
        level15.blockList.Add(new BlockData(2, 0, 4, 2));
        level15.blockList.Add(new BlockData(3, 1, 3, 3));
        level15.blockList.Add(new BlockData(4, 2, 4, 2));
        level15.blockList.Add(new BlockData(4, 2, 5, 2));
        level15.blockList.Add(new BlockData(4, 4, 5, 2));

        LevelData level16 = new LevelData(16);
        level16.blockList.Add(new BlockData(2, 0, 0, 2));
        level16.blockList.Add(new BlockData(2, 0, 2, 2));
        level16.blockList.Add(new BlockData(4, 1, 0, 2));
        level16.blockList.Add(new BlockData(4, 1, 2, 2));
        level16.blockList.Add(new BlockData(1, 2, 3, 2));
        level16.blockList.Add(new BlockData(5, 0, 5, 3));
        level16.blockList.Add(new BlockData(4, 3, 0, 2));
        level16.blockList.Add(new BlockData(2, 3, 2, 2));
        level16.blockList.Add(new BlockData(2, 3, 4, 2));
        level16.blockList.Add(new BlockData(4, 4, 2, 2));
        level16.blockList.Add(new BlockData(2, 4, 4, 2));
        level16.blockList.Add(new BlockData(2, 5, 4, 2));

        LevelData level17 = new LevelData(17);
        level17.blockList.Add(new BlockData(4, 0, 0, 2));
        level17.blockList.Add(new BlockData(4, 2, 0, 2));
        level17.blockList.Add(new BlockData(2, 3, 1, 2));
        level17.blockList.Add(new BlockData(2, 3, 3, 2));
        level17.blockList.Add(new BlockData(3, 4, 0, 3));
        level17.blockList.Add(new BlockData(2, 5, 0, 2));
        level17.blockList.Add(new BlockData(2, 5, 2, 2));
        level17.blockList.Add(new BlockData(1, 2, 2, 2));
        level17.blockList.Add(new BlockData(4, 0, 3, 2));
        level17.blockList.Add(new BlockData(2, 0, 4, 2));
        level17.blockList.Add(new BlockData(4, 1, 4, 2));
        level17.blockList.Add(new BlockData(4, 1, 5, 2));

        LevelData level18 = new LevelData(18);
        level18.blockList.Add(new BlockData(3, 0, 2, 3));
        level18.blockList.Add(new BlockData(3, 1, 0, 3));
        level18.blockList.Add(new BlockData(1, 2, 0, 2));
        level18.blockList.Add(new BlockData(2, 3, 0, 2));
        level18.blockList.Add(new BlockData(4, 4, 0, 2));
        level18.blockList.Add(new BlockData(3, 4, 1, 3));
        level18.blockList.Add(new BlockData(3, 5, 1, 3));
        level18.blockList.Add(new BlockData(5, 1, 3, 3));
        level18.blockList.Add(new BlockData(4, 1, 4, 2));
        level18.blockList.Add(new BlockData(4, 3, 4, 2));
        level18.blockList.Add(new BlockData(4, 0, 5, 2));
        level18.blockList.Add(new BlockData(4, 2, 5, 2));

        LevelData level19 = new LevelData(19);
        level19.blockList.Add(new BlockData(1, 2, 0, 2));
        level19.blockList.Add(new BlockData(5, 3, 0, 3));
        level19.blockList.Add(new BlockData(5, 3, 1, 3));
        level19.blockList.Add(new BlockData(5, 0, 2, 3));
        level19.blockList.Add(new BlockData(2, 1, 4, 2));
        level19.blockList.Add(new BlockData(3, 4, 2, 3));
        level19.blockList.Add(new BlockData(2, 5, 2, 2));
        level19.blockList.Add(new BlockData(5, 2, 5, 3));

        LevelData level20 = new LevelData(20);
        level20.blockList.Add(new BlockData(3, 1, 0, 3));
        level20.blockList.Add(new BlockData(1, 2, 0, 2));
        level20.blockList.Add(new BlockData(4, 3, 1, 2));
        level20.blockList.Add(new BlockData(2, 5, 0, 2));
        level20.blockList.Add(new BlockData(4, 2, 2, 2));
        level20.blockList.Add(new BlockData(4, 1, 3, 2));
        level20.blockList.Add(new BlockData(4, 1, 4, 2));
        level20.blockList.Add(new BlockData(4, 1, 5, 2));
        level20.blockList.Add(new BlockData(3, 3, 3, 3));
        level20.blockList.Add(new BlockData(4, 4, 3, 2));

        levelConfig.Add(level1);
        levelConfig.Add(level2);
        levelConfig.Add(level3);
        levelConfig.Add(level4);
        levelConfig.Add(level5);
        levelConfig.Add(level6);
        levelConfig.Add(level7);
        levelConfig.Add(level8);
        levelConfig.Add(level9);
        levelConfig.Add(level10);
        levelConfig.Add(level11);
        levelConfig.Add(level12);
        levelConfig.Add(level13);
        levelConfig.Add(level14);
        levelConfig.Add(level15);
        levelConfig.Add(level16);
        levelConfig.Add(level17);
        levelConfig.Add(level18);
        levelConfig.Add(level19);
        levelConfig.Add(level20);
    }
}

public class LevelData
{
    public int id;

    public List<BlockData> blockList;

    public LevelData(int id)
    {
        this.id = id;
        blockList = new List<BlockData>();
    }
}

public class BlockData
{
    public int type;//1Ö÷ 2horzitonal 3 horzontal3  4 vertical2   5 vertical3
    public int x;
    public int y;
    public int offset;

    public BlockData(int a, int b , int c, int d)
    {
        type = a;
        x = b;
        y = c;
        offset = d;
    }
}