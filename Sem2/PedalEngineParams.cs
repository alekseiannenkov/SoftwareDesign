using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedalCarAccauntingInformationSystem;

/// <summary>
/// Параметры педального двигателя
/// </summary>
public record PedalEngineParams : EngineParamsBase
{
    /// <summary>
    /// Размер педалей
    /// </summary>
    public int PedalSize { get; }

    public PedalEngineParams(int pedalSize)
    {
        PedalSize = pedalSize;
    }
}