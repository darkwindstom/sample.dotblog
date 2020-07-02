﻿using System;
using Newtonsoft.Json;
using PowerArgs;

namespace NetCore31.Behaviors
{
    [ArgExceptionBehavior(ArgExceptionPolicy.StandardExceptionHandling)]
    public class SingleBehavior
    {
        [ArgRequired(PromptIfMissing = true)]
        [ArgDescription("來源路徑")]
        [ArgShortcut("-S")]
        [ArgPosition(1)]
        public string SourceFolder { get; set; }

        [ArgRequired(PromptIfMissing = true)]
        [ArgDescription("目標路徑")]
        [ArgPosition(2)]
        [ArgShortcut("-T")]
        public string TargetFolder { get; set; }

        [ArgRequired(PromptIfMissing = true)]
        [ArgDescription("搜尋模式")]
        [ArgPosition(3)]
        [ArgShortcut("-SP")]
        public string SearchPattern { get; set; }

        public void Main()
        {
            Console.WriteLine(JsonConvert.SerializeObject(this));
        }
    }
}