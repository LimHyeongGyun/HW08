#include "SpartaGameMode.h"
#include "PlayCharacter.h"
#include "SpartaPlayerController.h"

ASpartaGameMode::ASpartaGameMode()
{
	DefaultPawnClass = APlayCharacter::StaticClass();
	PlayerControllerClass = ASpartaPlayerController::StaticClass();
}
