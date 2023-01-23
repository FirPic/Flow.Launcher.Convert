using System;
using System.IO;
using NAudio.Wave;

namespace Convert{
public class AudioConvert{
// .aac .aiff .au .flac .m4a .mp3 .ogg .wav .wma .pgg

    public List<string> audioExtensionFile = new List<string>(){"aac","aiff","au","flac","m4a","mp3","ogg","pgg","wav","wma"};

    static void Main(string[] args)
    {
        
    }


}}



class aiff{
    private void aiff_aiff(string source, string output){
            
        }
    private void aiff_flac(string source, string output){
            
        }
    private void aiff_m4a(string source, string output){
            
        }
    private void aiff_mp3(string source, string output){
            
        }
    private void aiff_wav(string source, string output){
            
        }
}
class flac{
    private void flac_aiff(string source, string output){
            
        }
    private void flac_flac(string source, string output){
            
        }
    private void flac_m4a(string source, string output){
            
        }
    private void flac_mp3(string source, string output){
            
        }
    private void flac_wav(string source, string output){
            
        }
}
class m4a{
    private void m4a_aiff(string source, string output){
            
        }
    private void m4a_flac(string source, string output){
            
        }
    private void m4a_m4a(string source, string output){
            
        }
    private void m4a_mp3(string source, string output){
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
    public void m4a_wav(string source, string output){
        // Instance de la classe MediaFoundationReader pour lire le fichier M4A
        MediaFoundationReader reader = new MediaFoundationReader(source);

        // Instance de la classe WaveFileWriter pour écrire le fichier WAV
        WaveFileWriter.CreateWaveFile(output, reader);

        // Fermeture des flux
        reader.Close();
        }
}
class mp3{
    private void mp3_aiff(string source, string output){
            
        }
    private void mp3_flac(string source, string output){
            
        }
    private void mp3_m4a(string source, string output){
            
        }
    private void mp3_mp3(string source, string output){
            
        }
    private void mp3_wav(string source, string output){
            
        }
}
class wav{
    private void wav_aiff(string source, string output){
            
        }
    private void wav_flac(string source, string output){
            
        }
    private void wav_m4a(string source, string output){
            
        }
    private void wav_mp3(string source, string output){
            
        }
    private void wav_wav(string source, string output){
            
        }
}
