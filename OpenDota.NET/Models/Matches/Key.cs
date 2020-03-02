namespace OpenDotaDotNet.Models.Matches
{
    public struct Key
    {
        public long? Integer;
        public string String;

        public static implicit operator Key(long integer) => new Key
                                                                 {
                                                                     Integer = integer,
                                                                 };

        public static implicit operator Key(string @string) => new Key
                                                                   {
                                                                       String = @string,
                                                                   };
    }
}
