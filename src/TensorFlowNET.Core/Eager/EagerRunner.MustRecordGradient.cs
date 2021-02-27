﻿using System;
using Tensorflow.Gradients;
using static Tensorflow.Binding;
using static Tensorflow.tensorflow;

namespace Tensorflow.Eager
{
    public partial class EagerRunner
    {
        public bool MustRecordGradient()
        {
            return HasGradientTape();
        }
    }
}
