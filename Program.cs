using System;
using System.IO;
using NAudio.Wave;

namespace Convert{

class Convert
{
    static void Main(string[] args)
    {
        
        AudioConvert audio = new AudioConvert();
        try{
            //audio.m4a_mp3("C:\\Users\\Elève\\workspace\\Convert\\example.m4a", "C:\\Users\\Elève\\workspace\\Convert\\example.mp3");
            //audio.m4a_wav("C:\\Users\\Elève\\workspace\\Convert\\example.m4a", "C:\\Users\\Elève\\workspace\\Convert\\example.wav");
            
        }
        catch{
            Console.WriteLine("Erreur");
        }

                
    }

    

}
}