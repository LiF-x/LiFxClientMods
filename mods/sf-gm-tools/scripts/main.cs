//-----------------------------------------------------------------------------
// MAIN
//-----------------------------------------------------------------------------

// Set Title
// Gets the current version from init.cs and suffixes it to the window title
if ($sfVersion)
{
	SFGMGuiWindowCtrl.text = "SF GM Tools " @ $sfGMVersion;
}


// Window Toggle
// Does what it says really
function sfGMWindowToggle(%val)
{
	if (%val)
	{
		if (SFGMGuiWindow.isAwake())
		{		
			PlayGui.remove(SFGMGuiWindow);
			
			// Save the window position
			sfGMSaveWindowPosition();

		} else
		{	
			PlayGui.add(SFGMGuiWindow);
			
			// Sets the window position
			sfGMSetWindowPosition();
		}
	}
}

// Sets window toggle to the ALT + G combo
moveMap.bind(keyboard, "alt g", sfGMWindowToggle);


// Save the window position
function sfGMSaveWindowPosition()
{
	$pref::SFGMTools::WindowPosition = SFGMGuiWindowCtrl.position;
	
	export("$pref::*", "data/prefs.cs", False);
}


// Sets the window position
function sfGMSetWindowPosition()
{
	SFGMGuiWindowCtrl.position = $pref::SFGMTools::WindowPosition;
}


// Reload GM Tools
// Re-executes the GM Tools (mainly used for Debugging)
function sfGMReloadGMTools(%val)
{
	if (%val)
	{
		onChatMessage("<spush><color:ffff00>SF GM Tools Reloaded<spop>", null, null);
		
		warn("SF GM Tools Reloaded");
		
		exec("mod/sf-gm-tools/init.cs");
	}
}

// Sets reload to F11 key
moveMap.bind(keyboard, "F11", sfGMReloadGMTools);


// List Items
// Opens the official lif items search in a handy built-in web window
function sfGMListItems() 
{
	openWeb("https://lifeisfeudal.com/billing/gmcommands.php#itemSearch");
}


// Toggle Fly Mode
// Without the need to press F7 and F8 to toggle
// Also forces third person on when disabing
function sfGMToggleFlyMode(%val)
{	
	if (%val)
	{
		if (isObject(ServerConnection))
		{
			%co = ServerConnection.getControlObject();
			
			if (%co.isMethod(isInFlyingCameraMode) && %co.isInFlyingCameraMode())
			{
				// Disble fly mode
				commandToServer('DropPlayerAtCamera');
				
				// Set third person
				ServerConnection.setFirstPerson(false);				
				
			} else
			{				
				// Enable fly mode
				commandToServer('dropCameraAtPlayer');
			}
		}		
	}
}

moveMap.bind(keyboard, "alt f", sfGMToggleFlyMode);


// Set Weather List
// Clears the list, adds all the gubbins
SFGMGuiWeather.clear();
SFGMGuiWeather.Add("Fair", 0);
SFGMGuiWeather.Add("Cloudy", 1);
SFGMGuiWeather.Add("Shower", 2);


// Set Time of Day List
// Clears the list, adds all the gubbins
SFGMGuiTimeOfDay.clear();
SFGMGuiTimeOfDay.Add("morning();", 0);
SFGMGuiTimeOfDay.Add("noon();", 1);
SFGMGuiTimeOfDay.Add("evening();", 2);
SFGMGuiTimeOfDay.Add("midnight();", 3);


// Set Animal List
// Clears the list, adds all the gubbins
SFGMGuiAnimal.clear();
SFGMGuiAnimal.Add("AurochsBullData", 0);
SFGMGuiAnimal.Add("AurochsCowData", 1);
SFGMGuiAnimal.Add("BoarData", 2);
SFGMGuiAnimal.Add("SowData", 3);
SFGMGuiAnimal.Add("WolfData", 4);
SFGMGuiAnimal.Add("MuttonData", 5);
SFGMGuiAnimal.Add("MooseData", 6);
SFGMGuiAnimal.Add("HindData", 7);
SFGMGuiAnimal.Add("HareData", 8);
SFGMGuiAnimal.Add("GrouseData", 9);
SFGMGuiAnimal.Add("DeerMaleData", 10);
SFGMGuiAnimal.Add("BearData", 11);
SFGMGuiAnimal.Add("ChieftainData", 12);


//-----------------------------------------------------------------------------
// SET DEFAULT VARIABLES AND PREFS
//-----------------------------------------------------------------------------

// Password
$sfgmPassword = "gm_pass";

if ($pref::SFGMTools::Password  $= "") { $pref::SFGMTools::Password = $sfgmPassword; } else { $sfgmPassword = $pref::SFGMTools::Password; }

SFGMGuiPassword.setText($pref::SFGMTools::Password);


// AddAmount
$sfgmAddAmount = 10;

if ($pref::SFGMTools::AddAmount  $= "") { $pref::SFGMTools::AddAmount = $sfgmAddAmount; } else { $sfgmAddAmount = $pref::SFGMTools::AddAmount; }

SFGMGuiAddAmount.setText($pref::SFGMTools::AddAmount);


// AddQuality
$sfgmAddQuality = 50;

if ($pref::SFGMTools::AddQuality  $= "") { $pref::SFGMTools::AddQuality = $sfgmAddQuality; } else { $sfgmAddQuality = $pref::SFGMTools::AddQuality; }

SFGMGuiAddQuality.setText($pref::SFGMTools::AddQuality);


// AddDurability
$sfgmAddDurability = 5000;

if ($pref::SFGMTools::AddDurability  $= "") { $pref::SFGMTools::AddDurability = $sfgmAddDurability; } else { $sfgmAddDurability = $pref::SFGMTools::AddDurability; }

SFGMGuiAddDurability.setText($pref::SFGMTools::AddDurability);


// TPPlayerName
$sfgmTPPlayerName = "";

if ($pref::SFGMTools::TPPlayerName  $= "") { $pref::SFGMTools::TPPlayerName = $sfgmTPPlayerName; } else { $sfgmTPPlayerName = $pref::SFGMTools::TPPlayerName; }

SFGMGuiTPPlayerName.setText($pref::SFGMTools::TPPlayerName);


// Weather
$sfgmWeather = "0";

if ($pref::SFGMTools::Weather  $= "") { $pref::SFGMTools::Weather = $sfgmWeather; } else { $sfgmWeather = $pref::SFGMTools::Weather; }

SFGMGuiWeather.setSelected($sfgmWeather);


// TimeOfDay
$sfgmTimeOfDay = "0";

if ($pref::SFGMTools::TimeOfDay  $= "") { $pref::SFGMTools::TimeOfDay = $sfgmTimeOfDay; } else { $sfgmTimeOfDay = $pref::SFGMTools::TimeOfDay; }

SFGMGuiTimeOfDay.setSelected($sfgmTimeOfDay);


// Animal
$sfgmAnimal = "0";

if ($pref::SFGMTools::Animal  $= "") { $pref::SFGMTools::Animal = $sfgmAnimal; } else { $sfgmAnimal = $pref::SFGMTools::Animal; }

SFGMGuiAnimal.setSelected($sfgmAnimal);


// AnimalQuality
$sfgmAnimalQuality = 50;

if ($pref::SFGMTools::AnimalQuality  $= "") { $pref::SFGMTools::AnimalQuality = $sfgmAnimalQuality; } else { $sfgmAnimalQuality = $pref::SFGMTools::AnimalQuality; }

SFGMGuiAnimalQuality.setText($pref::SFGMTools::AnimalQuality);


// EXPORT ALL PREFS
export("$pref::*", "data/prefs.cs", False);