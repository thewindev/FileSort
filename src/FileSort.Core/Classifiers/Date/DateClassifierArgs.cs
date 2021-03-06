﻿using FileSort.Core.Storage;

namespace FileSort.Core.Classifiers.Date
{
    public class DateClassifierArgs: ClassifierArgs
    {
        public DateClassifierArgs()
        {
            
        }

        public DateClassifierArgs(DateInterval interval, bool useMultipleClassifiers = false)
        {
            Interval = interval;
            UseMultipleClassifiers = useMultipleClassifiers;
        }

        public bool UseMultipleClassifiers { get; set; }

        public DateInterval Interval { get; set; }
    }
}