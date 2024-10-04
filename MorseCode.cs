using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MorseCode : MonoBehaviour
{
	[SerializeField] float SpeedInSeconds;
	[TextArea][SerializeField] string Message;
	[SerializeField] bool Loop;
	[SerializeField] bool AutoActivateOnStart;
	
	//Thing You want to turn of/on
	[Header("Thing you want to turn on/off")]
	[SerializeField]Light light;
	


	protected void Start()
	{
		light.enabled=false;
		if(AutoActivateOnStart){
				
			StartCoroutine(PrintingEachLetter());
		}
	}
	
	IEnumerator PrintingEachLetter(){
		do{
			
			foreach(char c in Message){
				string morseCode = ConvertToMorseCode(c);
				for(int i = 0; i < morseCode.Length; i++){
				
				
				
					if(morseCode[i]=='0'){//short blink
						light.enabled=true;
						yield return new WaitForSeconds(SpeedInSeconds);
						light.enabled=false;
					}
					else if(morseCode[i]=='1'){//long blink
						light.enabled=true;
						yield return new WaitForSeconds(SpeedInSeconds*2);
						light.enabled=false;
					}
					yield return new WaitForSeconds(SpeedInSeconds);
				}
				yield return new WaitForSeconds(SpeedInSeconds*2);
			}
		}
		while(Loop);
		
	}
	
	
	
	
	
	
	
	
	string ConvertToMorseCode(char input){
		//1 is long and 0 is short
		char c = char.ToUpper(input);
		
		switch(c){
			case'A':return"01";
			case'B':return"1000";
			case'C':return"1010";
			case'D':return"100";
			case'E':return"0";
			case'F':return"0010";
			case'G':return"110";
			case'H':return"0000";
			case'I':return"00";
			case'J':return"0111";
			case'K':return"101";
			case'L':return"0100";
			case'M':return"11";
			case'N':return"10";
			case'O':return"111";
			case'P':return"0110";
			case'Q':return"1101";
			case'R':return"010";
			case'S':return"000";
			case'T':return"1";
			case'U':return"001";
			case'V':return"0001";
			case'W':return"011";
			case'X':return"1001";
			case'Y':return"1011";
			case'Z':return"1100";
			default:return"";
		}
		
	}
}
