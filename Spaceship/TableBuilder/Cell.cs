﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSpaceship.TableBuilder
{
    enum MergeCellOption
    {
        MergeTop,
        MergeLeft,
        MergeDefault
    }
    enum Alignment
    {
        Left,
        Right,
        Center
    }
    internal class Cell
    {
        public Alignment Alignment { get; set; }
        public MergeCellOption MergeCellOption { get; set; }
        public string Content { get; set; }

        public Cell(MergeCellOption mergeCellOption = MergeCellOption.MergeDefault, Alignment alignment = Alignment.Left, string content = null)
        {
            MergeCellOption = mergeCellOption;
            Alignment = alignment;
            Content = content;
        }
    }
}
