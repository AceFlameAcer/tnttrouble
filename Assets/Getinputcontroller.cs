using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Getinputcontroller : MonoBehaviour
{
    public TMP_InputField chargeInputField;
	public TMP_InputField CoyoteRangeInputField;
	public TMP_InputField RRRangeInputField;

	public TMP_Text RCText;
	public TMP_Text RRText;

	public void OnClick_CalculateButton ()
    {
        string chargeString = chargeInputField.text;
		string CoyoteRangeString = CoyoteRangeInputField.text;
		string RRRangeString = RRRangeInputField.text;

		double Zc;
		double Zr;
		double Rc;
		double Rr;
		double Q;
		try
		{
			Rc = Convert.ToDouble(CoyoteRangeString);
			Rr = Convert.ToDouble(RRRangeString);
			Q = Convert.ToDouble(chargeString);
		}
		catch (Exception e)
		{
			Debug.Log("Missing parameter!!!");
			return;
		}
		
		double SqrtQ;

		SqrtQ = Math.Pow(Q, (double)1 / 3);

		Zc = Rc / SqrtQ;
		Zr = Rr / SqrtQ;

		Zc = Math.Round(Zc);
		Zr = Math.Round(Zr);


		RCText.text = Zc.ToString();
		RRText.text = Zr.ToString();

		//The following code calls for the user to input the peak incident pressure
		//(to refer from graph provided using the scaled distance).



	}
}
