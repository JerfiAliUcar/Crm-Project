using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetMvc.Framework.Entity
{
    public abstract class BaseEntity<TKey>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public TKey Id { get; set; }
    }

    //varsayılan olarak int tipinde Id kullansın.
    //özel bir durumda int yerine başka bir tip kullanılabilsin diye TKEy yaparak genericleştirdik.
    public abstract class BaseEntity : BaseEntity<int>
    {
    }
}
