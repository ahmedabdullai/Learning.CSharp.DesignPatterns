using State;

MediaPlayer player = new MediaPlayer();

player.Play();  // Starting the media.
player.Pause(); // Pausing the media.
player.Play();  // Resuming the media.
player.Stop();  // Stopping the media.
player.Pause(); // Cannot pause. The media is stopped.