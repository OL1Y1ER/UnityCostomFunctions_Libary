public int RelativeYPostion(float playerY, float heightThreshold){
	float difference = playerY - transform.position.y;
		
	if(difference < - heightThreshold){
		//this obj is higher than given obj
		return(1);
	}
	else if(difference > heightThreshold){
		//this obj is lower than given obj
		return(-1);
	}
	else{
		//this obj is close to the same elevation
		return(0);
	}
}