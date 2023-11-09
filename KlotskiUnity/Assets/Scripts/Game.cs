using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    [SerializeField]
    AudioClip clip;
    [SerializeField]
    AudioClip clip2;
    public List<GameObject> BlockList;
    public List<Sprite> levelSpriteList;

    public Transform bgGame;
    public Transform btnVolume;

    public GameObject winLayer;
    public GameObject menuLayer;

    public Image imgLevel;

    AudioSource audioSource;

    static bool isVolume = true;

    int[,] grid = new int[6, 7];

    private float startPosX = -332.47f;
    private float startPosY = 332.85f;

    private int cellWidth = 110;
    private int cellHeight = 110;
    private int level;
    private int maxLevel;
    private List<Transform> blockTransList;

    Config config;

    void Awake()
    {
        audioSource = GameObject.Find("GameManager").GetComponent<AudioSource>();

        blockTransList = new List<Transform>();

        maxLevel = PlayerPrefs.GetInt("MaxLevel", 1);
    }

    void Start()
    {
        btnVolume.Find("spDisable").gameObject.SetActive(!isVolume);
        level = 1;
        imgLevel.sprite = levelSpriteList[level - 1];
        imgLevel.SetNativeSize();
        config = Config.Instance;

        generateLevel();
        //updateMenu();
    }

    void generateLevel()
    {
        clear();

        imgLevel.sprite = levelSpriteList[level - 1];
        imgLevel.SetNativeSize();

        for (int i = 0; i < 6; i++)
        {
            for(int j = 0; j < 7; j++)
            {
                grid[i,j] = 0;
            }
        }
        grid[0, 6] = 1;
        grid[1, 6] = 1;
        grid[2, 6] = 0;
        grid[3, 6] = 1;
        grid[4, 6] = 1;
        grid[5, 6] = 1;
        LevelData levelData = config.levelConfig[level - 1];
        for(int i = 0; i < levelData.blockList.Count; i++)
        {
            GameObject blockGo = GameObject.Instantiate(BlockList[levelData.blockList[i].type - 1]);
            Transform blockTrans = blockGo.transform;
            blockTrans.SetParent(bgGame);
            blockTrans.localScale = Vector3.one;
            blockTrans.localRotation = Quaternion.identity;
            blockTrans.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(startPosX + levelData.blockList[i].y * cellWidth, startPosY - levelData.blockList[i].x * cellHeight, 0);
            Block block = blockTrans.GetComponent<Block>();
            block.setType(levelData.blockList[i].type);
            block.setGridPos(levelData.blockList[i].x, levelData.blockList[i].y, levelData.blockList[i].offset);

            for (int off =0;off< levelData.blockList[i].offset; off++)
            {
                if (levelData.blockList[i].type < 4)
                    grid[levelData.blockList[i].x, levelData.blockList[i].y + off] = 1;
                else
                    grid[levelData.blockList[i].x + off, levelData.blockList[i].y ] = 1;
            }

            blockTransList.Add(blockTrans);
        }

        //for (int i = 0; i < 6; i++)
        //{
        //    Debug.LogError(grid[i, 0] + "  " + grid[i, 1] + "  " +  grid[i, 2] + "  " + grid[i, 3] + "  " + grid[i, 4] + "  " + grid[i, 5]);
        //}
    }

    void updateMenu()
    {
        for(int i = 1;i<= maxLevel; i++)
        {
            int tmpI = i;
            Transform cell = menuLayer.transform.Find("bg/root").GetChild(i - 1);
            cell.Find("lblLvel").GetComponent<Text>().text = i.ToString();
            cell.Find("cur/lblLvel").GetComponent<Text>().text = i.ToString();
            cell.Find("Image").gameObject.SetActive(false);
            if (level == i)
                cell.Find("cur").gameObject.SetActive(true);
            else
                cell.Find("cur").gameObject.SetActive(false);
            Button btn = cell.transform.GetComponent<Button>();
            btn.onClick.RemoveAllListeners();
            btn.onClick.AddListener(() =>
            {
                audioSource.PlayOneShot(clip);
                Transform bg = menuLayer.transform.Find("bg");
                bg.DOScale(Vector3.zero, 0.3f).OnComplete(() =>
                {
                    menuLayer.gameObject.SetActive(false);
                });
                level = tmpI;
                generateLevel();
            });
        }
    }

    void clear()
    {
        for(int i = 0; i < blockTransList.Count; i++)
        {
            GameObject.Destroy(blockTransList[i].gameObject);
        }
        blockTransList.Clear();

        //menuLayer.gameObject.SetActive(false);
        //winLayer.gameObject.SetActive(false);
    }

    public void move(Block block)
    {
        if (block.blockDirection == BlockDirection.None)
            return;
        int type = block.type;
        int x = block.x;
        int y = block.y;
        int newX = x;
        int newY = y;
        int offset = block.offset;
        bool isNull = true;
        bool win = false;
        if(block.blockDirection == BlockDirection.Up)
        {
            if (x == 0)
            {
                block.checkOver();
                return;
            }
            if(type < 4)
            {
                isNull = checkGridHoriztontal(x, y, offset, -1);
            }
            else
            {
                isNull = grid[x - 1, y] ==0;
            }
            newX -= 1;
        }
        else if(block.blockDirection == BlockDirection.Down)
        {
            if (x == 5 || (type >= 4 && x + offset > 5))
            {
                block.checkOver();
                return;
            }
            if(type < 4)
            {
                isNull = checkGridHoriztontal(x, y, offset, 1);
            }
            else
            {
                isNull = grid[x + offset, y] == 0;
            }
            newX += 1;
        }
        else if (block.blockDirection == BlockDirection.Left)
        {
            if (y == 0)
            {
                block.checkOver();
                return;
            }
            if (type < 4)
            {
                isNull = grid[x, y - 1] == 0;
            }
            else
            {
                isNull = checkGridVertical(x, y, offset, -1);
            }
            newY -= 1;
        }
        else if (block.blockDirection == BlockDirection.Right)
        {
            if (y == 5 || (type<4 && y +offset > 6))
            {
                block.checkOver();
                return;
            }
            newY += 1;
            if (newY == 6 && type != 1)
            {
                block.checkOver();
                return;
            }
            if (newY == 5 && type == 1) win = true;
            if (type < 4)
            {
                isNull = grid[x, y + offset] == 0;
            }
            else
            {
                isNull = checkGridVertical(x, y, offset, 1);
            }
            
        }
        if(isNull)
        {
            for (int off = 0; off < offset; off++)
            {
                if (type < 4)
                    grid[x, y + off] = 0;
                else
                    grid[x + off, y] = 0;
            }
            for (int off = 0; off < offset; off++)
            {
                if (type < 4)
                    grid[newX, newY + off] = 1;
                else
                    grid[newX + off, newY] = 1;
            }
            block.setGridPos(newX, newY, offset);
            block.transform.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(startPosX + newY * cellWidth, startPosY - newX * cellHeight, 0);
            
            if(win)
            {
                audioSource.PlayOneShot(clip2);
                winLayer.SetActive(true);
                Transform bg = winLayer.transform.Find("Image");
                bg.localScale = Vector3.zero;
                bg.transform.DOScale(Vector3.one, 0.3f);
                level++;
                if (level > maxLevel)
                {
                    maxLevel = level;
                    if (maxLevel > 20) maxLevel = 20;
                    updateMenu();
                    PlayerPrefs.SetInt("MaxLevel", maxLevel);
                }
            }
        }
        block.checkOver();
    }

    bool checkGridHoriztontal(int x, int y, int offset, int horizontalOff)
    {
        bool isNull = true;
        for (int off = 0; off < offset; off++)
        {
            if (grid[x + horizontalOff, y + off] == 1)
            {
                isNull = false;
                break;
            }
        }
        return isNull;
    }

    bool checkGridVertical(int x, int y, int offset, int verticalOff)
    {
        bool isNull = true;
        for (int off = 0; off < offset; off++)
        {
            if (grid[x + off, y + verticalOff] == 1)
            {
                isNull = false;
                break;
            }
        }
        return isNull;
    }

    public void onBtnClick(string name)
    {
        audioSource.PlayOneShot(clip);
        if (name == "btnNext")
        {
            if (level > 20)
                level = 1;
            generateLevel();
            
            Transform bg = winLayer.transform.Find("Image");
            bg.DOScale(Vector3.zero, 0.3f).OnComplete(() =>
            {
                winLayer.SetActive(false);
            });
        }else if(name == "btnMenu")
        {
            //winLayer.SetActive(false);
            menuLayer.gameObject.SetActive(true);
            Transform bg = menuLayer.transform.Find("bg");
            bg.localScale = Vector3.zero;
            bg.transform.DOScale(Vector3.one, 0.3f);
            updateMenu();
        }
        else if(name == "btnClose")
        {
            Transform bg = menuLayer.transform.Find("bg");
            bg.DOScale(Vector3.zero, 0.3f).OnComplete(() =>
            {
                menuLayer.gameObject.SetActive(false);
            });
            
        }else if(name == "btnRestart")
        {
            generateLevel();
        }else if(name == "btnVolume")
        {
            isVolume = !isVolume;
            audioSource.volume = isVolume ? 1 : 0;
            btnVolume.Find("spDisable").gameObject.SetActive(!isVolume);
        }
        else if(name == "btnHome")
        {
            UnityEngine.SceneManagement.SceneManager.LoadSceneAsync("LoginScene");
        }
    }
}
