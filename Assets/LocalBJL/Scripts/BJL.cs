using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BJL : MonoBehaviour
{

    public Button cm100Btn;
    public Button cm500Btn;
    public Button cm1000Btn;


    public Button xzXianBtn;
    public Button xzHeBtn;
    public Button xzZhuangBtn;

    public Transform xzXian;
    public Transform xzHe;
    public Transform xzZhuang;


    public Image[] kpxian;
    public Image[] kpzhuang;

    public Text gold;

    public Button goldAdd;

    public Button extBtn;
    public Button begianBtn;


    private int CMNum = 0;

    public GameObject xzCMPrefab;

    public Sprite[] xzCMs;

    private int totleXZNum;

    private int goldNum = 5000;




    public Sprite[] heitao;
    public Sprite[] hongtao;
    public Sprite[] meihua;
    public Sprite[] fangkuai;

    public Sprite bg;

    public Text tips;

    public Transform tipsObj;
    // Use this for initialization
    void Start()
    {
        cm100Btn.onClick.AddListener(cm100BtnOnClick);
        cm500Btn.onClick.AddListener(cm500BtnOnClick);
        cm1000Btn.onClick.AddListener(cm1000BtnOnClick);

        xzXianBtn.onClick.AddListener(xzXianBtnOnClick);
        xzHeBtn.onClick.AddListener(xzHeBtnOnClick);
        xzZhuangBtn.onClick.AddListener(xzZhuangBtnOnClick);


        extBtn.onClick.AddListener(extBtnOnClick);
        begianBtn.onClick.AddListener(begianBtnOnClick);

        goldAdd.onClick.AddListener(goldAddBtnOnClick);

        ReFrashGoldView();

        tipsObj.gameObject.SetActive(false);

      //  tips.enabled = true;
       // gold.enabled = true;
        gold.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (tipsObj.gameObject.activeSelf)
        {
            tipsIime = tipsIime - Time.deltaTime;
            if (tipsIime <= 0)
            {
                tipsObj.gameObject.SetActive(false);
                tipsIime = 1;
            }
        }
    }

    float tipsIime = 1;

    private void cm100BtnOnClick()
    {
        CMNum = 100;
    }

    private void cm500BtnOnClick()
    {
        CMNum = 500;
    }

    private void cm1000BtnOnClick()
    {
        CMNum = 1000;
    }


    int xzXianCMCount = 0;
    int xzXianGoldCount = 0;
    private void xzXianBtnOnClick()
    {
        if (CMNum == 0)
        {
          //  Debug.LogError("请先选择筹码");
            tips.text = "请先选择筹码";
            tips.enabled = true;
            tips.gameObject.SetActive(true);
            tipsObj.gameObject.SetActive(true);
            return;
        }
        if (goldNum - CMNum < 0)
        {
         //   Debug.LogError("金币不够");
            tips.text = "金币不够";
            tips.enabled = true;
            tips.gameObject.SetActive(true);
            tipsObj.gameObject.SetActive(true);
            return;
        }
        initPai();
        xzXianCMCount++;
        xzXianGoldCount = xzXianGoldCount + CMNum;
        totleXZNum = totleXZNum + xzXianGoldCount;
        goldNum = goldNum - CMNum;
        GameObject temp = GameObject.Instantiate(xzCMPrefab) as GameObject;
        temp.transform.parent = xzXian;
        switch (CMNum)
        {
            case 100:
                temp.GetComponent<Image>().sprite = (Sprite)xzCMs[0];
                break;
            case 500:
                temp.GetComponent<Image>().sprite = (Sprite)xzCMs[1];
                break;
            case 1000:
                temp.GetComponent<Image>().sprite = (Sprite)xzCMs[2];
                break;
            default:
                temp.GetComponent<Image>().sprite = (Sprite)xzCMs[0];
                break;
        }
        temp.GetComponent<RectTransform>().localPosition = new Vector3(0, xzXianCMCount * 10, 0);
        ReFrashGoldView();
    }


    int xzHeCMCount = 0;
    int xzHeGoldCount = 0;
    private void xzHeBtnOnClick()
    {
        if (CMNum == 0)
        {
          //  Debug.LogError("请先选择筹码");
            tips.text = "请先选择筹码";
            tips.enabled = true;
            tips.gameObject.SetActive(true);
            tipsObj.gameObject.SetActive(true);
            return;
        }
        if (goldNum - CMNum < 0)
        {
         //   Debug.LogError("金币不够");
            tips.text = "金币不够";
            tips.enabled = true;
            tips.gameObject.SetActive(true);
            tipsObj.gameObject.SetActive(true);
            return;
        }
        initPai();
        xzHeCMCount++;
        xzHeGoldCount = xzHeGoldCount + CMNum;
        totleXZNum = totleXZNum + xzHeGoldCount;
        goldNum = goldNum - CMNum;
        GameObject temp = GameObject.Instantiate(xzCMPrefab) as GameObject;
        temp.transform.parent = xzHe;
        switch (CMNum)
        {
            case 100:
                temp.GetComponent<Image>().sprite = (Sprite)xzCMs[0];
                break;
            case 500:
                temp.GetComponent<Image>().sprite = (Sprite)xzCMs[1];
                break;
            case 1000:
                temp.GetComponent<Image>().sprite = (Sprite)xzCMs[2];
                break;
            default:
                temp.GetComponent<Image>().sprite = (Sprite)xzCMs[0];
                break;
        }
        temp.GetComponent<RectTransform>().localPosition = new Vector3(0, xzHeCMCount * 10, 0);
        ReFrashGoldView();
    }


    int xzZhuangCMCount = 0;
    int xzZhuangGoldCount = 0;
    private void xzZhuangBtnOnClick()
    {
        if (CMNum == 0)
        {
         //   Debug.LogError("请先选择筹码");
            tips.text = "请先选择筹码";
            tips.enabled = true;
            tips.gameObject.SetActive(true);
            tipsObj.gameObject.SetActive(true);
            return;
        }
        if (goldNum - CMNum < 0)
        {
          //  Debug.LogError("金币不够");
            tips.text = "金币不够";
            tips.enabled = true;
            tips.gameObject.SetActive(true);
            tipsObj.gameObject.SetActive(true);
            return;
        }
        initPai();
        xzZhuangCMCount++;
        xzZhuangGoldCount = xzZhuangGoldCount + CMNum;
        totleXZNum = totleXZNum + xzZhuangGoldCount;
        goldNum = goldNum - CMNum;
        GameObject temp = GameObject.Instantiate(xzCMPrefab) as GameObject;
        temp.transform.parent = xzZhuang;
        switch (CMNum)
        {
            case 100:
                temp.GetComponent<Image>().sprite = (Sprite)xzCMs[0];
                break;
            case 500:
                temp.GetComponent<Image>().sprite = (Sprite)xzCMs[1];
                break;
            case 1000:
                temp.GetComponent<Image>().sprite = (Sprite)xzCMs[2];
                break;
            default:
                temp.GetComponent<Image>().sprite = (Sprite)xzCMs[0];
                break;
        }
        temp.GetComponent<RectTransform>().localPosition = new Vector3(0, xzZhuangCMCount * 10, 0);
        ReFrashGoldView();
    }

    private void extBtnOnClick()
    {
        Application.Quit();
    }


    int[] paiIndex;
    private void begianBtnOnClick()
    {
        if (xzZhuangGoldCount + xzXianGoldCount + xzHeGoldCount == 0)
        {
         //   Debug.LogError("请先下注");
            tips.text = "请先下注";
            tips.enabled = true;
            tips.gameObject.SetActive(true);
            tipsObj.gameObject.SetActive(true);
            return;
        }
        paiIndex = new int[] { -1, -1, -1, -1, -1, -1 };
        while (true)
        {
            int temp = Random.Range(1, 52);

            for (int i = 0; i < paiIndex.Length; i++)
            {
                if (paiIndex[i] == -1)
                {
                    paiIndex[i] = temp;
                    break;
                }
                else
                {
                    if (paiIndex[i] == temp)
                    {
                        break;
                    }
                }
            }
            if (paiIndex[5] != -1)
            {
                break;
            }
        }

        int xianOpenNum = 0;
        int zhuangOpenNum = 0;

        for (int i = 0; i < kpxian.Length; i++)
        {
            int bigIndex = paiIndex[i] / 13;
            int smallIndex = paiIndex[i] % 13;
            switch (bigIndex)
            {
                case 0:
                    kpxian[i].sprite = heitao[smallIndex];
                    break;
                case 1:
                    kpxian[i].sprite = hongtao[smallIndex];
                    break;
                case 2:
                    kpxian[i].sprite = meihua[smallIndex];
                    break;
                case 3:
                    kpxian[i].sprite = fangkuai[smallIndex];
                    break;
            }

            if (smallIndex >= 10)
            {
                smallIndex = 0;
            }
            xianOpenNum = xianOpenNum + smallIndex;
        }


        for (int i = 0; i < kpzhuang.Length; i++)
        {
            int bigIndex = paiIndex[i + 3] / 13;
            int smallIndex = paiIndex[i + 3] % 13;
            switch (bigIndex)
            {
                case 0:
                    kpzhuang[i].sprite = heitao[smallIndex];
                    break;
                case 1:
                    kpzhuang[i].sprite = hongtao[smallIndex];
                    break;
                case 2:
                    kpzhuang[i].sprite = meihua[smallIndex];
                    break;
                case 3:
                    kpzhuang[i].sprite = fangkuai[smallIndex];
                    break;
            }

            if (smallIndex >= 10)
            {
                smallIndex = 0;
            }
            zhuangOpenNum = zhuangOpenNum + smallIndex;
        }

        if (zhuangOpenNum > xianOpenNum)
        {
//            Debug.LogError("庄赢");
            tips.text = "庄赢";
            tips.enabled = true;
            tips.gameObject.SetActive(true);
            tipsObj.gameObject.SetActive(true);
            goldNum = goldNum + xzZhuangGoldCount * 2;
            ReFrashGoldView();

        }
        else if (zhuangOpenNum < xianOpenNum)
        {
//            Debug.LogError("闲赢");
            tips.text = "闲赢";
            tips.enabled = true;
            tips.gameObject.SetActive(true);
            tipsObj.gameObject.SetActive(true);
            goldNum = goldNum + xzXianGoldCount * 2;
            ReFrashGoldView();
        }
        else
        {
      //      Debug.LogError("和");
            tips.text = "和";
            tips.gameObject.SetActive(true);
            goldNum = goldNum + xzHeGoldCount * 8;
            ReFrashGoldView();
        }

        xzHeGoldCount = 0;
        xzHeCMCount = 0;
        xzXianCMCount = 0;
        xzXianGoldCount = 0;
        xzZhuangCMCount = 0;
        xzZhuangGoldCount = 0;
        CleanXZ();
    }

    private void goldAddBtnOnClick()
    {
        goldNum = goldNum + 5000;
        ReFrashGoldView();
    }

    private void ReFrashGoldView()
    {
        gold.text = goldNum + "";
    }

    private void CleanXZ()
    {
        for (int i = 0; i < xzXian.childCount; i++)
        {
            Destroy(xzXian.GetChild(i).gameObject);
        }

        for (int i = 0; i < xzHe.childCount; i++)
        {
            Destroy(xzHe.GetChild(i).gameObject);
        }

        for (int i = 0; i < xzZhuang.childCount; i++)
        {
            Destroy(xzZhuang.GetChild(i).gameObject);
        }

    }


    private void initPai()
    {
        for (int i = 0; i < kpxian.Length; i++)
        {
            kpxian[i].sprite = bg;
        }


        for (int i = 0; i < kpzhuang.Length; i++)
        {
            kpzhuang[i].sprite = bg;
        }
    }
}
