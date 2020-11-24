//-----------------------------------------------------------------------------
// COMMANDS	
//-----------------------------------------------------------------------------

// GM Mode - Toggles GM Mode on or off
// Takes the password from the password text box, executes the /GM commmand,
// then saves the password to prefs.cs
function sfGMToggleMode(%val)
{
	if (%val)
	{
		// Get password from password text box
		%password = SFGMGuiPassword.GetValue();
		
		// Join the /GM command and password togther
		%cmd = "/GM " @ %password;
		
		// Logs the command in system chat
		// Usually we'd show the actual command made using %cmd, but since we want 
		// to hide the password, we'll just display "/GM" and some bullet points
		onChatMessage("<spush><color:FF4500>/GM ••••<spop>", null, null);
		
		// Execute command
		doSlashCommand(%cmd);
		
		// Disables cursor
		SFGMGuiPassword.setActive(false); SFGMGuiPassword.setActive(true);		
			
		// Saves password in prefs
		$pref::SFGMTools::Password = %password;
		
		// Exports to prefs.cs
		export("$pref::*", "data/prefs.cs", False);		
	}
}

// Sets GM Toggle to Alt + T key
moveMap.bind(keyboard, "alt t", sfGMToggleMode);


// God - Jaffa Kree
function sfGMInvul()
{
	%cmd = "/INVUL";
	
	onChatMessage("<spush><color:FF4500>" @ %cmd @ "<spop>", null, null);
	
	doSlashCommand(%cmd);	
}


// Morning - Sets the day to morning - client-side only
function sfGMSuicide()
{	
	%cmd = "/SUICIDE";

	onChatMessage("<spush><color:FF4500>" @ %cmd @ "<spop>", null, null);
	
	doSlashCommand(%cmd);
}


// All Skills - Sets every single skill and stats to max - why not?
function sfGMAllSkills()
{
	// Set Stats to Max
	for (%i = 0; %i < 5; %i++)
	{
		%cmd = "/SETMYSTAT " @ %i @ " 100";
		
		onChatMessage("<spush><color:FF4500>" @ %cmd @ "<spop>", null, null);
		
		doSlashCommand(%cmd);
	}
	
	// Set Skills to Max
	for (%i = 1; %i < 66; %i++)
	{
		%cmd = "/SETMYSKILL " @ %i @ " 100";
		
		onChatMessage("<spush><color:FF4500>" @ %cmd @ "<spop>", null, null);
		
		doSlashCommand(%cmd);
	}
}


// Heal Self - Heal youself to max HP
function sfGMHealSelf()
{
	%cmd = "/HEALSELF";
	
	onChatMessage("<spush><color:FF4500>" @ %cmd @ "<spop>", null, null);
	
	doSlashCommand(%cmd);	
}


// Remove Effects - Remove all effects e.g. Poison
function sfGMRemoveEffects()
{
	%cmd = "/REMOVEEFFECTS";
	
	onChatMessage("<spush><color:FF4500>" @ %cmd @ "<spop>", null, null);
	
	doSlashCommand(%cmd);	
}


// JH On - Starts judgment hour based on server set duration
function sfGMJHOn()
{
	%cmd = "/JHFORCEON";
	
	onChatMessage("<spush><color:FF4500>" @ %cmd @ "<spop>", null, null);
	
	doSlashCommand(%cmd);	
}


// JH Off - Ends judgment hour based on server set duration
function sfGMJHOff()
{
	%cmd = "/JHFORCEOFF";
	
	onChatMessage("<spush><color:FF4500>" @ %cmd @ "<spop>", null, null);
	
	doSlashCommand(%cmd);	
}


