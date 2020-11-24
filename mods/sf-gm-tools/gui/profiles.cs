//-----------------------------------------------------------------------------
// INFO BAR
//-----------------------------------------------------------------------------

singleton GuiControlProfile(SFGMGuiInfoBar : GuiControlProfile)
{
	opaque = true;
	border = true;  
	border = 3;
	borderThickness = 2; 
	fillColor = "30 30 30 100";
	borderColor = "255 255 255";
	justify = "right";
};

singleton GuiControlProfile(SFGMGuiInfoBarText : GuiTextProfile)
{
	fontSize = 15;
	fontColor = "255 255 255";
	justify = "center";
};

singleton GuiControlProfile(SFGMGuiInfoBarTextGreen : GuiTextProfile)
{
	fontSize = 15;
	fontColor = "64 254 64";
	justify = "center";
};

singleton GuiControlProfile(SFGMGuiInfoBarTextRed : GuiTextProfile)
{
	fontSize = 15;
	fontColor = "255 0 0";
	justify = "center";
};
//-----------------------------------------------------------------------------
// LOCATION BAR
//-----------------------------------------------------------------------------

singleton GuiControlProfile(SFGMGuiLocationBar : GuiControlProfile)
{
	opaque = true;
	border = true;  
	border = 3;
	borderThickness = 2; 
	fillColor = "30 30 30 100";
	borderColor = "255 255 255";
	justify = "right";
};

singleton GuiControlProfile(SFGMGuiLocationBarText : GuiTextProfile)
{
	fontSize = 15;
	fontColor = "255 255 255";
	justify = "center";
};

singleton GuiControlProfile(SFGMGuiLocationBarTextGreen : GuiTextProfile)
{
	fontSize = 15;
	fontColor = "64 254 64";
	justify = "center";
};

singleton GuiControlProfile(SFGMGuiLocationBarTextRed : GuiTextProfile)
{
	fontSize = 15;
	fontColor = "255 0 0";
	justify = "center";
};
//-----------------------------------------------------------------------------
// THE REST - Needs tidied up, tad lazy...
//-----------------------------------------------------------------------------

singleton GuiControlProfile(SFGuiTextEditAlphaProfile : GuiTextEditProfile)
{

};

singleton GuiControlProfile(SFGuiTextEditProfile : GuiTextEditProfile)
{
	numbersOnly = true;
};

singleton GuiControlProfile(SFGuiTextEditAlphaCenterProfile : GuiTextEditProfile)
{
	justify = "center";
};

singleton GuiControlProfile(SFGuiTextEditProfileCenter : GuiTextEditProfile)
{
	numbersOnly = true;
	justify = "center";
};

singleton GuiControlProfile(SFGuiTitleTextProfile : GuiBaseTextProfile)
{
	fontSize = 16;
};

singleton GuiControlProfile(SFGuiTextProfile : GuiBaseTextProfile)
{
};

singleton GuiControlProfile(SFGuiTextProfileRight : GuiBaseTextProfile)
{
	justify = "right";
};

singleton GuiControlProfile(SFGuiTextProfileCenter : GuiBaseTextProfile)
{
	justify = "center";
};

singleton GuiControlProfile(SFGuiTextClock : GuiBaseTextProfile)
{
	fontSize = 38;
	fontColor = "255 255 255";
	justify = "center";
};

singleton GuiControlProfile(SFGuiInv : GuiBaseTextProfile)
{
	fontSize = 12;
	fontType = "Arial";
};

singleton GuiControlProfile(SFGuiCheckBoxProfile : GuiCheckBoxProfile)
{
	fontSize = 12;
	//bitmap = "./images/checkbox";
	//hasBitmapArray = true;
};

singleton GuiControlProfile(SFGuiDropdownProfile : GuiBaseTextProfile)
{
	border = "";
	
	textOffset = "5 0";
	fontColor = "255 255 255";
	fontColorHL = "255 255 255";
	fontColorNA = "0 0 0";
	fontColorSEL= "0 0 0";	
};

singleton GuiControlProfile(SFGuiDropdownCenterProfile : GuiBaseTextProfile)
{
	border = "";
	
	justify = "center";
	
	textOffset = "3 0";
	fontColor = "255 255 255";
	fontColorHL = "255 255 255";
	fontColorNA = "0 0 0";
	fontColorSEL= "0 0 0";	
};

singleton GuiControlProfile(SFGuiWindowOverlayProfile : GuiOverlayProfile)
{
	modal = false;
	border = "rect1_color";
	borderColor = "0 0 0";
};

singleton GuiControlProfile(SFGuiSmallWindowProfile : GuiBaseCaptionProfile)
{
	opaque = false;
	border = "all_tiling";
	globalImageIndex = "small_window";
	bottomDecorOffset = "2 34";
	bottomDecorSize = "-47 0";
	fontSize = "20";
	textOffset = "8 -2";
	fontColor = "30 29 27";
};

singleton GuiControlProfile(SFGuiButtonTabProfile : GuiButtonTabProfile)
{
	opaque = true;
	border = "rect1_color";

	fillColor = "28 28 28";
	fontColor = "175 175 175";
	fontColorHL = "255 255 255";
	fontColorNA = "94 78 60";
	fontColorSEL= "255 255 255";
	fixedExtent = false;
	justify = "center";
	canKeyFocus = false;
	bitmap = "";
	hasBitmapArray = false;
	category = "Core";
};