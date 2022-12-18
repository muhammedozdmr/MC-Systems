namespace McSystems
{
    //DataAccesten buna erişebilmek için Entityden cross cuttinge taşıdım çünkü sabit değerler ve her katmanda kullanılabilir
    public enum Gender : byte
    {
        None = 0,
        Male,
        Female,
    }
}