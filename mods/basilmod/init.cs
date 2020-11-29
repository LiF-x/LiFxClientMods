exec("basilmodloader/loader.cs");

%xml = new SimXMLDocument() {};

if(%xml.loadFile("data/cm_objects.xml"))
{
  %xml.pushFirstChildElement("object_types");
  echo (%xml.attribute("defaultState"));
}
else
  echo ("not loaded");
echo(%xml.elementValue());
%findPattern = "mods/*/cm_objects.xml";
for( %file = findFirstFile( %findPattern);
%file !$= "";
%file = findNextFile( %findPattern ))
{
  %localxml = new SimXMLDocument() {};
  %localxml.load(%file);
  %localxml.pushFirstChildElement("object_types");
  %localxml.pushFirstChildElement("object");

  
}