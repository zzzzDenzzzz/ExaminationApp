using System.ComponentModel;

namespace ExaminationApp.Constants
{
    public enum BookGenre
    {
        [Description("Фэнтези")]
        Fantasy = 1,
        [Description("Научная фантастика")]
        ScienceFiction,
        [Description("Детектив")] 
        Detective,
        [Description("Ужасы")]
        Horror,
        [Description("Философия")]
        Philosophy,
        [Description("Любовный роман")]
        LoveStory,
    }
}
