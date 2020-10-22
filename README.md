# DummyGame

Game contains a dummy scence and a script NativeInterfaceImpl to communicate with native
This script have methods to interect which are
onGameStart method get all require data for game (for now it is getting userId)
onGameEnd method to post score to native (for now it post final score)
launchGame method open game scene (now its MXGame scene)

MxGame scene will post final score to user using onGameEnd method in last
