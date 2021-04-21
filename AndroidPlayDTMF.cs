/*
* Author: Stephen Han
* Purpose: Function receives a string and determines which DTMF tone to play on the Android mobile device
* Language: C#
*/

using Android.Content;
using Android.Media;

public void DTMFToneGenerator(string number)
        {
            AudioManager audioMgr = (AudioManager)global::Android.App.Application.Context.GetSystemService(Context.AudioService);
            int durationMs = 500;

            // Set the volume OF the voice call stream to the system volume 
            var currentVolume = audioMgr.GetStreamVolume(Stream.System);

            // Determine the proper sample rate supported by the hardware

            // Setup tone generator
            ToneGenerator mToneGenerator = new ToneGenerator(Stream.Music, currentVolume);
            mToneGenerator.StopTone();

            switch (number)
            {
                case "0":
                    mToneGenerator.StartTone(Tone.Dtmf0, durationMs);
                    break;

                case "1":
                    mToneGenerator.StartTone(Tone.Dtmf1, durationMs);
                    break;

                case "2":
                    mToneGenerator.StartTone(Tone.Dtmf2, durationMs);
                    break;

                case "3":
                    mToneGenerator.StartTone(Tone.Dtmf3, durationMs);
                    break;

                case "4":
                    mToneGenerator.StartTone(Tone.Dtmf4, durationMs);
                    break;

                case "5":
                    mToneGenerator.StartTone(Tone.Dtmf5, durationMs);
                    break;

                case "6":
                    mToneGenerator.StartTone(Tone.Dtmf6, durationMs);
                    break;

                case "7":
                    mToneGenerator.StartTone(Tone.Dtmf7, durationMs);
                    break;

                case "8":
                    mToneGenerator.StartTone(Tone.Dtmf8, durationMs);
                    break;

                case "9":
                    mToneGenerator.StartTone(Tone.Dtmf9, durationMs);
                    break;

                // EVENT10 is * 
                case "*":
                    mToneGenerator.StartTone(Tone.DtmfS, durationMs);
                    break;

                // EVENT11 is #
                case "#":
                    mToneGenerator.StartTone(Tone.DtmfP, durationMs);
                    break;
            }
        }
