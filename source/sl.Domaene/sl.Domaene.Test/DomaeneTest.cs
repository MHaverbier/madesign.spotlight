using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using sl.Domaene;

namespace sl.Domaene.Test
{
    [TestFixture]
    public class DomaeneTest
    {
        [Test]
        public void FortschreitenTest()
        {
            var domaene = new Domaene();

            var dateien = new[] { "a", "b.txt", "c.dat", ".temp" };

            var gefundeneDateien = new List<string>();
            var fortschritt = new List<int>();
            domaene.Fortschreiten( dateien, gefundeneDateien.Add, fortschritt.Add );

            Assert.That( gefundeneDateien, Is.EqualTo( dateien ) );
            Assert.That( fortschritt, Is.EqualTo( new int[] { 0, 25, 50, 100 } ) );
        }
    }
}
