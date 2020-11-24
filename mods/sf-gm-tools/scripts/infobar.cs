//-----------------------------------------------------------------------------
// INFO BAR
//-----------------------------------------------------------------------------

// Set a schedule to update the Info Bar Time every 1 second
$sfInfoBarTime = schedule(1000, 0, sfInfoBarTimeStart);

function sfInfoBarTimeStart()
{
	cancel($sfInfoBarTime);
	
	sfInfoBarTime();
		
	$sfInfoBarTime = schedule(1000, 0, "sfInfoBarTimeStart");
}

function sfInfoBarTime()
{
	// Uses the getGameTime() function to fetch the in-game time/date
	// (only returns a value if GM is enabled)
	%getTime = getGameTime();
	
	if (gmBar.visible)
	{
		if (isObject(SFGMGuiWindowInfoBar))
		{
			PlayGui.add(SFGMGuiWindowInfoBar);
		}
		
		%date = getWord(%getTime, 0);
		%time = getWord(%getTime, 1);
		
		%dateDDMM = getSubStr(%date, 0, 6);
		
		%dateYYY = getSubStr(%date, 7, 3);
		
		%dateYYY = "1" @ %dateYYY;
		
		%fixedDate = %dateDDMM @ %dateYYY;
		
		SFGMGuiInfoTime.setText(%fixedDate SPC %time);		
	} 
	
	else 
	{	
		if (isObject(SFGMGuiWindowInfoBar) && SFGMGuiWindowInfoBar.isAwake())
		{
			PlayGui.remove(SFGMGuiWindowInfoBar);
		}		
		
	}	
}