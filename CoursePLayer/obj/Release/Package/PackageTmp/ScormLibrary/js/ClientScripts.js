function onEnterKeyPress()
{
	if ((event.which && event.which == 13) || (event.keyCode &&	event.keyCode == 13))
	{			
		event.keyCode=0;				
		return false;
	}
}
