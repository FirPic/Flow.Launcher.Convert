using System;
using System.IO;
using NAudio.Wave;

namespace Convert{

class Convert
{
    static void Main(string[] args)
    {
        
        //AudioConvert audio = new AudioConvert();
        MP3 mp3 = new MP3();
        try{
            
            mp3.mp3_wav("./test/example.mp3", "./test/example.wav");

        }
        catch{
            Console.WriteLine("Erreur");
        }

                
    }   

    

}
}