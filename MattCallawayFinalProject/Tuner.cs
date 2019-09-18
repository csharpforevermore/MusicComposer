using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace MattCallawayFinalProject
{
    class Tuner
    {

        private System.Media.SoundPlayer lowEString;
        private System.Media.SoundPlayer aString;
        private System.Media.SoundPlayer dString;
        private System.Media.SoundPlayer gString;
        private System.Media.SoundPlayer bString;
        private System.Media.SoundPlayer highEString;

        public System.Media.SoundPlayer getLowE()
        {
            String basePath = System.IO.Path.Combine(Environment.CurrentDirectory, @"assets\sounds\");
            String path = System.IO.Path.Combine(basePath, @"lowE.wav");

            lowEString = new System.Media.SoundPlayer(path);
            return lowEString;
        }

        public System.Media.SoundPlayer getAString()
        {
            String basePath = System.IO.Path.Combine(Environment.CurrentDirectory, @"assets\sounds\");
            String path = System.IO.Path.Combine(basePath, @"aString.wav");

            aString = new System.Media.SoundPlayer(path);
            return aString;
        }

        public System.Media.SoundPlayer getDString()
        {
            String basePath = System.IO.Path.Combine(Environment.CurrentDirectory, @"assets\sounds\");
            String path = System.IO.Path.Combine(basePath, @"dString.wav");

            dString = new System.Media.SoundPlayer(path);
            return dString;
        }

        public System.Media.SoundPlayer getGString()
        {
            String basePath = System.IO.Path.Combine(Environment.CurrentDirectory, @"assets\sounds\");
            String path = System.IO.Path.Combine(basePath, @"gString.wav");

            gString = new System.Media.SoundPlayer(path);
            return gString;
        }

        public System.Media.SoundPlayer getBString()
        {
            String basePath = System.IO.Path.Combine(Environment.CurrentDirectory, @"assets\sounds\");
            String path = System.IO.Path.Combine(basePath, @"bString.wav");

            bString = new System.Media.SoundPlayer(path);
            return bString;
        }

        public System.Media.SoundPlayer getHighE()
        {
            String basePath = System.IO.Path.Combine(Environment.CurrentDirectory, @"assets\sounds\");
            String path = System.IO.Path.Combine(basePath, @"highE.wav");

            highEString = new System.Media.SoundPlayer(path);
            return highEString;
        }


    }

}
