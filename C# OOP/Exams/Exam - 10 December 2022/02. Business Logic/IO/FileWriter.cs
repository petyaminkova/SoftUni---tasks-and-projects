﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ChristmasPastryShop.IO
{
    using Contracts;
    using System.IO;

    public class FileWriter : IWriter
    {
        public FileWriter()
        {
            using (StreamWriter writer = new StreamWriter("../../../output.txt", false))
            {
                writer.WriteLine("");
            }
        }
        public void WriteLine(string message)
        {
            using (StreamWriter writer = new StreamWriter("../../../output.txt", true))
            {
                writer.WriteLine(message);
            }
        }

        public void Write(string message)
        {
            using (StreamWriter writer = new StreamWriter("../../../output.txt", true))
            {
                writer.Write(message);
            }
        }

    }
}
