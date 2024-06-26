/*
	BasilMod::Pack
	2015 Basil Semuonov
	
	Content server config.
*/

//Send server content to the client
BasilMod::pack_content("data/skill_types.xml");
BasilMod::pack_content("data/cm_objects.xml");
BasilMod::pack_content("data/cm_equipTypes.xml");

//Auto-generate
BasilMod::pack_updateRecipe();
BasilMod::pack_updateRecipeRequirement();
BasilMod::pack_updateObjectsTypes();

//Add fast connect button for client for clients
BasilMod::pack_favoriteServer("Join Awesome Server", "127.0.0.1:28000", "basil");

//Special update with different file path
//BasilMod::pack_content("data/recipe.xml", "update/data/recipe.xml");
//BasilMod::pack_content("data/recipe_requirement.xml", "update/data/recipe_requirement.xml");
//BasilMod::pack_content("data/objects_types.xml", "update/data/objects_types.xml");

//Send whole directory update to client (directory structure should follow client game dir)
//BasilMod::pack_contentdir("update");