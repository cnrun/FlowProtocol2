namespace FlowProtocol2.Core
{
    public class IMOptionValue
    {
        public string Key { get; set; }
        public string UniqueKey => ParentOptionGroup.Key + "_" + Key;
        public string Promt { get; set; }
        private IMOptionGroupElement ParentOptionGroup { get; set; }
        public IMOptionValue(IMOptionGroupElement parentOptionGroup)
        {
            ParentOptionGroup = parentOptionGroup;
            Key = string.Empty;
            Promt = string.Empty;
        }
    }
}