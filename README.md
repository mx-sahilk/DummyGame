# DummyGame

Game contains a dummy scence and a script <b>NativeInterfaceImpl</b> to communicate with native<br />
This script have methods to interect which are<br />
<b>onGameStart</b> method get all require data for game (for now it is getting userId) <br />
<b>onGameEnd method</b> to post score to native (for now it post final score) <br />
<b>launchGame</b> method open game scene (now its MXGame scene)<br />

MxGame scene will post final score to user using <b>onGameEnd</b> method in last <br />
