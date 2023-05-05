using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Getresults : MonoBehaviour
{
	public TMP_InputField CpressureInputField;
	public TMP_InputField RpressureInputField;

	public TMP_Text CResults;
	public TMP_Text RResults;

	public void OnClick_AnalyseButton()
	{
		string CpressureString = CpressureInputField.text;
		string RpressureString = RpressureInputField.text;

		double CP;
		double RP;

		//Converting the string that is read to a double.
		try
		{
			CP = Convert.ToDouble(CpressureString);
			RP = Convert.ToDouble(RpressureString);
		} 
		catch (Exception e)
		{
			Debug.Log("Missing Parameter!!!");
			return;
		}
		

		//Converting from psi to kPa.
		CP = CP * 6895;
		RP = RP * 6895;

		//Write code for (b) below.

		//If Else statement to check P
		if (CP > 70000)
		{
			CResults.text = "Lung Damage";
		}
		else if (CP > 35000)
		{
			CResults.text = "Eardrum Damage";
		}
		else
		{
			CResults.text = "Safe and Sound";
		}

		if (RP > 70000)
		{
			RResults.text = "Lung Damage";
		}
		else if (RP > 35000)
		{
			RResults.text = "Eardrum Damage";
		}
		else
		{
			RResults.text = "Safe and Sound";
		}

	}
}
