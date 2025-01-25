

using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

using Models;
using Models.DTO;
using Seido.Utilities.SeedGenerator;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbModels;

[Table("Categories", Schema = "supusr")]
public class CategoryDbM : Category, ISeed<CategoryDbM>
{
    [Key]
    public override Guid CategoryId { get; set; }

    [NotMapped]
    public override List<IAttraction> Attractions { get => AttractionsDbM?.ToList<IAttraction>(); set => throw new NotImplementedException(); }
    [JsonIgnore]
    public List<AttractionDbM> AttractionsDbM { get; set; }

    public CategoryDbM(csSeedGenerator seed)
    {
        Seed(seed);
    }
    
    public virtual string Catkind
    {
        get => Name.ToString(); 
        set {}
    }
    

    // lägg till seedern här sen

    public override CategoryDbM Seed(csSeedGenerator seedGenerator)
    {
        base.Seed(seedGenerator);

        return this;
    }

    
}