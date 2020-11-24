//-----------------------------------------------------------------------------
// STARTER PACK
//-----------------------------------------------------------------------------

function sfGMStarterPack()
{
	onChatMessage("<spush><color:FF4500>Spawning Starter Pack<spop>", null, null);

	// ADD [Item ID] [Quantity] [Quality] [Durability]
	doSlashCommand("/ADD 40 1 50 5000"); // Shovel
	doSlashCommand("/ADD 48 1 50 5000"); // Pickaxe
	doSlashCommand("/ADD 51 1 50 5000"); // Saw
}