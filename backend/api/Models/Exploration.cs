using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models;

public class Exploration
{
    public Guid Id { get; set; }
    public Project Project { get; set; } = null!;
    public Guid ProjectId { get; set; }
    public string Name { get; set; } = string.Empty;
    public ExplorationWellCostProfile? ExplorationWellCostProfile { get; set; }
    public AppraisalWellCostProfile? AppraisalWellCostProfile { get; set; }
    public SidetrackCostProfile? SidetrackCostProfile { get; set; }
    public SeismicAcquisitionAndProcessing? SeismicAcquisitionAndProcessing { get; set; }
    public CountryOfficeCost? CountryOfficeCost { get; set; }
    public GAndGAdminCost? GAndGAdminCost { get; set; }
    public double RigMobDemob { get; set; }
    public Currency Currency { get; set; }
    public ICollection<ExplorationWell>? ExplorationWells { get; set; }
}

public class ExplorationWellCostProfile : TimeSeriesCost
{
    [ForeignKey("Exploration.Id")]
    public Exploration Exploration { get; set; } = null!;
    public bool Override { get; set; }
}
public class AppraisalWellCostProfile : TimeSeriesCost
{
    [ForeignKey("Exploration.Id")]
    public Exploration Exploration { get; set; } = null!;
    public bool Override { get; set; }
}
public class SidetrackCostProfile : TimeSeriesCost
{
    [ForeignKey("Exploration.Id")]
    public Exploration Exploration { get; set; } = null!;
    public bool Override { get; set; }
}

public class GAndGAdminCost : TimeSeriesCost
{
    [ForeignKey("Exploration.Id")]
    public Exploration Exploration { get; set; } = null!;
}

public class SeismicAcquisitionAndProcessing : TimeSeriesCost
{
    [ForeignKey("Exploration.Id")]
    public Exploration Exploration { get; set; } = null!;
}

public class CountryOfficeCost : TimeSeriesCost
{
    [ForeignKey("Exploration.Id")]
    public Exploration Exploration { get; set; } = null!;
}
