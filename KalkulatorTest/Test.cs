using System;
using NUnit.Compatibility;
using NUnit.Framework;

namespace KalkulatorTest
{
    public class Test
    {
        [Test]
        public void DodajDwieDodatnie()
        {
            var kalk = new KalkulatorDemo.Kalkulator();
            int sum = kalk.Dodaj(2, 2);
            Assert.AreEqual(4, sum);
        }

        [Test]
        public void DodajPierwszaUjemna()
        {
            var kalk = new KalkulatorDemo.Kalkulator();
            int sum = kalk.Dodaj((-1), 2);
            Assert.AreEqual(1, sum);
        }

        [Test]
        public void DodajDrugaUjemna()
        {
            var kalk = new KalkulatorDemo.Kalkulator();
            int sum = kalk.Dodaj(3, (-1));
            Assert.AreEqual(2, sum);
        }

        [Test]
        public void DodajDwieUjemne()
        {
            var kalk = new KalkulatorDemo.Kalkulator();
            int sum = kalk.Dodaj((-2), (-2));
            Assert.AreEqual((-4), sum);
        }
    }
}
