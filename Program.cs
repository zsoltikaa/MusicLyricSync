using WMPLib;

Console.CursorVisible = false; // hide the blinking cursor in the console window

var player = new WindowsMediaPlayer();         // create a new media player instance
player.URL = "elefant_bocs.mp3";               // set the mp3 file to be played
player.controls.play();                        // start playing the audio file

Thread.Sleep(2700); // pause the program for 2700 milliseconds (2.7 seconds) to let the intro of the music play

var lines = new List<(string text, int lineDelay, int charDelay)>
{
    ("Nem keresem az értelmét többé!", 1400, 110),
    ("Történt, ami megtörtént", 700, 90),
    ("Nem haragudhatok rád örökké!", 1450, 105),
    ("Eddig kísértett, innentől kísérj!", 400, 90),
    ("Megbocsátom azt, hogy egyszer minden véget ér", 3800, 65),
    ("Megvárjuk egymást a legvégénél", 2400, 118),
    ("Hajnalig sorolhatnám, miért, miért...", 1600, 108),
    ("Bocsánatot szeretnék kérni mindenért", 1400, 95),
    ("Hajnalig sorolhatnám, miért, miért...", 3400, 108),
    ("Bocsánatot szeretnék kérni mindenért", 1500, 95)
};

for (int i = 0; i < lines.Count; i++)
{
    var (text, lineDelay, charDelay) = lines[i];
    Console.ForegroundColor = (i % 2 == 0) ? ConsoleColor.DarkRed : ConsoleColor.White;

    foreach (char c in text)
    {
        Console.Write(c);
        Thread.Sleep(charDelay);
    }

    Console.WriteLine();
    Thread.Sleep(lineDelay);
}

Console.WriteLine();