// Add Item - Add items into your inventory
function sfGMAddItem()
{
	%item = SFGMGuiAddItemID.GetValue();
	%amount = SFGMGuiAddAmount.GetValue();
	%quality = SFGMGuiAddQuality.GetValue();
	%durability = SFGMGuiAddDurability.GetValue();
	
	%cmd = "/ADD " @ %item @ " " @ %amount @ " " @ %quality @ " " @ %durability;
	
	onChatMessage("<spush><color:FF4500>" @ %cmd @ "<spop>", null, null);
	
	doSlashCommand(%cmd);
	
	// Disable cursors
	SFGMGuiAddItemID.setActive(false); SFGMGuiAddItemID.setActive(true);
	SFGMGuiAddAmount.setActive(false); SFGMGuiAddAmount.setActive(true);
	SFGMGuiAddQuality.setActive(false); SFGMGuiAddQuality.setActive(true);
	SFGMGuiAddDurability.setActive(false); SFGMGuiAddDurability.setActive(true);
	
	// SAVE PREFS
	$pref::SFGMTools::AddItemID = %item;
	$pref::SFGMTools::AddAmount = %amount;
	$pref::SFGMTools::AddQuality = %quality;
	$pref::SFGMTools::AddDurability = %durability;

	// EXPORT ALL PREFS
	export("$pref::*", "data/prefs.cs", False);
}


// TP to Player - Teleports to a player based on their First Name
function sfGMTPToPlayer()
{
	%player = SFGMGuiTPPlayerName.GetValue();
	
	%cmd = "/TPTOPLAYER " @ %player;
	
	onChatMessage("<spush><color:FF4500>" @ %cmd @ "<spop>", null, null);
	
	doSlashCommand(%cmd);
	
	// Disable cursor
	SFGMGuiTPPlayerName.setActive(false); SFGMGuiTPPlayerName.setActive(true);	
	
	// SAVE PREFS
	$pref::SFGMTools::TPPlayerName = %player;
	
	// EXPORT ALL PREFS
	export("$pref::*", "data/prefs.cs", False);		
}


// Set Weather (server-side)
function sfGMWeather()
{
	%weather = SFGMGuiWeather.getSelected();
	%weatherText = SFGMGuiWeather.getText();
	
	%cmd = "/WEATHER " @ %weatherText;
	
	onChatMessage("<spush><color:FF4500>" @ %cmd @ "<spop>", null, null);
	
	doSlashCommand(%cmd);
	
	// SAVE PREFS
	$pref::SFGMTools::Weather = %weather;
	
	// EXPORT ALL PREFS
	export("$pref::*", "data/prefs.cs", False);
}


// Set Time of Day (client-side)
function sfGMTimeOfDay()
{
	%timeOfDay = SFGMGuiTimeOfDay.getSelected();
	%timeOfDayText = SFGMGuiTimeOfDay.getText();
	
	%cmd = %timeOfDayText;
	
		switch(%timeOfDay)
	{
		case 0: morning();
		case 1: noon();
		case 2: evening();
		case 3: midnight();
	}
	
	onChatMessage("<spush><color:FF4500>" @ %cmd @ "<spop>", null, null);
	
	// SAVE PREFS
	$pref::SFGMTools::TimeOfDay = %timeOfDay;
	
	// EXPORT ALL PREFS
	export("$pref::*", "data/prefs.cs", False);
}


// Spawn Animal - Moo?
function sfGMSpawnAnimal()
{
	%animal = SFGMGuiAnimal.getSelected();
	%animalText = SFGMGuiAnimal.getText();
	%quality = SFGMGuiAnimalQuality.GetValue();
	
	%cmd = "/ANIMAL " @ %animalText @ " " @ %quality;
	
	onChatMessage("<spush><color:FF4500>" @ %cmd @ "<spop>", null, null);
	
	doSlashCommand(%cmd);
	
	// Disable cursor
	SFGMGuiAnimalQuality.setActive(false); SFGMGuiAnimalQuality.setActive(true);	
	
	// SAVE PREFS
	$pref::SFGMTools::Animal = %animal;
	$pref::SFGMTools::AnimalQuality = %quality;
	
	// EXPORT ALL PREFS
	export("$pref::*", "data/prefs.cs", False);	
}