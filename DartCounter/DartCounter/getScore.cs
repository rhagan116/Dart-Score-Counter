 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Vosk; //vosk is the actual speech recognition module
using NAudio.Wave; //naudio is for mic detection

namespace DartCounter
{
    internal class getScore
    {
        public string Listen()
        {
            var modelPath = new Model("C:\\vosk-model-en-us-0.22");
            var rec = new VoskRecognizer(modelPath, 16000); //passing through link to file path and sample rate

            Console.WriteLine("Running.....");

            string score = "";
            // start recording user voice 
            using (var waveIn = new WaveInEvent())
            {
                waveIn.DeviceNumber = 0; //use default microphone
                waveIn.WaveFormat = new WaveFormat(16000, 1); //set the sample rate and channel i.e. 1 is mono 
                waveIn.BufferMilliseconds = 1000;

                //.DataAvailable checks to see if there is an speech coming through 
                waveIn.DataAvailable += (sender, e) =>
                {
                    if (rec.AcceptWaveform(e.Buffer, e.BytesRecorded))
                    {
                        score = rec.Result().Split('"')[3];
                        Console.WriteLine(score);
                    }
                };

                waveIn.StartRecording();

                Console.WriteLine("Waiting for score...");

                Console.ReadKey();
                waveIn.StopRecording();
            }

            return score;
        }
    }
}