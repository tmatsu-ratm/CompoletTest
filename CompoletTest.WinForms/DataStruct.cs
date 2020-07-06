namespace CompoletTest.WinForms
{
    public struct DataStruct
    {
        public bool[] bitData;
        public int[] intData;

        public DataStruct(int bitCount, int intCount)
        {
            this.bitData = new bool[bitCount];
            this.intData = new int[intCount];
        }
    }
}
