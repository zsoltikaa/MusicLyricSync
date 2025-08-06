using WMPLib; // import Windows Media Player library

Console.CursorVisible = false; // hide the blinking cursor in the console window

var player = new WindowsMediaPlayer(); // instantiate Windows Media Player
player.URL = "elefant_bocs.mp3"; // specify the audio file to be played
player.controls.play(); // start playback of the mp3

// pause to allow the intro of the song to play before showing any text
Thread.Sleep(2700); // wait 2.7 seconds

// list of lyric lines with per-line delay and character animation delay
var lines = new List<(string text, int lineDelay, int charDelay)>
{
    ("Nem keresem az értelmét többé!", 1400, 110),               // line 1: text, wait after line, char delay
    ("Történt, ami megtörtént", 700, 90),                        // line 2
    ("Nem haragudhatok rád örökké!", 1450, 105),                 // line 3   
    ("Eddig kísértett, innentől kísérj!", 400, 90),              // line 4
    ("Megbocsátom azt, hogy egyszer minden véget ér", 3800, 65), // line 5
    ("Megvárjuk egymást a legvégénél", 2400, 118),               // line 6
    ("Hajnalig sorolhatnám, miért, miért...", 1600, 108),        // line 7
    ("Bocsánatot szeretnék kérni mindenért", 1400, 95),          // line 8
    ("Hajnalig sorolhatnám, miért, miért...", 3400, 108),        // line 9
    ("Bocsánatot szeretnék kérni mindenért", 1500, 95)           // line 10
};

// iterate through each line and display it with animation
for (int i = 0; i < lines.Count; i++)
{
    var (text, lineDelay, charDelay) = lines[i]; // unpack tuple

    // alternate line colors: even = dark red, odd = white
    Console.ForegroundColor = (i % 2 == 0) ? ConsoleColor.DarkRed : ConsoleColor.White;

    // print characters one by one with animation delay
    foreach (char c in text)
    {
        Console.Write(c);
        Thread.Sleep(charDelay);
    }
     
    Console.WriteLine();     // move to next line after finishing one
    Thread.Sleep(lineDelay); // wait before printing next line
}

Console.WriteLine(); // extra spacing after all lines

// ASCII art logo shown at the end of the lyrics
string[] asciiLogo =
{
    "  ███████╗██╗     ███████╗███████╗ █████╗ ███╗   ██╗████████╗",
    "  ██╔════╝██║     ██╔════╝██╔════╝██╔══██╗████╗  ██║╚══██╔══╝",
    "  █████╗  ██║     █████╗  █████╗  ███████║██╔██╗ ██║   ██║   ",
    "  ██╔══╝  ██║     ██╔══╝  ██╔══╝  ██╔══██║██║╚██╗██║   ██║   ",
    "  ███████╗███████╗███████╗██║     ██║  ██║██║ ╚████║   ██║   ",
    "  ╚══════╝╚══════╝╚══════╝╚═╝     ╚═╝  ╚═╝╚═╝  ╚═══╝   ╚═╝   ",
    "",
    "                        ██████╗  ██████╗  ██████╗███████╗",
    "                        ██╔══██╗██╔═══██╗██╔════╝██╔════╝",
    "                        ██████╔╝██║   ██║██║     ███████╗",
    "                        ██╔══██╗██║   ██║██║     ╚════██║",
    "                        ██████╔╝╚██████╔╝╚██████╗███████║",
    "                        ╚═════╝  ╚═════╝  ╚═════╝╚══════╝"
};

// set logo color and display speed
Console.ForegroundColor = ConsoleColor.DarkRed;  // set text color for logo
int asciiCharDelay = 24;                         // delay per character when printing ASCII lines

// display the logo line by line with character animation
foreach (string line in asciiLogo)
{
    foreach (char c in line)
    {
        Console.Write(c);
        Thread.Sleep(asciiCharDelay); // small delay between each character
    }

    Console.WriteLine();
    Thread.Sleep(200); // short pause between logo lines
}

// restore console to original settings
Console.ResetColor(); // reset console text colors back to default
Thread.Sleep(30000);  // keep the program running for 30 seconds to let the music finish and user read the text