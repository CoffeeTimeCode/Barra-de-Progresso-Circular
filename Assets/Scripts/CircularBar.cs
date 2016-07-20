using UnityEngine;
using UnityEngine.UI;// <- Para Manipular as UIs
using System.Collections;

public class CircularBar : MonoBehaviour {

	public StatusBar _statusBar;
	public Image _bar;
	public Text _texto;
	public float _maxValor;
	public float _minValor;

	// Use this for initialization
	void Start () {
		_statusBar = this.gameObject.GetComponent<StatusBar>();
	}
	
	// Update is called once per frame
	void Update () {
		_bar.fillAmount = _statusBar.PegarTamanhoBarra (_minValor,_maxValor);
		_texto.text = _statusBar.PegarPorcentageBarra (_minValor, _maxValor).ToString();

		if(_minValor < _maxValor){
			_minValor = _minValor + Time.deltaTime*10;
		}

	}
}
