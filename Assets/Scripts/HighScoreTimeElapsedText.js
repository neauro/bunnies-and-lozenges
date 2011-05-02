function Update () {
	var timeElapsed:float = TimerGUI.timeElapsed;
	guiText.text = "Time Elapsed: " + TimerGUI.timeFormat(timeElapsed);
}