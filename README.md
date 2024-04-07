# PokemonInfo.API

These are the CRUD endpoints for this Pokemon Data API

GET /api/v1.0/pokemon
Description: Returns the list of all Pokémon.
Query Parameters:
name (optional): Filter query by Pokémon name.
searchQuery (optional): Search query for Pokémon.
Returns: An array of Pokémon DTOs.

GET /api/v1.0/pokemon/{pokemonId}
Description: Get Pokémon by ID.
Path Parameters:
pokemonId: The ID of the Pokémon to retrieve.
Returns: The requested Pokémon DTO.
Status Codes:
200 OK: If the Pokémon is found.
404 Not Found: If the Pokémon with the given ID does not exist.

POST /api/v1.0/pokemon
Description: Create a new Pokémon entry.
Body: Pokémon DTO for creation.
Returns: The created Pokémon DTO.
Status Codes:
201 Created: If the Pokémon is successfully created.
400 Bad Request: If the request body is invalid.

PUT /api/v1.0/pokemon/{pokemonId}
Description: Completely update the given Pokémon.
Path Parameters:
pokemonId: The ID of the Pokémon to update.
Body: Updated Pokémon DTO.
Returns: No content.
Status Codes:
204 No Content: If the Pokémon is successfully updated.
404 Not Found: If the Pokémon with the given ID does not exist.

PATCH /api/v1.0/pokemon/{pokemonId}
Description: Partially update the given Pokémon.
Path Parameters:
pokemonId: The ID of the Pokémon to partially update.
Body: JSON Patch document for updating.
Returns: No content.
Status Codes:
204 No Content: If the Pokémon is successfully updated.
400 Bad Request: If the request body or JSON Patch document is invalid.
404 Not Found: If the Pokémon with the given ID does not exist.

DELETE /api/v1.0/pokemon/{pokemonId}
Description: Delete the given Pokémon.
Path Parameters:
pokemonId: The ID of the Pokémon to delete.
Returns: No content.
Status Codes:
204 No Content: If the Pokémon is successfully deleted.
404 Not Found: If the Pokémon with the given ID does not exist.
