﻿using System;
using System.IO;

namespace cs_smallpt.core
{
    public class ImageIO
    {
        public static void WritePPM(int w, int h, Vector3[] Ls) 
        {
            using (StreamWriter sw = new StreamWriter("image.ppm"))
            {

                string sbegin = string.Format("P3\n{0} {1}\n{2}\n", w, h, 255);
                sw.Write(sbegin);

                for (int i = 0; i < w * h; ++i)
                {
                    string s = string.Format("{0} {1} {2} ", MathUtils.ToByte(Ls[i][0]), MathUtils.ToByte(Ls[i][1]), MathUtils.ToByte(Ls[i][2]));
                    sw.Write(s);
                }
            }
        }
    }
}
