using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace Md5.Test
{
    [TestClass]
    public class Md5Test
    {
        private static Tuple<T1, T2> Pair<T1, T2>(T1 t1, T2 t2)
        {
            return Tuple.Create(t1, t2);
        }

        public IEnumerable<Tuple<string, string>> TestData
        {
            get
            {
                yield return Pair("51bb50d72b1fc", "25e584bc1e1dac32d2eff83e942aae79");
                yield return Pair("51bb50d72d91d", "697aa8744801af070a0ca8c21363e0c4");
                yield return Pair("51bb50d73005c", "eaffdeecbdfbb060a0cd10f74fdfd28e");
                yield return Pair("51bb50d732767", "85b533fca96a5d6718653dfdaf629b98");
                yield return Pair("51bb50d734e90", "54e1ffdaaaa9ff2d46165948fb623148");
                yield return Pair("51bb50d7375b2", "5282fb4adb47c0382f14198690217803");
                yield return Pair("51bb50d739cda", "fce99b1de667370f0743c135f2eb3cb1");
                yield return Pair("51bb50d73c410", "3c4489ba48fcd4232468afed3a63260f");
                yield return Pair("51bb50d73eb3b", "69ac6a64c7b9428983a5676fdc341766");
                yield return Pair("51bb50d74125c", "cd8fc6346e0efde2c2426cdcf9d383c8");
                yield return Pair("51bb50d743984", "70a6a835b750c2996248e3f0398f8767");
                yield return Pair("51bb50d7460a6", "3dcc41139f05190368cfef79720a5bee");
                yield return Pair("51bb50d7487ce", "6fc80730b8800ee6bbb093b89726ec8c");
                yield return Pair("51bb50d74aef1", "09dd7021176a0a229efcbe624d80d746");
                yield return Pair("51bb50d74d619", "6133ba3e879319a7d29b22004cebf6cc");
                yield return Pair("51bb50d74fd4f", "95cb3b1cc026b14e5d182158d93fd44c");
                yield return Pair("51bb50d752477", "6ea2315ce927e90341a84ab46e7a7bc7");
                yield return Pair("51bb50d754b9a", "2dcbe2359bb8885645907900e927ae04");
                yield return Pair("51bb50d7572d6", "6f6a8efa686135d372440ab7efc32d97");
                yield return Pair("51bb50d7599f9", "97e99560859cea40e00990d2385792dc");
            }
        }

        [TestMethod]
        public void Test()
        {
            foreach (var tuple in TestData)
            {
                Assert.AreEqual(tuple.Item2, MD5Core.GetHashString(tuple.Item1).ToLower());
            }
        }
    }
}
