﻿using System.Collections.Concurrent;

namespace ParallelProcessingEight
{
    public interface IBespokeDictionary
    {
        ConcurrentDictionary<string, Widget> widgets { get; set; }

        void AddIndexedSingleVat(int x, double rate);
        void AddSingleVat(KeyValuePair<string, Widget> pair, double rate);
        Task AddSingleVatAsync(KeyValuePair<string, Widget> pair, double rate);
        int AddVat(double rate);
        void AddVatSpecific(double rate);
        bool MakeWidgets(int size);
        Task<int> ParallelForEachAsyncOptionsVat(ParallelOptions parallelOptions, double rate);
        Task<int> ParallelForEachOptionsVat(ParallelOptions parallelOptions, double rate);
        Task<int> ParallelForEachVat(double rate);
        Task<int> ParallelForOptionsVat(ParallelOptions parallelOptions, double rate);
        Task<int> ParallelForVat(double rate);
    }
}