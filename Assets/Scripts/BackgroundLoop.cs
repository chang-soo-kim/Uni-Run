using UnityEngine;

// 왼쪽 끝으로 이동한 배경을 오른쪽 끝으로 재배치하는 스크립트
public class BackgroundLoop : MonoBehaviour {
    private float width; // 배경의 가로 길이

    private void Awake()
    {
        // 가로 길이를 측정하는 처리

        //BoxCollider2D 컴포넌트의 Size 필드의 x 값을 가로 길이로 사용
        BoxCollider2D backgroundCollider = GetComponent<BoxCollider2D>();
        width = backgroundCollider.size.x;

        
    }

    private void Update()
    {
        
        //현재 위치가 원점에서 왼쪽으로 width 이상 이동했을 때 위치를 재배치
        if (transform.position.x <= -width-10f)
        {
            Reposition();
        }

    }

    // 위치를 리셋하는 메서드
    private void Reposition()
    { 
      //현재위치에서 오른쪽으로 가로 길이 * 2 만큼 이동
      Vector3 offset = new Vector3(width*3f, 0);
        transform.position += offset;
    }
}