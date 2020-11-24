//-----------------------------------------------------------------------------
// Location BAR
//-----------------------------------------------------------------------------

// Set a schedule to update the Location Bar Coords every 1 second
function sfLocationBarTimeStart()
{
	cancel($sfLocationBarTime);
	
	sfLocationBarTime();
		
	$sfLocationBarTime = schedule(1000, 0, "sfLocationBarTimeStart");
}

// Uses the ServerConnection.getControlObject().getPosition(); function to fetch your current position
// (only returns a value if GM is enabled)
function sfLocationBar()
{
	if (gmBar.visible)
	{
		if (isObject(SFGMGuiWindowLocationBar))
		{
			PlayGui.add(SFGMGuiWindowLocationBar);
		}
	%ppos = ServerConnection.getControlObject().getPosition();
		%x = mCeil(%ppos.x);
		%y = mCeil(%ppos.y);
		%z = mCeil(%ppos.z);

		SFGMGuiLocation.setText("x: " @ %x @ "  y: " @ %y @ "  z: " @ %z);	

	} else 
	{	
		if (isObject(SFGMGuiWindowLocationBar) && SFGMGuiWindowLocationBar.isAwake())
		{
			PlayGui.remove(SFGMGuiWindowLocationBar);
		}		
		
	}	
}