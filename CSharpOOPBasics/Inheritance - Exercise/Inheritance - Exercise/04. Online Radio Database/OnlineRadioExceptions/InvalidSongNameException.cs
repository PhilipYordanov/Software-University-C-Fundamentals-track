﻿namespace _04.Online_Radio_Database.CustomExceptions
{
    class InvalidSongNameException : InvalidSongException
    {
        public override string Message => "Song name should be between 3 and 30 symbols.";
    }
}
