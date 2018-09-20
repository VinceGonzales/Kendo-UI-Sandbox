using System.Collections.Generic;

namespace Xolartek.Web.Fortnite.Models
{
    public class RangedVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stars { get; set; }
        public int Level { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public int Damage { get; set; }
        public int AmmoCost { get; set; }
        public decimal AttackRate { get; set; }
        public decimal CritChance { get; set; }
        public decimal CritDamage { get; set; }
        public int Durability { get; set; }
        public decimal DurabilityPerUse { get; set; }
        public int Impact { get; set; }
        public int MagazineSize { get; set; }
        public List<SchematicMaterial> Materials { get; set; }
        public int Range { get; set; }
        public int RarityId { get; set; }
        public decimal ReloadTime { get; set; }
        public List<SchematicTrait> Traits { get; set; }
        public int WeaponTypeId { get; set; }
    }
    public class SchematicMaterial
    {
        public int Id { get; set; }
        public int Cost { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public int MaterialId { get; set; }
        public int SchematicId { get; set; }
    }
    public class SchematicTrait
    {
        public int Id { get; set; }
        public string Impact { get; set; }
        public string Description { get; set; }
        public int TraitId { get; set; }
        public int SchematicId { get; set; }
    }
}