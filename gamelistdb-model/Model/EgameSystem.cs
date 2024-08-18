using System;
using System.Collections.Generic;

namespace GameListDB.Model;

public partial class EgameSystem
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? IsPortable { get; set; }

    public int? Emulable { get; set; }

    public int? LowendEmulable { get; set; }

    public int? Own { get; set; }

    public int? IsRetro { get; set; }
}
