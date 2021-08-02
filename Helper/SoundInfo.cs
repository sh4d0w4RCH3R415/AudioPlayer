using NAudio.Wave;

namespace Helper
{
	/// <summary>
	/// Reads the specified audio file and returns its duration length.
	/// </summary>
	public struct SoundInfo
	{
		private int hours, minutes, seconds, milliseconds;

		/// <summary>
		/// Creates a new instance of the <see cref="SoundInfo"/> <see langword="struct"/>.
		/// </summary>
		/// <param name="File">The mp3 file to read.</param>
		private SoundInfo(string File)
		{
			Mp3FileReader mp3 = new Mp3FileReader(File);
			hours = mp3.TotalTime.Hours;
			minutes = mp3.TotalTime.Minutes;
			seconds = mp3.TotalTime.Seconds;
			milliseconds = mp3.TotalTime.Milliseconds;
		}

		/// <summary>
		/// Creates a new <see cref="SoundInfo"/> instance from the specified <paramref name="File"/>.
		/// </summary>
		/// <param name="File">The MP3 file to read.</param>
		/// <returns>A new <see cref="SoundInfo"/> with the file's audio length.</returns>
		public static SoundInfo ReadFile(string File)
		{
			return new SoundInfo(File);
		}
	}
}
