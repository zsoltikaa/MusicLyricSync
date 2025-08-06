using WMPLib;

Console.CursorVisible = false; // hide the blinking cursor in the console window

var player = new WindowsMediaPlayer();         // create a new media player instance
player.URL = "elefant_bocs.mp3";               // set the mp3 file to be played
player.controls.play();                        // start playing the audio file

Thread.Sleep(2700); // pause the program for 2700 milliseconds (2.7 seconds) to let the intro of the music play
