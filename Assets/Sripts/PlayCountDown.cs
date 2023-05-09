using UnityEngine;
using UnityEngine.Events;
using DG.Tweening;
using TMPro;

public class PlayCountDown : MonoBehaviour
{
	[SerializeField] TMP_Text tmpText;
	public UnityEvent OnStart;
	public UnityEvent OnEnd;

	private void Start () {
		OnStart.Invoke();
		// var sequence = DOTween.Sequence();
		// tmpText.transform.localScale = Vector3.zero;
		// tmpText.text = "Ready";
		// sequence.Append(tmpText.transform.DOScale(
		// 	Vector3.one,
		// 	1).OnComplete(() => 
		// 	{
		// 		tmpText.transform.localScale = Vector3.zero;
		// 		tmpText.text = "Set";
		// 	}));		
		
		// sequence.Append(tmpText.transform.DOScale(
		// 	Vector3.one,
		// 	1).OnComplete(() => 
		// 	{
		// 		tmpText.transform.localScale = Vector3.zero;
		// 		tmpText.text = "It's crossin' time!";
		// 	}));
		// sequence.Append(tmpText.transform.DOScale(
		// 	Vector3.one,
		// 	1).OnComplete(() => 
		// 	{
		// 		OnEnd.Invoke();
		// 	}));	
		OnEnd.Invoke();

	}
}
