using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// 게임 오버 상태를 표현하고, 게임 점수와 UI를 관리하는 게임 매니저
// 씬에는 단 하나의 게임 매니저만 존재할 수 있다.
public class GameManager : MonoBehaviour
{
    
    private static GameManager instance = null; // 싱글톤을 할당할 전역 변수
    public PlayerController player;
    public static GameManager Instance //프로퍼티 선언
    {
        get
        {
            if(instance == null)
            {
                instance = GameObject.FindObjectOfType<GameManager>();
                    if(instance == null)
                {
                    instance= new GameObject().AddComponent<GameManager>();
                }
            }
            return instance;
        }

    }

    public bool isGameover = false; // 게임 오버 상태
    public Text scoreText; // 점수를 출력할 UI 텍스트
    public Slider invintime; //무적타임 시간 게이지로
    public GameObject gameoverUI; // 게임 오버시 활성화 할 UI 게임 오브젝트

    private int score = 0; // 게임 점수

    // 게임 시작과 동시에 싱글톤을 구성
    void Awake()
    {
        invintime.value = 0;
        invintime.gameObject.SetActive(false);
    }

    void Update() 
    {
        // 게임 오버 상태에서 게임을 재시작할 수 있게 하는 처리

         if(isGameover && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);  //게임 오버 상태에서 마우스 왼쪽 버튼을 클릭하면 현재 씬 재시작
        }

        if (player.invin == true)
        {
            invintime.gameObject.SetActive(true);
            invintime.value = ((5-player.invintime)/5) / 1;

            //Debug.Log(5 - player.invintime);
            if (5 - player.invintime <= 0.002f)
            {
                invintime.gameObject.SetActive(false);
            }
        }

    }

    // 점수를 증가시키는 메서드
    public void AddScore(int newScore) 
    {
        //게임오버가 아니라면
        if(!isGameover)
        {
            //점수를 증가
            score += newScore;
            scoreText.text = "Score : " + score;
            
        }
    }

    // 플레이어 캐릭터가 사망시 게임 오버를 실행하는 메서드
    public void OnPlayerDead() 
    {
        
        //현재 상태를 게임오버 상태로 변경
        isGameover = true;
        //게임오버 UI를 활성화
        gameoverUI.SetActive(true);
        
    }
}