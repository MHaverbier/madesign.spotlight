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
            Assert.That( fortschritt, Is.EqualTo( new int[] { 0, 25, 50, 75, 100 } ) );
        }

        [Test]
        public void Teste_Fortschreiten_MitVielenDateien()
        {
            var domaene = new Domaene();

            var dateien = new List<string>( Enumerable.Range( 1, 3333 ).Select( i => string.Format( "Datei {0}.txt", i ) ) );

            var gefundeneDateien = new List<string>();
            var fortschritt = new List<int>();
            domaene.Fortschreiten( dateien, gefundeneDateien.Add, fortschritt.Add );


            Assert.That( gefundeneDateien, Is.EqualTo( dateien ) );

            Assert.That( fortschritt, Is.EqualTo( Enumerable.Range(0, 101).ToList() ) );
        }

        [Test]
        public void DateiDurchsuchenTest()
        {
            var domaene = new Domaene();
            var treffer = new List<string>();

            domaene.DateiDursuchen( "foo.txt", "ganz viel Inhalt", "viel", treffer.Add );
            domaene.DateiDursuchen( "bar.txt", "ganz viel Inhalt", "neuer", treffer.Add );
            domaene.DateiDursuchen( "zip.txt", "ganz viel neuer Inhalt", "neuer", treffer.Add );

            Assert.That( treffer, Is.EqualTo( new[] { "foo.txt", "zip.txt" } ) );
        }
    }
}
