namespace DtMoney.Infra.Models
{
    public abstract class Identity
    {
        public Guid Id { get; set; }

        public Identity()
        {
            Id = Guid.NewGuid();
        }
    }
}
