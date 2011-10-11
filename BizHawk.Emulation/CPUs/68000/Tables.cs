﻿namespace BizHawk.Emulation.CPUs.M68000
{
    partial class MC68000
    {
        static readonly int[,] MoveCyclesBW = new int[12,9]
        {
            { 4, 4, 8, 8, 8, 12, 14, 12, 16 },
			{ 4, 4, 8, 8, 8, 12, 14, 12, 16 },
			{ 8, 8, 12, 12, 12, 16, 18, 16, 20 },
			{ 8, 8, 12, 12, 12, 16, 18, 16, 20 },
			{ 10, 10, 14, 14, 14, 18, 20, 18, 22 },
			{ 12, 12, 16, 16, 16, 20, 22, 20, 24 },
			{ 14, 14, 18, 18, 18, 22, 24, 22, 26 },
			{ 12, 12, 16, 16, 16, 20, 22, 20, 24 },
			{ 16, 16, 20, 20, 20, 24, 26, 24, 28 },
			{ 12, 12, 16, 16, 16, 20, 22, 20, 24 },
			{ 14, 14, 18, 18, 18, 22, 24, 22, 26 },
			{ 8, 8, 12, 12, 12, 16, 18, 16, 20 }
        };

        static readonly int[,] MoveCyclesL = new int[12, 9]
        {
			{ 4, 4, 12, 12, 12, 16, 18, 16, 20 },
			{ 4, 4, 12, 12, 12, 16, 18, 16, 20 },
			{ 12, 12, 20, 20, 20, 24, 26, 24, 28 },
			{ 12, 12, 20, 20, 20, 24, 26, 24, 28 },
			{ 14, 14, 22, 22, 22, 26, 28, 26, 30 },
			{ 16, 16, 24, 24, 24, 28, 30, 28, 32 },
			{ 18, 18, 26, 26, 26, 30, 32, 30, 34 },
			{ 16, 16, 24, 24, 24, 28, 30, 28, 32 },
			{ 20, 20, 28, 28, 28, 32, 34, 32, 36 },
			{ 16, 16, 24, 24, 24, 28, 30, 28, 32 },
			{ 18, 18, 26, 26, 26, 30, 32, 30, 34 },
			{ 12, 12, 20, 20, 20, 24, 26, 24, 28 }
        };

        static readonly int[,] EACyclesBW = new int[8, 8]
        {
            { 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0 },
            { 4, 4, 4, 4, 4, 4, 4, 4 },
            { 4, 4, 4, 4, 4, 4, 4, 4 },
            { 6, 6, 6, 6, 6, 6, 6, 6 },
            { 8, 8, 8, 8, 8, 8, 8, 8 },
            { 10, 10, 10, 10, 10, 10, 10, 10 },
            { 8, 12, 8, 10, 4, 99, 99, 99 }
        };

        static readonly int[,] EACyclesL = new int[8, 8]
        {
            { 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0 },
            { 8, 8, 8, 8, 8, 8, 8, 8 },
            { 8, 8, 8, 8, 8, 8, 8, 8 },
            { 10, 10, 10, 10, 10, 10, 10, 10 },
            { 12, 12, 12, 12, 12, 12, 12, 12 },
            { 14, 14, 14, 14, 14, 14, 14, 14 },
            { 12, 16, 12, 14, 8, 99, 99, 99 }
        };
    }
}