/// Copyright (c) 2009, Greg Todd
/// All rights reserved.
///
/// Redistribution and use in source and binary forms, with or without modification,
/// are permitted provided that the following conditions are met:
/// 
/// * Redistributions of source code must retain the above copyright notice,
///   this list of conditions and the following disclaimer.
///   
/// * Redistributions in binary form must reproduce the above copyright notice,
///   this list of conditions and the following disclaimer in the documentation
///   and/or other materials provided with the distribution.
///   
/// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
/// ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
/// WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED.
/// IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT,
/// INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING,
/// BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
/// DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF
/// LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE
/// OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED
/// OF THE POSSIBILITY OF SUCH DAMAGE.

using System;
using System.Media;

namespace ReflectiveCode.GMinder
{
    /// <summary>
    /// Provides methods to make sound
    /// </summary>
    public static class Sound
    {
        /// <summary>
        /// Play an audio file if a path is specified
        /// or beep if no path is specified
        /// </summary>
        /// <param name="filename">filepath of the audio file to play</param>
        public static void MakeSound(string filename)
        {
            if (!String.IsNullOrEmpty(filename))
                Play(filename);
            else
                Beep();
        }

        /// <summary>
        /// Play the specified audio file
        /// </summary>
        /// <param name="filename">filepath of the audio file to play</param>
        public static void Play(string filename)
        {
            if (filename == null)
            {
                Logging.LogException(false, new ArgumentNullException("filename"), "Error in Sound.Play(filename)");
                return;
            }

            using (var player = new SoundPlayer(filename))
            {
                try
                {
                    player.Play();
                }
                catch (Exception e)
                {
                    Logging.LogException(true, e,
                        String.Format("Error playing audio file: {0}", filename),
                        "Please go to Options and select a valid sound file."
                    );
                }
            }
        }

        /// <summary>
        /// Emit a short series of beeps through the console speakers
        /// </summary>
        public static void Beep()
        {
            try
            {
                System.Console.Beep(550, 100);
                System.Console.Beep(600, 100);
                System.Console.Beep(700, 100);
            }
            catch (System.Security.HostProtectionException e)
            {
                Logging.LogException(false, e, "Error playing console beep in Sound.Beep()");
            }
        }
    }
}