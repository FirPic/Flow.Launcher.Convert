using System;
using System.IO;
using NAudio.Wave;
using System.Diagnostics;


namespace Converter {


  public class AudioConvert {

    public List < string > audioExtensionFile = new List < string > () {
      "aac",
      "aiff",
      "au",
      "flac",
      "m4a",
      "mp3",
      "ogg",
      "pgg",
      "wav",
      "wma"
    };
    
  }

  public class AIFF {
    public void aiff_flac(string source, string output) {
      Console.WriteLine("aiff to flac");
    }
    public void aiff_m4a(string source, string output) {

    }
    public void aiff_mp3(string source, string output) {

    }
    public void aiff_wav(string source, string output) {

    }
  }
  class FLAC {
    public void flac_aiff(string source, string output) {

    }
    public void flac_flac(string source, string output) {

    }
    public void flac_m4a(string source, string output) {

    }
    public void flac_mp3(string source, string output) {

    }
    public void flac_wav(string source, string output) {

    }
  }
  class M4A {
    public void m4a_aiff(string source, string output) {

    }
    public void m4a_flac(string source, string output) {

    }
    public void m4a_m4a(string source, string output) {

    }
    public void m4a_mp3(string source, string output) {
      // Instance de la classe MediaFoundationReader pour lire le fichier M4A
      MediaFoundationReader reader = new MediaFoundationReader(source);

      // Instance de la classe WaveFormatConversionStream pour convertir le format audio
      WaveFormatConversionStream conversionStream = new WaveFormatConversionStream(
        new WaveFormat(44100, 2), reader);

      // Instance de la classe WaveFileWriter pour écrire le fichier MP3
      WaveFileWriter.CreateWaveFile(output, conversionStream);

      // Fermeture des flux
      conversionStream.Close();
      reader.Close();
    }
    public void m4a_wav(string source, string output) {
      // Instance de la classe MediaFoundationReader pour lire le fichier M4A
      MediaFoundationReader reader = new MediaFoundationReader(source);

      // Instance de la classe WaveFileWriter pour écrire le fichier WAV
      WaveFileWriter.CreateWaveFile(output, reader);

      // Fermeture des flux
      reader.Close();
    }
  }
  class MP3 {
    public void mp3_aiff(string source, string output) {

    }
    public void mp3_flac(string source, string output) {
        Console.WriteLine("mp3 to flac");
    }
    public void mp3_m4a(string source, string output) {

    }
    public void mp3_mp3(string source, string output) {

    }
    public void mp3_wav(string source, string output) {
      var process = new Process
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = "ffmpeg",
                Arguments = $"-i {source} {output}",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true,
            }
        };
        process.Start();
        process.WaitForExit();
        Console.WriteLine("mp3 to wav");
    }
  }
  class WAV {
    public void wav_aiff(string source, string output) {

    }
    public void wav_flac(string source, string output) {

    }
    public void wav_m4a(string source, string output) {
      var process = new Process
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = "ffmpeg",
                Arguments = $"-i {source} -c:a aac -b:a 64k {output}",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true,
            }
        };
        process.Start();
        process.WaitForExit();
        Console.WriteLine("wav to m4a");
    }
    public void wav_mp3(string source, string output) {

    }
    public void wav_wav(string source, string output) {

    }
  }

}
