using hw2.Entities;

namespace hw1;

public record PedalEngineParams : EngineParamsBase
{
    public int PedalSize { get; }

    public PedalEngineParams(int pedalSize)
    {
        PedalSize = pedalSize;
    }
}