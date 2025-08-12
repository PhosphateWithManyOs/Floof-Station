namespace Content.Server.DetailExaminable
{
    [RegisterComponent]
    public sealed partial class DetailExaminableComponent : Component
    {
        [DataField(required: true)] [ViewVariables(VVAccess.ReadWrite)]
        public string Content = string.Empty;

        [DataField(required: true)] [ViewVariables(VVAccess.ReadWrite)]
        public string NsfwContent = string.Empty;
    }
}
